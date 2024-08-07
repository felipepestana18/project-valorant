import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs/internal/Observable';
import { Root } from '../model/mapAPI';

@Injectable({
  providedIn: 'root'
})
export class MapService {

  private url: string = "http://localhost:5106/api/v1/map/";

  constructor(private http: HttpClient) { }

  httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json'
    })
  }

  public getMapsDataApi(): Observable<Array<Root>> {
    return this.http.get<Array<Root>>(`${this.url}get-maps-api`)
      .pipe(
        res => res,
        error => error
      )
  }
 // getAgentDataApi() {
 //   console.log("Caiu no services");
 //   return this.http.get(this.url + 'get-agent');
 // }



  getDataMap(){
    return this.http.get(this.url + 'get-all')
  }



  postData(data: any) {
    return this.http.post(this.url + 'create', data);
  }

  putData(id: number, formData: any) {
    return this.http.put(this.url + 'update', formData);
  }

  deleteData(id: number) {
    return this.http.delete(this.url + 'delete/' + id);
  }

  doneData(id: number) {
    return this.http.put(this.url + 'done/' + id, '');
  }
}