using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class _seededRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a06d9c1c-154a-441e-a4f4-e49f03e4d2a8", "8e445865-a24d-4543-a6c6-9443d048cdb9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fde7a6d6-067c-4c71-b6cf-4a71afd861d4", "AQAAAAEAACcQAAAAEP8vhtwt/PhQIVgodIudlwKjqK8eJVIDT9WA3lbfF53k5wXUEUAiEGRWYwlQBYdzig==", "ea671649-854f-4e5e-a9bf-f9f8e27eb371" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a06d9c1c-154a-441e-a4f4-e49f03e4d2a8", "8e445865-a24d-4543-a6c6-9443d048cdb9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca947c7c-a533-4467-9395-542a97e51721", "AQAAAAEAACcQAAAAEGFmWtskcCVTTWUZI/dF4GpbdKeXfa0VBgv5TVlYu2n0c5J08DtOSWaWd99EdvAY5w==", "439dce53-e421-4a55-8f11-53f654444df6" });
        }
    }
}
