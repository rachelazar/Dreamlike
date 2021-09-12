import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable()
export class MailService {

  sendEmailAsync(subject: string, message: string, email: string): Observable<ArrayBuffer> {
    return this.http.post<ArrayBuffer>("/api/Mail", {subject, message, email});
  }

  //TODO:
  // sendM(subject: string,  message: string,  address: string): Observable<boolean> {
  //     return this.http.post<boolean>("/api/")
  // }


  constructor(private http: HttpClient) { }
}
