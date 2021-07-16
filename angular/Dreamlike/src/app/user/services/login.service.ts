import { Injectable } from '@angular/core';
import {HttpClient} from "@angular/common/http";
import { Observable } from 'rxjs';
import { Login } from '../models/login.model';

// @Injectable({
//   providedIn: 'root'
// })
@Injectable()
export class LoginService {


  Login(login:Login): Observable<boolean>{
    return this._http.post<boolean>("/api/Login",login);
  }
  
  constructor(private _http: HttpClient) { }
}
