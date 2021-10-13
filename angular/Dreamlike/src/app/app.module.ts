import { HttpClientModule } from '@angular/common/http';
import { SharedModule } from './shared/shared.module';
import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { UserModule } from './user/user.module';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatSliderModule } from '@angular/material/slider';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
  ],  imports: [
    CommonModule,
    BrowserModule,
    AppRoutingModule,
    UserModule, 
    SharedModule,
    HttpClientModule,
    BrowserAnimationsModule,
    MatSliderModule,
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
