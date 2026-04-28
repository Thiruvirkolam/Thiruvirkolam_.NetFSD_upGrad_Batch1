import { Component } from '@angular/core';

@Component({
  selector: 'app-task5',
  imports: [],
  templateUrl: './task5.html',
  styleUrl: './task5.css',
})
export class Task5 {
  isLoggedIn: boolean = false;

  toggleLogin() {
    this.isLoggedIn = !this.isLoggedIn;
  }
}
