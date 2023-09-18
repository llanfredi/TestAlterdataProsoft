using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class AdjustmentFieldBaseTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "DBCadDev",
                table: "Auth",
                keyColumn: "Id",
                keyValue: new Guid("c33345f9-c938-4a40-8024-7065293a458b"));

            migrationBuilder.DeleteData(
                schema: "DBCadDev",
                table: "TipoDev",
                keyColumn: "Id",
                keyValue: new Guid("1667edef-3bff-4093-9571-cf9b35100f8e"));

            migrationBuilder.DeleteData(
                schema: "DBCadDev",
                table: "TipoDev",
                keyColumn: "Id",
                keyValue: new Guid("302f808a-e9b0-4170-9dce-9c97fa096f62"));

            migrationBuilder.DeleteData(
                schema: "DBCadDev",
                table: "TipoDev",
                keyColumn: "Id",
                keyValue: new Guid("795494f1-decb-4c4b-ad22-c6ade9a30e1b"));

            migrationBuilder.DeleteData(
                schema: "DBCadDev",
                table: "TipoDev",
                keyColumn: "Id",
                keyValue: new Guid("93a95c47-d4ba-446f-a1a4-1752f953ec61"));

            migrationBuilder.DeleteData(
                schema: "DBCadDev",
                table: "TipoDev",
                keyColumn: "Id",
                keyValue: new Guid("aa03b612-6683-4b22-95fa-cffb250296c0"));

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                schema: "DBCadDev",
                table: "TipoDev",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "DBCadDev",
                table: "TipoDev",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                schema: "DBCadDev",
                table: "Dev",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "DBCadDev",
                table: "Dev",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedBy",
                schema: "DBCadDev",
                table: "Auth",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "DBCadDev",
                table: "Auth",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "UpdatedBy",
                schema: "DBCadDev",
                table: "TipoDev",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy",
                schema: "DBCadDev",
                table: "TipoDev",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "UpdatedBy",
                schema: "DBCadDev",
                table: "Dev",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy",
                schema: "DBCadDev",
                table: "Dev",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "UpdatedBy",
                schema: "DBCadDev",
                table: "Auth",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy",
                schema: "DBCadDev",
                table: "Auth",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                schema: "DBCadDev",
                table: "Auth",
                columns: new[] { "Id", "Active", "CreatedBy", "CreatedDate", "Login", "Nome", "Senha", "UpdatedBy", "UpdatedDate" },
                values: new object[] { new Guid("c33345f9-c938-4a40-8024-7065293a458b"), true, 1, new DateTime(2023, 9, 18, 0, 21, 51, 156, DateTimeKind.Local).AddTicks(8575), "llanfredi", "Leandro Lanfredi", "9N1RJ4v/JxP6S23Lg8STzA==", null, null });

            migrationBuilder.InsertData(
                schema: "DBCadDev",
                table: "TipoDev",
                columns: new[] { "Id", "Active", "CreatedBy", "CreatedDate", "DescTipoDev", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("1667edef-3bff-4093-9571-cf9b35100f8e"), true, 1, new DateTime(2023, 9, 18, 0, 21, 51, 155, DateTimeKind.Local).AddTicks(2944), "Pleno", null, null },
                    { new Guid("302f808a-e9b0-4170-9dce-9c97fa096f62"), true, 1, new DateTime(2023, 9, 18, 0, 21, 51, 155, DateTimeKind.Local).AddTicks(2880), "Estágiário", null, null },
                    { new Guid("795494f1-decb-4c4b-ad22-c6ade9a30e1b"), true, 1, new DateTime(2023, 9, 18, 0, 21, 51, 155, DateTimeKind.Local).AddTicks(2929), "Júnior", null, null },
                    { new Guid("93a95c47-d4ba-446f-a1a4-1752f953ec61"), true, 1, new DateTime(2023, 9, 18, 0, 21, 51, 155, DateTimeKind.Local).AddTicks(2956), "Sênior", null, null },
                    { new Guid("aa03b612-6683-4b22-95fa-cffb250296c0"), true, 1, new DateTime(2023, 9, 18, 0, 21, 51, 155, DateTimeKind.Local).AddTicks(2985), "Especialista", null, null }
                });
        }
    }
}
