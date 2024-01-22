
using VassaSpraket_TW.Data.Models;
using VassaSpraket_TW.Enums;
using VassaSpraket_TW.Helpers;

namespace VassaSpraket_TW.Models
{
    public class PageTemplateViewModel
    {

        public int Id { get; set; }
        public string PdfSrc { get; set; }
        public string CroppedPdfSrc { get; set; }
        public string ThumbnailImg { get; set; }
        public int ChapterId { get; set; }
        public List<HotspotViewModel> Rows { get; set; }

         public static implicit operator PageTemplateViewModel(PageTemplate pageTemplate) => new PageTemplateViewModel
        {
            Id = pageTemplate.Id,
            PdfSrc = string.IsNullOrEmpty(pageTemplate.PdfSrc) ? "" : GetBaseUrl() + pageTemplate.PdfSrc,
            CroppedPdfSrc = string.IsNullOrEmpty(pageTemplate.CroppedPdfSrc) ? "" : GetBaseUrl() + pageTemplate.CroppedPdfSrc,
            ThumbnailImg = string.IsNullOrEmpty(pageTemplate.ThumbnailImg) ? "" : GetBaseUrl() + pageTemplate.ThumbnailImg,         
            ChapterId = pageTemplate.ChapterId,         
            Rows = pageTemplate.Rows == null ? new List<HotspotViewModel>() : pageTemplate.Rows.Select<Hotspot, HotspotViewModel>(b => b).ToList()

        };

        private static string GetBaseUrl()
        {
            return PathResolverHelper.ResolveUrl(PathResolverEnum.PageTemplate);
        }

    }

    public class HotspotViewModel
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



        public static implicit operator HotspotViewModel(Hotspot hotspot) => new HotspotViewModel
        {
            Id = hotspot.Id,
            PageNumber = hotspot.PageNumber,
            Label_Top = hotspot.Label_Top,
            Label_Left = hotspot.Label_Left,
            Label_Width = hotspot.Label_Width,
            Label_Height = hotspot.Label_Height,
            CroppedPdfPageNumber = hotspot.CroppedPdfPageNumber,
            PopupSortOrder = hotspot.PopupSortOrder,
            PageTemplateId = hotspot.PageTemplateId
        };

    }

    

}
