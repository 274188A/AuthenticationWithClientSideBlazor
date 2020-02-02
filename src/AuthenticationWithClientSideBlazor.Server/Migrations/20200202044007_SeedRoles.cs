using Microsoft.EntityFrameworkCore.Migrations;

namespace AuthenticationWithClientSideBlazor.Server.Data.Migations
{
    public partial class SeedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fac3bce3-65e6-405a-ae1d-bafe6be50650", "fe58b4f1-c6c1-4078-96bf-cbb5096de0d2", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9c0e3578-520b-4b90-a2f3-2e9d38bb7511", "4604f4c9-afcd-458a-9913-465c7ee4c2ed", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9c0e3578-520b-4b90-a2f3-2e9d38bb7511");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fac3bce3-65e6-405a-ae1d-bafe6be50650");
        }
    }
}
