import { Routes } from '@angular/router';
import { App } from './app';
import { Task5 } from './Components/task5/task5';
import { Task6 } from './Components/task6/task6';
import { Task7 } from './Components/task7/task7';

export const routes: Routes = [
    {path : '', component : Task5},
    {path : 'task5', component : Task5},
    {path : 'task6', component : Task6},
    {path : 'task7', component : Task7}
];
