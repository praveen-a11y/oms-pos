export interface OuteltItemWiseOrderResponse{
    srNo: number,
    source: string,
    billNo: string,
    date: Date,
    category: string,
    item: string,
    qty: number,
    rate: number,
    itemAmount: number,
    discount: number,
    gst: number,
    totalAmount: number
}