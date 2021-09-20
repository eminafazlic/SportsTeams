import { Component, Input, OnInit } from '@angular/core';
import { Countries } from '../../countries.model';
import { CountryService } from '../../countries.service';

@Component({
  selector: 'app-country-item',
  templateUrl: './country-item.component.html',
  styleUrls: ['./country-item.component.css']
})
export class CountryItemComponent implements OnInit {
  @Input() country!:Countries;
  @Input() index!:number;
  constructor(private countryService:CountryService) { }

  ngOnInit(): void {
  }
  onDelete(){
    
  }

}
