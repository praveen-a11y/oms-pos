export interface OutletOrderListResponse{
    orderId: number,
    orderBy: string,
    orderDate: Date,
    orderSource: string,
    orderType: string,
    orderNo: number,
    orderStatus: string,
    orderAmount: number,
    paymentMode: string,
    reason: string
}