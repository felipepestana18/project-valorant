import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MapsDashboardComponent } from './maps-dashboard/maps-dashboard.component';
import { MapsCreateComponent } from './maps-create/maps-create.component';



@NgModule({
  declarations: [
    MapsDashboardComponent,
    MapsCreateComponent
  ],
  imports: [
    CommonModule
  ],
  exports: [
    MapsDashboardComponent
  ]
})
export class MapsModule { }
