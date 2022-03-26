import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-property-list',
  templateUrl: './property-list.component.html',
  styleUrls: ['./property-list.component.css'],
})
export class PropertyListComponent implements OnInit {
  properties: Array<any> = [
    {
      Id: 1,
      Name: 'Prince Villa',
      Type: 'House',
      Price: 12000,
    },
    {
      Id: 2,
      Name: 'Sohail Villa',
      Type: 'House',
      Price: 18000,
    },
    {
      Id: 3,
      Name: 'Faizan Villa',
      Type: 'House',
      Price: 18000,
    },
    {
      Id: 4,
      Name: 'Zeeshan Villa',
      Type: 'House',
      Price: 18000,
    },
    {
      Id: 5,
      Name: 'Shoaib Villa',
      Type: 'House',
      Price: 18000,
    },
    {
      Id: 6,
      Name: 'Ameen Villa',
      Type: 'House',
      Price: 18000,
    },
  ]

  constructor() {}

  ngOnInit() {}
}
