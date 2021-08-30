import { NgModule } from '@angular/core';
import { Route, RouterModule } from '@angular/router';

const routes: Route[] = [
  { path: "shared", loadChildren: () => import("./shared/shared.module").then(m => m.SharedModule), canLoad: [] },
  { path: "user",loadChildren:()=>import("./user/user.module").then(m => m.UserModule), canLoad: [] },
  { path: "manager",loadChildren:()=>import("./manager/manager.module").then(m => m.ManagerModule), canLoad: [] },
]

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
