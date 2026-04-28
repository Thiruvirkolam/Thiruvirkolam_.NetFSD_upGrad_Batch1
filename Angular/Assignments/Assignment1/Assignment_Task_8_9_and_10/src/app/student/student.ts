import { Component } from '@angular/core';

@Component({
  selector: 'app-student',
  imports: [],
  templateUrl: './student.html',
  styleUrl: './student.css'
})
export class Student {
  name: string = "Thiru";
  age: number = 21;
  course: string = "Angular";
}