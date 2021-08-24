import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Route, RouterModule } from '@angular/router';
import { LoginComponent } from '../user/components/login/login.component';
import { HomeComponent } from './components/home/home.component';
import { ProductsComponent } from './components/products/products.component';
import { LoginUserComponent } from './components/login-user/login-user.component';
import { ProductsDetailsComponent } from './components/products-details/products-details.component';

const routes: Route[] = [
  // { path: "", component: HomeComponent, pathMatch: "full" },
  { path: "products", component: ProductsComponent },
  { path: "productsDetails/:id", component: ProductsDetailsComponent },
  // { path: "login", component: LoginComponent },
  { path: "loginUser", component: LoginUserComponent }
]

// @NgModule({
//   declarations: [],
//   imports: [
//     CommonModule
//   ]
//})
@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})

export class SharedRoutingModule { }
