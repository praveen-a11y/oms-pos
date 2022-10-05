import { AfterViewInit, Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';
import { OrderReportRequest } from '../../models/order-report-request';
import { OrderReportService } from '../../services/order-report.service';
import { OuteltItemSummaryResponse } from '../../models/outelt-item-summary-response';
import { MatSort, Sort } from '@angular/material/sort';
import { LiveAnnouncer } from '@angular/cdk/a11y';
import { OutletSaleDetailsResponse } from '../../models/outlet-sale-details-response';

import { OutletSaleSourceDetails } from "../../models/outlet-sale-source-details";
import { OutletSalePaymentDetails } from "../../models/outlet-sale-payment-details";



@Component({
  selector: 'app-order-report-sale',
  templateUrl: './order-report-sale.component.html',
  styleUrls: ['./order-report-sale.component.scss']
})
export class OrderReportSaleComponent implements AfterViewInit  {    
  saleSourceColumns: string[] = ['orderSource','netSale','itemAmount','discount','gst'];
  salePaymentColumns: string[] = ['paymentTypeName','netSales'];
  dataSourceSaleSource!: MatTableDataSource<OutletSaleSourceDetails>;
  dataSourceSalePayment!: MatTableDataSource<OutletSalePaymentDetails>;
  startDate!: string;
  endDate!: string;
  outletSaleDetailsResponse: OutletSaleDetailsResponse = { outletSaleDetails : [], outletSalePaymentDetails: [] };
  constructor(private orderReportService: OrderReportService) { }

  ngOnInit(): void {
  }
  
  ngAfterViewInit() {
   
  }

  public search(): void{
  const request:OrderReportRequest = { outletId : 1, fromDate: this.startDate, toDate: this.startDate};   
      this.orderReportService.getOuteltSaleDetails(request).subscribe( res => {
        this.outletSaleDetailsResponse = res;  
        this.dataSourceSaleSource = new MatTableDataSource<OutletSaleSourceDetails>(this.outletSaleDetailsResponse.outletSaleDetails);
        this.dataSourceSalePayment = new MatTableDataSource<OutletSalePaymentDetails>(this.outletSaleDetailsResponse.outletSalePaymentDetails);
      });

  }

  

}
