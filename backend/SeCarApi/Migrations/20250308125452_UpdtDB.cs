using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SeCarApi.Migrations
{
    /// <inheritdoc />
    public partial class UpdtDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DemoModels",
                table: "DemoModels");

            migrationBuilder.RenameTable(
                name: "DemoModels",
                newName: "demo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_demo",
                table: "demo",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_demo",
                table: "demo");

            migrationBuilder.RenameTable(
                name: "demo",
                newName: "DemoModels");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DemoModels",
                table: "DemoModels",
                column: "Id");
        }
    }
}
