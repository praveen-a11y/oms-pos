import { OrderRequestItem } from "./order-request-item";
import { OrderRequestPayment } from "./order-request-payment";

export interface OrderRequest{
    orderType: string,
    kot: string,
    customerName: string,
    customerMobile: string,
    customerAddress: string,
    discountPer: number,
    discountDesc: string,
    orderRequestItem: OrderRequestItem[],
    requestPaymentDetails: OrderRequestPayment[]

}