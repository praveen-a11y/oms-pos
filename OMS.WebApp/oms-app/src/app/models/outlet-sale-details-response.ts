import { OutletSaleSourceDetails } from "./outlet-sale-source-details";
import { OutletSalePaymentDetails } from "./outlet-sale-payment-details";

export interface OutletSaleDetailsResponse{
    outletSaleDetails: OutletSaleSourceDetails[],
    outletSalePaymentDetails: OutletSalePaymentDetails[] 
}


