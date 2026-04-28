import { Component } from '@angular/core'; 
import { CommonModule } from '@angular/common';
import { Product } from './Model/product';

@Component({
  selector: 'app-task4',
  imports: [CommonModule],
  templateUrl: './task4.html',
  styleUrl: './task4.css',
})
export class Task4 {
  products: Product[] = [
    { id: 1, name: 'Laptop', price: 50000, quantity: 2 },
    { id: 2, name: 'Mobile', price: 20000, quantity: 5 },
    { id: 3, name: 'Headphones', price: 2000, quantity: 10 }
  ];

}
