import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Task2 } from './task2';

describe('Task2', () => {
  let component: Task2;
  let fixture: ComponentFixture<Task2>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [Task2],
    }).compileComponents();

    fixture = TestBed.createComponent(Task2);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
