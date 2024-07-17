import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatchDashboardComponent } from './match-dashboard/match-dashboard.component';
import { MatchCreateComponent } from './match-create/match-create.component';
import { MatchRankComponent } from './match-rank/match-rank.component';



@NgModule({
  declarations: [
    MatchDashboardComponent,
    MatchCreateComponent,
    MatchRankComponent
  ],
  imports: [
    CommonModule,
    MapsDashboardComponent
  ]
})
export class MatchModule { }
