using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VassaSpraket_TW.Data.Migrations
{
    public partial class insert_data_extrachapters : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Chapters VALUES ('Chapter 3', 3)");
            migrationBuilder.Sql("INSERT INTO Chapters VALUES ('Chapter 4', 4)");

            migrationBuilder.Sql("INSERT INTO PageTemplate(PdfSrc,CroppedPdfSrc,ThumbnailImg,ChapterId) VALUES ('ch_3.pdf','zoom_ch_3.pdf','ch_3.png', 3)");
            migrationBuilder.Sql("INSERT INTO PageTemplate(PdfSrc,CroppedPdfSrc,ThumbnailImg,ChapterId) VALUES ('ch_4.pdf','zoom_ch_4.pdf','ch_4.png', 4)");

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
    ( 1, '47.5', '50', '74.5', '21.5', 1, 1, 3),
    ( 1, '71', '50', '74.5', '22',2, 2,3),
    ( 2, '9', '51', '73.5', '34',3,1,3),
    ( 2, '45', '51', '73.5', '20', 4,2, 3),
    ( 2, '67', '50', '78', '28', 5,3, 3),
    ( 3, '9', '50', '74.5', '38.5', 6,1, 3),
    ( 3, '50', '50', '74.5', '43', 7,2, 3), 


   ( 1, '9', '51', '74.5', '20', 1,1, 4),
   ( 1, '32', '51', '74.5', '61', 2,2, 4),
   ( 2, '28', '50', '74.5', '38',  3,1,4),
   ( 2, '67', '50', '74.5', '26', 4,2, 4),
   ( 3, '4', '51', '74.5', '47',  5,1, 4),
   ( 3, '53', '51', '74.5', '40',  6,2, 4);  

");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
