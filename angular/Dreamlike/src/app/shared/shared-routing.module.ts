import { NgModule } from '@angular/core';
import { Route, RouterModule } from '@angular/router';
import { ProductsComponent } from './components/products/products.component';
import { LoginUserComponent } from './components/login-user/login-user.component';
import { ProductsDetailsComponent } from './components/products-details/products-details.component';
import { CouponComponent } from '../user/components/coupon/coupon.component';
import { MailComponent } from './components/mail/mail.component';

const routes: Route[] = [
  { path: "products", component: ProductsComponent },
  { path: "productsDetails/:id", component: ProductsDetailsComponent },
  { path: "loginUser", component: LoginUserComponent },
  { path: "coupon", component: CouponComponent },
  { path: "mail", component: MailComponent },
]

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})

export class SharedRoutingModule { }
