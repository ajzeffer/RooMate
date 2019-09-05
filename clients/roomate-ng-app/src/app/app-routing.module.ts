import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeContainerComponent } from './containers/home-container/home-container.component';
import { RoomContainerComponent } from './containers/room-container/room-container.component';


const routes: Routes = [
  { path: '', component: HomeContainerComponent },
  { path: 'room', component: RoomContainerComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
