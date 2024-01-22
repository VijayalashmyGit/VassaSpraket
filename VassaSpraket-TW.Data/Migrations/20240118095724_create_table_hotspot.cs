using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VassaSpraket_TW.Data.Migrations
{
    public partial class create_table_hotspot : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {          

            migrationBuilder.AddColumn<string>(
                name: "CroppedPdfSrc",
                table: "PageTemplate",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Hotspot",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PageNumber = table.Column<int>(type: "int", nullable: false),
                    Label_Top = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Label_Left = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Label_Width = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Label_Height = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CroppedPdfPageNumber = table.Column<int>(type: "int", nullable: false),
                    PopupSortOrder = table.Column<int>(type: "int", nullable: false),
                    PageTemplateId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotspot", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hotspot_PageTemplate_PageTemplateId",
                        column: x => x.PageTemplateId,
                        principalTable: "PageTemplate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Hotspot_PageTemplateId",
                table: "Hotspot",
                column: "PageTemplateId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hotspot");

            migrationBuilder.DropColumn(
                name: "CroppedPdfSrc",
                table: "PageTemplate");

            migrationBuilder.CreateTable(
                name: "LabelCanvasPos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Canvas_Height = table.Column<int>(type: "int", nullable: false),
                    Canvas_StartX = table.Column<int>(type: "int", nullable: false),
                    Canvas_StartY = table.Column<int>(type: "int", nullable: false),
                    Canvas_Width = table.Column<int>(type: "int", nullable: false),
                    LabelCanvas_Height = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LabelCanvas_Left = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LabelCanvas_Top = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LabelCanvas_Width = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PageNumber = table.Column<int>(type: "int", nullable: false),
                    PageTemplateId = table.Column<int>(type: "int", nullable: false),
                    Scale = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LabelCanvasPos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LabelCanvasPos_PageTemplate_PageTemplateId",
                        column: x => x.PageTemplateId,
                        principalTable: "PageTemplate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LabelCanvasPos_PageTemplateId",
                table: "LabelCanvasPos",
                column: "PageTemplateId");
        }
    }
}
