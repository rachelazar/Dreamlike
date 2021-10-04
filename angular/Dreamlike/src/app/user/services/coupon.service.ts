import { Injectable } from '@angular/core';
import {HttpClient} from "@angular/common/http";
import { Observable } from 'rxjs';
import { Coupon } from '../models/coupon.model';
import { User } from 'src/app/shared/models/user.model';

@Injectable()
export class CouponService {
  addCoupon (coupon: Coupon): Observable<boolean> {
    return this.http.post<boolean>("/api/Coupon/AddCoupon", coupon);
  }

  getUserById (id: number): Observable<User> {
    return this.http.get<User>("/api/User/" + id);
  }
  
  constructor(private http: HttpClient) { }
}
