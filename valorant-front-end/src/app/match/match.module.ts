import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatchDashboardComponent } from './match-dashboard/match-dashboard.component';
import { MatchCreateComponent } from './match-create/match-create.component';



@NgModule({
  declarations: [
    MatchDashboardComponent,
    MatchCreateComponent
  ],
  imports: [
    CommonModule,
    MapsDashboardComponent
  ]
})
export class MatchModule { }
