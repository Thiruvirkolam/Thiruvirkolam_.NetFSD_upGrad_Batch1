import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';

@Component({
  selector: 'app-task7',
  imports: [CommonModule],
  templateUrl: './task7.html',
  styleUrl: './task7.css',
})
export class Task7 {
  products = [
    { id: 1, name: 'Keyboard', price: 400 },
    { id: 2, name: 'Monitor', price: 800 },
    { id: 3, name: 'Mouse', price: 300 },
    { id: 4, name: 'Headphones', price: 1200 }
  ];
}
