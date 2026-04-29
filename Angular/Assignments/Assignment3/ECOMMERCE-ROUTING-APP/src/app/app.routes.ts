import { Routes } from '@angular/router';
import { ProductList } from './products/product-list/product-list';
import { ProductDetails } from './products/product-details/product-details';
import { ProductReviews } from './products/product-reviews/product-reviews';
import { Cart } from './cart/cart';
import { PageNotFound } from './page-not-found/page-not-found';
import { authGuard } from './auth-guard';

export const routes: Routes = [
  {
    path: '',
    redirectTo: 'products',
    pathMatch: 'full'
  },
  {
    path: 'products',
    component: ProductList
  },
  {
    path: 'products/details',
    component: ProductDetails,
    children: [
      {
        path: 'reviews',
        component: ProductReviews
      }
    ]
  },
  {
    path: 'products/:id',
    component: ProductDetails
  },
  {
    path: 'cart',
    component: Cart
  },
  {
  path: 'checkout',
  canActivate: [authGuard],
  loadChildren: () =>
   import('./checkout/checkout/checkout.routes').then(m => m.CHECKOUT_ROUTES)
},
  {
    path: '**',
    component: PageNotFound
  }
];