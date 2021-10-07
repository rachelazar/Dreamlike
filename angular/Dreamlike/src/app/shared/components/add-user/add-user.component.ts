import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { AddUserService } from '../../services/add-user.service';

@Component({
  selector: 'app-add-user',
  templateUrl: './add-user.component.html',
  styleUrls: ['./add-user.component.scss'],
})
export class AddUserComponent implements OnInit {
  AddUserForm: FormGroup;

  onSubmit() {
    // debugger;
    let user = this.AddUserForm.value;
    user.username = user.mail;
    this._AddUserService.AddUser(user).subscribe(() => {
      sessionStorage.setItem('username', user.username);
      // sessionStorage.setItem('password', user.password); - correct

      // sessionStorage.setItem(`${user.username}`, user.password); - error
      this.router.navigate(['/login']);
      console.log(user);
    });
  }

  constructor(private _AddUserService: AddUserService, private router: Router) {}

  ngOnInit(): void {
    this.AddUserForm = new FormGroup({
      userId: new FormControl(),
      firstName: new FormControl(),
      lastName: new FormControl(),
      phone: new FormControl(),
      mail: new FormControl(),
      username: new FormControl(),
      password: new FormControl(),
    });
  }
}
