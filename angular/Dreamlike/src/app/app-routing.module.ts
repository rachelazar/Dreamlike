import { CouponComponent } from './user/components/coupon/coupon.component';
import { NgModule } from '@angular/core';
import { Route, RouterModule } from '@angular/router';
import { HomeComponent } from './shared/components/home/home.component';
import { ProductsDetailsComponent } from './shared/components/products-details/products-details.component';
import { ProductsComponent } from './shared/components/products/products.component';
import { LoginComponent } from './user/components/login/login.component';
import { PaymentComponent } from './user/components/payment/payment.component';
import { LoginUserComponent } from './shared/components/login-user/login-user.component';
import { MailComponent } from './shared/components/mail/mail.component';

const routes: Route[] = [
  { path: "", redirectTo: "home", pathMatch: "full" },
  // { path: "", component: HomeComponent, pathMatch: "full" },
  { path: "products", component: ProductsComponent },
  { path: "productDetails/:id", component: ProductsDetailsComponent },
  { path: "login", component: LoginComponent },
  { path: "loginUser", component: LoginUserComponent },
  { path: "home", component: HomeComponent },
  { path: "coupon", component: CouponComponent },
  { path: "mail", component: MailComponent },
  { path: "payment", component: PaymentComponent }
]

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
