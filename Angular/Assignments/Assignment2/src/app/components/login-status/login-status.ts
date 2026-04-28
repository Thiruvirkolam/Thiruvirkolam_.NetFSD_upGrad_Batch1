import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-login-status',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './login-status.html',
  styleUrl: './login-status.css'
})
export class LoginStatus {
  isLoggedIn: boolean = true;
}