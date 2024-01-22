import { CommonModule } from '@angular/common';
import { Component, Input, Output, EventEmitter } from '@angular/core';
import { PdfViewerModule } from 'ng2-pdf-viewer';

@Component({
  selector: 'app-pdfviewer',
  standalone: true,
  imports: [CommonModule, PdfViewerModule],
  templateUrl: './pdfviewer.component.html',
  styleUrls: ['./pdfviewer.component.scss']
})
export class PdfviewerComponent {

  @Input() pdfUrl: string;
  @Input() currentPageNumber: number = 1;
  @Output() totalPages: EventEmitter<number> = new EventEmitter<number>();
  @Output() isPageLoaded: EventEmitter<boolean> = new EventEmitter<boolean>();
  @Input() thumbnailImgUrl: string;
  isShowThumbnail: boolean = true;

  constructor() { }

  //once the PDF is loaded emit the total number of pages
  afterLoadComplete(pdfData: { numPages: number }) {
    this.totalPages.emit(pdfData.numPages);
  }

  //once the page of PDF is loaded, hide the thumbnailimage
  pageRendered() {
    this.isPageLoaded.emit(false);
    this.isShowThumbnail = false;
  }
}
