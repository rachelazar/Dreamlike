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
    //TODO: if (sessionStorage.getItem('username') === this.loginForm.value.username.toString())
    this._LoginService.Login(this.loginForm.value).subscribe((success) => {
      // if (success === 0) { TODO:
      //   console.log("the mail address not found")    
      // }
      // else
      if (!success) {
        console.log("One or more of the data is incorrect")
      }
      if (success != null && success) {
        //TODO: success.toString()) why toString?
        sessionStorage.setItem('userId', success.toString())
        // sessionStorage.setItem('username', this.loginForm.value.username.toString())
        // debugger TODO: equals 
        // error - if(sessionStorage.getItem(`${this.loginForm.value.Username}`) == this.loginForm.value.Password) {
        //   console.log('very nice')
        // }
        this.router.navigate(['../../']);//TODO: continue;
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