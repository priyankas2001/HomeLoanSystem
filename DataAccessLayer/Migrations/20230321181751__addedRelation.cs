using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class _addedRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cc449f6c-eae7-40a4-a032-371126370ff7", "8e445865-a24d-4543-a6c6-9443d048cdb9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb28e232-9c16-4e33-8228-09bb3a4af89d", "AQAAAAEAACcQAAAAEEKoLIbHH2YFKnpGCMoIYTQw2/I4kX27c6Xv5NvkWJJOGTPfqh4M0sfbwve7jXVlOw==", "d8b737c7-fe66-49b8-8f11-b64b51e882f5" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cc449f6c-eae7-40a4-a032-371126370ff7", "8e445865-a24d-4543-a6c6-9443d048cdb9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ac01bf7-6a6f-4f02-b557-4a67cf7f92bb", "AQAAAAEAACcQAAAAEL/PDw+V91Cyfn9RgOWErNEAkzu9zKELm5IXeJ7j8ZW47KR+OUwifQNI5A8AoKnmEQ==", "7458233d-5eee-4179-b346-41ec10c855ef" });
        }
    }
}
