import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MapsDashboardComponent } from './maps-dashboard.component';

describe('MapsDashboardComponent', () => {
  let component: MapsDashboardComponent;
  let fixture: ComponentFixture<MapsDashboardComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MapsDashboardComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(MapsDashboardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
