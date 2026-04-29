import { Component } from '@angular/core';
import { RouterLink } from '@angular/router';

@Component({
  selector: 'app-product-list',
  imports: [],
  templateUrl: './product-list.html',
  styleUrl: './product-list.css'
})
export class ProductList {
  products = [
    { id: 1, name: 'Laptop', category: 'electronics' },
    { id: 2, name: 'Mobile', category: 'electronics' },
    { id: 3, name: 'Shoes', category: 'fashion' }
  ];
}