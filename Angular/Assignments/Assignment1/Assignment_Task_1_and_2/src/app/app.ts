import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Student } from './Components/student/student';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, FormsModule],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected readonly title = signal('Assignment_Task_1_and_2');
}
