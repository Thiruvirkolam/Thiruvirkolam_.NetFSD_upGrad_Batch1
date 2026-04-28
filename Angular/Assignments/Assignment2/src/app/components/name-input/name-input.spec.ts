import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NameInput } from './name-input';

describe('NameInput', () => {
  let component: NameInput;
  let fixture: ComponentFixture<NameInput>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [NameInput],
    }).compileComponents();

    fixture = TestBed.createComponent(NameInput);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
