import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { MatchService } from '../services/match.service';
import { AgentService } from 'src/app/agents/services/agent.service';

@Component({
  selector: 'app-match-rank',
  templateUrl: './match-rank.component.html',
  styleUrls: ['./match-rank.component.css']
})
export class MatchRankComponent {

  constructor(private router: Router, private MatchService: MatchService, private AgentService: AgentService, private activeRoute: ActivatedRoute){}


  matchs: any;
  dataAgents: any;
  top1Agent: any;
  top2Agent: any;
  top3Agent: any; 
  params: any;
  name: string = '';
  uuid: string = '';
  id: number = 0;

  ngOnInit(): void {

    this.activeRoute.params.subscribe(res => this.params = res);

    console.log(this.params);
    if(this.params.name){
      this.name = this.params.name;
      console.log("tem Nome");
    }
    if(this.params.uuid){
      this.uuid = this.params.uuid;
      console.log("tem uid");
    } 

    if(this.params.id){
      this.id = Number(this.params.id);
      console.log("tem id");
    } 

    this.getDataAgent();

    this.getDataRankTop3();
    
  }


  getDataRankTop3(){

    this.AgentService.getDataTop3(this.uuid, this.id).subscribe((data: any) => {
      this.dataAgents = data;

      console.log(this.dataAgents);
     
      if(this.dataAgents[0]) this.top1Agent= this.dataAgents[0];
      if(this.dataAgents[1]) this.top2Agent = this.dataAgents[1];
      if(this.dataAgents[2]) this.top3Agent = this.dataAgents[2];

      console.log(this.top1Agent);
      console.log(this.top2Agent);
      console.log(this.top3Agent);

  })
  }

 getDataAgent(){
  this.MatchService.getDataMatch(this.uuid).subscribe((data: any) => {
      
       this.matchs = data;
   })
 }
 createNewMatch(){
  this.router.navigateByUrl(`match/create/${this.uuid}`);
}
}
