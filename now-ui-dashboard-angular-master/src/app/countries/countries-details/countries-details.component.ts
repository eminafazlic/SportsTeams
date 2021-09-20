import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Params, Router } from '@angular/router';
import { Subscription } from 'rxjs';
import { Countries } from '../countries.model';
import { CountryService } from '../countries.service';

@Component({
  selector: 'app-countries-details',
  templateUrl: './countries-details.component.html',
  styleUrls: ['./countries-details.component.css']
})
export class CountriesDetailsComponent implements OnInit {
  country!:Countries;
  id!:number;
    constructor(private countriesService:CountryService,
      private route:ActivatedRoute,
      private router:Router) { }

    ngOnInit(): void {
      this.id = Number(this.route.snapshot.paramMap.get('id'));

      this.countriesService.GetCountryById(this.id).subscribe(
        (res: Countries) => {
          this.country = res;
          console.log(res);

        })

    }
    EditCountry(){
   this.router.navigate(['edit'],{relativeTo:this.route});
    }
    onDeleteCountry(id:number){

        this.countriesService.DeleteCountry(this.id).subscribe(
         ( res:Countries)=>{
            this.country=res;
          }

        );
        this.router.navigate(['/countries']);



    }


    }
