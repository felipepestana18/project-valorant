import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MapsCreateComponent } from './maps-create.component';

describe('MapsCreateComponent', () => {
  let component: MapsCreateComponent;
  let fixture: ComponentFixture<MapsCreateComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MapsCreateComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(MapsCreateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
