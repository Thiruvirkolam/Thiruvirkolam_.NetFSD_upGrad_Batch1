import { Component } from '@angular/core';

@Component({
  selector: 'app-user-profile',
  imports: [],
  templateUrl: './user-profile.html',
  styleUrl: './user-profile.css',
})
export class UserProfile {
  User_Name : string = "Thiru";
  Email : string = "thiru@gmail.com";
  Role : string = "Admin";
}
