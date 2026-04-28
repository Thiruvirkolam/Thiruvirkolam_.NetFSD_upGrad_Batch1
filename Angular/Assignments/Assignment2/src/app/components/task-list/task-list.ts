import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-task-list',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './task-list.html',
  styleUrl: './task-list.css'
})
export class TaskList {
  tasks = [
    { name: 'Complete Angular Assignment', completed: true },
    { name: 'Practice SQL Queries', completed: false },
    { name: 'Revise .NET API', completed: true }
  ];
}