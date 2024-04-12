using Microsoft.EntityFrameworkCore.Migrations;

namespace MyFlatAPI.Migrations
{
    public partial class AddCategoryOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9088ce13-5bc2-42ff-8c5c-c7057513753b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9dc0ac14-fe4b-41c3-84bf-7ba6b66ce2bb");

            migrationBuilder.CreateTable(
                name: "CategoryOrder",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryOrder", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5a736f04-4cf7-4e64-921e-39d996bdd25d", "6d5c54e4-667f-4b61-9ac9-d61039cdf950", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "73f851d7-e93e-40ef-b225-419d68623f1c", "302dc497-bf7b-49fa-af47-cc1123b3fe8e", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryOrder");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5a736f04-4cf7-4e64-921e-39d996bdd25d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73f851d7-e93e-40ef-b225-419d68623f1c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9dc0ac14-fe4b-41c3-84bf-7ba6b66ce2bb", "6d5c54e4-667f-4b61-9ac9-d61039cdf950", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9088ce13-5bc2-42ff-8c5c-c7057513753b", "302dc497-bf7b-49fa-af47-cc1123b3fe8e", "User", "USER" });
        }
    }
}
