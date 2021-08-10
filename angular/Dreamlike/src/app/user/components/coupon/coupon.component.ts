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
        "id": new FormControl(this.buyCoupon.UserId ),
        "name": new FormControl(this.buyCoupon.RecipientName, [Validators.required, Validators.minLength(3)]),
      });
    }
  }
  
  payment() {

  }

  constructor() {}

  ngOnInit(): void {}
}
