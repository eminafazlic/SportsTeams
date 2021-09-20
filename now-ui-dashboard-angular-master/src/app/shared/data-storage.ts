import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";

import { TeamsService } from "../teams/teams.service";
import { Teams } from "../teams/teams.model";
import  {tap, map} from "rxjs/operators";
@Injectable({providedIn:'root'})
export class DataStorageService{
constructor(private http:HttpClient,
    private teamsService:TeamsService){

}
}
