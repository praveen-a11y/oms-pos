import { DatePipe } from "@angular/common";
import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { catchError, map, Observable, throwError } from "rxjs";
import { environment } from "src/environments/environment";
import { OrderReportRequest } from "../models/order-report-request";
import { OuteltItemSummaryResponse } from "../models/outelt-item-summary-response";
import { OuteltItemWiseOrderResponse } from "../models/outelt-itemWise-order-response";
import { OutletOrderListResponse } from "../models/outlet-order-list-response";
import { OutletSaleDetailsResponse } from "../models/outlet-sale-details-response";
import { AccountService } from "./account.service";

@Injectable({
    providedIn: 'root'
  })  
  export class OrderReportService{

    constructor(
        private http: HttpClient,
        private datePipe: DatePipe,
        private accountService: AccountService
    ) {}

    public getOutletOrderList(orderReportRequest: OrderReportRequest): Observable<OutletOrderListResponse[]> {   
        const outleId = this.accountService.getOutletId();
        orderReportRequest.outletId = outleId;
        orderReportRequest.fromDate = this.datePipe.transform(orderReportRequest.fromDate,'MM/dd/yyyy')!
            orderReportRequest.toDate = this.datePipe.transform(orderReportRequest.toDate,'MM/dd/yyyy')!
        return this.http.post<OutletOrderListResponse[]>(`${environment.apiUrl}/OrderReport/GetOutletOrderList`, orderReportRequest).
            pipe(
               map((data: OutletOrderListResponse[]) => {
                 return data;
               }), catchError( error => {
                 return throwError( 'Something went wrong!' );
               })
            )
        }
    
    public getOuteltItemWiseOrderDetail(orderReportRequest: OrderReportRequest): Observable<OuteltItemWiseOrderResponse[]> {   
        const outleId = this.accountService.getOutletId();
        orderReportRequest.outletId = outleId;
        orderReportRequest.fromDate = this.datePipe.transform(orderReportRequest.fromDate,'MM/dd/yyyy')!
            orderReportRequest.toDate = this.datePipe.transform(orderReportRequest.toDate,'MM/dd/yyyy')!
        return this.http.post<OuteltItemWiseOrderResponse[]>(`${environment.apiUrl}/OrderReport/GetOuteltItemWiseOrderDetail`, orderReportRequest).
            pipe(
               map((data: OuteltItemWiseOrderResponse[]) => {
                 return data;
               }), catchError( error => {
                 return throwError( 'Something went wrong!' );
               })
            )
        }

        public getOuteltItemDetailSummary(orderReportRequest: OrderReportRequest): Observable<OuteltItemSummaryResponse[]> {   
            const outleId = this.accountService.getOutletId();
            orderReportRequest.outletId = outleId;
            orderReportRequest.fromDate = this.datePipe.transform(orderReportRequest.fromDate,'MM/dd/yyyy')!
            orderReportRequest.toDate = this.datePipe.transform(orderReportRequest.toDate,'MM/dd/yyyy')!
            return this.http.post<OuteltItemSummaryResponse[]>(`${environment.apiUrl}/OrderReport/GetOuteltItemDetailSummary`, orderReportRequest).
                pipe(
                   map((data: OuteltItemSummaryResponse[]) => {
                     return data;
                   }), catchError( error => {
                     return throwError( 'Something went wrong!' );
                   })
                )
            }

        public getOuteltSaleDetails(orderReportRequest: OrderReportRequest): Observable<OutletSaleDetailsResponse> {   
            const outleId = this.accountService.getOutletId();
            orderReportRequest.outletId = outleId;
            orderReportRequest.fromDate = this.datePipe.transform(orderReportRequest.fromDate,'MM/dd/yyyy')!
            orderReportRequest.toDate = this.datePipe.transform(orderReportRequest.toDate,'MM/dd/yyyy')!
            return this.http.post<OutletSaleDetailsResponse>(`${environment.apiUrl}/OrderReport/GetOuteltSaleDetails`, orderReportRequest).
                pipe(
                   map((data: OutletSaleDetailsResponse) => {
                     return data;
                   }), catchError( error => {
                     return throwError( 'Something went wrong!' );
                   })
                )
            }

    
}