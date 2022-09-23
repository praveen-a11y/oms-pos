import { OrderItem } from "./order-item";

export interface Order{
    orderType: string,
    orderId: number,
    orderNo: string,
    billNo: string,
    subTotal: number,
    quantityTotal: number,
    discount: number,
    discountPercentage: number,
    discountReason: string,
    gstPer: number,
    gstAmount: number,    
    roundOff: number,
    total: number,
    customerName: string,
    customerMobile: string,
    customerAddress: string,    
    orderItems: OrderItem[],
    paymentInputs: any[]
}