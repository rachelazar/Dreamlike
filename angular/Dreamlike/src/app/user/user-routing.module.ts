import { NgModule } from '@angular/core';
import { Route, RouterModule } from '@angular/router';
import { CouponComponent } from '../user/components/coupon/coupon.component';
import { LoginComponent } from './components/login/login.component';
import { PaymentComponent } from './components/payment/payment.component';

const routes: Route[] = [
  // { path: "", component: HomeComponent, pathMatch: "full" },
  { path: "login", component: LoginComponent },
  { path: "addUser", loadChildren: () => import("../shared/shared.module").then(m => m.SharedModule), canLoad: [] },
  { path: "coupon", component: CouponComponent },
  { path: "payment", component: PaymentComponent },
]

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})

export class UserRoutingModule { }
