using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class passkey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"UPDATE [dbo].[Cities] SET [Country]='India' WHERE [Country] IS NULL");
            migrationBuilder.DropColumn("Password", "Users");
            migrationBuilder.AddColumn<byte[]>(
                name: "Password",
                table: "Users",
                nullable: false,
                defaultValue: "passkey@123"
                //oldClrType: typeof(string),
                //oldType: "nvarchar(max)"
                );

            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordKey",
                table: "Users",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Cities",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PasswordKey",
                table: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(byte[]));

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Cities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
