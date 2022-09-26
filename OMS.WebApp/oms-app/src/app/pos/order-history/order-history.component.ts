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

@Component({
  selector: 'app-order-history',
  templateUrl: './order-history.component.html',
  styleUrls: ['./order-history.component.scss']
})
export class OrderHistoryComponent implements AfterViewInit  {  
  constructor() { }

  ngOnInit(): void {
  }
  
  ngAfterViewInit() {
  }



}
