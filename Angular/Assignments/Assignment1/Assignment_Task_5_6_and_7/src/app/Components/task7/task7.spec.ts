import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Task7 } from './task7';

describe('Task7', () => {
  let component: Task7;
  let fixture: ComponentFixture<Task7>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [Task7],
    }).compileComponents();

    fixture = TestBed.createComponent(Task7);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
