/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { WeighttableComponent } from './weighttable.component';

describe('WeighttableComponent', () => {
  let component: WeighttableComponent;
  let fixture: ComponentFixture<WeighttableComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ WeighttableComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(WeighttableComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
