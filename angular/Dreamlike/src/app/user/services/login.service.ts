import { Injectable } from '@angular/core';
import {HttpClient} from "@angular/common/http";
import { Observable } from 'rxjs';
import { Login } from '../models/login.model';

// @Injectable({
//   providedIn: 'root'
// })
@Injectable()
export class LoginService {

  Login(login: Login): Observable<number>{
    return this._http.post<number>("/api/Login", login);
  }
  
  constructor(private _http: HttpClient) { }
}
