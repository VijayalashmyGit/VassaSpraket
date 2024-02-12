import { Component, Input, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { ZoompdfComponent } from '../zoompdf/zoompdf.component';
import { PdfviewerComponent } from '../pdfviewer/pdfviewer.component';
import { CommonModule } from '@angular/common';
import { MatDialogModule } from '@angular/material/dialog';
import { PageTemplateViewModel } from '../../models/pagetemplate.model';

@Component({
  selector: 'app-hotspot',
  standalone: true,
  imports: [PdfviewerComponent, ZoompdfComponent, CommonModule, MatDialogModule],
  templateUrl: './hotspot.component.html',
  styleUrls: ['./hotspot.component.scss']
})
export class HotspotComponent implements OnInit {
  @Input() model: PageTemplateViewModel;
  @Input() currentPageNumber: number;
  filteredData: any = [];
  pdfUrl: string;

  constructor(public dialog: MatDialog) { }

  ngOnInit() {
    this.pdfUrl = this.model.croppedPdfSrc;
    this.loadHotspot();
  }

  //filter the data based on the pageNumber and convert the values to Number
  loadHotspot() {
    this.filteredData = this.model.rows
      .map((item: { label_Width: string; label_Top: string; label_Height: string; pageNumber: number }) => ({
        ...item,
        label_Width: parseFloat(item.label_Width),
        label_Height: parseFloat(item.label_Height),
        label_Top: parseFloat(item.label_Top),
      }));
  }

  // Handles mouse over event to show specific part
  onMouseOver(index: number) {
    this.filteredData[index].isVisible = true;
  }

  // Handles mouse leave event to hide specific part
  onMouseLeave(index: number) {
    this.filteredData[index].isVisible = false;
  }

  // Opens a popup dialog with zoomed PDF details
  openPopup(croppedPdfPageNumber: number, popupSortOrder: number, pageNumber: number): void {

    const popupCount = this.model.rows.filter(item => item.pageNumber === pageNumber).length;

    this.dialog.open(ZoompdfComponent, {
      maxWidth: '92vw',
      width: '100%',
      height: '87vh',
      data: {
        pdfUrl: this.model.croppedPdfSrc,
        croppedPdfPageNumber,
        popupSortOrder,
        totalPopups: popupCount
      }
    });
  }
}
