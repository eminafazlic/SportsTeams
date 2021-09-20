


import { Component, Input, OnInit,} from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Teams} from '../../teams.model';
import { TeamsService } from '../../teams.service';

@Component({
  selector: 'app-teams-item',
  templateUrl: './teams-item.component.html',
  styleUrls: ['./teams-item.component.css']
})
export class TeamsItemComponent implements OnInit {
@Input()team!:Teams;
@Input()index!:number;
  constructor(private teamsService:TeamsService,
    public route:ActivatedRoute,public router:Router) { }

  ngOnInit(): void {
  }


}
