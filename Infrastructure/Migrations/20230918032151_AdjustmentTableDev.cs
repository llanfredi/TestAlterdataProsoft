using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class AdjustmentTableDev : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dev_TipoDev_Id",
                schema: "DBCadDev",
                table: "Dev");

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

            migrationBuilder.CreateIndex(
                name: "IX_Dev_IdTipoDev",
                schema: "DBCadDev",
                table: "Dev",
                column: "IdTipoDev");

            migrationBuilder.AddForeignKey(
                name: "FK_Dev_TipoDev_IdTipoDev",
                schema: "DBCadDev",
                table: "Dev",
                column: "IdTipoDev",
                principalSchema: "DBCadDev",
                principalTable: "TipoDev",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dev_TipoDev_IdTipoDev",
                schema: "DBCadDev",
                table: "Dev");

            migrationBuilder.DropIndex(
                name: "IX_Dev_IdTipoDev",
                schema: "DBCadDev",
                table: "Dev");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Dev_TipoDev_Id",
                schema: "DBCadDev",
                table: "Dev",
                column: "Id",
                principalSchema: "DBCadDev",
                principalTable: "TipoDev",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
