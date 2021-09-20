import { HttpClient } from '@angular/common/http';
import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { PlayersService } from '../players.service';

@Component({
  selector: 'app-players-list',
  templateUrl: './players-list.component.html',
  styleUrls: ['./players-list.component.css']
})
export class PlayersListComponent implements OnInit {
  @Input() list: any[];
  page:number=1;
  pageSize:number;
  total:number;
  passenger: any;
  itemsPerPage = 10;
  totalItems : any;
  constructor(
    public playerService:PlayersService,
    private http:HttpClient,
    private router:Router,
    private route:ActivatedRoute
  ) { }

  ngOnInit(): void {
  }
  getAllData(){
    this.http.get("https://192.168.1.116:5001/api/v1/Player").subscribe((data: any) => {

     this.passenger = data.data;
     this.page =  0;
     this.totalItems = data.totalPassengers;
     })

   }
   onNewTeam(){
     this.router.navigate(['add'],{relativeTo:this.route});
   }
}
