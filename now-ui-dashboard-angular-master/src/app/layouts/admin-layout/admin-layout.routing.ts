import { Routes } from '@angular/router';

import { DashboardComponent } from '../../dashboard/dashboard.component';
import { CountryTeamsComponent } from '../../country-teams/country-teams.component';
import { CountriesComponent } from '../../countries/countries.component';
import { CountriesAddComponent } from '../../countries/countries-add/countries-add.component';
import { CountriesDetailsComponent } from '../../countries/countries-details/countries-details.component';
import { CountriesEditComponent } from '../../countries/countries-edit/countries-edit.component';
import { TeamsComponent } from '../../teams/teams.component';
import { TeamsAddComponent } from '../../teams/teams-add/teams-add.component';
import { TeamsDetailsComponent } from '../../teams/teams-details/teams-details.component';
import { TeamsEditComponent } from '../../teams/teams-edit/teams-edit.component';
import { TeamsPlayersComponent } from '../../teams/teams-players/teams-players.component';
import { PlayersComponent } from '../../players/players.component';
import { PlayersAddComponent } from '../../players/players-add/players-add.component';
import { PlayersDetailsComponent } from '../../players/players-details/players-details.component';
import { PlayersEditComponent } from '../../players/players-edit/players-edit.component';

export const AdminLayoutRoutes: Routes = [
    { path: 'dashboard',      component: DashboardComponent},
    { path: 'countries/:id/teams', component: CountryTeamsComponent },
    {path:'countries', component:CountriesComponent, children:[
    {path:'add', component:CountriesAddComponent},
    {path:':id',component:CountriesDetailsComponent},
    {path:':id/edit',component:CountriesEditComponent}
    ]},
    {
      path:'teams',component:TeamsComponent,children:[
        {path:'add',component:TeamsAddComponent},
        {path:':id',component:TeamsDetailsComponent},
        {path:':id/edit',component:TeamsEditComponent},
        {path:':id/players',component:TeamsPlayersComponent}
      ]
    },

    { path: 'teams/:id/players', component: TeamsPlayersComponent},
    { path: 'teams/:id/players/:id', component: PlayersDetailsComponent },

    { path:'players', component:PlayersComponent,children:[
        {path:'add',component:PlayersAddComponent},
        {path:':id',component:PlayersDetailsComponent},
        {path:':id/edit',component:PlayersEditComponent}
      ]}
];
