using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CR_GR__Helper.Migrations
{
    /// <inheritdoc />
    public partial class Alerts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Complains",
                table: "Complains");

            migrationBuilder.RenameTable(
                name: "Complains",
                newName: "Complain");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Complain",
                table: "Complain",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Alert",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Posted_By = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsUrgent = table.Column<bool>(type: "bit", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alert", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alert");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Complain",
                table: "Complain");

            migrationBuilder.RenameTable(
                name: "Complain",
                newName: "Complains");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Complains",
                table: "Complains",
                column: "Id");
        }
    }
}
