import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-task2',
  imports: [FormsModule],
  templateUrl: './task2.html',
  styleUrl: './task2.css',
})
export class Task2 {
  name = '';
  email = '';
}
