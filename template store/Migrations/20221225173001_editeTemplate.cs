using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace templatestore.Migrations
{
    /// <inheritdoc />
    public partial class editeTemplate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TemlateAddress",
                table: "Templates");

            migrationBuilder.AlterColumn<string>(
                name: "TemplateName",
                table: "Templates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TemplateAddress",
                table: "Templates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "TemplatePrice",
                table: "Templates",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TemplateAddress",
                table: "Templates");

            migrationBuilder.DropColumn(
                name: "TemplatePrice",
                table: "Templates");

            migrationBuilder.AlterColumn<string>(
                name: "TemplateName",
                table: "Templates",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "TemlateAddress",
                table: "Templates",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
