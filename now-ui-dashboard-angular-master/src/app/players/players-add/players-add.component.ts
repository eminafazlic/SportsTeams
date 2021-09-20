import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { TeamsService } from '../../teams/teams.service';
import { CountryService } from '../../countries/countries.service';
import { PlayersService } from '../players.service';

@Component({
  selector: 'app-players-add',
  templateUrl: './players-add.component.html',
  styleUrls: ['./players-add.component.css']
})
export class PlayersAddComponent implements OnInit {
  id!:number;
  editMode=false;

  countries: any = {};
  teams:any={};
    constructor(private route:ActivatedRoute,
      private playerService:PlayersService,
      private router:Router,
      public countryService:CountryService,
      public teamService:TeamsService) { }
      playersForm=new FormGroup({
        name:new FormControl(''),
        picture:new FormControl(''),
        number:new FormControl(''),
        dateOfBirth:new FormControl(''),
        placeOfBirth:new FormControl(''),
        age:new FormControl(''),
        countryId:new FormControl(''),
        marketValue:new FormControl(''),
        position:new FormControl(''),
        teamId:new FormControl(''),
        joined:new FormControl(''),
        constractExpDate:new FormControl('')

            });
    ngOnInit(): void {
      this.countryService.GetAllCountries().subscribe(res =>{
        this.countries = res;
      });

      this.teamService.GetAllTeams().subscribe(res =>{
        this.teams = res;
      })

    }

  onCancel(){
   this.router.navigate(['../'],{relativeTo:this.route});

  }
  onSubmit(){
   // console.log(this.teamsForm.value);
   console.log(this.playersForm.value);
   this.playerService.InsertPlayer(this.playersForm.value).subscribe(
     (result)=>{
       console.log('dodano', result);
     }
   );
   this.router.navigate(['.../'],{relativeTo:this.route});
  }
  }




