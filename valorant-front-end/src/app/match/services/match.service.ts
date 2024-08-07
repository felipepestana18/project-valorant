import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';


@Injectable({
  providedIn: 'root'
})
export class MatchService {

  private url: string = "http://localhost:5106/api/v1/match/";

  constructor(private http: HttpClient) { }

  httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json'
    })
  }

  getDataMatch(uuid: any) {
    console.log(uuid);
    return this.http.get(this.url + 'get-all/' + uuid);
  }

  postData(data: any) {
      return this.http.post(this.url + 'create', data);
  }
}