namespace P01_HospitalDatabase.Migrations
{
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class AddDefaultCommentForDiagnoses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Comments",
                table: "Diagnoses",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "Healthy :)",
                oldClrType: typeof(string),
                oldMaxLength: 250);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Comments",
                table: "Diagnoses",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldDefaultValue: "Healthy :)");
        }
    }
}
