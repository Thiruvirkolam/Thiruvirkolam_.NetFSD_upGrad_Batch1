import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-dynamic-style',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './dynamic-style.html',
  styleUrl: './dynamic-style.css'
})
export class DynamicStyle {
  fontSize: number = 18;
  textColor: string = 'blue';

  increaseFont() {
    this.fontSize += 2;
  }

  decreaseFont() {
    this.fontSize -= 2;
  }

  changeColor() {
    this.textColor = this.textColor === 'blue' ? 'red' : 'blue';
  }
}