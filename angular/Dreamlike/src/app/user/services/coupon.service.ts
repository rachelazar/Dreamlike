import { Injectable } from '@angular/core';
import {HttpClient} from "@angular/common/http";
import { Observable } from 'rxjs';
import { Coupon } from '../models/coupon.model';
import { User } from 'src/app/shared/models/user.model';

@Injectable()
export class CouponService {
<<<<<<< HEAD
  
  AddCoupon (coupon: Coupon): Observable<boolean> {
    return this.http.post<boolean>("/api/Coupon", coupon);
=======
  addCoupon (coupon: Coupon): Observable<boolean> {
    return this.http.post<boolean>("/api/Coupon/AddCoupon", coupon);
>>>>>>> 2c90d1a74d4865c76672e4d8c5c8777291a8f7e4
  }

  getUserById (id: number): Observable<User> {
    return this.http.get<User>("/api/User/" + id);
  }
  
  constructor(private http: HttpClient) { }
}
