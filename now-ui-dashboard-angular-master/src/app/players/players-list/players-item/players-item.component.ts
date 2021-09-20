import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Player } from '../../player.model';
import { PlayersService } from '../../players.service';

@Component({
  selector: 'app-players-item',
  templateUrl: './players-item.component.html',
  styleUrls: ['./players-item.component.css']
})
export class PlayersItemComponent implements OnInit {

@Input()player!:Player;
@Input()index!:number;
  constructor(private playerService:PlayersService,
    public route:ActivatedRoute,public router:Router) { }

    ngOnInit(): void {
    }


}
