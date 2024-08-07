import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatchDashboardComponent } from './match-dashboard/match-dashboard.component';
import { MatchCreateComponent } from './match-create/match-create.component';
import { MatchRankComponent } from './match-rank/match-rank.component';
import { MapsDashboardComponent } from '../maps/maps-dashboard/maps-dashboard.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';



@NgModule({
  declarations: [
    MatchDashboardComponent,
    MatchCreateComponent,
    MatchRankComponent
  ],
  imports: [
    ReactiveFormsModule,
    FormsModule,
    CommonModule,
  ]
})
export class MatchModule { }
