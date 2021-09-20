import { Component, Input, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Countries } from '../../countries/countries.model';
import { CountryService } from '../../countries/countries.service';


declare interface RouteInfo {
    path: string;
    title: string;
    icon: string;
    class: string;
}

export const ROUTES: RouteInfo[] = [
    // { path: '/dashboard', title: 'Dashboard',  icon: 'design_app', class: '' },
    { path: '/icons', title: 'Bosna i Hercegovina',  icon:'flag-icon flag-icon-ba flag-icon-squared', class: '' },
    { path: '/maps', title: 'Hrvatska',  icon:'flag-icon flag-icon-hr flag-icon-squared', class: '' },
    { path: '/notifications', title: 'Srbija',  icon:'flag-icon flag-icon-rs flag-icon-squared', class: '' },

    { path: '/user-profile', title: 'Španija',  icon:'flag-icon flag-icon-es flag-icon-squared', class: '' },
    { path: '/table-list', title: 'Ujedinjeno Kraljevstvo',  icon:'flag-icon flag-icon-gb-eng flag-icon-squared', class: '' },
    { path: '/typography', title: 'Francuska',  icon:'flag-icon flag-icon-fr flag-icon-squared', class: '' },
    { path: '/upgrade', title: 'Njemačka',  icon:'flag-icon flag-icon-de flag-icon-squared', class: '' },

    //{path:'/teams', title:'Timovi', icon:'flag-icon flag-icon-de flag-icon-squared', class:''}



];

@Component({
  selector: 'app-sidebar',
  templateUrl: './sidebar.component.html',
  styleUrls: ['./sidebar.component.css']
})
export class SidebarComponent implements OnInit {
  menuItems: any = {};

  constructor(public countriesService: CountryService,
    public router: Router) {
    this.countriesService.GetAllCountries().subscribe(x=>{
      this.menuItems = x;
    })
   }

  ngOnInit() {
  }
  isMobileMenu() {
      if ( window.innerWidth > 991) {
          return false;
      }
      return true;
  };
  teams(id)
  {
    this.router.navigate([`countries/${id}/teams`]);
  }
}
