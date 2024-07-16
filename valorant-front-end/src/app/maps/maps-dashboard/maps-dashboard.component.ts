import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-maps-dashboard',
  templateUrl: './maps-dashboard.component.html',
  styleUrls: ['./maps-dashboard.component.css']
})
export class MapsDashboardComponent {

  constructor(private router: Router){}
  
  createMap(){
    this.router.navigateByUrl('maps/create');
  }
}
