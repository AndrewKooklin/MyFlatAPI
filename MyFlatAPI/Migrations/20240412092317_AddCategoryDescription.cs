using Microsoft.EntityFrameworkCore.Migrations;

namespace MyFlatAPI.Migrations
{
    public partial class AddCategoryDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "832fc885-4109-417d-8174-48eb4d201bad");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a7541b2a-a5c2-4b7c-a489-a90c1ca8efac");

            migrationBuilder.AddColumn<string>(
                name: "CategoryDescription",
                table: "CategoryService",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "00b8a498-eb1f-4133-94fd-3c2b87e43723", "6d5c54e4-667f-4b61-9ac9-d61039cdf950", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "75125766-9df9-4e49-91dd-ef34fb96d6e7", "302dc497-bf7b-49fa-af47-cc1123b3fe8e", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00b8a498-eb1f-4133-94fd-3c2b87e43723");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75125766-9df9-4e49-91dd-ef34fb96d6e7");

            migrationBuilder.DropColumn(
                name: "CategoryDescription",
                table: "CategoryService");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a7541b2a-a5c2-4b7c-a489-a90c1ca8efac", "6d5c54e4-667f-4b61-9ac9-d61039cdf950", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "832fc885-4109-417d-8174-48eb4d201bad", "302dc497-bf7b-49fa-af47-cc1123b3fe8e", "User", "USER" });
        }
    }
}
