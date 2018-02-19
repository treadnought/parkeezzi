using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Parkeezzi.Migrations
{
    public partial class AddItemTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContractorInvoiceItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Amount = table.Column<double>(nullable: false),
                    ContractorInvoiceId = table.Column<int>(nullable: false),
                    GST = table.Column<bool>(nullable: false),
                    Item = table.Column<string>(nullable: true),
                    ItemNote = table.Column<string>(nullable: true),
                    Onbill = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractorInvoiceItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContractorInvoiceItem_ContractorInvoices_ContractorInvoiceId",
                        column: x => x.ContractorInvoiceId,
                        principalTable: "ContractorInvoices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContractorInvoiceItem_ContractorInvoiceId",
                table: "ContractorInvoiceItem",
                column: "ContractorInvoiceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContractorInvoiceItem");
        }
    }
}
