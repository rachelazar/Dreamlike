import { Component, OnInit } from '@angular/core';
import { FormGroup } from '@angular/forms';

@Component({
  selector: 'app-coupon',
  templateUrl: './coupon.component.html',
  styleUrls: ['./coupon.component.scss']
})
export class CouponComponent implements OnInit {

  BuyCoupon: FormGroup;

  payment() {
    
  }

  constructor() { }

  ngOnInit(): void {
  }

}
