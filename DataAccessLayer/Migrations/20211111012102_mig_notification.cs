using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_notification : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    NotID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NotType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NotTypeSymbol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NotDetail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NotDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NotStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.NotID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notifications");
        }
    }
}
