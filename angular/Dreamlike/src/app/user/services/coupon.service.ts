import { Injectable } from '@angular/core';
import {HttpClient} from "@angular/common/http";
import { Observable } from 'rxjs';
import { Login } from '../models/login.model';
import { Coupon } from '../models/coupon.model';

@Injectable()
export class CouponService {
  AddCoupon (coupon: Coupon): Observable<boolean> {
    return this.http.post<boolean>("/api/Coupon/AddCoupon", coupon);
  }
  
  constructor(private http: HttpClient) { }
}
