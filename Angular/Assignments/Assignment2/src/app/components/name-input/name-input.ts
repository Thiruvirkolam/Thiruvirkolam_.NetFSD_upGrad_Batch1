import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-name-input',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './name-input.html',
  styleUrl: './name-input.css'
})
export class NameInput {
  userName: string = '';
}