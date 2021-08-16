import { Component, Input, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Coupon } from '../../models/coupon.model';
// import { Event } from '../../models/event.model';

@Component({
  selector: 'app-coupon',
  templateUrl: './coupon.component.html',
  styleUrls: ['./coupon.component.scss'],
})
export class CouponComponent implements OnInit {
  FormCoupon: FormGroup;
  // eventTypes:Event[]=[]
  private _coupon: Coupon=new Coupon();

  public get coupon(): Coupon {
    return this._coupon;
  }

  // @Input()
  public set coupon(value: Coupon) {
    this._coupon = value;
    if (this._coupon != undefined) {
      
    }
  }
  
  buyCoupon() {
    
 console.log(this.FormCoupon.value)
  }

  constructor() {}

  ngOnInit(): void {

    this.initCouponForm();
  }

  initCouponForm(): void {
    this.FormCoupon = new FormGroup({
      "couponId": new FormControl(),
      "recipientName": new FormControl(this.coupon.recipientName, [Validators.required]),
      "greetingCard": new FormControl(this.coupon.greetingCard),
      "musicFile": new FormControl(this.coupon.musicFile),
      "totalSum": new FormControl(this.coupon.totalSum, [Validators.required]),
      "shippingAddress": new FormControl(this.coupon.shippingAddress, [Validators.required]),
      "dateOrder": new FormControl(this.coupon.dateOrder, [Validators.required]),
      "balance": new FormControl(this.coupon.balance, [Validators.required]),
      "userId": new FormControl(+sessionStorage.getItem('userId')!, [Validators.required]),
      "eventId": new FormControl(this.coupon.eventId, [Validators.required]),
    });
  }
}
