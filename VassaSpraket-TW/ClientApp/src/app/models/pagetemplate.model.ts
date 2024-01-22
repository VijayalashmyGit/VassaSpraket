export class PageTemplateViewModel{
  id: number;
  pdfSrc: string;
  croppedPdfSrc: string;
  thumbnailImg: string;
  chapterId: number;
  rows: HotspotViewModel[];
}

export class HotspotViewModel {  
  id: number;
  pageNumber: number;
  label_Top: string;
  label_Left: string;
  label_Width: string;
  label_Height: string;
  croppedPdfPageNumber: number;
  popupSortOrder: number; 
  pageTemplateId: number;
}
