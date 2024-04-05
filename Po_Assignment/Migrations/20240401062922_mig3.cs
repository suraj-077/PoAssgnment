using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Po_Assignment.Migrations
{
    /// <inheritdoc />
    public partial class mig3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Unit",
                table: "PoDetailsMaster");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Unit",
                table: "PoDetailsMaster",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
