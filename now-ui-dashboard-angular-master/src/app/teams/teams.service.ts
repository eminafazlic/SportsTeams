import { HttpClient } from "@angular/common/http";
import { EventEmitter, Injectable } from "@angular/core";
import { map } from "rxjs/operators";
import { Observable, Subject } from "rxjs";
import { Teams } from "./teams.model";


@Injectable( {providedIn: 'root'})
export class TeamsService{
readonly APIUrl="https://192.168.1.116:5001";
// "https://192.168.1.116:5001";
//"https://localhost:44396";
//"https://192.168.1.116:5001";
//https://192.168.1.112:5001
teamsChanged=new Subject<Teams[]>();
teamsSelected=new EventEmitter<Teams>();
teams:Teams[];

constructor(private http:HttpClient){}


GetAllTeams(){

  return this.http.get(`${this.APIUrl}/api/v1/Team`).pipe(map((res: Teams[]) => {
      this.teams = res;
      return res;
  }));
}
InsertTeam(val){
    return this.http.post(`${this.APIUrl}/api/v1/Team/`,val)
}
UpdateTeam(id,val){
    return this.http.put(`${this.APIUrl}/api/v1/Team/${id}`,val);
}
DeleteTeam(id){
    return this.http.delete(`${this.APIUrl}/api/v1/Team/${id}`);
}
GetTeamById(id){
   return this.http.get(`${this.APIUrl}/api/v1/Team/${id}`);
}
GetTeamByCountryId(id, pageNumber, pageSize){
   return this.http.get(`${this.APIUrl}/api/v1/Team/countryid=${id}?PageNumber=${pageNumber}&PageSize=${pageSize}`);
}

}
