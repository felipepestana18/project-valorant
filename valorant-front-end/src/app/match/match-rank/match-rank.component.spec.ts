import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MatchRankComponent } from './match-rank.component';

describe('MatchRankComponent', () => {
  let component: MatchRankComponent;
  let fixture: ComponentFixture<MatchRankComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MatchRankComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(MatchRankComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
