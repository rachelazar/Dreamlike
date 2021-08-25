import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FilterPipe } from './pipes/filter.pipe';
import { AppComponent } from '../app.component';
import { ProductsComponent } from './components/products/products.component';
import { ProductsDetailsComponent } from './components/products-details/products-details.component';
import { SharedRoutingModule } from './shared-routing.module';
import { ReactiveFormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    ProductsComponent,
    ProductsDetailsComponent,

  ],
  imports: [
    CommonModule,
    HttpClientModule,
    SharedRoutingModule,
    ReactiveFormsModule
  ],
  exports: [ProductsComponent, ProductsDetailsComponent]
})
export class SharedModule { }
