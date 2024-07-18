import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MapsDashboardComponent } from './maps-dashboard/maps-dashboard.component';
import { MapsCreateComponent } from './maps-create/maps-create.component';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { AppRoutingModule } from '../app-routing.module';
import { HttpClientModule } from '@angular/common/http';



@NgModule({
  declarations: [
    MapsDashboardComponent,
    MapsCreateComponent
  ],
  imports: [
    BrowserModule,
    CommonModule,
    ReactiveFormsModule,
    FormsModule,
    NgbModule,
    AppRoutingModule,
    HttpClientModule
  ],
  exports: [
    MapsDashboardComponent,
    MapsCreateComponent
  ]
})
export class MapsModule { }
