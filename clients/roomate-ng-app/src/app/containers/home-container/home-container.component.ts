import { Component, OnInit } from '@angular/core';
import { RoomService } from 'src/app/services/room.service';
import { IRoom } from 'src/app/contracts/IRoom';

@Component({
  selector: 'app-home-container',
  templateUrl: './home-container.component.html',
  styleUrls: ['./home-container.component.scss']
})
export class HomeContainerComponent implements OnInit {
  public rooms: IRoom[]; 
  constructor(public roomService: RoomService) { }

  async ngOnInit() {
    this.rooms = await this.roomService.getRooms(); 
  }

}
