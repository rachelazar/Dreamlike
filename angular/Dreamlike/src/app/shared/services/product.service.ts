import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { HttpClient } from '@angular/common/http';
import { Product } from "../models/product.model";



@Injectable()
export class ProductService {

    // getProducts(): Observable<Product[]> {
    //     return this.http.get<Product[]>("/api/Product");
    // }

    getProductsByCategoryId(categoryId: number): Observable<Product[]> {
        return this.http.get<Product[]>("/api/Product/" + categoryId);
    }

    getProductById(id: number): Observable<Product> {       
        return this.http.get<Product>("/api/Product/" + id);
    }

    constructor(private http: HttpClient){}
}