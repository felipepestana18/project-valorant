import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MapsCreateComponent } from './maps-create/maps-create.component';
import { MapsDashboardComponent } from './maps-dashboard/maps-dashboard.component';
import { MatchDashboardComponent } from './match-dashboard/match-dashboard.component';
import { MatchCreateComponent } from './match-create/match-create.component';



@NgModule({
  declarations: [
    MapsCreateComponent,
    MapsDashboardComponent,
    MatchDashboardComponent,
    MatchCreateComponent
  ],
  imports: [
    CommonModule,
    MapsDashboardComponent
  ]
})
export class MatchModule { }
