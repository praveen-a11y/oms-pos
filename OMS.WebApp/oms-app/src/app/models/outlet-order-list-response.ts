export interface OutletOrderListResponse{
    orderBy: string,
    orderDate: Date,
    orderSource: string,
    orderNo: number,
    orderStatus: string,
    orderAmount: number,
    paymentMode: string,
    reason: string
}