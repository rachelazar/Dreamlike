import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { LoginService } from '../../services/login.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss'],
})

export class LoginComponent implements OnInit {
  loginForm: FormGroup;

  onSubmit() {
    this._LoginService.Login(this.loginForm.value).subscribe((success) => {
      if (!success) {
        console.log("the mail address not found")
      }
      if (success != null && success) {
        //TODO: success.toString()) why toString?
        sessionStorage.setItem('userId', success.toString());
        this.router.navigate(['../shared/home']);
        console.log(success.toString());
      }

    }, err => console.error(err));
  }

  constructor(private _LoginService: LoginService, private router: Router) { }

  ngOnInit(): void {
    this.loginForm = new FormGroup({
      Username: new FormControl(),
      Password: new FormControl(),
    });
  }
}