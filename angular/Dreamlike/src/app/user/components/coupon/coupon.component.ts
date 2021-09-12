import { parseI18nMeta } from '@angular/compiler/src/render3/view/i18n/meta';
import { Component, Input, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
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

  // @Input()
  public set coupon(value: Coupon) {
    this._coupon = value;
    if (this._coupon != undefined) {
      
    }
  }

  buyCoupon() {
    // debugger;
    let coupon = this.FormCoupon.value;
    console.log(coupon)
    this._couponService.AddCoupon(coupon).subscribe(data => {
      console.log(data);
    })
  }

  constructor(private _couponService: CouponService, private _eventService: EventService) {}

  ngOnInit(): void {
    this.initCouponForm();
    this.initEvents();
  }

  
  initCouponForm(): void {
    this.FormCoupon = new FormGroup({
      couponId: new FormControl(),
      recipientName: new FormControl(this.coupon.recipientName, [Validators.required]),
      greetingCard: new FormControl(this.coupon.greetingCard),
      musicFile: new FormControl(this.coupon.musicFile),
      totalSum: new FormControl(this.coupon.totalSum, [Validators.required]),
      shippingAddress: new FormControl(this.coupon.shippingAddress, [Validators.required]),
      dateOrder: new FormControl(this.coupon.dateOrder, [Validators.required]),
      balance: new FormControl(this.coupon.balance, [Validators.required]),
      // userId: new FormControl("5", [Validators.required]),
      userId: new FormControl((+sessionStorage.getItem('userId')!).toString(), [Validators.required]),
      eventId: new FormControl(this.coupon.eventId, [Validators.required]),
    });
    
  } 
  
  initEvents(): void {
    this._eventService.getEvents().subscribe(data => {
      this.eventTypes = data;
    })
  }
}
