import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CountryStartComponent } from './country-start.component';

describe('CountryStartComponent', () => {
  let component: CountryStartComponent;
  let fixture: ComponentFixture<CountryStartComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CountryStartComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CountryStartComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
