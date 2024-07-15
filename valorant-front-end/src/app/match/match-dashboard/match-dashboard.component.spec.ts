import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MatchDashboardComponent } from './match-dashboard.component';

describe('MatchDashboardComponent', () => {
  let component: MatchDashboardComponent;
  let fixture: ComponentFixture<MatchDashboardComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MatchDashboardComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(MatchDashboardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
