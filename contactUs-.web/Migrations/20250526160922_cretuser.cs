using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace contactUs.web.Migrations
{
    /// <inheritdoc />
    public partial class cretuser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "userss",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Firstname = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Lastname = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    password = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    mobile = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    registerDatetime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userss", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "userss");
        }
    }
}
