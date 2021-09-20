import { NgModule } from '@angular/core';
import { CommonModule, } from '@angular/common';
import { BrowserModule  } from '@angular/platform-browser';
import { Routes, RouterModule } from '@angular/router';

import { AdminLayoutComponent } from './layouts/admin-layout/admin-layout.component';

import { TeamsComponent } from './teams/teams.component';
import { CountriesComponent } from './countries/countries.component';
import { AuthComponent } from './auth/auth.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { TeamsDetailsComponent } from './teams/teams-details/teams-details.component';
import { TeamsListComponent } from './teams/teams-list/teams-list.component';
import { TeamsEditComponent } from './teams/teams-edit/teams-edit.component';
import { CountriesDetailsComponent } from './countries/countries-details/countries-details.component';
import { CountriesEditComponent } from './countries/countries-edit/countries-edit.component';
import { TeamsStartComponent } from './teams/teams-start/teams-start.component';
import { CountryStartComponent } from './countries/country-start/country-start.component';
import { CountriesAddComponent } from './countries/countries-add/countries-add.component';
import { TeamsAddComponent } from './teams/teams-add/teams-add.component';
import { PlayersComponent } from './players/players.component';
import { PlayersStartComponent } from './players/players-start/players-start.component';
import { PlayersAddComponent } from './players/players-add/players-add.component';
import { PlayersDetailsComponent } from './players/players-details/players-details.component';
import { PlayersEditComponent } from './players/players-edit/players-edit.component';
import { TeamsPlayersComponent } from './teams/teams-players/teams-players.component';

const routes: Routes =[
  {
    path: '',
    redirectTo: 'dashboard',
    pathMatch: 'full',

  },

   {path:'Team',component:TeamsComponent,children:[
    { path:'', component:TeamsStartComponent },
    {path:'add',component:TeamsAddComponent},
    {path:':id',component:TeamsDetailsComponent},
    {path:':id/edit',component:TeamsEditComponent},
    {path:':id/players',component:TeamsPlayersComponent}
  ]},

  {path:'Country',component:CountriesComponent,children:[
    { path:'', component:CountryStartComponent },
    {path:'add',component:CountriesAddComponent},
    {path:':id',component:CountriesDetailsComponent},
    {path:':id/edit',component:CountriesEditComponent}
  ]},
{
  path:'Player', component:PlayersComponent ,children:[
    { path:'', component:PlayersStartComponent },
    {path:'add',component:PlayersAddComponent},
    {path:':id',component:PlayersDetailsComponent},
    {path:':id/edit',component:PlayersEditComponent}
  ]
},

  {path:'auth', component:AuthComponent}
  ,
   {
    path: '',
    component: AdminLayoutComponent,
    children: [
        {
      path: '',
      loadChildren: './layouts/admin-layout/admin-layout.module#AdminLayoutModule'
  }]},
  {
    path: '**',
    redirectTo: 'dashboard'
  }
];

@NgModule({
  imports: [
    CommonModule,
    BrowserModule,
    RouterModule.forRoot(routes)
  ],
  exports: [
  ],
})
export class AppRoutingModule { }
