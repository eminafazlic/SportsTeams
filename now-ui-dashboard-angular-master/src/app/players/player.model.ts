

export class Player{
  public id:number;
   public name:string;
   public picture:string;
   public number:number;
   public dateOfBirth:Date;
   public countryId:number;
   public country:string;
   public placeOfBirth:string;
   public age:number;
   public marketValue:number;
   public position:string;
   public team:string;
   public teamId:number;
   public joined:Date;
   public constractExpDate:Date;

   constructor(
       id:number,
       name:string, picture:string,number:number, Country:string,countryID:number, dateofBirth:Date, placeOfBirth:string,
        age:number,marketValue:number,position:string,team:string,teamId:number,joined:Date, constractExpDate:Date){

       this.id=id;
        this.name=name;
        this.picture=picture;
        this.number=number;
        this.countryId=countryID;
        this.country=Country;
        this.dateOfBirth=dateofBirth;
        this.placeOfBirth=placeOfBirth;
        this.age=age;
        this.marketValue=marketValue;
        this.position=position;
        this.team=team;
        this.teamId=teamId;
        this.joined=joined;
        this.constractExpDate=constractExpDate;
   }
}
