import { Injectable } from '@angular/core';
import {HttpClient} from "@angular/common/http";
import { Observable } from 'rxjs';
import { User } from '../models/user.model';

@Injectable()
export class AddUserService {

  AddUser(user: User): Observable<boolean> {
    return this.http.post<boolean>("/api/User/AddUser", user);
  }

  constructor(private http: HttpClient) { }
}
