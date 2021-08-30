import { Component, Input, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Product } from '../../models/product.model';
import { ProductService } from '../../services/product.service';

@Component({
  selector: 'app-products-details',
  templateUrl: './products-details.component.html',
  styleUrls: ['./products-details.component.scss'],
})

export class ProductsDetailsComponent implements OnInit {
  productDetails: FormGroup;
  currentProduct: Product;

  @Input()
  id: number;
  // name: string;
  // price: number;
  // quantity: number;
  // categoryId: number;

  constructor(private _productService: ProductService, _router: Router, private activate: ActivatedRoute) {}

  ngOnInit(): void {

    this.activate.paramMap.subscribe((params) => {
      this.id = Number(params.get('id'));
      if (this.id != undefined) {
        this._productService.getProductById(this.id).subscribe(p => {
          this.currentProduct = p;
          console.log(this.currentProduct);
          if (this.currentProduct != undefined) {
            this.productDetails = new FormGroup({
              "productId": new FormControl(this.currentProduct.productId, Validators.required),
              "name": new FormControl(this.currentProduct.name, Validators.required),
              "price": new FormControl(this.currentProduct.price, Validators.required),
              "quantity": new FormControl(this.currentProduct.quantity, Validators.required),
              "categoryId": new FormControl(this.currentProduct.categoryId, Validators.required),
            });
          }
        })
      }

      // this._productService.getProductById(this.id).subscribe((p) => {
      //   this.currentProduct = p;
      //   console.log(this.currentProduct);
      //   this.name = this.currentProduct.name;
      //   this.price = this.currentProduct.price;
      //   this.quantity = this.currentProduct.quantity;
      //   this.categoryId = this.currentProduct.categoryId;
      // });
    });
  }
}
