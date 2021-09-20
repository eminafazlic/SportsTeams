import { HttpClient } from "@angular/common/http";
import { EventEmitter, Injectable } from "@angular/core";
import { map } from "rxjs/operators";
import { Observable, Subject } from "rxjs";
import { Player } from "./player.model";


@Injectable( {providedIn: 'root'})
export class PlayersService{
readonly APIUrl="https://192.168.1.116:5001";
//"https://192.168.1.116:5001";
//"https://localhost:44396";
//"https://192.168.1.116:5001";
//https://192.168.1.112:5001
playerChanged=new Subject<Player[]>();
playerSelected=new EventEmitter<Player>();
player:Player[];

constructor(private http:HttpClient){}


GetAllPlayers(){
  return this.http.get(`${this.APIUrl}/api/v1/Player`).pipe(map((res: Player[]) => {
      this.player = res;
      return res;
  }));
}
InsertPlayer(val){
    return this.http.post(`${this.APIUrl}/api/v1/Player/`,val)
}
UpdatePlayer(id,val){
    return this.http.put(`${this.APIUrl}/api/v1/Player/${id}`,val);
}
DeletePlayer(id){
    return this.http.delete(`${this.APIUrl}/api/v1/Player/${id}`);
}
GetPlayerById(id){
   return this.http.get(`${this.APIUrl}/api/v1/Player/${id}`);
}
GetPlayerByTeamId(id, pageNumber, pageSize){
   return this.http.get(`${this.APIUrl}/api/v1/Player?teamId=${id}&PageNumber=${pageNumber}&PageSize=${pageSize}`);
}

}
