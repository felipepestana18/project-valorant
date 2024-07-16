import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-agent-dashboard',
  templateUrl: './agent-dashboard.component.html',
  styleUrls: ['./agent-dashboard.component.css']
})
export class AgentDashboardComponent {


  constructor(private router: Router){}

  createAgent(){
    this.router.navigateByUrl('agents/create');
  }

}
