import { Component, OnInit } from '@angular/core';
import { ICreateOrderRequest, IPayPalConfig } from 'ngx-paypal';

@Component({
  selector: 'app-payment',
  templateUrl: './payment.component.html',
  styleUrls: ['./payment.component.scss']
})
export class PaymentComponent implements OnInit {

  constructor() { }

  public defaultPrice: string = '9.99';
  public payPalConfig?: IPayPalConfig;

  public showSuccess: boolean = false;
  public showCancel: boolean = false;
  public showError: boolean = false;


  ngOnInit(): void {
    // להביא את זה כאינפוט מהקומפוננטה של הסל
    this.initConfig("sum");
  }

  private initConfig(price: string): void {
    this.payPalConfig = {
      currency: 'NIS',
      clientId: 'sb',
      createOrderOnClient: (data) => <ICreateOrderRequest>{
        intent: 'CAPTURE',
        purchase_units: [
          {
            amount: {
              currency_code: 'NIS',
              value: price,
              breakdown: {
                item_total: {
                  currency_code: 'NIS',
                  value: price
                }
              }
            },
            items: [
              {
                name: 'Enterprise Subscription',
                quantity: '1',
                category: 'DIGITAL_GOODS',
                unit_amount: {
                  currency_code: 'NIS',
                  value: price,
                },
              }
            ] 
          }
        ]
      },
      onCancel: (data, actions) => {
        console.log('OnCancel', data, actions);
      },
      onError: err => {
        console.log('OnError', err);
      },
      onClick: (data, actions) => {
        console.log('onClick', data, actions);
      },
    }
  }
}
  
