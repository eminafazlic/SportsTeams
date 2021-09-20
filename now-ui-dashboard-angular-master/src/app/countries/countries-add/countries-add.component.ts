import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { CountryService } from '../countries.service';

@Component({
  selector: 'app-countries-add',
  templateUrl: './countries-add.component.html',
  styleUrls: ['./countries-add.component.css']
})
export class CountriesAddComponent implements OnInit {

  constructor(private router:Router,
    private route:ActivatedRoute,
    private countryService:CountryService) { }

    countriesForm=new FormGroup({
name:new FormControl(''),
picture:new FormControl(''),
abbreviation:new FormControl(''),
capital:new FormControl(''),
population:new FormControl(''),
    });
  ngOnInit(): void {
  }
 
    onCancel(){
      this.router.navigate(['../'],{relativeTo:this.route});}

      onSubmit(){
      console.log(this.countriesForm.value);
      this.countryService.InsertCountry(this.countriesForm.value).subscribe(
        (result)=>{
          console.log('dodano', result);
        }
      );
      this.router.navigate(['.../'],{relativeTo:this.route});
     
      }
}
