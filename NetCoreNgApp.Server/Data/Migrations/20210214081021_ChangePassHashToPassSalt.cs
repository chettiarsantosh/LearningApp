using Microsoft.EntityFrameworkCore.Migrations;

namespace NetCoreNgApp.Server.Data.Migrations
{
    public partial class ChangePassHashToPassSalt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PasswordHash",
                table: "Users",
                newName: "PasswordSalt");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PasswordSalt",
                table: "Users",
                newName: "PasswordHash");
        }
    }
}
