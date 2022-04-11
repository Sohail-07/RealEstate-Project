import { Component, OnInit } from '@angular/core';
import { AltertyfyService } from '../services/altertyfy.service';

@Component({
  selector: 'app-nav-bar',
  templateUrl: './nav-bar.component.html',
  styleUrls: ['./nav-bar.component.css']
})
export class NavBarComponent implements OnInit {

  loggedinUser: string;
  constructor(private alertify:AltertyfyService) { }

  ngOnInit() {
  }
  loggedin(){
    this.loggedinUser= localStorage.getItem('token');
    return this.loggedinUser;
  }
  onLogout(){
    localStorage.removeItem('token');
    this.alertify.warning('You are successfully logged out!~')
  }
}
