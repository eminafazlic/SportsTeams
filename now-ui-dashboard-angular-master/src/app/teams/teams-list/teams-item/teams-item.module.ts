import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { ToastrModule } from 'ngx-toastr';
//import { AppRoutingModule } from '../../app.routing';
import { AppRoutingModule } from '../../../app.routing';
//import { ComponentsModule } from '../../components/components.module';
import { ComponentsModule } from '../../../components/components.module';
//import { AppComponent } from '../../app.component';
import { AppComponent } from '../../../app.component';
//import { AdminLayoutComponent } from '../../layouts/admin-layout/admin-layout.component';
import { AdminLayoutComponent } from '../../../layouts/admin-layout/admin-layout.component';
import { TeamsComponent } from '../../teams.component';
//import { SidebarComponent } from '../../components/sidebar/sidebar.component';
import { SidebarComponent } from '../../../components/sidebar/sidebar.component';
import { CommonModule } from '@angular/common';
import { BrowserModule } from '@angular/platform-browser';






@NgModule({
  imports: [
    BrowserAnimationsModule,
    FormsModule,
    HttpClientModule,
    ComponentsModule,
    RouterModule,
    AppRoutingModule,
    NgModule,
    BrowserModule,
    CommonModule,
    ToastrModule.forRoot(),
    ReactiveFormsModule,
    SidebarComponent,
    TeamsComponent,
    AppComponent,
    AdminLayoutComponent
  ],
  declarations: [

  ]
})
export class TeamsItemModule { }
