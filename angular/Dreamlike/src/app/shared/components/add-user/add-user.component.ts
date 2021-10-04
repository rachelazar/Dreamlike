import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
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
    this._AddUserService.AddUser(user).subscribe((success) => {
      //sessionStorage.setItem('userId', success.toString());
      console.log(user);
      console.log(user.userId);
    });
  }

  constructor(private _AddUserService: AddUserService) {}

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
