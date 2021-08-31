import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { PaymentComponent } from './components/payment/payment.component';
import { NgxPayPalModule } from 'ngx-paypal';
import { LoginComponent } from './components/login/login.component';
import { CouponComponent } from './components/coupon/coupon.component';
import { UserRoutingModule } from './user-routing.module';
import { LoginService } from './services/login.service';
import { AddUserService } from '../shared/services/add-user.service';
import { CouponService } from './services/coupon.service';


@NgModule({
  declarations: [
    LoginComponent,
    // NgxPaypalComponent,
    PaymentComponent,
    CouponComponent
  ],
  imports: [
    CommonModule,
    UserRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
    NgxPayPalModule,
  ],
  providers: [LoginService, AddUserService, CouponService],
})
export class UserModule { }