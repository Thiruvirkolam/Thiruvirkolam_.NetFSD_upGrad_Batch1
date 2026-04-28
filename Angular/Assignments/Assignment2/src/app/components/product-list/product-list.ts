import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-product-list',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './product-list.html',
  styleUrl: './product-list.css'
})
export class ProductList {
  products = [
    { name: 'Laptop', price: 55000 },
    { name: 'Mobile', price: 25000 },
    { name: 'Keyboard', price: 1200 }
  ];
}