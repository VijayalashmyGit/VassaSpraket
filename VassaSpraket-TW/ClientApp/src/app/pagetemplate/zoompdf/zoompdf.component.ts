import { CommonModule } from '@angular/common';
import { Component, Inject } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogModule } from '@angular/material/dialog';
import { MatIconModule } from '@angular/material/icon';
import { PdfviewerComponent } from '../pdfviewer/pdfviewer.component';
import { MatButtonModule } from '@angular/material/button';


@Component({
  selector: 'app-zoompdf',
  standalone: true,
  imports: [CommonModule, MatDialogModule, MatIconModule, PdfviewerComponent, MatButtonModule],
  templateUrl: './zoompdf.component.html',
  styleUrls: ['./zoompdf.component.scss']
})
export class ZoompdfComponent {

  croppedPdfPageNumber = this.data.croppedPdfPageNumber;
  popupSortOrder = this.data.popupSortOrder;
  totalPopupCount = this.data.totalPopups;
  public isShowLoader: boolean = true;
  constructor(@Inject(MAT_DIALOG_DATA) public data: any) { }


  loadPrevPopup() {    
    this.popupSortOrder--;
    this.croppedPdfPageNumber--;
  }

  loadNxtPopup() {    
    this.popupSortOrder++;
    this.croppedPdfPageNumber++;
  }

  isPageLoaded(data: boolean) {    
    this.isShowLoader = data;
  }

}
