import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable()
export class MailService {

  sendEmailAsync(subject: string, message: string, email: string): Observable<ArrayBuffer> {
    return this.http.post<ArrayBuffer>("/api/Mail", {subject, message, email});
  }

  constructor(private http: HttpClient) { }
}
