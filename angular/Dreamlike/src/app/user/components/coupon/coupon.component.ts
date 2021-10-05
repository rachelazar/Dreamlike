import { Component, Input, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { Event } from 'src/app/shared/models/event.model';
import { EventService } from 'src/app/shared/services/event.service';
import { Coupon } from '../../models/coupon.model';
import { CouponService } from '../../services/coupon.service';

@Component({
  selector: 'app-coupon',
  templateUrl: './coupon.component.html',
  styleUrls: ['./coupon.component.scss'],
})

export class CouponComponent implements OnInit {
  FormCoupon: FormGroup;
  eventTypes: Event[];

  private _coupon: Coupon = new Coupon();

  public get coupon(): Coupon {
    return this._coupon;
  }

  public set coupon(value: Coupon) {
    this._coupon = value;
    if (this._coupon != undefined) {
      
    }
  }

  buyCoupon() {
    // debugger;
    let coupon = this.FormCoupon.value;
    this.initParams(coupon);

    console.log(coupon)
    this._couponService.addCoupon(coupon).subscribe((success) => {
      this._router.navigate(['/payment']);
    })
  }

  constructor(private _couponService: CouponService, private _eventService: EventService, private _router: Router) {}

  ngOnInit(): void {
    this.initCouponForm();
    this.initEvents();
  }

  
  initCouponForm(): void {
    this.FormCoupon = new FormGroup({
      // couponId: new FormControl(),
      recipientName: new FormControl(this.coupon.recipientName, [Validators.required]),
      greetingCard: new FormControl(this.coupon.greetingCard),
      musicFile: new FormControl(this.coupon.musicFile),
      totalSum: new FormControl(this.coupon.totalSum, [Validators.required]),
      shippingAddress: new FormControl(this.coupon.shippingAddress, [Validators.required]),
      // dateOrder: new FormControl(this.coupon.dateOrder, [Validators.required]),
      // balance: new FormControl(this.coupon.totalSum, [Validators.required]),
      // userId: new FormControl("5", [Validators.required]),
      userId: new FormControl((+sessionStorage.getItem('userId')!), [Validators.required]),
      eventId: new FormControl(this.coupon.eventId, [Validators.required]),
    });
    
  } 
  
  initEvents(): void {
    this._eventService.getEvents().subscribe(data => {
      this.eventTypes = data;
    })
  }

  initParams(coupon: Coupon): void {
    coupon.balance = coupon.totalSum;
    coupon.couponId = this.createCoupon(coupon.userId, coupon.totalSum);
  }

  createCoupon(userId: number, totalSum: number): any{
    //TODO:let count: number;
    return (userId + totalSum) * 100;
  }
}
