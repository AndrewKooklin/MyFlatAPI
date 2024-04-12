using Microsoft.EntityFrameworkCore.Migrations;

namespace MyFlatAPI.Migrations
{
    public partial class RenameCategoryOrderToService : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5a736f04-4cf7-4e64-921e-39d996bdd25d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73f851d7-e93e-40ef-b225-419d68623f1c");

            migrationBuilder.AlterColumn<string>(
                name: "CategoryName",
                table: "CategoryOrder",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fae27316-a849-45ef-8a5d-d074153bea4d", "6d5c54e4-667f-4b61-9ac9-d61039cdf950", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "acb82d9f-419d-45c6-a815-4fd6ba7efc0d", "302dc497-bf7b-49fa-af47-cc1123b3fe8e", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "acb82d9f-419d-45c6-a815-4fd6ba7efc0d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fae27316-a849-45ef-8a5d-d074153bea4d");

            migrationBuilder.AlterColumn<string>(
                name: "CategoryName",
                table: "CategoryOrder",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5a736f04-4cf7-4e64-921e-39d996bdd25d", "6d5c54e4-667f-4b61-9ac9-d61039cdf950", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "73f851d7-e93e-40ef-b225-419d68623f1c", "302dc497-bf7b-49fa-af47-cc1123b3fe8e", "User", "USER" });
        }
    }
}
