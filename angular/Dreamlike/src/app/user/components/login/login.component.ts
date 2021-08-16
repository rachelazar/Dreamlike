import { Component, NgModule, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
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
      sessionStorage.setItem('userId',success.toString());

    });
  }

  constructor(private _LoginService: LoginService) {}
  // constructor(private _LoginService: LoginService, private activate: ActivatedRoute, private router: Router) { }

  ngOnInit(): void {
    this.loginForm = new FormGroup({
      Username: new FormControl(),
      Password: new FormControl(),
    });
  }
}
