import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { PaymentComponent } from './components/payment/payment.component';
import { NgxPaypalComponent, NgxPayPalModule } from 'ngx-paypal';
import { LoginComponent } from './components/login/login.component';
import { CouponComponent } from './components/coupon/coupon.component';
import { UserRoutingModule } from './user-routing.module';
import { LoginService } from './services/login.service';
import { LoginUserComponent } from '../shared/components/login-user/login-user.component';
import { LoginUserService } from '../shared/services/login-user.service';


@NgModule({
  declarations: [
    LoginComponent,
    // LoginUserComponent,
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
  providers: [LoginService, LoginUserService],
  // exports: [LoginComponent, CouponComponent]
})
export class UserModule { }