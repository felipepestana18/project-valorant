import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { MapService } from '../services/maps.service';

@Component({
  selector: 'app-maps-create',
  templateUrl: './maps-create.component.html',
  styleUrls: ['./maps-create.component.css']
})
export class MapsCreateComponent {

    constructor(private MapService: MapService, private router: Router){}

    maps: any;
    uuid: string = '';
    displayIcon: string = ''
    name: string = ''
    description: string = ''

    ngOnInit(): void {
      this.getMapFromApi();
    }
    getMapFromApi(){
      this.MapService.getMapsDataApi().subscribe((data: any) => {
        this.maps = data.data;
      })
    }

    onChange(){
      let map = this.maps.find((maps: any) => maps.uuid === this.uuid);
      this.displayIcon = map["splash"];
      this.name = map["displayName"];
      this.description = map["tacticalDescription"];
    }

    saveMap(){

      console.log("save");


         let data = {
          uuid: this.uuid,
          name: this.name,
        }

        console.log(data);


        this.MapService.postData(data).subscribe((data) => {
          if (data) {
            this.router.navigateByUrl('/maps');
          }
        })
    }
}
