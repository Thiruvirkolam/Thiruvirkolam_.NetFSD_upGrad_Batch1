import { Routes } from '@angular/router';
import { Student } from './student/student';
import { Header } from './header/header';
import { Dashboard } from './dashboard/dashboard';
import { Footer } from './footer/footer';

export const routes: Routes = [
  { path: '', component: Dashboard },        // default page
  { path: 'student', component: Student },
  { path: 'header', component: Header },
  { path: 'dashboard', component: Dashboard },
  { path: 'footer', component: Footer },
  { path: '**', redirectTo: '' }             // fallback
];