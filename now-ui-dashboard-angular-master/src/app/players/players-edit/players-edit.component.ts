import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { CountryService } from '../../countries/countries.service';
import { TeamsService } from '../../teams/teams.service';

import { PlayersService } from '../players.service';

@Component({
  selector: 'app-players-edit',
  templateUrl: './players-edit.component.html',
  styleUrls: ['./players-edit.component.css']
})
export class PlayersEditComponent implements OnInit {

id!:number;
editMode=false;

teams:any={};
countries:any={};
  constructor(private route:ActivatedRoute,
    private playerService:PlayersService,
    private router:Router,
    public teamsService:TeamsService,
    public countriesService:CountryService) { }
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
    //  console.log(this.route.snapshot.params.id);
    this.playerService.GetPlayerById(this.route.snapshot.params.id).subscribe(
      res=>{

        this.playersForm=new FormGroup({
          name:new FormControl(res['name']),
          picture:new FormControl(res['picture']),
          number:new FormControl(res['number']),
          dateOfBirth:new FormControl(res['dateOfBirth']),
          placeOfBirth:new FormControl(res['placeOfBirth']),
          age:new FormControl(res['age']),
          countryId:new FormControl(res['countryId']),
          marketValue:new FormControl(res['marketValue']),
          position:new FormControl(res['position']),
          teamId:new FormControl(res['teamId']),
          joined:new FormControl(res['joined']),
          constractExpDate:new FormControl(res['constractExpDate'])
        }
        );
      }
    );
    this.teamsService.GetAllTeams().subscribe(res =>{
      this.teams = res;
    });
    this.countriesService.GetAllCountries().subscribe(res =>{
      this.countries = res;
    });
  }

onCancel(){
 this.router.navigate(['../'],{relativeTo:this.route});

}
onSubmit(){
 // console.log(this.teamsForm.value);
  this.playerService.UpdatePlayer(this.route.snapshot.params.id,this.playersForm.value).subscribe(
    res=>{
      console.log('promijenjeno',res);

    },
    err=>{
      console.log(err);
    }
  );
  this.router.navigate(['/players']);

}

}

