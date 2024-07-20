import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { AgentService } from 'src/app/agents/services/agent.service';
import { Root } from '../model/agentAPI';

@Component({
  selector: 'app-agent-create',
  templateUrl: './agent-create.component.html',
  styleUrls: ['./agent-create.component.css']
})
export class AgentCreateComponent {

    constructor(private AgentService: AgentService, private router: Router){}

    uui: any;
    data: any;
    displayName: string = '';
    function: string = '';
    description: string = '';
    displayIcon: string = '';
    BodyImgURL: string = '';


    ngOnInit(): void {
      this.getAgentFromApi();
    }

    getAgentFromApi(){
      this.AgentService.getAgentDataApi().subscribe((data: any) => {
        this.data = data.data;
      })
    }
    onChange(){
      let agent = this.data.find((agent: any) => agent.uuid === this.uui);
      this.BodyImgURL = agent["fullPortrait"];

      console.log(this.BodyImgURL);
      this.displayName = agent["displayName"];
      this.displayIcon = agent["displayIcon"];
      this.description = agent["description"];
      this.function = agent["role"]["displayName"];
    }

    saveAgent(){
      let data = {
        uui: this.uui,
        name: this.displayName,
        description: this.description,
        function: this.function,
        BodyImgURL: this.BodyImgURL,
        ThumbImgURL: this.displayIcon
      }
      this.AgentService.postData(data).subscribe((data) => {
        if (data) {
          this.router.navigateByUrl('/agents');
        }
      })
    }


}
