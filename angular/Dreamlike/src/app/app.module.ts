import { HttpClientModule } from '@angular/common/http';
import { SharedRoutingModule } from './shared/shared-routing.module';
import { SharedModule } from './shared/shared.module';
import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginManagerComponent } from './manager/components/login-manager/login-manager.component';
import { HomeComponent } from './shared/components/home/home.component';
import { ProductsComponent } from './shared/components/products/products.component';
import { ProductService } from './shared/services/product.service';
import { LoginComponent } from './user/components/login/login.component';
import { SelectedProductComponent } from './user/components/selected-product/selected-product.component';
import { LoginService } from './user/services/login.service';
import { UserModule } from './user/user.module';
import { CouponComponent } from './user/components/coupon/coupon.component';
import { ProductsDetailsComponent } from './shared/components/products-details/products-details.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    LoginComponent,
    LoginComponent,
    ProductsComponent,
    SelectedProductComponent,
    ProductsComponent,
    ProductsDetailsComponent,
    LoginManagerComponent,
    CouponComponent,
  ],
  imports: [
    CommonModule,
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    UserModule, 
    SharedModule,
    SharedRoutingModule,
    HttpClientModule
  ],
  providers: [LoginService, ProductService],
  bootstrap: [AppComponent]
})
export class AppModule { }
