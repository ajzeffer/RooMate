import { Component, OnInit, Input } from '@angular/core';
import { IRoom } from 'src/app/contracts/IRoom';

@Component({
  selector: 'app-room-list',
  templateUrl: './room-list.component.html',
  styleUrls: ['./room-list.component.scss']
})
export class RoomListComponent implements OnInit {
  @Input() rooms: IRoom[]; 
  
  constructor() { }

  ngOnInit() {
  }

}
