import { AfterViewInit, Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';
import { OutletOrderListResponse } from '../../models/outlet-order-list-response';
import { OrderReportRequest } from '../../models/order-report-request';
import { OrderReportService } from '../../services/order-report.service';
import { OuteltItemWiseOrderResponse } from '../../models/outelt-itemWise-order-response';
import { OuteltItemSummaryResponse } from '../../models/outelt-item-summary-response';
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
  outletOrderListResponse!: OutletOrderListResponse[];
  outeltItemWiseOrderResponse!: OuteltItemWiseOrderResponse[];
  outeltItemSummaryResponse!: OuteltItemSummaryResponse[];
  constructor(private orderReportService: OrderReportService) { }

  ngOnInit(): void {
const request:OrderReportRequest = { outletId : 1, fromDate: '01/01/2022', toDate: '11/11/2022'};

    this.orderReportService.getOutletOrderList(request).subscribe( res => {
      this.outletOrderListResponse = res;
    });

    this.orderReportService.getOuteltItemWiseOrderDetail(request).subscribe( res => {
      this.outeltItemWiseOrderResponse = res;
    });

    this.orderReportService.getOuteltItemDetailSummary(request).subscribe( res => {
      this.outeltItemSummaryResponse = res;
    });


  }
  
  ngAfterViewInit() {
    this.dataSource.paginator = this.paginator;
  }



}
