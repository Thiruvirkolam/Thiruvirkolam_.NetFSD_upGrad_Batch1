import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
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

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, UserProfile, ImageGallery, Counter, NameInput, LoginStatus, ProductList, TaskList, DynamicStyle, Highlight, RegistrationForm, LoginForm],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
}
