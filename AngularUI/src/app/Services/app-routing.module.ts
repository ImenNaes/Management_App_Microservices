import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { ProductsComponent } from '../Products/products/products.component';

const routes: Routes =[
  {path:'Products', component: ProductsComponent}
]

@NgModule({
  declarations: [],
  imports: [
    CommonModule, 
    RouterModule.forRoot(routes)
  ]
})
export class AppRoutingModule { }
