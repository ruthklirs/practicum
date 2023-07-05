



import { Component, Input, OnInit } from '@angular/core';
import User from 'src/models/Person';
import { UserService } from '../person.service';

@Component({
  selector: 'app-guidelines',
  templateUrl: './guidelines.component.html',
  styleUrls: ['./guidelines.component.scss']
})
export class GuidelinesComponent implements OnInit{

  user:User=new User(0,"","","",new Date(), 0,"",[])

constructor(public userService:UserService){}
  ngOnInit(): void {
  }
  logOut(){

}

}
