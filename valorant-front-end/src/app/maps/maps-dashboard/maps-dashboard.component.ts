import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { MapService } from '../services/maps.service';

@Component({
  selector: 'app-maps-dashboard',
  templateUrl: './maps-dashboard.component.html',
  styleUrls: ['./maps-dashboard.component.css']
})
export class MapsDashboardComponent {

  constructor(private MapService: MapService, private router: Router){}
  
  maps: any;
  
  ngOnInit(): void {
    this.getDataMap();
  }
  getDataMap(){
    this.MapService.getDataMap().subscribe((data: any) => {
 
      this.maps = data
    })
  }
  createMap(){
    this.router.navigateByUrl('maps/create');
  }
}
