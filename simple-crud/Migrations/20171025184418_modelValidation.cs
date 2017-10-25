using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace simplecrud.Migrations
{
    public partial class modelValidation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Genre",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Genre",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50);
        }
    }
}
