import { Component, OnInit } from '@angular/core';
import { Product } from '../../models/product.model';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.scss']
})
export class ProductsComponent implements OnInit {

  products: Product[] = [
    {productId:1, name: 'John', price: 1, quantity: 1, categoryId: 3},
    {productId:1, name: 'John', price: 1, quantity: 1, categoryId: 3},
    {productId:1, name: 'John', price: 1, quantity: 1, categoryId: 3},
    {productId:1, name: 'John', price: 1, quantity: 1, categoryId: 3},
    {productId:1, name: 'John', price: 1, quantity: 1, categoryId: 3},
  ]
  
  constructor() { }

  ngOnInit(): void {
  }

}
