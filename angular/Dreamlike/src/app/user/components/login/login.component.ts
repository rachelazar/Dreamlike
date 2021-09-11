import { Component, NgModule, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
// import { ActivatedRoute, Router } from '@angular/router';
import { LoginService } from '../../services/login.service';
// import { UserModule } from '../../user.module';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss'],
})

export class LoginComponent implements OnInit {
  loginForm: FormGroup;

  onSubmit() {
    this._LoginService.Login(this.loginForm.value).subscribe((success) => {
      if (success != null) {
        sessionStorage.setItem('userId', success.toString());
        this.router.navigate(['../shared/home']);
      }

    }, err => console.error(err));
  }

  constructor(private _LoginService: LoginService, private router: Router) { }
  // constructor(private _LoginService: LoginService, private activate: ActivatedRoute, private router: Router) { }

  ngOnInit(): void {
    this.loginForm = new FormGroup({
      Username: new FormControl(),
      Password: new FormControl(),
    });
  }
}
