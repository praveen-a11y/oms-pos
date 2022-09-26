import { AfterViewInit, Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';
import { OrderReportRequest } from '../../models/order-report-request';
import { OrderReportService } from '../../services/order-report.service';
import { OuteltItemWiseOrderResponse } from '../../models/outelt-itemWise-order-response';
import { LiveAnnouncer } from '@angular/cdk/a11y';
import { MatSort, Sort } from '@angular/material/sort';


@Component({
  selector: 'app-order-report-item-wise',
  templateUrl: './order-report-item-wise.component.html',
  styleUrls: ['./order-report-item-wise.component.scss']
})
export class OrderReportItemWiseComponent implements AfterViewInit  {  
  displayedColumns: string[] = [ 'srNo', 'source', 'billNo', 'date', 'category', 'item', 'qty', 'rate', 'itemAmount', 'discount', 'gst', 'totalAmount'];
  dataSource!: MatTableDataSource<OuteltItemWiseOrderResponse>;
  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;
  startDate!: string;
  endDate!: string;
  outeltItemWiseOrderResponse!: OuteltItemWiseOrderResponse[];
  constructor(private _liveAnnouncer: LiveAnnouncer, private orderReportService: OrderReportService) { }

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
