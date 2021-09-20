import { HttpClient, HttpErrorResponse } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { catchError } from "rxjs/operators";
import{throwError} from "rxjs";
interface AuthResponseData{
    kind:string;
    idToken:string;
    email:string;
    refreshToken:string;
    expiresIn:string;
    localId:string;
    registered?:boolean;
}


@Injectable({providedIn:'root'})
export class AuthService{
constructor(private http:HttpClient){

}
    signup(email:string, password:string){
return this.http.post<AuthResponseData>('https://identitytoolkit.googleapis.com/v1/accounts:signUp?key=AIzaSyA0MIUGNjPXL15n60nUiu9F5e5m3uuEZLg'
,{
    email:email,
    password:password,
    returnSecureToken:true
}).pipe(catchError(this.HandleError));
    }

    login(email:string,password:string){
     return this.http.post<AuthResponseData>('https://identitytoolkit.googleapis.com/v1/accounts:signInWithPassword?key=AIzaSyA0MIUGNjPXL15n60nUiu9F5e5m3uuEZLg'
        ,{
            email:email,
            password:password,
            returnSecureToken:true
        }).pipe(catchError(this.HandleError));
    }

    private HandleError(errorResponse:HttpErrorResponse){

        let errorMessage='An unknown error occured!';

        if(!errorResponse.error || !errorResponse.error.error)
        {
            return throwError(errorMessage);
        }
         
        switch(errorResponse.error.error.message){
        case 'EMAIL_EXISTS':
         errorMessage='This email exist already!'
         break;
        case 'INVALID_PASSWORD':
            errorMessage="Your password is incorrect!";
            break;
        case 'EMAIL_NOT_FOUND':
            errorMessage="This email doesn't exist!"
        }
        return throwError(errorMessage);
    }
}