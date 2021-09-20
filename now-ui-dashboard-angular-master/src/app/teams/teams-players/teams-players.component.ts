import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { PlayersService } from '../../players/players.service';

@Component({
  selector: 'app-teams-players',
  templateUrl: './teams-players.component.html',
  styleUrls: ['./teams-players.component.css']
})
export class TeamsPlayersComponent implements OnInit {

  teamId: string;
  players: any = {};
  constructor(private route: ActivatedRoute,
              private playerService: PlayersService) {
                this.teamId = this.route.snapshot.paramMap.get('id');
                this.playerService.GetPlayerByTeamId(this.teamId, 1, 10).subscribe(x=>{
                  this.players = x;
                })
               }

  ngOnInit(): void {
  }

}
