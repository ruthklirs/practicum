import { Component, OnDestroy, OnInit,ViewChild } from '@angular/core';
import { UserService } from './person.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent  implements OnInit{
  title = 'testProjectClient';
  constructor(public userService:UserService){}
 

  ngOnInit(): void {
  }
  logOut(){

  }


}
