import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { MatchService } from '../services/match.service';
import { MapService } from 'src/app/maps/services/maps.service';

@Component({
  selector: 'app-match-dashboard',
  templateUrl: './match-dashboard.component.html',
  styleUrls: ['./match-dashboard.component.css']
})
export class MatchDashboardComponent {

  constructor(private router: Router, private MapService: MapService){}


  maps: any;

  ngOnInit(): void {
    this.getDataMatch();
 }

 getDataMatch(){
  this.MapService.getDataMap().subscribe((data: any) => {

    console.log(data);
    this.maps = data
  })
 }


  InformationAboutMatch(uuid: string, name: string, id: number)
  { 
    this.router.navigateByUrl(`match/rank/${uuid}/${name}/${id}`);
  }
  
  createNewMatch(){
    this.router.navigateByUrl('match/create');
  }

}
