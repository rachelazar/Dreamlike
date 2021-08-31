import { NgModule } from '@angular/core';
import { Route, RouterModule } from '@angular/router';
import { ProductsComponent } from './components/products/products.component';
import { ProductsDetailsComponent } from './components/products-details/products-details.component';
import { CouponComponent } from '../user/components/coupon/coupon.component';
import { MailComponent } from './components/mail/mail.component';
import { HomeComponent } from './components/home/home.component';
import { AddUserComponent } from './components/add-user/add-user.component';

const routes: Route[] = [
  { path: "products", component: ProductsComponent },
  { path: "productsDetails/:id", component: ProductsDetailsComponent },
  { path: "addUser", component: AddUserComponent },
  { path: "coupon", component: CouponComponent },
  // { path: "mail", component: MailComponent },
  { path: "home", component: HomeComponent },
]

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})

export class SharedRoutingModule { }
