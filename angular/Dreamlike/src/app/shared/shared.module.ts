import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ProductsComponent } from './components/products/products.component';
import { ProductsDetailsComponent } from './components/products-details/products-details.component';
import { SharedRoutingModule } from './shared-routing.module';
import { ReactiveFormsModule } from '@angular/forms';
import { ProductService } from './services/product.service';
import { LoginUserService } from './services/login-user.service';
import { MailService } from './services/mail.service';
import { EventService } from './services/event.service';
import { FilterPipe } from './pipes/filter.pipe';
import { LoginUserComponent } from './components/login-user/login-user.component';
import { MailComponent } from './components/mail/mail.component';

@NgModule({
  declarations: [
    ProductsComponent,
    ProductsDetailsComponent,
    LoginUserComponent,
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
  providers: [ProductService, LoginUserService, MailService, EventService],
  // exports: [ProductsComponent, ProductsDetailsComponent, LoginUserComponent, MailComponent]
})
export class SharedModule { }
