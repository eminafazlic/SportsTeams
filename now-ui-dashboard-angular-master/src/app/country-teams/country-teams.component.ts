import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, NavigationEnd, NavigationStart, Router } from '@angular/router';
import { TeamsService } from '../teams/teams.service';

@Component({
  selector: 'app-country-teams',
  templateUrl: './country-teams.component.html',
  styleUrls: ['./country-teams.component.css']
})
export class CountryTeamsComponent implements OnInit {
countryId: string;
teams: any = {};
  constructor(public route: ActivatedRoute,
              public teamsService: TeamsService,
              public router: Router) {
                this.countryId = this.route.snapshot.paramMap.get('id');
                this.getTeams(this.countryId);
                this.router.events.subscribe(x=>{
                  if(x instanceof NavigationEnd) {
                    this.countryId = this.route.snapshot.paramMap.get('id');
                    this.getTeams(this.countryId);
                  }

                })

               }

  ngOnInit(): void {
  }

  getTeams(countryId)
  {
    this.teamsService.GetTeamByCountryId(countryId, 1, 10).subscribe(x=>{
      this.teams = x;
    })
  }

}
