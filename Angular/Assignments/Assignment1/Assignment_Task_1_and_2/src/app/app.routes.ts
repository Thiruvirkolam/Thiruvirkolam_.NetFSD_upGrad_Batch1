import { Routes } from '@angular/router';
import { Student } from './Components/student/student';
import { Task2 } from './Components/task2/task2';

export const routes: Routes = [
    {path : '', component : Student},
    {path : 'student', component : Student},
    {path : 'task2', component : Task2}
];
