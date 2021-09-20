
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Params, Router } from '@angular/router';
import { Teams } from '../teams.model';
import { TeamsService } from '../teams.service';

@Component({
  selector: 'app-teams-details',
  templateUrl: './teams-details.component.html',
  styleUrls: ['./teams-details.component.css']
})
export class TeamsDetailsComponent implements OnInit {
  team: Teams;
  id: number;
  constructor(private teamsService: TeamsService,
    private route: ActivatedRoute,
    private router: Router) { }

  ngOnInit(): void {

    this.id = Number(this.route.snapshot.paramMap.get('id'));

    this.teamsService.GetTeamById(this.id).subscribe(
      (res: Teams) => {
        this.team = res;


      });

  }

 onEditTeam() {
    this.router.navigate(['edit'], { relativeTo: this.route });
  }
  onDeleteTeam(id:number) {
   this.teamsService.DeleteTeam(this.id).subscribe(
    ( res:Teams)=>{
       this.team=res;
     }

   );
   this.router.navigate(['/Team']);


  }

  players(teamId)
  {
    this.router.navigate([`teams/${teamId}/players`])
  }


}
