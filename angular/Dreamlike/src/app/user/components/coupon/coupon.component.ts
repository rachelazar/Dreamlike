import { Component, Input, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Coupon } from '../../models/coupon.model';

@Component({
  selector: 'app-coupon',
  templateUrl: './coupon.component.html',
  styleUrls: ['./coupon.component.scss'],
})
export class CouponComponent implements OnInit {
  FormCoupon: FormGroup;

  private _coupon!: Coupon;

  public get buyCoupon(): Coupon {
    return this._coupon;
  }

  @Input()
  public set coupon(value: Coupon) {
    this._coupon = value;
    if (this._coupon != undefined) {
      this.FormCoupon = new FormGroup({
        "couponId": new FormControl(this.buyCoupon.couponId, [Validators.required]),
        "recipientName": new FormControl(this.buyCoupon.recipientName, [Validators.required]),
        "greetingCard": new FormControl(this.buyCoupon.greetingCard),
        "musicFile": new FormControl(this.buyCoupon.musicFile),
        "totalSum": new FormControl(this.buyCoupon.totalSum, [Validators.required]),
        "shippingAddress": new FormControl(this.buyCoupon.shippingAddress, [Validators.required]),
        "dateOrder": new FormControl(this.buyCoupon.dateOrder, [Validators.required]),
        "balance": new FormControl(this.buyCoupon.balance, [Validators.required]),
        "userId": new FormControl(this.buyCoupon.userId, [Validators.required]),
        "eventId": new FormControl(this.buyCoupon.eventId, [Validators.required]),
      });
    }
  }
  
  payment() {

  }

  constructor() {}

  ngOnInit(): void {}
}
