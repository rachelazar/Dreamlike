import { Component, OnInit } from '@angular/core';
import { MailService } from '../../services/mail.service';

@Component({
  selector: 'app-mail',
  templateUrl: './mail.component.html',
  styleUrls: ['./mail.component.scss']
})
export class MailComponent implements OnInit {

  subject: string = "sub";
  message: string = "mes";
  email: string = "r0556782231@gmail.com";

  send() {
    this._mailService.sendEmail(this.subject, this.message, this.email).subscribe(data => {
      console.log(data)
    })
  }
  
  constructor(private _mailService: MailService) { }

  ngOnInit(): void {
  
  }

}
