using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class NewFiledTableDev : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Email",
                schema: "DBCadDev",
                table: "Dev",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                schema: "DBCadDev",
                table: "Auth",
                columns: new[] { "Id", "Active", "CreatedBy", "CreatedDate", "Login", "Nome", "Senha", "UpdatedBy", "UpdatedDate" },
                values: new object[] { new Guid("7d3512b7-6179-4283-914d-47f29110facc"), true, 1, new DateTime(2023, 9, 15, 18, 41, 25, 936, DateTimeKind.Local).AddTicks(4313), "llanfredi", "Leandro Lanfredi", "9N1RJ4v/JxP6S23Lg8STzA==", null, null });

            migrationBuilder.InsertData(
                schema: "DBCadDev",
                table: "TipoDev",
                columns: new[] { "Id", "Active", "CreatedBy", "CreatedDate", "DescTipoDev", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("618d6115-7e38-4c7b-a950-ef7eb8b0410d"), true, 1, new DateTime(2023, 9, 15, 18, 41, 25, 934, DateTimeKind.Local).AddTicks(6693), "Estágiário", null, null },
                    { new Guid("73af6b0d-26e9-44e1-adf8-a454a5ef26da"), true, 1, new DateTime(2023, 9, 15, 18, 41, 25, 934, DateTimeKind.Local).AddTicks(6742), "Pleno", null, null },
                    { new Guid("874e8f79-5035-4a5e-853c-c75ecacebc0d"), true, 1, new DateTime(2023, 9, 15, 18, 41, 25, 934, DateTimeKind.Local).AddTicks(6733), "Júnior", null, null },
                    { new Guid("b2a9da96-a4a1-42e8-a6a5-69eb14d64a44"), true, 1, new DateTime(2023, 9, 15, 18, 41, 25, 934, DateTimeKind.Local).AddTicks(6748), "Sênior", null, null },
                    { new Guid("d2038d02-7233-42e7-a366-ffdcd796bfa3"), true, 1, new DateTime(2023, 9, 15, 18, 41, 25, 934, DateTimeKind.Local).AddTicks(6754), "Especialista", null, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "DBCadDev",
                table: "Auth",
                keyColumn: "Id",
                keyValue: new Guid("7d3512b7-6179-4283-914d-47f29110facc"));

            migrationBuilder.DeleteData(
                schema: "DBCadDev",
                table: "TipoDev",
                keyColumn: "Id",
                keyValue: new Guid("618d6115-7e38-4c7b-a950-ef7eb8b0410d"));

            migrationBuilder.DeleteData(
                schema: "DBCadDev",
                table: "TipoDev",
                keyColumn: "Id",
                keyValue: new Guid("73af6b0d-26e9-44e1-adf8-a454a5ef26da"));

            migrationBuilder.DeleteData(
                schema: "DBCadDev",
                table: "TipoDev",
                keyColumn: "Id",
                keyValue: new Guid("874e8f79-5035-4a5e-853c-c75ecacebc0d"));

            migrationBuilder.DeleteData(
                schema: "DBCadDev",
                table: "TipoDev",
                keyColumn: "Id",
                keyValue: new Guid("b2a9da96-a4a1-42e8-a6a5-69eb14d64a44"));

            migrationBuilder.DeleteData(
                schema: "DBCadDev",
                table: "TipoDev",
                keyColumn: "Id",
                keyValue: new Guid("d2038d02-7233-42e7-a366-ffdcd796bfa3"));

            migrationBuilder.DropColumn(
                name: "Email",
                schema: "DBCadDev",
                table: "Dev");

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
    }
}
