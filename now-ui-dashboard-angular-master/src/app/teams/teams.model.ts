

export class Teams{
   public id:number;
    public name:string;
    public picture:string;
    public countryId:number;
    public country:string;
    public founded:number;
    public homeGround:string;
    public stadiumCapacity:number;
    public marketValue:number;
    public numberOfPlayers:number;
    public headCoach:string;
    public president:string;
    public league:string; 

    constructor(
        id:number, 
        name:string, picture:string, Country:string,countryID:number, founded:number, homeground:string,
         marketvalue:number,numberofplayers:number,coach:string,president:string,capacity:number,league:string){
        
        this.id=id;
         this.name=name;
         this.picture=picture;
         this.countryId=countryID;
         this.country=Country;
         this.founded=founded;
         this.homeGround=homeground;
         this.marketValue=marketvalue;
         this.numberOfPlayers=numberofplayers;
         this.headCoach=coach;
         this.president=president;
         this.stadiumCapacity=capacity;
         this.league=league;         
    }
}