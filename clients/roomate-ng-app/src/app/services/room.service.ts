import { Injectable } from '@angular/core';
import { IRoom } from '../contracts/IRoom';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class RoomService {

  constructor(public httpClient: HttpClient) { }

  public getRoom(id: string) : Promise<IRoom>{

    return Promise.resolve({
      roomId : "room-reaction@drivetime.com", 
      roomName: "room-reaction",
      isAvailableNow: true
    } as IRoom );
  }


  public getRooms(): Promise<IRoom[]>{


    return new Promise((res,rej) => {
      this.httpClient.get('https://localhost:5001/api/rooms').subscribe(res);
    });
  }
}
