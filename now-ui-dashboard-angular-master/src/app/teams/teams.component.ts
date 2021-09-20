
  import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { DataStorageService } from '../shared/data-storage';
  import { Teams } from './teams.model';
  import { TeamsService } from './teams.service';

  @Component({
    selector: 'app-teams',
    templateUrl: './teams.component.html',
    styleUrls: ['./teams.component.css']
  })
  export class TeamsComponent implements OnInit {
  selectedTeams!:Teams;
  page:number=1;
  pageSize:number;
  total:number;
  passenger: any;
  itemsPerPage = 10;
  totalItems : any;
    constructor(private teamsService:TeamsService,
    private http:HttpClient) { }

    public Teams: Teams[];
    ngOnInit(): void {
      this.teamsService.GetAllTeams().subscribe((res: any)=>{

        this.Teams = res;


      })
       this.teamsService.teamsSelected.subscribe(
       (team:Teams)=>{
         this.selectedTeams=team;
       }
      );
      this.getSortByName();
      this.getSortByID();

      }
      getSortByName(){
        this.http.get("https://192.168.1.116:5001/api/v1/Team").subscribe((data:any)=>{
          this.passenger = data.data;
          this.page =  0;
          this.totalItems = data.totalPassengers;
          this.Teams = data;
          console.log(data);
        })
      }

      getSortByID(){
        this.http.get("https://192.168.1.116:5001/api/v2/Team").subscribe((data:any)=>{
          this.passenger = data.data;
          this.page =  0;
          this.totalItems = data.totalPassengers;
          this.Teams = data;
          console.log(data);
        })
      }

  }
