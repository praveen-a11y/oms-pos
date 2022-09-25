import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { catchError, map, Observable, throwError } from "rxjs";
import { environment } from "src/environments/environment";
import { OrderReportRequest } from "../models/order-report-request";
import { OuteltItemSummaryResponse } from "../models/outelt-item-summary-response";
import { OuteltItemWiseOrderResponse } from "../models/outelt-itemWise-order-response";
import { OutletOrderListResponse } from "../models/outlet-order-list-response";
import { AccountService } from "./account.service";

@Injectable({
    providedIn: 'root'
  })  
  export class OrderReportService{

    constructor(
        private http: HttpClient,
        private accountService: AccountService
    ) {}

    public getOutletOrderList(orderReportRequest: OrderReportRequest): Observable<OutletOrderListResponse[]> {   
        const outleId = this.accountService.getOutletId();
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
            return this.http.post<OuteltItemSummaryResponse[]>(`${environment.apiUrl}/OrderReport/GetOuteltItemDetailSummary`, orderReportRequest).
                pipe(
                   map((data: OuteltItemSummaryResponse[]) => {
                     return data;
                   }), catchError( error => {
                     return throwError( 'Something went wrong!' );
                   })
                )
            }



    
}