import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { AgentService } from 'src/app/agents/services/agent.service';

@Component({
  selector: 'app-agent-dashboard',
  templateUrl: './agent-dashboard.component.html',
  styleUrls: ['./agent-dashboard.component.css']
})
export class AgentDashboardComponent {


  constructor(private AgentService: AgentService, private router: Router){}

  agents: any;

  ngOnInit(): void {
    this.getAllAgents();
  }
  createAgent(){
    this.router.navigateByUrl('/agents/create');
  }
  getAllAgents(){
    this.AgentService.getDataAgent().subscribe((data: any) => {
        this.agents = data;
    })
  }
}
