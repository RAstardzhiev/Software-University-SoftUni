namespace P01_HospitalDatabase.Migrations
{
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class AddDefaultCommentForVisitations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Comments",
                table: "Visitations",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "OK",
                oldClrType: typeof(string),
                oldMaxLength: 250);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Comments",
                table: "Visitations",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldDefaultValue: "OK");
        }
    }
}
