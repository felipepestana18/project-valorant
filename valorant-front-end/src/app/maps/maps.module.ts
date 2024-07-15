import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DashboardComponent } from './dashboard/dashboard.component';
import { MapsDashboardComponent } from './maps-dashboard/maps-dashboard.component';
import { MapsCreateComponent } from './maps-create/maps-create.component';



@NgModule({
  declarations: [
    DashboardComponent,
    MapsDashboardComponent,
    MapsCreateComponent
  ],
  imports: [
    CommonModule
  ]
})
export class MapsModule { }
