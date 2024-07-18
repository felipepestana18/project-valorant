import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { AppRoutingModule } from '../app-routing.module';
import { HttpClientModule } from '@angular/common/http';
import { AgentCreateComponent } from './agent-create/agent-create.component';
import { AgentDashboardComponent } from './agent-dashboard/agent-dashboard.component';


@NgModule({
  declarations: [
    AgentDashboardComponent,
    AgentCreateComponent
  ],
  imports: [
    BrowserModule,
    CommonModule,
    ReactiveFormsModule,
    FormsModule,
    NgbModule,
    AppRoutingModule,
    HttpClientModule,

  ],

  exports: [
    AgentDashboardComponent,
    AgentCreateComponent
    
  ]
})
export class AgentsModule { }
