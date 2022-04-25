import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { IPropertyBase } from 'src/app/model/ipropertyBase';
import { HousingService } from 'src/app/services/housing.service';

@Component({
  selector: 'app-property-list',
  templateUrl: './property-list.component.html',
  styleUrls: ['./property-list.component.css'],
})
export class PropertyListComponent implements OnInit {

  SellRent = 1;
  properties: IPropertyBase[];
  today= new Date();
  city='';
  searchCity ='';
  sortByParam = '';
  sortDirection = 'asc';

  constructor(private route:ActivatedRoute, private housingService: HousingService) {}

  ngOnInit():void {
    if(this.route.snapshot.url.toString()){
      this.SellRent = 2;
    }
    this.housingService.getAllProperties(this.SellRent).subscribe(
        data=>{
        this.properties=data;
        console.log(data);
      }

    );
  }
  onCityFilter(){
    this.searchCity = this.city;
  }

  onCityFilterClear(){
    this.searchCity='';
    this.city='';
  }

  onSortDirection(){
    if(this.sortDirection === 'desc'){
      this.sortDirection= 'asc';
    }else{
      this.sortDirection= 'desc';
    }
  }
}
