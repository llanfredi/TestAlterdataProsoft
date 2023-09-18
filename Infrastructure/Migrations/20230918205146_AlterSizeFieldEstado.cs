using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class AlterSizeFieldEstado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Estado",
                schema: "DBCadDev",
                table: "Dev",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                schema: "DBCadDev",
                table: "Auth",
                columns: new[] { "Id", "Active", "CreatedBy", "CreatedDate", "Login", "Nome", "Senha", "UpdatedBy", "UpdatedDate" },
                values: new object[] { new Guid("4e5c47ea-bfa2-4040-a2d6-2096c6959973"), true, "1425f45f-fa52-4aa1-8a3e-b2b863e4df0b", new DateTime(2023, 9, 18, 17, 51, 43, 75, DateTimeKind.Local).AddTicks(4698), "llanfredi", "Leandro Lanfredi", "9N1RJ4v/JxP6S23Lg8STzA==", null, null });

            migrationBuilder.InsertData(
                schema: "DBCadDev",
                table: "TipoDev",
                columns: new[] { "Id", "Active", "CreatedBy", "CreatedDate", "DescTipoDev", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("1d9e44ea-6bce-4bfa-9379-c5823df11b49"), true, "8e527ff5-f049-4716-8d90-a641be723e5f", new DateTime(2023, 9, 18, 17, 51, 43, 73, DateTimeKind.Local).AddTicks(562), "Júnior", null, null },
                    { new Guid("89953768-e9ed-4950-b625-2e940d6ba875"), true, "c281ded7-0d31-439f-a5c6-0811a5f02d8d", new DateTime(2023, 9, 18, 17, 51, 43, 73, DateTimeKind.Local).AddTicks(603), "Sênior", null, null },
                    { new Guid("c64bb26c-1599-4207-8a00-baa5895046a4"), true, "17b19284-8a71-495c-8689-be15493f0f9a", new DateTime(2023, 9, 18, 17, 51, 43, 73, DateTimeKind.Local).AddTicks(613), "Especialista", null, null },
                    { new Guid("dd804765-29d7-42bd-9c1e-fd60e7bc9379"), true, "4fb11f2c-e935-406e-b5a9-a7b828aad692", new DateTime(2023, 9, 18, 17, 51, 43, 73, DateTimeKind.Local).AddTicks(591), "Pleno", null, null },
                    { new Guid("e60ea66d-6336-4963-b69b-16731e635a96"), true, "dafb109b-e51d-4393-ae46-643afd394eed", new DateTime(2023, 9, 18, 17, 51, 43, 73, DateTimeKind.Local).AddTicks(502), "Estágiário", null, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "DBCadDev",
                table: "Auth",
                keyColumn: "Id",
                keyValue: new Guid("4e5c47ea-bfa2-4040-a2d6-2096c6959973"));

            migrationBuilder.DeleteData(
                schema: "DBCadDev",
                table: "TipoDev",
                keyColumn: "Id",
                keyValue: new Guid("1d9e44ea-6bce-4bfa-9379-c5823df11b49"));

            migrationBuilder.DeleteData(
                schema: "DBCadDev",
                table: "TipoDev",
                keyColumn: "Id",
                keyValue: new Guid("89953768-e9ed-4950-b625-2e940d6ba875"));

            migrationBuilder.DeleteData(
                schema: "DBCadDev",
                table: "TipoDev",
                keyColumn: "Id",
                keyValue: new Guid("c64bb26c-1599-4207-8a00-baa5895046a4"));

            migrationBuilder.DeleteData(
                schema: "DBCadDev",
                table: "TipoDev",
                keyColumn: "Id",
                keyValue: new Guid("dd804765-29d7-42bd-9c1e-fd60e7bc9379"));

            migrationBuilder.DeleteData(
                schema: "DBCadDev",
                table: "TipoDev",
                keyColumn: "Id",
                keyValue: new Guid("e60ea66d-6336-4963-b69b-16731e635a96"));

            migrationBuilder.AlterColumn<string>(
                name: "Estado",
                schema: "DBCadDev",
                table: "Dev",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2);

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
    }
}
