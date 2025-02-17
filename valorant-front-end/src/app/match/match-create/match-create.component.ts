import { Component } from '@angular/core';
import { MatchService } from '../services/match.service';
import { MapService } from 'src/app/maps/services/maps.service';
import { AgentService } from 'src/app/agents/services/agent.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-match-create',
  templateUrl: './match-create.component.html',
  styleUrls: ['./match-create.component.css']
})
export class MatchCreateComponent {
  constructor(private MatchService: MatchService, private MapService: MapService, private AgentService: AgentService, private router: Router){}

  agents: any;
  maps: any;

  //agent
  idAgent: string = '';
  displayIconAgent: string = ''
  nameAgent: string = ''
  descriptionAgent: string  =''

  //Map
  idMap: string = '';
  displayIconMap: string = ''
  nameMap: string = ''
  CharactersId: string  = ''
  descriptionMap: string = ''

  result: boolean = false
  kills: Number = 0
  Death: Number = 0

  uuid: string = ''

  ngOnInit(): void {
     this.getDataAgent();
     this.getDataMap();
  }

  getDataAgent(){
   this.AgentService.getDataAgent().subscribe((data: any) => {
        this.agents = data;
    })
  }
  getDataMap(){
    this.MapService.getDataMap().subscribe((data: any) => {
      this.maps = data;
   })
  }
  onChangeAgent(){
    let agent = this.agents.find((agent: any) => agent.id === this.idAgent);
    this.displayIconAgent = agent["thumbImgURL"];
    this.nameAgent = agent["name"];
    this.descriptionAgent = agent["function"];
    
  }

  onChangeMap(){
    let map = this.maps.find((maps: any) => maps.id === this.idMap);
    console.log(map);
    this.displayIconMap = map["imageUrl"];
    this.nameMap = map["name"];
    this.descriptionMap = 'A/B';
    this.uuid = map["uuid"];

  }
  saveResultMatch(){
    let dateTime = new Date();
    let data = {
      Result: true,
      Kilss: this.kills,
      Death: this.Death,
      MapId: this.idMap,
      DateMatch: dateTime,
      CharactersId: this.idAgent
    }

    this.MatchService.postData(data).subscribe((data) => {
      console.log(data);
      if (data) {

        this.router.navigateByUrl(`match/rank/${this.uuid}/${this.nameMap}/${this.idMap}`);
      }
    })
  }
}
