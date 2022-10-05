import { AfterViewInit, Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';
import { OutletOrderListResponse } from '../../models/outlet-order-list-response';
import { OrderReportRequest } from '../../models/order-report-request';
import { OrderReportService } from '../../services/order-report.service';
import { MatSort, Sort } from '@angular/material/sort';
import { LiveAnnouncer } from '@angular/cdk/a11y';
import { DialogService } from '../../services/dialog.service';
import { OrderService } from '../../services/order.service';
import { OrderUpdateRequest } from 'src/app/models/order-update-request';
import { ReasonComponent } from 'src/app/dialogs/reason/reason.component';
import { MatDialog } from '@angular/material/dialog';

@Component({
  selector: 'app-new-order',
  templateUrl: './new-order.component.html',
  styleUrls: ['./new-order.component.scss']
})
export class NewOrderComponent implements AfterViewInit  {  
  displayedColumns: string[] = ['orderBy','orderDate','orderSource', 'orderType', 'orderNo','orderStatus','orderAmount','paymentMode','reason', 'actions'];
  dataSource!: MatTableDataSource<OutletOrderListResponse>;
  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;
  startDate!: string;
  endDate!: string;
  outletOrderListResponse!: OutletOrderListResponse[];
  constructor(public dialog: MatDialog, private dialogService: DialogService, private _liveAnnouncer: LiveAnnouncer, 
    private orderReportService: OrderReportService, private orderService: OrderService) { }

  ngOnInit(): void { }
  
  ngAfterViewInit() { }

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

  cancelOrder(element: any): void{
    const orderUpdateRequest: OrderUpdateRequest ={
      orderId: element.orderId,
      outletId:0,
      comment: '',
    }



    const dialogRefDis = this.dialog.open(ReasonComponent, {
      width: '350px',
      data: orderUpdateRequest,
      disableClose: true,
    });

    dialogRefDis.afterClosed().subscribe(result => {
      console.log('The dialog was closed');      
      let orderDiscount: OrderUpdateRequest = result;
      if(result){
        //this.removeAllFromCart();
        //this.resetPayment();        
        this.orderService.cancelOrder(orderUpdateRequest).subscribe((response) =>{
          //console.log(response.orderId);
         // this.orderProcessing = false;
          if(response && response.isSuccess)
          {
            element.orderStatus = 'Cancelled';
            element.reason = orderUpdateRequest.comment;
          }
          else{
            this.dialogService.alertDialog({
              title: 'Failed!',
              message: response.message,
              confirmText: 'Ok',
              cancelText: '',
            }).subscribe(result => {     
        
              });
          }
    
          
         },
         error => {
          console.log(error)
          this.dialogService.alertDialog({
            title: 'Failed!',
            message: error,
            confirmText: 'Ok',
            cancelText: '',
          }).subscribe(result => {     
      
            });
            //this.orderProcessing = false;
         });
        
      } 
    });




  }

}
