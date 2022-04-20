import { Component, OnInit } from '@angular/core';
import { DialogService } from '../services/dialog.service';

@Component({
  selector: 'app-nav-bar',
  templateUrl: './nav-bar.component.html',
  styleUrls: ['./nav-bar.component.css'],
})
export class NavBarComponent implements OnInit {
  loggedinUser: string;
  constructor(

    private dialogService: DialogService
  ) {}

  ngOnInit() {}
  loggedin() {
    this.loggedinUser = localStorage.getItem('token');
    return this.loggedinUser;
  }


  openDialog() {
    this.dialogService.confirmDialog();
  }
}
