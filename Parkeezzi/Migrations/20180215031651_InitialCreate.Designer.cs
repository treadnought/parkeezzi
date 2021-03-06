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
    [Migration("20180215031651_InitialCreate")]
    partial class InitialCreate
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

            modelBuilder.Entity("Parkeezzi.Models.ContractorInvoice", b =>
                {
                    b.HasOne("Parkeezzi.Models.Contractor", "Contractor")
                        .WithMany("ContractorInvoices")
                        .HasForeignKey("ContractorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
