import { Component, OnInit, ViewChild } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Router } from '@angular/router';
import { TabsetComponent } from 'ngx-bootstrap/tabs';
import { IPropertyBase } from 'src/app/model/ipropertyBase';

@Component({
  selector: 'app-add-property',
  templateUrl: './add-property.component.html',
  styleUrls: ['./add-property.component.css']
})
export class AddPropertyComponent implements OnInit {
  @ViewChild('formTabs') formTabs: TabsetComponent;

  numberofRoom:Array<string>=['1','2','3','4'];
  propertyType:Array<string>=['House','Apartment','Duplex'];
  furnishType:Array<string>=['Fully','Semi','Unfurnished'];
  mainEntrence:Array<string>=['East','West','South','North'];

  propertyView :IPropertyBase = {
    Id:null,
    Name:'',
    Price:null,
    SellRent:null,
    PType:null,
    FType:null,
    BHK:null,
    BuiltArea:null,
    City:null,
    RTM:null

  };
  addPropertyForm: any;

  constructor(private router: Router) { }

  ngOnInit() {
  }

  onBack(){
      this.router.navigate(['/']);
  }
  onSubmit(){
    console.log('Congrats your form submitted.');
    console.log(this.addPropertyForm);
  }
  selectTab(tabId: number) {

      this.formTabs.tabs[tabId].active = true;

  }
}
