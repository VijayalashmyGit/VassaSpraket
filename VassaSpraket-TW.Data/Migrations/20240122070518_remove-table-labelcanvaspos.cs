using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VassaSpraket_TW.Data.Migrations
{
    public partial class removetablelabelcanvaspos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM LabelCanvasPos", true);
            migrationBuilder.DropTable(
            name: "LabelCanvasPos");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
