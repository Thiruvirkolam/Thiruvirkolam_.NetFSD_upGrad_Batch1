import { Routes } from '@angular/router';
import { UserProfile } from './components/user-profile/user-profile';
import { ImageGallery } from './components/image-gallery/image-gallery';
import { Counter } from './components/counter/counter';
import { NameInput } from './components/name-input/name-input';
import { LoginStatus } from './components/login-status/login-status';
import { ProductList } from './components/product-list/product-list';
import { TaskList } from './components/task-list/task-list';
import { DynamicStyle } from './components/dynamic-style/dynamic-style';
import { Highlight } from './components/highlight/highlight';
import { RegistrationForm } from './components/registration-form/registration-form';
import { LoginForm } from './components/login-form/login-form';

export const routes: Routes = [
  { path: 'user', component: UserProfile },
  { path: 'image', component: ImageGallery },
  { path: 'counter', component: Counter },
  { path: 'name', component: NameInput },
  { path: 'login', component: LoginStatus },
  { path: 'product', component: ProductList },
  { path: 'track', component: TaskList },
  { path: 'dynamic', component: DynamicStyle},
  { path: 'highlight', component: Highlight},
  { path: 'form1', component: RegistrationForm},
  { path: 'fomr2', component: LoginForm},
  { path: '', redirectTo: 'user', pathMatch: 'full' }
];