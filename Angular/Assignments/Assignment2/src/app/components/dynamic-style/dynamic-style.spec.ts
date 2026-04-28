import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DynamicStyle } from './dynamic-style';

describe('DynamicStyle', () => {
  let component: DynamicStyle;
  let fixture: ComponentFixture<DynamicStyle>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [DynamicStyle],
    }).compileComponents();

    fixture = TestBed.createComponent(DynamicStyle);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
