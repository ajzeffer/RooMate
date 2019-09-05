import { Component, OnInit, Input } from '@angular/core';
import { IRoom } from 'src/app/contracts/IRoom';

@Component({
  selector: 'app-room',
  templateUrl: './room.component.html',
  styleUrls: ['./room.component.scss']
})
export class RoomComponent implements OnInit {
  @Input() room: IRoom;
  constructor() { }

  ngOnInit() {
    console.log(this.room);
  }

}
