import { Injectable } from '@angular/core';
import {HttpClient} from "@angular/common/http";
import { Observable } from 'rxjs';
import { Login } from '../models/login.model';
import { Coupon } from '../models/coupon.model';

@Injectable()
export class CouponService {
  AddCoupon (coupon: Coupon): Observable<number> {
    return this.http.post<number>("/api/Coupon", coupon);
  }

  constructor(private http: HttpClient) { }
}
