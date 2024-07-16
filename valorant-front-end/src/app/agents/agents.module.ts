import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AgentDashboardComponent } from './agent-dashboard/agent-dashboard.component';
import { AgentCreateComponent } from './agent-create/agent-create.component';



@NgModule({
  declarations: [
    AgentDashboardComponent,
    AgentCreateComponent
  ],
  imports: [
    CommonModule,
    
  ],
  exports: [
    AgentDashboardComponent,
    AgentCreateComponent
  ]
})
export class AgentsModule { }
