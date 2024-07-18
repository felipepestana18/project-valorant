import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AgentDashboardComponent } from './agents/agent-dashboard/agent-dashboard.component';
import { MapsDashboardComponent } from './maps/maps-dashboard/maps-dashboard.component';
import { MatchDashboardComponent } from './match/match-dashboard/match-dashboard.component';
import { AgentCreateComponent } from './agents/agent-create/agent-create.component';
import { MapsCreateComponent } from './maps/maps-create/maps-create.component';
import { MatchRankComponent } from './match/match-rank/match-rank.component';
import { MatchCreateComponent } from './match/match-create/match-create.component';


const routes: Routes = [
  { path: '', component: MatchDashboardComponent, pathMatch: 'full'},
  { path: 'agents', component: AgentDashboardComponent, },
  { path: 'agents/create', component: AgentCreateComponent, },
  { path: 'maps', component: MapsDashboardComponent, },
  { path: 'maps/create', component: MapsCreateComponent, },
  { path: 'match/dashboard', component: MatchDashboardComponent, },
  { path: 'match/create', component: MatchCreateComponent, },
  { path: 'match/rank', component: MatchRankComponent, },
];


@NgModule({
  declarations: [],
  imports: [
    RouterModule.forRoot(routes)],
  exports: [
    RouterModule
  ]
})
export class AppRoutingModule { }
