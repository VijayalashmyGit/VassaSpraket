namespace VassaSpraket_TW.Data.Models
{
    public class PageTemplate
    {
        public int Id { get; set; }
        public string PdfSrc { get; set; }
        public string CroppedPdfSrc { get; set; }
        public string ThumbnailImg { get; set; }        
        public int ChapterId { get; set; }
        public List<Hotspot> Rows { get; set; }

    }

    public class Hotspot
    {
        public int Id { get; set; }
        public int PageNumber { get; set; }
        public string Label_Top { get; set; }
        public string Label_Left { get; set; }
        public string Label_Width { get; set; }
        public string Label_Height { get; set; }     
        public int CroppedPdfPageNumber { get; set; }
        public int PopupSortOrder { get; set; }
        public int PageTemplateId { get; set; }       

    }


}
