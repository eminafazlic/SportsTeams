import { HttpClient } from '@angular/common/http';
import { THIS_EXPR } from '@angular/compiler/src/output/output_ast';
import { Component, OnInit } from '@angular/core';

import { Countries } from './countries.model';
import { CountryService } from './countries.service';

@Component({
  selector: 'app-countries',
  templateUrl: './countries.component.html',
  styleUrls: ['./countries.component.css']
})
export class CountriesComponent implements OnInit {
  page:number=1;
  pageSize:number;
  total:number;
  passenger: any;
  itemsPerPage = 10;
  totalItems : any;
  selectedCountry!:Countries;
  constructor(private countryService:CountryService,
    private http:HttpClient) {

   }

  public Countries: Countries[];
  ngOnInit(): void {

    this.countryService.GetAllCountries().subscribe((res: Countries[])=>{
      this.Countries = res;

    })
     this.countryService.countrySelected.subscribe(
     (countries:Countries)=>{
       this.selectedCountry=countries;
     }
    );
  this.getSortByName();
  this.getSortByID();
  }
  getSortByName(){
    this.http.get("https://192.168.1.116:5001/api/v1/Country").subscribe((data:any)=>{
      this.passenger = data.data;
      this.page =  0;
      this.totalItems = data.totalPassengers;
      this.Countries = data;
      console.log(data);
    })
  }

  getSortByID(){
    this.http.get("https://192.168.1.116:5001/api/v2/Country").subscribe((data:any)=>{
      this.passenger = data.data;
      this.page =  0;
      this.totalItems = data.totalPassengers;
      this.Countries = data;
      console.log(data);
    })
  }


}
