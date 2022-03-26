import { Component } from "@angular/core";


@Component({
  selector:'aap-property-card',
  templateUrl:'property-card.component.html',
  styleUrls:['property-card.component.css']

})
export class PropertyCardComponent{

  Property : any ={
    "Name":"Prince Villa",
    "Id":1,
    "Type":"House",
    "Price":12000
  }

}
