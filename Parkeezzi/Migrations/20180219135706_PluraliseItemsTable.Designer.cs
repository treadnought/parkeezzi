﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Parkeezzi.DataAccess;
using System;

namespace Parkeezzi.Migrations
{
    [DbContext(typeof(ParkeezziContext))]
    [Migration("20180219135706_PluraliseItemsTable")]
    partial class PluraliseItemsTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Parkeezzi.Models.Contractor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Company");

                    b.HasKey("Id");

                    b.ToTable("Contractors");
                });

            modelBuilder.Entity("Parkeezzi.Models.ContractorInvoice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ContractorId");

                    b.Property<string>("InvRef");

                    b.HasKey("Id");

                    b.HasIndex("ContractorId");

                    b.ToTable("ContractorInvoices");
                });

            modelBuilder.Entity("Parkeezzi.Models.ContractorInvoiceItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Amount");

                    b.Property<int>("ContractorInvoiceId");

                    b.Property<bool>("GST");

                    b.Property<string>("Item");

                    b.Property<string>("ItemNote");

                    b.Property<bool>("Onbill");

                    b.HasKey("Id");

                    b.HasIndex("ContractorInvoiceId");

                    b.ToTable("ContractorInvoiceItems");
                });

            modelBuilder.Entity("Parkeezzi.Models.ContractorInvoice", b =>
                {
                    b.HasOne("Parkeezzi.Models.Contractor", "Contractor")
                        .WithMany("ContractorInvoices")
                        .HasForeignKey("ContractorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Parkeezzi.Models.ContractorInvoiceItem", b =>
                {
                    b.HasOne("Parkeezzi.Models.ContractorInvoice", "ContractorInvoice")
                        .WithMany("ContractorInvoiceItems")
                        .HasForeignKey("ContractorInvoiceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
