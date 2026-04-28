import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';

@Component({
  selector: 'app-task6',
  imports: [CommonModule],
  templateUrl: './task6.html',
  styleUrl: './task6.css',
})
export class Task6 {
  courses: string[] = ['Angular', 'React', '.NET'];
}
