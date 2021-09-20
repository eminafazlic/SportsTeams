import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { Teams } from "../teams/teams.model";
@Injectable({providedIn:'root'})
export class SharedService{
//private teams:Teams=[];
readonly APIUrl="https://localhost:44396"; 
constructor(private http:HttpClient){
}

GetAllTeams():Observable<any[]>{
    return this.http.get<any>(this.APIUrl+'/api/v1/Team')
}
InsertTeam(val:any){
    return this.http.post(this.APIUrl+'/api/v1/Team',val)
}
UpdateTeam(val:any){
    return this.http.put(this.APIUrl+'/api/v1/Team/',val)
}
DeleteTeam(val:any){
    return this.http.delete(this.APIUrl+'/api/v1/Team/',val)
}
GetTeamById(val:any){
    return this.http.get(this.APIUrl+'/api/v1/Team/',val)
}


GetAllCountries():Observable<any[]>{
    return this.http.get<any>(this.APIUrl+'/api/v1/Country')
}
InsertCountry(val:any){
return this.http.post(this.APIUrl+'/api/v1/Country',val)
}
UpdateCountry(val:any){
return this.http.put(this.APIUrl+'/api/v1/Country/',val)
}
DeleteCountry(val:any){
return this.http.delete(this.APIUrl+'/api/v1/Country/',val)
}
}