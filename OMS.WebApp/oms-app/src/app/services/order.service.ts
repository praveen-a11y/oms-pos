import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { catchError, map, Observable, throwError } from "rxjs";
import { environment } from "src/environments/environment";
import { Order } from "../models/order";
import { OrderRequest } from "../models/order-request";
import { OrderResponse } from "../models/order-response";
import { AccountService } from "./account.service";


@Injectable({
    providedIn: 'root'
  })  
  export class OrderService{

    constructor(
        private http: HttpClient,
        private accountService: AccountService
    ) {}
    
    public saveOrder(order : Order):  Observable<OrderResponse>{  
      
      const requestOrder: OrderRequest = { 
        orderType: order.orderType,
        kot: "0",
        customerName: order.customerName,
        customerMobile: order.customerMobile,
        customerAddress: order.customerAddress,
        discountPer: order.discountPercentage,
        discountDesc: order.discountReason,
        orderRequestItem: [],
        requestPaymentDetails: [],
       }
    
       order.orderItems.forEach(item => {
        requestOrder.orderRequestItem.push({
          itemID: Number(item.itemId),      
          quantity: item.qty,
        });
       }); 
       
       order.paymentInputs.forEach(item => {
        requestOrder.requestPaymentDetails.push({
          paymentTypeId: item.paymentTypeId,      
          amount: item.amountTendered,
        });
       });
    
    console.log(order);

      return this.http.post<OrderResponse>(`${environment.apiUrl}/order/save/`, requestOrder).
          pipe(
             map((data: OrderResponse) => {
               return data;
             }), catchError( error => {
               return throwError( 'Something went wrong!' );
             })
          )
      }
  }