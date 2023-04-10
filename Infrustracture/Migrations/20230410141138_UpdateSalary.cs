using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrustracture.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSalary : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EnployeeId",
                table: "Salary");

            migrationBuilder.RenameColumn(
                name: "GorssValue",
                table: "Salary",
                newName: "OveTimeGrossValue");

            migrationBuilder.AlterColumn<int>(
                name: "OveTime",
                table: "Salary",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "Date",
                table: "Salary",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Salary",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Salary");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "Salary");

            migrationBuilder.RenameColumn(
                name: "OveTimeGrossValue",
                table: "Salary",
                newName: "GorssValue");

            migrationBuilder.AlterColumn<double>(
                name: "OveTime",
                table: "Salary",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "EnployeeId",
                table: "Salary",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
