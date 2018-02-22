using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Parkeezzi.Migrations
{
    public partial class PluraliseItemsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContractorInvoiceItem_ContractorInvoices_ContractorInvoiceId",
                table: "ContractorInvoiceItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContractorInvoiceItem",
                table: "ContractorInvoiceItem");

            migrationBuilder.RenameTable(
                name: "ContractorInvoiceItem",
                newName: "ContractorInvoiceItems");

            migrationBuilder.RenameIndex(
                name: "IX_ContractorInvoiceItem_ContractorInvoiceId",
                table: "ContractorInvoiceItems",
                newName: "IX_ContractorInvoiceItems_ContractorInvoiceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContractorInvoiceItems",
                table: "ContractorInvoiceItems",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ContractorInvoiceItems_ContractorInvoices_ContractorInvoiceId",
                table: "ContractorInvoiceItems",
                column: "ContractorInvoiceId",
                principalTable: "ContractorInvoices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContractorInvoiceItems_ContractorInvoices_ContractorInvoiceId",
                table: "ContractorInvoiceItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContractorInvoiceItems",
                table: "ContractorInvoiceItems");

            migrationBuilder.RenameTable(
                name: "ContractorInvoiceItems",
                newName: "ContractorInvoiceItem");

            migrationBuilder.RenameIndex(
                name: "IX_ContractorInvoiceItems_ContractorInvoiceId",
                table: "ContractorInvoiceItem",
                newName: "IX_ContractorInvoiceItem_ContractorInvoiceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContractorInvoiceItem",
                table: "ContractorInvoiceItem",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ContractorInvoiceItem_ContractorInvoices_ContractorInvoiceId",
                table: "ContractorInvoiceItem",
                column: "ContractorInvoiceId",
                principalTable: "ContractorInvoices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
