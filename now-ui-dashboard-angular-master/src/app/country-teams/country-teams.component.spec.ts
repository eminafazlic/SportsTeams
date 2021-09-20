import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CountryTeamsComponent } from './country-teams.component';

describe('CountryTeamsComponent', () => {
  let component: CountryTeamsComponent;
  let fixture: ComponentFixture<CountryTeamsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CountryTeamsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CountryTeamsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
