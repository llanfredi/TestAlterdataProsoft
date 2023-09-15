using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class PopulateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "DBCadDev",
                table: "Auth",
                columns: new[] { "Id", "Active", "CreatedBy", "CreatedDate", "Login", "Nome", "Senha", "UpdatedBy", "UpdatedDate" },
                values: new object[] { new Guid("c4de9379-7d63-4ab9-bd95-0017f5750a98"), true, 1, new DateTime(2023, 9, 15, 14, 36, 43, 706, DateTimeKind.Local).AddTicks(5862), "llanfredi", "Leandro Lanfredi", "123456", null, null });

            migrationBuilder.InsertData(
                schema: "DBCadDev",
                table: "TipoDev",
                columns: new[] { "Id", "Active", "CreatedBy", "CreatedDate", "DescTipoDev", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("048d114c-4671-4742-922a-eb3aafe8fe30"), true, 1, new DateTime(2023, 9, 15, 14, 36, 43, 705, DateTimeKind.Local).AddTicks(2553), "Pleno", null, null },
                    { new Guid("254c5c47-7af2-4797-a27a-1a36d593d8cb"), true, 1, new DateTime(2023, 9, 15, 14, 36, 43, 705, DateTimeKind.Local).AddTicks(2567), "Especialista", null, null },
                    { new Guid("2d7a5fc9-bb02-4369-b012-2983281361ca"), true, 1, new DateTime(2023, 9, 15, 14, 36, 43, 705, DateTimeKind.Local).AddTicks(2559), "Sênior", null, null },
                    { new Guid("9ec0f7b4-9b72-4a81-b55a-c209389dc97e"), true, 1, new DateTime(2023, 9, 15, 14, 36, 43, 705, DateTimeKind.Local).AddTicks(2478), "Estágiário", null, null },
                    { new Guid("b27e03ab-4266-4351-bceb-17fd81ba6bd0"), true, 1, new DateTime(2023, 9, 15, 14, 36, 43, 705, DateTimeKind.Local).AddTicks(2430), "Estágiário", null, null },
                    { new Guid("f185f4b4-61c2-4978-82cf-3beb35f73151"), true, 1, new DateTime(2023, 9, 15, 14, 36, 43, 705, DateTimeKind.Local).AddTicks(2485), "Júnior", null, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "DBCadDev",
                table: "Auth",
                keyColumn: "Id",
                keyValue: new Guid("c4de9379-7d63-4ab9-bd95-0017f5750a98"));

            migrationBuilder.DeleteData(
                schema: "DBCadDev",
                table: "TipoDev",
                keyColumn: "Id",
                keyValue: new Guid("048d114c-4671-4742-922a-eb3aafe8fe30"));

            migrationBuilder.DeleteData(
                schema: "DBCadDev",
                table: "TipoDev",
                keyColumn: "Id",
                keyValue: new Guid("254c5c47-7af2-4797-a27a-1a36d593d8cb"));

            migrationBuilder.DeleteData(
                schema: "DBCadDev",
                table: "TipoDev",
                keyColumn: "Id",
                keyValue: new Guid("2d7a5fc9-bb02-4369-b012-2983281361ca"));

            migrationBuilder.DeleteData(
                schema: "DBCadDev",
                table: "TipoDev",
                keyColumn: "Id",
                keyValue: new Guid("9ec0f7b4-9b72-4a81-b55a-c209389dc97e"));

            migrationBuilder.DeleteData(
                schema: "DBCadDev",
                table: "TipoDev",
                keyColumn: "Id",
                keyValue: new Guid("b27e03ab-4266-4351-bceb-17fd81ba6bd0"));

            migrationBuilder.DeleteData(
                schema: "DBCadDev",
                table: "TipoDev",
                keyColumn: "Id",
                keyValue: new Guid("f185f4b4-61c2-4978-82cf-3beb35f73151"));
        }
    }
}
