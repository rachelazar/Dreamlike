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
    debugger
 let user=this.loginUserForm.value;
 user.username = user.mail;
    this._LoginUserService.LoginUser(user).subscribe((success) => {
      // sessionStorage.setItem('userId', success.toString());
      console.log(user);
    });
  }

  constructor(private _LoginUserService: LoginUserService) {}

  ngOnInit(): void {
    this.loginUserForm = new FormGroup({
      userId: new FormControl(),
      firstName: new FormControl(),
      lastName: new FormControl(),
      phone: new FormControl(),
      mail: new FormControl(),
      username: new FormControl(),
      password: new FormControl()
    });
  }
}