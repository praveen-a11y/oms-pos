import { AfterViewInit, Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';
import { OutletOrderListResponse } from '../../models/outlet-order-list-response';
import { OrderReportRequest } from '../../models/order-report-request';
import { OrderReportService } from '../../services/order-report.service';
import { MatSort, Sort } from '@angular/material/sort';
import { LiveAnnouncer } from '@angular/cdk/a11y';

@Component({
  selector: 'app-order-report',
  templateUrl: './order-report.component.html',
  styleUrls: ['./order-report.component.scss']
})
export class OrderReportComponent implements AfterViewInit  {  
  displayedColumns: string[] = ['orderBy','orderDate','orderSource','orderNo','orderStatus','orderAmount','paymentMode','reason'];
  dataSource!: MatTableDataSource<OutletOrderListResponse>;
  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;
  startDate!: string;
  endDate!: string;
  outletOrderListResponse!: OutletOrderListResponse[];
  constructor(private _liveAnnouncer: LiveAnnouncer, private orderReportService: OrderReportService) { }

  ngOnInit(): void {
const request:OrderReportRequest = { outletId : 1, fromDate: '01/01/2022', toDate: '11/11/2022'};



  }
  
  ngAfterViewInit() {
   
  }

  public search(): void{

    
const request:OrderReportRequest = { outletId : 1, fromDate: this.startDate, toDate: this.endDate};   
    this.orderReportService.getOutletOrderList(request).subscribe( res => {
      this.outletOrderListResponse = res;
      this.dataSource = new MatTableDataSource<OutletOrderListResponse>(this.outletOrderListResponse);
      this.dataSource.paginator = this.paginator;
      this.dataSource.sort = this.sort;
    });

  }

  /** Announce the change in sort state for assistive technology. */
  announceSortChange(sortState: Sort) {
    // This example uses English messages. If your application supports
    // multiple language, you would internationalize these strings.
    // Furthermore, you can customize the message to add additional
    // details about the values being sorted.
    if (sortState.direction) {
      this._liveAnnouncer.announce(`Sorted ${sortState.direction}ending`);
    } else {
      this._liveAnnouncer.announce('Sorting cleared');
    }
  }

}
