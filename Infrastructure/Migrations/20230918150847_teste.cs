using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class teste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "DBCadDev",
                table: "Auth",
                keyColumn: "Id",
                keyValue: new Guid("6c5d9f1d-1e7c-4455-a72e-7c8d4c52c680"));

            migrationBuilder.DeleteData(
                schema: "DBCadDev",
                table: "TipoDev",
                keyColumn: "Id",
                keyValue: new Guid("19e122fd-d0a3-4ff2-bc27-f947abf20bec"));

            migrationBuilder.DeleteData(
                schema: "DBCadDev",
                table: "TipoDev",
                keyColumn: "Id",
                keyValue: new Guid("5d7cf4a1-9102-4333-902c-c230ab738fe2"));

            migrationBuilder.DeleteData(
                schema: "DBCadDev",
                table: "TipoDev",
                keyColumn: "Id",
                keyValue: new Guid("67c79c71-b703-4af2-8998-a48f4e94645d"));

            migrationBuilder.DeleteData(
                schema: "DBCadDev",
                table: "TipoDev",
                keyColumn: "Id",
                keyValue: new Guid("8f06da26-929a-409a-b964-9679ba2be79b"));

            migrationBuilder.DeleteData(
                schema: "DBCadDev",
                table: "TipoDev",
                keyColumn: "Id",
                keyValue: new Guid("9ffece72-087e-4742-830a-0bc84ba9c318"));

            migrationBuilder.InsertData(
                schema: "DBCadDev",
                table: "Auth",
                columns: new[] { "Id", "Active", "CreatedBy", "CreatedDate", "Login", "Nome", "Senha", "UpdatedBy", "UpdatedDate" },
                values: new object[] { new Guid("153da047-6824-482f-8c18-be28bc13e2bd"), true, "f4ccb748-23f6-4694-9790-be6e0209b065", new DateTime(2023, 9, 18, 12, 8, 46, 780, DateTimeKind.Local).AddTicks(5542), "llanfredi", "Leandro Lanfredi", "9N1RJ4v/JxP6S23Lg8STzA==", null, null });

            migrationBuilder.InsertData(
                schema: "DBCadDev",
                table: "TipoDev",
                columns: new[] { "Id", "Active", "CreatedBy", "CreatedDate", "DescTipoDev", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("012623ce-24f0-4d8e-befb-19a84e7f4591"), true, "09b6813e-664c-412e-bb52-43e07b260294", new DateTime(2023, 9, 18, 12, 8, 46, 779, DateTimeKind.Local).AddTicks(1741), "Estágiário", null, null },
                    { new Guid("5afc05a1-c49f-48e9-9581-7e61c9c6062c"), true, "4cb66dd2-7a3a-4758-b96c-5a39dee06fe6", new DateTime(2023, 9, 18, 12, 8, 46, 779, DateTimeKind.Local).AddTicks(1842), "Sênior", null, null },
                    { new Guid("8f4327d0-4c8e-43da-a16d-ce7f8737daf0"), true, "d8721bbb-6b43-4b6c-8388-41518c158a20", new DateTime(2023, 9, 18, 12, 8, 46, 779, DateTimeKind.Local).AddTicks(1832), "Pleno", null, null },
                    { new Guid("e2d14b1d-8535-4b1a-b9b3-e9f30bab64f5"), true, "a831b5b0-ace7-45b3-a6f4-ec7c4f351ba3", new DateTime(2023, 9, 18, 12, 8, 46, 779, DateTimeKind.Local).AddTicks(1820), "Júnior", null, null },
                    { new Guid("fc98d66f-b991-4fdf-b1db-4dc38624dd50"), true, "ba83d389-6a27-4016-92b1-54c6e7f04149", new DateTime(2023, 9, 18, 12, 8, 46, 779, DateTimeKind.Local).AddTicks(1849), "Especialista", null, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "DBCadDev",
                table: "Auth",
                keyColumn: "Id",
                keyValue: new Guid("153da047-6824-482f-8c18-be28bc13e2bd"));

            migrationBuilder.DeleteData(
                schema: "DBCadDev",
                table: "TipoDev",
                keyColumn: "Id",
                keyValue: new Guid("012623ce-24f0-4d8e-befb-19a84e7f4591"));

            migrationBuilder.DeleteData(
                schema: "DBCadDev",
                table: "TipoDev",
                keyColumn: "Id",
                keyValue: new Guid("5afc05a1-c49f-48e9-9581-7e61c9c6062c"));

            migrationBuilder.DeleteData(
                schema: "DBCadDev",
                table: "TipoDev",
                keyColumn: "Id",
                keyValue: new Guid("8f4327d0-4c8e-43da-a16d-ce7f8737daf0"));

            migrationBuilder.DeleteData(
                schema: "DBCadDev",
                table: "TipoDev",
                keyColumn: "Id",
                keyValue: new Guid("e2d14b1d-8535-4b1a-b9b3-e9f30bab64f5"));

            migrationBuilder.DeleteData(
                schema: "DBCadDev",
                table: "TipoDev",
                keyColumn: "Id",
                keyValue: new Guid("fc98d66f-b991-4fdf-b1db-4dc38624dd50"));

            migrationBuilder.InsertData(
                schema: "DBCadDev",
                table: "Auth",
                columns: new[] { "Id", "Active", "CreatedBy", "CreatedDate", "Login", "Nome", "Senha", "UpdatedBy", "UpdatedDate" },
                values: new object[] { new Guid("6c5d9f1d-1e7c-4455-a72e-7c8d4c52c680"), true, "6ef082bf-18d1-4468-969c-d8696e8bd6e7", new DateTime(2023, 9, 18, 11, 1, 12, 885, DateTimeKind.Local).AddTicks(3294), "llanfredi", "Leandro Lanfredi", "9N1RJ4v/JxP6S23Lg8STzA==", null, null });

            migrationBuilder.InsertData(
                schema: "DBCadDev",
                table: "TipoDev",
                columns: new[] { "Id", "Active", "CreatedBy", "CreatedDate", "DescTipoDev", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("19e122fd-d0a3-4ff2-bc27-f947abf20bec"), true, "a3330d55-47c8-424c-b569-156db813c195", new DateTime(2023, 9, 18, 11, 1, 12, 839, DateTimeKind.Local).AddTicks(5485), "Pleno", null, null },
                    { new Guid("5d7cf4a1-9102-4333-902c-c230ab738fe2"), true, "e53dad50-326b-4e18-8665-0026d69b8cb3", new DateTime(2023, 9, 18, 11, 1, 12, 839, DateTimeKind.Local).AddTicks(5431), "Estágiário", null, null },
                    { new Guid("67c79c71-b703-4af2-8998-a48f4e94645d"), true, "72e589f8-a7e8-4180-a25f-6b0dfde2ce69", new DateTime(2023, 9, 18, 11, 1, 12, 839, DateTimeKind.Local).AddTicks(5476), "Júnior", null, null },
                    { new Guid("8f06da26-929a-409a-b964-9679ba2be79b"), true, "98306590-41a8-4c30-94a8-5c210435ffb6", new DateTime(2023, 9, 18, 11, 1, 12, 839, DateTimeKind.Local).AddTicks(5519), "Especialista", null, null },
                    { new Guid("9ffece72-087e-4742-830a-0bc84ba9c318"), true, "3d4039a4-31bc-4d26-9033-d0d241bc9a34", new DateTime(2023, 9, 18, 11, 1, 12, 839, DateTimeKind.Local).AddTicks(5511), "Sênior", null, null }
                });
        }
    }
}
