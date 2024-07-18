import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-match-dashboard',
  templateUrl: './match-dashboard.component.html',
  styleUrls: ['./match-dashboard.component.css']
})
export class MatchDashboardComponent {

  constructor(private router: Router){}

  InformationAboutMatch(){
    console.log('oi');
    this.router.navigateByUrl('match/rank');
  }
  
  createNewMatch(){
    this.router.navigateByUrl('match/create');
  }

}
