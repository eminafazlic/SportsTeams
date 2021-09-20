
import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { ActivatedRoute, Params, Router } from '@angular/router';
import { Teams } from '../teams.model';
import { TeamsService } from '../teams.service';
import { CountryService } from '../../countries/countries.service';
@Component({
  selector: 'app-teams-edit',
  templateUrl: './teams-edit.component.html',
  styleUrls: ['./teams-edit.component.css']
})
export class TeamsEditComponent implements OnInit {
id!:number;
editMode=false;

countries: any = {};
  constructor(private route:ActivatedRoute,
    private teamsservice:TeamsService,
    private router:Router,
   public countriesService:CountryService) { }
    teamsForm=new FormGroup({
      name:new FormControl(''),
      picture:new FormControl(''),
      countryId:new FormControl(''),
      founded:new FormControl(''),
      homeGround:new FormControl(''),
      stadiumCapacity:new FormControl(''),
      marketValue:new FormControl(''),
      numberOfPlayers:new FormControl(''),
      headCoach:new FormControl(''),
      president:new FormControl(''),
      league:new FormControl(''),
          });
  ngOnInit(): void
  {

    this.countriesService.GetAllCountries().subscribe(res =>{
      this.countries = res;});

    this.teamsservice.GetTeamById(this.route.snapshot.params.id).subscribe(
      res=>{
        console.log(res);
        this.teamsForm=new FormGroup({
          name:new FormControl(res['name']),
          picture:new FormControl(res['picture']),
          countryId:new FormControl(res['countryId']),
          founded:new FormControl(res['founded']),
          homeGround:new FormControl(res['homeGround']),
          stadiumCapacity:new FormControl(res['stadiumCapacity']),
          marketValue:new FormControl(res['marketValue']),
          numberOfPlayers:new FormControl(res['numberOfPlayers']),
          headCoach:new FormControl(res['headCoach']),
          president:new FormControl(res['president']),
          league:new FormControl(res['league']),
        }
        );
      }
    );
  }

onCancel(){
 this.router.navigate(['../'],{relativeTo:this.route});

}
onSubmit(){
 // console.log(this.teamsForm.value);
  this.teamsservice.UpdateTeam(this.route.snapshot.params.id,this.teamsForm.value).subscribe(
    res=>{
      console.log('promijenjeno',res);
    },
    err=>{
      console.log(err);
    }
  );
  this.router.navigate(['.../'],{relativeTo:this.route});
}

}
