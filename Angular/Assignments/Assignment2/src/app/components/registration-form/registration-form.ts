import { Component } from '@angular/core';
import { FormsModule, NgForm } from '@angular/forms';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-registration-form',
  standalone: true,
  imports: [FormsModule, CommonModule],
  templateUrl: './registration-form.html',
  styleUrl: './registration-form.css'
})
export class RegistrationForm {
  register(form: NgForm) {
    if (form.valid) {
      console.log(form.value);
      alert('Registration Successful');
    }
  }
}