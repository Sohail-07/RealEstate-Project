import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-property-detail',
  templateUrl: './property-detail.component.html',
  styleUrls: ['./property-detail.component.css']
})
export class PropertyDetailComponent implements OnInit {
public propertyId: any;
  constructor(private rout: ActivatedRoute, private router:Router) { }

  ngOnInit() {
    this.propertyId = +this.rout.snapshot.params['id'];

    this.rout.params.subscribe(
      (params)=>{
        this.propertyId=+params['id'];
      }
    )
  }
  onSelectNext()
  {
    this.propertyId += 1;
    this.router.navigate(['property-detail/', this.propertyId]);
  }
}
