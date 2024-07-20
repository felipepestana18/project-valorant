import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs/internal/Observable';
import { Root } from '../model/agentAPI';

@Injectable({
  providedIn: 'root'
})
export class AgentService {

  private url: string = "http://localhost:5106/api/v1/agent/";

  constructor(private http: HttpClient) { }

  httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json'
    })
  }

  public getAgentDataApi(): Observable<Array<Root>> {
    return this.http.get<Array<Root>>(`${this.url}get-agent`)
      .pipe(
        res => res,
        error => error
      )
  }
 // getAgentDataApi() {
 //   console.log("Caiu no services");
 //   return this.http.get(this.url + 'get-agent');
 // }

  getDataAgent() {
    return this.http.get(this.url + 'get-all')
  }

  getAgentById(id: number) {
    return this.http.get(this.url + '/' + 'get-by-id/'+ id);
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


}