import { Component, OnInit } from '@angular/core';
import { Product } from '../../models/product.model';
import { ProductService } from '../../services/product.service';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.scss']
})
export class ProductsComponent implements OnInit {

  // products: Product[] = [
  //   {productId:1, name: 'aa', price: 1, quantity: 1, categoryId: 2},
  //   {productId:2, name: 'bb', price: 1, quantity: 1, categoryId: 3},
  //   {productId:3, name: 'cc', price: 1, quantity: 1, categoryId: 1},
  //   {productId:4, name: 'dd', price: 1, quantity: 1, categoryId: 2},
  //   {productId:5, name: 'ee', price: 1, quantity: 1, categoryId: 2},
  // ]

  products: Product[];
  categoryId: number = 1;

  constructor(private _productService: ProductService) {}

  ngOnInit(): void {
    this._productService.getProducts().subscribe(data => {
      this.products = data;
    })
  }
}