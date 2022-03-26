import { Component, Input } from "@angular/core";


@Component({
  selector:'aap-property-card',
  templateUrl:'property-card.component.html',
  styleUrls:['property-card.component.css']

})
export class PropertyCardComponent{

  @Input() property : any

}
