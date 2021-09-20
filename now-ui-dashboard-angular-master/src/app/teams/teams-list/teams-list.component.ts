
import { HttpClient } from '@angular/common/http';
import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import {  ActivatedRoute, Router } from '@angular/router';
//import { SharedService } from '../../shared/shared-service';
import { Teams } from '../teams.model';
import { TeamsService } from '../teams.service';

@Component({
  selector: 'app-teams-list',
  templateUrl: './teams-list.component.html',
  styleUrls: ['./teams-list.component.css']
})
export class TeamsListComponent implements OnInit {
@Input() list: any[];
page:number=1;
pageSize:number;
total:number;
passenger: any;
itemsPerPage = 10;
totalItems : any;
  constructor(
    private teamsService:TeamsService,
    private http:HttpClient,
    private router:Router,
    private route:ActivatedRoute) { }

  ngOnInit(): void {

this.getAllData();
  }

  getAllData(){
   this.http.get("https://192.168.1.116:5001/api/v1/Team").subscribe((data: any) => {
    console.log(data);
    this.passenger = data.data;
    this.page =  0;
    this.totalItems = data.totalPassengers;
    })

  }
  onNewTeam(){
    this.router.navigate(['add'],{relativeTo:this.route});
  }

}
