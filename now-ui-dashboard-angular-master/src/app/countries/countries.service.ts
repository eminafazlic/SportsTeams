import { EventEmitter, Injectable } from "@angular/core";
import { Subject } from "rxjs";
import { HttpClient } from "@angular/common/http";
import { Countries } from "./countries.model";

@Injectable()
export class CountryService{

readonly APIUrl="https://192.168.1.116:5001";
//"https://192.168.1.116:5001";
//"https://192.168.1.116:5001";
countriesChanged=new Subject<Countries[]>();
countrySelected=new EventEmitter<Countries>();
private countries:Countries[]=[];

constructor(private http:HttpClient){}
GetAllCountries(){

    return this.http.get(`${this.APIUrl}/api/v1/Country`);
  }
GetCountryById(id){
    return this.http.get(`${this.APIUrl}/api/v1/Country/${id}`);
}
DeleteCountry(id){
    return this.http.delete(`${this.APIUrl}/api/v1/Country/${id}`);
}
InsertCountry(val){
    return this.http.post(`${this.APIUrl}/api/v1/Country`,val)
    }
UpdateCountry(id,val){
     return this.http.put(`${this.APIUrl}/api/v1/Country/${id}`,val)
        }



}
