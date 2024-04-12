using Microsoft.EntityFrameworkCore.Migrations;

namespace MyFlatAPI.Migrations
{
    public partial class RenameCategoryOrderToService1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CategoryOrder",
                table: "CategoryOrder");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "acb82d9f-419d-45c6-a815-4fd6ba7efc0d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fae27316-a849-45ef-8a5d-d074153bea4d");

            migrationBuilder.RenameTable(
                name: "CategoryOrder",
                newName: "CategoryService");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategoryService",
                table: "CategoryService",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a7541b2a-a5c2-4b7c-a489-a90c1ca8efac", "6d5c54e4-667f-4b61-9ac9-d61039cdf950", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "832fc885-4109-417d-8174-48eb4d201bad", "302dc497-bf7b-49fa-af47-cc1123b3fe8e", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CategoryService",
                table: "CategoryService");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "832fc885-4109-417d-8174-48eb4d201bad");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a7541b2a-a5c2-4b7c-a489-a90c1ca8efac");

            migrationBuilder.RenameTable(
                name: "CategoryService",
                newName: "CategoryOrder");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategoryOrder",
                table: "CategoryOrder",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fae27316-a849-45ef-8a5d-d074153bea4d", "6d5c54e4-667f-4b61-9ac9-d61039cdf950", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "acb82d9f-419d-45c6-a815-4fd6ba7efc0d", "302dc497-bf7b-49fa-af47-cc1123b3fe8e", "User", "USER" });
        }
    }
}
