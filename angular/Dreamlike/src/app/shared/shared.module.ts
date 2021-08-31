import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ProductsComponent } from './components/products/products.component';
import { ProductsDetailsComponent } from './components/products-details/products-details.component';
import { SharedRoutingModule } from './shared-routing.module';
import { ReactiveFormsModule } from '@angular/forms';
import { ProductService } from './services/product.service';
import { MailService } from './services/mail.service';
import { EventService } from './services/event.service';
import { FilterPipe } from './pipes/filter.pipe';
import { MailComponent } from './components/mail/mail.component';
import { AddUserComponent } from './components/add-user/add-user.component';
import { AddUserService } from './services/add-user.service';

@NgModule({
  declarations: [
    ProductsComponent,
    ProductsDetailsComponent,
    AddUserComponent,
    MailComponent,
    // SearchComponent,
    FilterPipe
  ],
  imports: [
    CommonModule,
    HttpClientModule,
    SharedRoutingModule,
    ReactiveFormsModule
  ],
  providers: [ProductService, AddUserService, MailService, EventService],
  // exports: [ProductsComponent, ProductsDetailsComponent, LoginUserComponent, MailComponent]
})
export class SharedModule { }
