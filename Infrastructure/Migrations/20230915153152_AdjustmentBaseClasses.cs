using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class AdjustmentBaseClasses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                schema: "DBCadDev",
                table: "TipoDev",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                schema: "DBCadDev",
                table: "TipoDev",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "UpdatedBy",
                schema: "DBCadDev",
                table: "TipoDev",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                schema: "DBCadDev",
                table: "TipoDev",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                schema: "DBCadDev",
                table: "Dev",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                schema: "DBCadDev",
                table: "Dev",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "UpdatedBy",
                schema: "DBCadDev",
                table: "Dev",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                schema: "DBCadDev",
                table: "Dev",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                schema: "DBCadDev",
                table: "TipoDev");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                schema: "DBCadDev",
                table: "TipoDev");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                schema: "DBCadDev",
                table: "TipoDev");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                schema: "DBCadDev",
                table: "TipoDev");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                schema: "DBCadDev",
                table: "Dev");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                schema: "DBCadDev",
                table: "Dev");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                schema: "DBCadDev",
                table: "Dev");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                schema: "DBCadDev",
                table: "Dev");
        }
    }
}
