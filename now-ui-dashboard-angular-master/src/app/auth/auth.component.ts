import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { AuthService } from './auth.service';

@Component({
  selector: 'app-auth',
  templateUrl: './auth.component.html',
  styleUrls: ['./auth.component.css']
})
export class AuthComponent implements OnInit {
isLoginMode=true;
isLoading=false;
error:any=null;
  constructor(private AuthService:AuthService) { }

  ngOnInit(): void {
  }
  onSwitchMode(){
    this.isLoginMode=!this.isLoginMode;
  }
   onSubmit(form:NgForm){
    const email=form.value.email;
    const password=form.value.password;
    this.isLoading=true;
     if(!form.valid){
       return;
     }
     if(this.isLoginMode){
     this.AuthService.login(email,password).subscribe(
      resData=>{
        console.log(resData);
        this.isLoading=false;
      },errorMessage=>{
      
        console.log(errorMessage);
        this.error=errorMessage;
        this.isLoading=false;
      }
     );
     }
     else{
      this.AuthService.signup(email,password).subscribe(resData=>{
        console.log(resData);
        this.isLoading=false;
      },errorMessage=>{
      
        console.log(errorMessage);
        this.error=errorMessage;
        this.isLoading=false;
      });
     }
   
     form.reset();
   }
}
