using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreCodeCamp.Migrations
{
    public partial class dataaddedd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Camps_Location_LocationId",
                table: "Camps");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropIndex(
                name: "IX_Camps_LocationId",
                table: "Camps");

            migrationBuilder.RenameColumn(
                name: "LocationId",
                table: "Camps",
                newName: "Location_LocationId");

            migrationBuilder.AddColumn<string>(
                name: "Location_Address1",
                table: "Camps",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Location_Address2",
                table: "Camps",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Location_Address3",
                table: "Camps",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Location_CityTown",
                table: "Camps",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Location_Country",
                table: "Camps",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Location_PostalCode",
                table: "Camps",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Location_StateProvince",
                table: "Camps",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Location_VenueName",
                table: "Camps",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Camps",
                keyColumn: "CampId",
                keyValue: 1,
                columns: new[] { "Location_Address1", "Location_CityTown", "Location_Country", "Location_LocationId", "Location_PostalCode", "Location_StateProvince", "Location_VenueName" },
                values: new object[] { "123 Main Street", "Atlanta", "USA", 1, "12345", "GA", "Atlanta Convention Center" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Location_Address1",
                table: "Camps");

            migrationBuilder.DropColumn(
                name: "Location_Address2",
                table: "Camps");

            migrationBuilder.DropColumn(
                name: "Location_Address3",
                table: "Camps");

            migrationBuilder.DropColumn(
                name: "Location_CityTown",
                table: "Camps");

            migrationBuilder.DropColumn(
                name: "Location_Country",
                table: "Camps");

            migrationBuilder.DropColumn(
                name: "Location_PostalCode",
                table: "Camps");

            migrationBuilder.DropColumn(
                name: "Location_StateProvince",
                table: "Camps");

            migrationBuilder.DropColumn(
                name: "Location_VenueName",
                table: "Camps");

            migrationBuilder.RenameColumn(
                name: "Location_LocationId",
                table: "Camps",
                newName: "LocationId");

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    LocationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CityTown = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StateProvince = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VenueName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.LocationId);
                });

            migrationBuilder.UpdateData(
                table: "Camps",
                keyColumn: "CampId",
                keyValue: 1,
                column: "LocationId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Camps_LocationId",
                table: "Camps",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Camps_Location_LocationId",
                table: "Camps",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
