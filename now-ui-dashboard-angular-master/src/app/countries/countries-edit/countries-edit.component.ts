import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, NgForm, Validators } from '@angular/forms';
import { ActivatedRoute, Params, Router } from '@angular/router';
import { first } from 'rxjs/operators';
import { Countries } from '../countries.model';
import { CountryService } from '../countries.service';

@Component({
  selector: 'app-countries-edit',
  templateUrl: './countries-edit.component.html',
  styleUrls: ['./countries-edit.component.css']
})
export class CountriesEditComponent implements OnInit {
  id:number;
    constructor(private route:ActivatedRoute,
      private countryService:CountryService,
      private router:Router,
      private formBuilder:FormBuilder,) { }
  
    countriesForm=new FormGroup({
    name:new FormControl(''),
    picture:new FormControl(''),
    abbreviation:new FormControl(''),
    capital:new FormControl(''),
    population:new FormControl(''),
        });
      ngOnInit(): void {
      //  console.log(this.route.snapshot.params.id);
        this.countryService.GetCountryById(this.route.snapshot.params.id).subscribe(
          res=>{
           // console.log(res);
            this.countriesForm=new FormGroup({
              name:new FormControl(res['name']),
              picture:new FormControl(res['picture']),
              abbreviation:new FormControl(res['abbreviation']),
              capital:new FormControl(res['capital']),
              population:new FormControl(res['population'])
            }
            );
          }
        );
      }
     
        onCancel(){
          this.router.navigate(['../'],{relativeTo:this.route});}
          onSubmit(){
            console.log(this.countriesForm.value);
            this.countryService.UpdateCountry(this.route.snapshot.params.id,this.countriesForm.value).subscribe(
              res=>{
                console.log(res);
              }
            );
            this.router.navigate(['.../'],{relativeTo:this.route});
          }
        
    
        }
      
    