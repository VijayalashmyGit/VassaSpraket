import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { PagetemplateComponent } from './pagetemplate/pagetemplate.component';


const routes: Routes = [
  {
    path: '',
    component: PagetemplateComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class LazyLoadModule { }
