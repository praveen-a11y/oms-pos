import { AfterViewInit, Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';
import { OrderReportRequest } from '../../models/order-report-request';
import { OrderReportService } from '../../services/order-report.service';
import { OuteltItemSummaryResponse } from '../../models/outelt-item-summary-response';

@Component({
  selector: 'app-order-report-item-summary',
  templateUrl: './order-report-item-summary.component.html',
  styleUrls: ['./order-report-item-summary.component.scss']
})
export class OrderReportItemSummaryComponent implements AfterViewInit  {  
  displayedColumns: string[] = ['itemID','itemCategoryName','itemName','sale'];
  dataSource!: MatTableDataSource<OuteltItemSummaryResponse>;
  @ViewChild(MatPaginator) paginator!: MatPaginator;
  startDate!: string;
  endDate!: string;
  outeltItemSummaryResponse!: OuteltItemSummaryResponse[];
  constructor(private orderReportService: OrderReportService) { }

  ngOnInit(): void {
  }
  
  ngAfterViewInit() {
   
  }

  public search(): void{

    
const request:OrderReportRequest = { outletId : 1, fromDate: this.startDate, toDate: this.endDate};   
    this.orderReportService.getOuteltItemDetailSummary(request).subscribe( res => {
      this.outeltItemSummaryResponse = res;
      this.dataSource = new MatTableDataSource<OuteltItemSummaryResponse>(this.outeltItemSummaryResponse);
      this.dataSource.paginator = this.paginator;
    });

  }



}
