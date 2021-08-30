import { Injectable } from '@angular/core';
import {HttpClient} from "@angular/common/http";
import { Observable } from 'rxjs';
import { Login } from '../models/login.model';

@Injectable()
export class LoginService {

  Login(login: Login): Observable<number>{
    return this.http.post<number>("/api/Login/Login", login);
  }

  constructor(private http: HttpClient) { }
}
