import { AfterViewInit, Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';
import { OrderReportRequest } from '../../models/order-report-request';
import { OrderReportService } from '../../services/order-report.service';
import { OuteltItemWiseOrderResponse } from '../../models/outelt-itemWise-order-response';


@Component({
  selector: 'app-order-report-item-wise',
  templateUrl: './order-report-item-wise.component.html',
  styleUrls: ['./order-report-item-wise.component.scss']
})
export class OrderReportItemWiseComponent implements AfterViewInit  {  
  displayedColumns: string[] = [ 'srNo', 'source', 'billNo', 'date', 'category', 'item', 'qty', 'rate', 'itemAmount', 'discount', 'gst', 'totalAmount'];
  dataSource!: MatTableDataSource<OuteltItemWiseOrderResponse>;
  @ViewChild(MatPaginator) paginator!: MatPaginator;
  startDate!: string;
  endDate!: string;
  outeltItemWiseOrderResponse!: OuteltItemWiseOrderResponse[];
  constructor(private orderReportService: OrderReportService) { }

  ngOnInit(): void {
  }
  
  ngAfterViewInit() {
   
  }

  public search(): void{

    
const request:OrderReportRequest = { outletId : 1, fromDate: this.startDate, toDate: this.endDate};   
    this.orderReportService.getOuteltItemWiseOrderDetail(request).subscribe( res => {
      this.outeltItemWiseOrderResponse = res;
      this.dataSource = new MatTableDataSource<OuteltItemWiseOrderResponse>(this.outeltItemWiseOrderResponse);
      this.dataSource.paginator = this.paginator;
    });

  }



}
