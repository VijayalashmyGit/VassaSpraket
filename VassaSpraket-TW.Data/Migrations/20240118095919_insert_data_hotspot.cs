using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VassaSpraket_TW.Data.Migrations
{
    public partial class insert_data_hotspot : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE PageTemplate SET CroppedPdfSrc = 'zoom_ch_1.pdf' WHERE ChapterId=1");

            migrationBuilder.Sql("UPDATE PageTemplate SET CroppedPdfSrc = 'zoom_ch_2.pdf' WHERE ChapterId=2");

            migrationBuilder.Sql(@"
    INSERT INTO Hotspot 
    (        
        PageNumber, 
        Label_Top, 
        Label_Left, 
        Label_Width, 
        Label_Height,       
        CroppedPdfPageNumber,
        PopupSortOrder,
        PageTemplateId
    ) 
    VALUES 
    ( 1, '47.5', '50', '74.5', '21.5', 1, 1, 1),
    ( 1, '71', '50', '74.5', '22',2, 2,1),
    ( 2, '9', '51', '73.5', '34',3,1,1),
    ( 2, '45', '51', '73.5', '20', 4,2, 1),
    ( 2, '67', '50', '78', '28', 5,3, 1),
    ( 3, '9', '50', '74.5', '38.5', 6,1, 1),
    ( 3, '50', '50', '74.5', '43', 7,2, 1),

   ( 1, '9', '51', '74.5', '20', 1,1, 2),
   ( 1, '32', '51', '74.5', '61', 2,2, 2),
   ( 2, '28', '50', '74.5', '38',  3,1,2),
   ( 2, '67', '50', '74.5', '26', 4,2, 2),
   ( 3, '4', '51', '74.5', '47',  5,1, 2),
   ( 3, '53', '51', '74.5', '40',  6,2, 2);

");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
