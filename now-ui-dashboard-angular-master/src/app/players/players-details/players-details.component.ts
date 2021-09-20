import { DatePipe } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Player } from '../player.model';
import { PlayersService } from '../players.service';

@Component({
  selector: 'app-players-details',
  templateUrl: './players-details.component.html',
  styleUrls: ['./players-details.component.css']
})
export class PlayersDetailsComponent implements OnInit {
  player: Player;
  id: number;
  datumRodjenja:string;
  datumPridruzivanja:string;
  datumIstekaUgovora:string;
  constructor(private playerService: PlayersService,
    private route: ActivatedRoute,
    private router: Router,
    public datePipe:DatePipe) { }

  ngOnInit(): void {

    this.id = Number(this.route.snapshot.paramMap.get('id'));

    this.playerService.GetPlayerById(this.id).subscribe(
      (res: Player) => {
        this.player = res;
        console.log(res);
      this.datumRodjenja= this.datePipe.transform(this.player.dateOfBirth, 'dd/MM/yyyy');
       this.datumPridruzivanja=this.datePipe.transform(this.player.joined, 'dd/MM/yyyy');
       this.datumIstekaUgovora= this.datePipe.transform(this.player.constractExpDate, 'dd/MM/yyyy');

      });




  }

 onEditPlayer() {
    this.router.navigate(['edit'], { relativeTo: this.route });
  }
  onDeletePlayer(id:number) {
   this.playerService.DeletePlayer(this.id).subscribe(
    ( res:Player)=>{
       this.player=res;
     }

   );
   this.router.navigate(['/players']);


  }

}

