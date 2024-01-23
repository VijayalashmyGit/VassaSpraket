﻿using Microsoft.EntityFrameworkCore.Migrations;

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

    ( 4, '47.5', '50', '74.5', '21.5', 8, 1, 3),
    ( 4, '71', '50', '74.5', '22',9, 2,3),
    ( 5, '9', '51', '73.5', '34',10,1,3),
    ( 5, '45', '51', '73.5', '20', 11,2, 3),
    ( 5, '67', '50', '78', '28', 12,3, 3),
    ( 6, '9', '50', '74.5', '38.5', 13,1, 3),
    ( 6, '50', '50', '74.5', '43', 14,2, 3),

    ( 7, '47.5', '50', '74.5', '21.5', 15, 1, 3),
    ( 7, '71', '50', '74.5', '22',16, 2,3),
    ( 8, '9', '51', '73.5', '34',17,1,3),
    ( 8, '45', '51', '73.5', '20', 18,2, 3),
    ( 8, '67', '50', '78', '28', 19,3, 3),
    ( 9, '9', '50', '74.5', '38.5', 20,1, 3),
    ( 9, '50', '50', '74.5', '43', 21,2, 3),

    ( 10, '47.5', '50', '74.5', '21.5', 22, 1, 3),
    ( 10, '71', '50', '74.5', '22',23, 2,3),
    ( 11, '9', '51', '73.5', '34',24,1,3),
    ( 11, '45', '51', '73.5', '20', 25,2, 3),
    ( 11, '67', '50', '78', '28', 26,3, 3),
    ( 12, '9', '50', '74.5', '38.5', 27,1, 3),
    ( 12, '50', '50', '74.5', '43', 28,2, 3),

    ( 13, '47.5', '50', '74.5', '21.5', 29, 1, 3),
    ( 13, '71', '50', '74.5', '22',30, 2,3),
    ( 14, '9', '51', '73.5', '34',31,1,3),
    ( 14, '45', '51', '73.5', '20', 32,2, 3),
    ( 14, '67', '50', '78', '28', 33,3, 3),
    ( 15, '9', '50', '74.5', '38.5', 34,1, 3),
    ( 15, '50', '50', '74.5', '43', 35,2, 3),

    ( 16, '47.5', '50', '74.5', '21.5', 36, 1, 3),
    ( 16, '71', '50', '74.5', '22',37, 2,3),
    ( 17, '9', '51', '73.5', '34',38,1,3),
    ( 17, '45', '51', '73.5', '20', 39,2, 3),
    ( 17, '67', '50', '78', '28', 40,3, 3),
    ( 18, '9', '50', '74.5', '38.5', 41,1, 3),
    ( 18, '50', '50', '74.5', '43', 42,2, 3),

    ( 19, '47.5', '50', '74.5', '21.5', 43, 1, 3),
    ( 19, '71', '50', '74.5', '22',44, 2,3),
    ( 20, '9', '51', '73.5', '34',45,1,3),
    ( 20, '45', '51', '73.5', '20', 46,2, 3),
    ( 20, '67', '50', '78', '28', 47,3, 3),
    ( 21, '9', '50', '74.5', '38.5', 48,1, 3),
    ( 21, '50', '50', '74.5', '43', 49,2, 3),

    ( 22, '47.5', '50', '74.5', '21.5', 50, 1, 3),
    ( 22, '71', '50', '74.5', '22',51, 2,3),
    ( 23, '9', '51', '73.5', '34',52,1,3),
    ( 23, '45', '51', '73.5', '20', 53,2, 3),
    ( 23, '67', '50', '78', '28', 54,3, 3),
    ( 24, '9', '50', '74.5', '38.5', 55,1, 3),
    ( 24, '50', '50', '74.5', '43', 56,2, 3),

    ( 25, '47.5', '50', '74.5', '21.5', 57, 1, 3),
    ( 25, '71', '50', '74.5', '22',58, 2,3),
    ( 26, '9', '51', '73.5', '34',59,1,3),
    ( 26, '45', '51', '73.5', '20', 60,2, 3),
    ( 26, '67', '50', '78', '28', 61,3, 3),
    ( 27, '9', '50', '74.5', '38.5', 62,1, 3),
    ( 27, '50', '50', '74.5', '43', 63,2, 3),

    ( 28, '47.5', '50', '74.5', '21.5', 64, 1, 3),
    ( 28, '71', '50', '74.5', '22',65, 2,3),
    ( 29, '9', '51', '73.5', '34',66,1,3),
    ( 29, '45', '51', '73.5', '20', 67,2, 3),
    ( 29, '67', '50', '78', '28', 68,3, 3),
    ( 30, '9', '50', '74.5', '38.5', 69,1, 3),
    ( 30, '50', '50', '74.5', '43', 70,2, 3),

    ( 31, '47.5', '50', '74.5', '21.5', 71, 1, 3),
    ( 31, '71', '50', '74.5', '22',72, 2,3),
    ( 32, '9', '51', '73.5', '34',73,1,3),
    ( 32, '45', '51', '73.5', '20', 74,2, 3),
    ( 32, '67', '50', '78', '28', 75,3, 3),
    ( 33, '9', '50', '74.5', '38.5', 76,1, 3),
    ( 33, '50', '50', '74.5', '43', 77,2, 3),

    ( 34, '47.5', '50', '74.5', '21.5', 78, 1, 3),
    ( 34, '71', '50', '74.5', '22',79, 2,3),
    ( 35, '9', '51', '73.5', '34',80,1,3),
    ( 35, '45', '51', '73.5', '20', 81,2, 3),
    ( 35, '67', '50', '78', '28', 82,3, 3),
    ( 36, '9', '50', '74.5', '38.5', 83,1, 3),
    ( 36, '50', '50', '74.5', '43', 84,2, 3),

    ( 37, '47.5', '50', '74.5', '21.5', 85, 1, 3),
    ( 37, '71', '50', '74.5', '22',86, 2,3),
    ( 38, '9', '51', '73.5', '34',87,1,3),
    ( 38, '45', '51', '73.5', '20', 88,2, 3),
    ( 38, '67', '50', '78', '28', 89,3, 3),
    ( 39, '9', '50', '74.5', '38.5', 90,1, 3),
    ( 39, '50', '50', '74.5', '43', 91,2, 3),

    ( 40, '47.5', '50', '74.5', '21.5', 92, 1, 3),
    ( 40, '71', '50', '74.5', '22',93, 2,3),
    ( 41, '9', '51', '73.5', '34',94,1,3),
    ( 41, '45', '51', '73.5', '20', 95,2, 3),
    ( 41, '67', '50', '78', '28', 96,3, 3),
    ( 42, '9', '50', '74.5', '38.5', 97,1, 3),
    ( 42, '50', '50', '74.5', '43', 98,2, 3),

    ( 43, '47.5', '50', '74.5', '21.5', 99, 1, 3),
    ( 43, '71', '50', '74.5', '22',100, 2,3),
    ( 44, '9', '51', '73.5', '34',101,1,3),
    ( 44, '45', '51', '73.5', '20', 102,2, 3),
    ( 44, '67', '50', '78', '28', 103,3, 3),
    ( 45, '9', '50', '74.5', '38.5', 104,1, 3),
    ( 45, '50', '50', '74.5', '43', 105,2, 3),

    ( 46, '47.5', '50', '74.5', '21.5', 106, 1, 3),
    ( 46, '71', '50', '74.5', '22',107, 2,3),
    ( 47, '9', '51', '73.5', '34',108,1,3),
    ( 47, '45', '51', '73.5', '20', 109,2, 3),
    ( 47, '67', '50', '78', '28', 110,3, 3),
    ( 48, '9', '50', '74.5', '38.5', 111,1, 3),
    ( 48, '50', '50', '74.5', '43', 112,2, 3),

    ( 49, '47.5', '50', '74.5', '21.5', 113, 1, 3),
    ( 49, '71', '50', '74.5', '22',114, 2,3),
    ( 50, '9', '51', '73.5', '34',115,1,3),
    ( 50, '45', '51', '73.5', '20', 116,2, 3),
    ( 50, '67', '50', '78', '28', 117,3, 3),
    ( 51, '9', '50', '74.5', '38.5', 118,1, 3),
    ( 51, '50', '50', '74.5', '43', 119,2, 3),


   ( 1, '9', '51', '74.5', '20', 1,1, 4),
   ( 1, '32', '51', '74.5', '61', 2,2, 4),
   ( 2, '28', '50', '74.5', '38',  3,1,4),
   ( 2, '67', '50', '74.5', '26', 4,2, 4),
   ( 3, '4', '51', '74.5', '47',  5,1, 4),
   ( 3, '53', '51', '74.5', '40',  6,2, 4),

   ( 4, '9', '51', '74.5', '20', 7,1, 4),
   ( 4, '32', '51', '74.5', '61', 8,2, 4),
   ( 5, '28', '50', '74.5', '38',  9,1,4),
   ( 5, '67', '50', '74.5', '26', 10,2, 4),
   ( 6, '4', '51', '74.5', '47',  11,1, 4),
   ( 6, '53', '51', '74.5', '40',  12,2, 4),

   ( 7, '9', '51', '74.5', '20', 13,1, 4),
   ( 7, '32', '51', '74.5', '61', 14,2, 4),
   ( 8, '28', '50', '74.5', '38',  15,1,4),
   ( 8, '67', '50', '74.5', '26', 16,2, 4),
   ( 9, '4', '51', '74.5', '47',  17,1, 4),
   ( 9, '53', '51', '74.5', '40',  18,2, 4),

   ( 10, '9', '51', '74.5', '20', 19,1, 4),
   ( 10, '32', '51', '74.5', '61', 20,2, 4),
   ( 11, '28', '50', '74.5', '38',  21,1,4),
   ( 11, '67', '50', '74.5', '26', 22,2, 4),
   ( 12, '4', '51', '74.5', '47',  23,1, 4),
   ( 12, '53', '51', '74.5', '40',  24,2, 4),

   ( 13, '9', '51', '74.5', '20', 25,1, 4),
   ( 13, '32', '51', '74.5', '61', 26,2, 4),
   ( 14, '28', '50', '74.5', '38',  27,1,4),
   ( 14, '67', '50', '74.5', '26', 28,2, 4),
   ( 15, '4', '51', '74.5', '47',  29,1, 4),
   ( 15, '53', '51', '74.5', '40',  30,2, 4),

   ( 16, '9', '51', '74.5', '20', 31,1, 4),
   ( 16, '32', '51', '74.5', '61', 32,2, 4),
   ( 17, '28', '50', '74.5', '38',  33,1,4),
   ( 17, '67', '50', '74.5', '26', 34,2, 4),
   ( 18, '4', '51', '74.5', '47',  35,1, 4),
   ( 18, '53', '51', '74.5', '40',  36,2, 4),

   ( 19, '9', '51', '74.5', '20', 37,1, 4),
   ( 19, '32', '51', '74.5', '61', 38,2, 4),
   ( 20, '28', '50', '74.5', '38',  39,1,4),
   ( 20, '67', '50', '74.5', '26', 40,2, 4),
   ( 21, '4', '51', '74.5', '47',  41,1, 4),
   ( 21, '53', '51', '74.5', '40',  42,2, 4),


   ( 22, '9', '51', '74.5', '20', 43,1, 4),
   ( 22, '32', '51', '74.5', '61', 44,2, 4),
   ( 23, '28', '50', '74.5', '38',  45,1,4),
   ( 23, '67', '50', '74.5', '26', 46,2, 4),
   ( 24, '4', '51', '74.5', '47',  47,1, 4),
   ( 24, '53', '51', '74.5', '40',  48,2, 4),

   ( 25, '9', '51', '74.5', '20', 49,1, 4),
   ( 25, '32', '51', '74.5', '61', 50,2, 4),
   ( 26, '28', '50', '74.5', '38', 51,1,4),
   ( 26, '67', '50', '74.5', '26', 52,2, 4),
   ( 27, '4', '51', '74.5', '47',  53,1, 4),
   ( 27, '53', '51', '74.5', '40',  54,2, 4),

   ( 28, '9', '51', '74.5', '20', 55,1, 4),
   ( 28, '32', '51', '74.5', '61', 56,2, 4),
   ( 29, '28', '50', '74.5', '38', 57,1,4),
   ( 29, '67', '50', '74.5', '26', 58,2, 4),
   ( 30, '4', '51', '74.5', '47',  59,1, 4),
   ( 30, '53', '51', '74.5', '40',  60,2, 4),

   ( 31, '9', '51', '74.5', '20', 61,1, 4),
   ( 31, '32', '51', '74.5', '61', 62,2, 4),
   ( 32, '28', '50', '74.5', '38', 63,1,4),
   ( 32, '67', '50', '74.5', '26', 64,2, 4),
   ( 33, '4', '51', '74.5', '47',  65,1, 4),
   ( 33, '53', '51', '74.5', '40',  66,2, 4),


   ( 34, '9', '51', '74.5', '20', 67,1, 4),
   ( 34, '32', '51', '74.5', '61', 68,2, 4),
   ( 35, '28', '50', '74.5', '38', 69,1,4),
   ( 35, '67', '50', '74.5', '26', 70,2, 4),
   ( 36, '4', '51', '74.5', '47',  71,1, 4),
   ( 36, '53', '51', '74.5', '40',  72,2, 4),

   ( 37, '9', '51', '74.5', '20', 73,1, 4),
   ( 37, '32', '51', '74.5', '61', 74,2, 4),
   ( 38, '28', '50', '74.5', '38', 75,1,4),
   ( 38, '67', '50', '74.5', '26', 76,2, 4),
   ( 39, '4', '51', '74.5', '47',  77,1, 4),
   ( 39, '53', '51', '74.5', '40',  78,2, 4),

   ( 40, '9', '51', '74.5', '20', 79,1, 4),
   ( 40, '32', '51', '74.5', '61', 80,2, 4),
   ( 41, '28', '50', '74.5', '38', 81,1,4),
   ( 41, '67', '50', '74.5', '26', 82,2, 4),
   ( 42, '4', '51', '74.5', '47',  83,1, 4),
   ( 42, '53', '51', '74.5', '40',  84,2, 4),

   ( 43, '9', '51', '74.5', '20', 79,1, 4),
   ( 43, '32', '51', '74.5', '61', 80,2, 4),
   ( 44, '28', '50', '74.5', '38', 81,1,4),
   ( 44, '67', '50', '74.5', '26', 82,2, 4),
   ( 45, '4', '51', '74.5', '47',  83,1, 4),
   ( 45, '53', '51', '74.5', '40',  84,2, 4),

   ( 46, '9', '51', '74.5', '20', 85,1, 4),
   ( 46, '32', '51', '74.5', '61', 86,2, 4),
   ( 47, '28', '50', '74.5', '38', 87,1,4),
   ( 47, '67', '50', '74.5', '26', 88,2, 4),
   ( 48, '4', '51', '74.5', '47',  89,1, 4),
   ( 48, '53', '51', '74.5', '40',  90,2, 4),

   ( 49, '9', '51', '74.5', '20', 91,1, 4),
   ( 49, '32', '51', '74.5', '61', 92,2, 4),
   ( 50, '28', '50', '74.5', '38', 93,1,4),
   ( 50, '67', '50', '74.5', '26', 94,2, 4),
   ( 51, '4', '51', '74.5', '47',  95,1, 4),
   ( 51, '53', '51', '74.5', '40',  96,2, 4);

");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}