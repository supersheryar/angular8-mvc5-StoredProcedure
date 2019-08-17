import { Component, OnInit } from '@angular/core';
import { RestService } from './rest.service';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  orderproducts: any = [];

  constructor(public rest: RestService) { }

  ngOnInit(): void {
    this.getOrderProducts();
  }

  getOrderProducts() {
    this.orderproducts = [];
    this.rest.getOrderProducts().subscribe((data: {}) => {
      this.orderproducts = data;
    })
  }
}
