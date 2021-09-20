import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { CountryService } from '../../countries/countries.service';
import { TeamsService } from '../teams.service';

@Component({
  selector: 'app-teams-add',
  templateUrl: './teams-add.component.html',
  styleUrls: ['./teams-add.component.css']
})
export class TeamsAddComponent implements OnInit {

  countries: any = {};

  constructor(private router:Router,
    private route:ActivatedRoute,
    private teamsService:TeamsService,
    private countrieService: CountryService) { }

    teamsForm=new FormGroup({
      name:new FormControl(''),
      picture:new FormControl(''),
      countryId:new FormControl(''),
      country:new FormControl(''),
      founded:new FormControl(''),
      homeground:new FormControl(''),
      capacity:new FormControl(''),
      marketvalue:new FormControl(''),
      numberofplayers:new FormControl(''),
      headCoach:new FormControl(''),
      president:new FormControl(''),
      league:new FormControl(''),
          });
  ngOnInit(): void {
    this.countrieService.GetAllCountries().subscribe(res =>{
      this.countries = res;
    })
  }

  onCancel(){
    this.router.navigate(['../'],{relativeTo:this.route});
   }
   onSubmit(){
    this.teamsService.InsertTeam(this.teamsForm.value).subscribe(
      (result)=>{
        console.log('dodano', result);
      }
    );
    this.router.navigate(['.../'],{relativeTo:this.route});
   }
}
