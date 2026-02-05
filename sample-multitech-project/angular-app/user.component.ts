import { Component, OnInit } from '@angular/core';
import { UserService } from './user.service';

@Component({
  selector: 'app-user',
  template: `<div>{{user?.name}}</div>`
})
export class UserComponent implements OnInit {

  user: any;

  constructor(private userService: UserService) {}

  ngOnInit() {
    this.loadUser();
  }

  loadUser() {
    this.userService.getUser(1).subscribe(res => {
      this.user = res;
    });
  }
}
