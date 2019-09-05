import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { RoomListComponent } from './components/room-list/room-list.component';
import { RoomComponent } from './components/room/room.component';
import { HomeContainerComponent } from './containers/home-container/home-container.component';
import { RoomContainerComponent } from './containers/room-container/room-container.component';

@NgModule({
  declarations: [
    AppComponent,
    RoomListComponent,
    HomeContainerComponent,
    RoomContainerComponent,
    RoomComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule, 
    HttpClientModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
