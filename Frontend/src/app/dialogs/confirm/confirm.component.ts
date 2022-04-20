import { Component, OnInit } from '@angular/core';
import { AltertyfyService } from 'src/app/services/altertyfy.service';

@Component({
  selector: 'app-confirm',
  templateUrl: './confirm.component.html',
  styleUrls: ['./confirm.component.css']
})
export class ConfirmComponent implements OnInit {

  constructor(private alertify:AltertyfyService ) { }

  ngOnInit(): void {
  }
  onLogout() {
    localStorage.removeItem('token');
    this.alertify.warning('You are successfully logged out!~');
  }
}
