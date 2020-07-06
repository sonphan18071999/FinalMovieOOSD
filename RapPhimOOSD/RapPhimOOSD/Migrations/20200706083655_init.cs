using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RapPhimOOSD.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Logins",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    userName = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true),
                    role = table.Column<string>(nullable: true),
                    sessionId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logins", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Logins",
                columns: new[] { "Id", "password", "role", "sessionId", "userName" },
                values: new object[] { new Guid("49ec83b0-57d5-49f2-a315-6a983ca588ab"), "Developer", "New York", "12345", "John" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Logins");
        }
    }
}
