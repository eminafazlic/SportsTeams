import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Player } from './player.model';
import { PlayersService } from './players.service';
import { FilterPipe } from '../filter.pipe';
@Component({
  selector: 'app-players',
  templateUrl: './players.component.html',
  styleUrls: ['./players.component.css']
})
export class PlayersComponent implements OnInit {
selectedPlayer:Player;
page:number=1;
pageSize:number;
total:number;
passenger: any;
itemsPerPage = 10;
totalItems : any;
searchText:string;
  constructor(public playerService:PlayersService,
    private http:HttpClient) { }

    public Player:Player[];

    ngOnInit(): void {
      this.playerService.GetAllPlayers().subscribe((res: any)=>{

        this.Player = res;
      });

      this.http.get('https://192.168.1.116:5001/api/v1/Player').subscribe((res:any) => {
        // Populating usersArray with names from API
        res.json().forEach(element => {
          this.Player.push(element.name);

        });
      });


       this.playerService.playerSelected.subscribe(
       (player:Player)=>{
         this.selectedPlayer=player;
       }
      );
      this.getSortByName();
      this.getSortByID();

      }
      getSortByName(){
        this.http.get("https://192.168.1.116:5001/api/v1/Player").subscribe((data:any)=>{
          this.passenger = data.data;
          this.page =  0;
          this.totalItems = data.totalPassengers;
          this.Player = data;

        })
      }

      getSortByID(){
        this.http.get("https://192.168.1.116:5001/api/v2/Player").subscribe((data:any)=>{
          this.passenger = data.data;
          this.page =  0;
          this.totalItems = data.totalPassengers;
          this.Player = data;

        })
      }
}
