import { AfterViewInit, Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';
export interface PeriodicElement {
  orderNo: string;
  orderSource: string;
  price: number;
  quantity: number;
  amount: number;
}

const ELEMENT_DATA: PeriodicElement[] = [
  {orderNo: '1001', orderSource: 'zomato', price: 250, quantity: 2 , amount: 500},
  {orderNo: '1002', orderSource: 'zomato', price: 250, quantity: 2 , amount: 500},
  {orderNo: '1003', orderSource: 'swiggy', price: 250, quantity: 2 , amount: 500},
  {orderNo: '1004', orderSource: 'zomato', price: 250, quantity: 2 , amount: 500},
  {orderNo: '1005', orderSource: 'swiggy', price: 250, quantity: 2 , amount: 500},

  {orderNo: '1006', orderSource: 'zomato', price: 250, quantity: 2 , amount: 500},
  {orderNo: '1007', orderSource: 'zomato', price: 250, quantity: 2 , amount: 500},
  {orderNo: '1008', orderSource: 'swiggy', price: 250, quantity: 2 , amount: 500},
  {orderNo: '1009', orderSource: 'zomato', price: 250, quantity: 2 , amount: 500},
  {orderNo: '1010', orderSource: 'swiggy', price: 250, quantity: 2 , amount: 500},

  {orderNo: '1006', orderSource: 'zomato', price: 250, quantity: 2 , amount: 500},
  {orderNo: '1007', orderSource: 'zomato', price: 250, quantity: 2 , amount: 500},
  {orderNo: '1008', orderSource: 'swiggy', price: 250, quantity: 2 , amount: 500},
  {orderNo: '1009', orderSource: 'zomato', price: 250, quantity: 2 , amount: 500},
  {orderNo: '1010', orderSource: 'swiggy', price: 250, quantity: 2 , amount: 500},
  
];
@Component({
  selector: 'app-order-history',
  templateUrl: './order-history.component.html',
  styleUrls: ['./order-history.component.scss']
})
export class OrderHistoryComponent implements AfterViewInit  {  
  displayedColumns: string[] = ['orderNo', 'orderSource', 'price', 'quantity', 'amount', 'action'];
  dataSource = new MatTableDataSource<PeriodicElement>(ELEMENT_DATA);
  @ViewChild(MatPaginator) paginator!: MatPaginator;
  constructor() { }

  ngOnInit(): void {
  }
  
  ngAfterViewInit() {
    this.dataSource.paginator = this.paginator;
  }

}
