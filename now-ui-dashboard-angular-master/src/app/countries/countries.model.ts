
export class Countries{

    public id:number;
    public name:string;
    public abbreviation:string;
    public picture:string;
    public capital:string;
    public population: number;

    constructor(id:number,name:string,abbreviation:string, picture:string,capital:string,population:number){
        this.id=id;
        this.name=name;
        this.abbreviation=abbreviation;
        this.picture=picture;
        this.capital=capital;
        this.population=population;

    }
}