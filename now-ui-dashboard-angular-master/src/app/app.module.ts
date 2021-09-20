import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { ToastrModule } from 'ngx-toastr';
import { AppRoutingModule } from './app.routing';
import { ComponentsModule } from './components/components.module';
import { AppComponent } from './app.component';

import { AdminLayoutComponent } from './layouts/admin-layout/admin-layout.component';
import { TeamsComponent } from './teams/teams.component';
import { CountriesComponent } from './countries/countries.component';
import { AuthComponent } from './auth/auth.component';
import { TeamsDetailsComponent } from './teams/teams-details/teams-details.component';
import { TeamsListComponent } from './teams/teams-list/teams-list.component';
import { TeamsItemComponent } from './teams/teams-list/teams-item/teams-item.component';
import { CommonModule, DatePipe } from '@angular/common';
import { BrowserModule } from '@angular/platform-browser';
import { TeamsService } from './teams/teams.service';
import { TeamsEditComponent } from './teams/teams-edit/teams-edit.component';
import { CountryService } from './countries/countries.service';
import { CountryListComponent } from './countries/country-list/country-list.component';
import { CountryItemComponent } from './countries/country-list/country-item/country-item.component';
import { CountriesDetailsComponent } from './countries/countries-details/countries-details.component';
import { CountriesEditComponent } from './countries/countries-edit/countries-edit.component';
import { CountryStartComponent } from './countries/country-start/country-start.component';
import { CountriesAddComponent } from './countries/countries-add/countries-add.component';
import { TeamsAddComponent } from './teams/teams-add/teams-add.component';
import {NgxPaginationModule} from 'ngx-pagination';
import {MatSelectModule} from '@angular/material/select';
import { PlayersComponent } from './players/players.component';
import { PlayersService } from './players/players.service';
import { PlayersAddComponent } from './players/players-add/players-add.component';
import { PlayersDetailsComponent } from './players/players-details/players-details.component';
import { PlayersEditComponent } from './players/players-edit/players-edit.component';
import { PlayersListComponent } from './players/players-list/players-list.component';
import { PlayersStartComponent } from './players/players-start/players-start.component';
import { PlayersItemComponent } from './players/players-list/players-item/players-item.component';
import { TeamsPlayersComponent } from './teams/teams-players/teams-players.component';
import { FilterPipe } from './filter.pipe';


@NgModule({
  imports: [
    BrowserAnimationsModule,
    FormsModule,
    HttpClientModule,
    //HttpClient,
    ComponentsModule,
    RouterModule,
    AppRoutingModule,
    NgbModule,
    BrowserModule,
    CommonModule,
    ToastrModule.forRoot(),
    ReactiveFormsModule,
    NgxPaginationModule,
    MatSelectModule

  ],
  declarations: [
    AppComponent,
    AdminLayoutComponent,
    TeamsComponent,
    CountriesComponent,
    AuthComponent,
    TeamsDetailsComponent,
    TeamsListComponent,
    TeamsItemComponent,

    TeamsEditComponent,

    CountryListComponent,

    CountryItemComponent,

    CountriesDetailsComponent,

    CountriesEditComponent,

    CountryStartComponent,

    CountriesAddComponent,

    TeamsAddComponent,

    PlayersComponent,

    PlayersAddComponent,

    PlayersDetailsComponent,

    PlayersEditComponent,

    PlayersListComponent,

    PlayersStartComponent,

    PlayersItemComponent,

    TeamsPlayersComponent,

    FilterPipe

   //SharedService

  ],
  providers: [TeamsService,CountryService,PlayersService,DatePipe],
  bootstrap: [AppComponent]
})
export class AppModule { }
