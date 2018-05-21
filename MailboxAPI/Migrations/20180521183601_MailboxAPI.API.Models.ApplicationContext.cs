using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace MailboxAPI.Migrations
{
    public partial class MailboxAPIAPIModelsApplicationContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblArea",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblArea", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblFacturas",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Area_id = table.Column<long>(nullable: false),
                    CNPJ = table.Column<string>(nullable: true),
                    EmissionDate = table.Column<DateTime>(nullable: false),
                    NoNote = table.Column<string>(nullable: true),
                    NoteType = table.Column<string>(nullable: true),
                    PO = table.Column<string>(nullable: true),
                    TotalValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblFacturas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblFacturas_tblArea_Area_id",
                        column: x => x.Area_id,
                        principalTable: "tblArea",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblFacturas_Area_id",
                table: "tblFacturas",
                column: "Area_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblFacturas");

            migrationBuilder.DropTable(
                name: "tblArea");
        }
    }
}
