import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { LoginUserService } from '../../services/login-user.service';

@Component({
  selector: 'app-login-user',
  templateUrl: './login-user.component.html',
  styleUrls: ['./login-user.component.scss']
})
export class LoginUserComponent implements OnInit {
  loginUserForm: FormGroup;

  onSubmit() {
    this._LoginUserService.LoginUser(this.loginUserForm.value).subscribe((success) => {
      sessionStorage.setItem('userId', success.toString());
    });
  }

  constructor(private _LoginUserService: LoginUserService) {}

  ngOnInit(): void {
    this.loginUserForm = new FormGroup({
      firstName: new FormControl(),
      lastName: new FormControl(),
      phone: new FormControl(),
      mail: new FormControl(),
      password: new FormControl()
    });
  }
}
