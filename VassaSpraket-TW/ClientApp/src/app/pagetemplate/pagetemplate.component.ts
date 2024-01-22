import { Component, OnInit } from '@angular/core';
import { PageTemplateService } from './pagetemplate.service';
import { ApiResponse } from '../models/apiResponse';
import { PageTemplateViewModel } from '../models/pagetemplate.model';
import { Input } from '@angular/core';
import { PdfviewerComponent } from './pdfviewer/pdfviewer.component';
import { HotspotComponent } from './hotspot/hotspot.component';
import { CommonModule } from '@angular/common';
import { MatButtonModule } from '@angular/material/button';
import { Router } from '@angular/router';

@Component({
  selector: 'app-pagetemplate',
  standalone: true,
  imports: [PdfviewerComponent, HotspotComponent, CommonModule, MatButtonModule],
  templateUrl: './pagetemplate.component.html',
  styleUrls: ['./pagetemplate.component.scss']
})
export class PagetemplateComponent implements OnInit {
  @Input() id = '';
  model: PageTemplateViewModel;
  currentPageNumber: number = 1;
  totalPageCount: number;
  isShowNavBtn: boolean = true;
  constructor(private pageTemplateService: PageTemplateService,private router: Router) { }

  ngOnInit() {
    this.pageTemplateService.getPageTemplateById(Number(this.id)).subscribe((data: ApiResponse<PageTemplateViewModel>) => {
      this.model = data.payload;
    });
  }

  loadPrevPage() {
    this.currentPageNumber--;
  }

  loadNxtPage() {
    this.currentPageNumber++;
  }

  //get Total pages of PDF from pdfviewer component
  getTotalPages(totalPages: number) {
    this.totalPageCount = totalPages;

  }

  isPageLoaded(data: boolean) {
    this.isShowNavBtn = data;
  }

  goHomePage() {
    this.router.navigate(['/']);
  }
}
