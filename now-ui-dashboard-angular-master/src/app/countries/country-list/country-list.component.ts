import { HttpClient } from '@angular/common/http';
import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Subscription } from 'rxjs';
import { Countries } from '../countries.model';
import { CountryService } from '../countries.service';

@Component({
  selector: 'app-country-list',
  templateUrl: './country-list.component.html',
  styleUrls: ['./country-list.component.css']
})
export class CountryListComponent implements OnInit {

@Input() list: any[];
page:number=1;
pageSize:number;
total:number;
passenger: any;
itemsPerPage = 10;
totalItems : any;

  constructor(private countryService:CountryService,
    private http:HttpClient,
    private route:ActivatedRoute,
    private router:Router) { }

  ngOnInit(): void {
   this.getAllData();

  }
  getAllData(){
    this.http.get("https://192.168.1.116:5001/api/v1/Country").subscribe((data: any) => {
     console.log(data);
     this.passenger = data.data;
     this.page =  0;
     this.totalItems = data.totalPassengers;
     })
    }
    AddCountry(){
      this.router.navigate(['add'],{relativeTo:this.route});
    }


  }


