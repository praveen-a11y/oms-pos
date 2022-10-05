import { Injectable } from "@angular/core";
import { Item } from "../models/item";
import { OrderDiscount } from "../models/order-discount";

@Injectable({
    providedIn: 'root'
  })
  export class CartService {    
    constructor(){}

    public addToCart(currentCart: any, item: Item): void{
        const productExistInCart = currentCart.items
        .find((x: { itemID: number; }) => x.itemID === item.itemID);
    
        if(!productExistInCart){
      currentCart.items.push(
          {
            itemID: item.itemID,
            itemName: item.itemName,
            itemPrice: item.itemPrice,
            qty: 1,
            total: item.itemPrice,
            gstPer: item.taxPercent
          });
          this.calculateTotal(currentCart);
        }else{
          this.addQtyToCart(currentCart, item);
        }
        
    }
    
    public removeFromCart(currentCart: any, item: Item): void{
      const productExistInCart = currentCart.items
      .find((x: { itemID: number; }) => x.itemID === item.itemID);
    
      if (productExistInCart) {
          currentCart.items.splice(productExistInCart, 1);
      }
      this.calculateTotal(currentCart);
    }
    
    public removeAllFromCart(currentCart: any): void{
        debugger;
      currentCart = this.initCart(currentCart);
      this.calculateTotal(currentCart);
      return currentCart
    }
    
    public addQtyToCart(currentCart: any, item: Item): void{
        
        const productExistInCart = currentCart.items
      .find((x: { itemID: number; }) => x.itemID === item.itemID);
        productExistInCart.qty++; 
        productExistInCart.total = productExistInCart.qty * productExistInCart.itemPrice;
        this.calculateTotal(currentCart);
      }
    
      public removeQtyToCart(currentCart: any, item: Item): void{
        
        const productExistInCart = currentCart.items
      .find((x: { itemID: number; }) => x.itemID === item.itemID);
        if(productExistInCart.qty === 1)
        {
            this.removeFromCart(currentCart, productExistInCart);
        }
        else{
        productExistInCart.qty--; 
        productExistInCart.total = productExistInCart.qty * productExistInCart.itemPrice;
        }
    
        this.calculateTotal(currentCart);
      }

      onHoldCartId = 1;
      public onholdCart(currentCart: any, onHoldCarts: any): any{
        debugger;
            onHoldCarts.push({ id: ++this.onHoldCartId, cart: currentCart});    
            currentCart = this.removeAllFromCart(currentCart);
            return currentCart;
      }
    
      public onHoldToCurrentCart(currentCart: any, onHoldCarts: any, onHoldCartId:  number): any{
        debugger;
         const onHoldCart = onHoldCarts.find((x: { id: any; }) => x.id === onHoldCartId);
         currentCart = onHoldCart.cart;
    
         if (onHoldCart) {
          onHoldCarts.splice(onHoldCart, 1);
      }
      return currentCart;
      }

      
      private calculateTotal(currentCart: any) {
        let total = 0;
        let cartitems = 0;
        let itemsGstPer = 0;
        let gstPer = 0;
        let gstAmount = 0;
        // Multiply item price by item quantity, add to total
        currentCart.items.forEach(function (x: { itemPrice: number; qty: number; gstPer: number; }) {
          total += (x.itemPrice * x.qty);
          cartitems += x.qty;
          itemsGstPer += x.gstPer; 
        });
        
        gstPer = itemsGstPer/currentCart.items.length;
        currentCart.itemSummary.gstPer = gstPer;
        
    
        currentCart.itemSummary.cartSubTotal = total;
        currentCart.itemSummary.cartTotal = total - currentCart.itemSummary.discount;
        if(currentCart.itemSummary.discountPercentage){
            currentCart.itemSummary.discount = (currentCart.itemSummary.cartSubTotal/100)*currentCart.itemSummary.discountPercentage;   
        }
    
        gstAmount = this.calculateGST(currentCart);
    
      }

      private calculateGST(currentCart: any): number{
        let gstAmount: number = 0;
        gstAmount = (currentCart.itemSummary.cartTotal/100)*currentCart.itemSummary.gstPer;
        currentCart.itemSummary.gst = gstAmount;
        currentCart.itemSummary.cartTotal = currentCart.itemSummary.cartTotal + gstAmount;
        return gstAmount;
      }

      public calculateDiscount(currentCart: any, orderDiscount: OrderDiscount): void{
        currentCart.itemSummary.discountReason = '';         

        if(orderDiscount.inPercentage > 100){
          currentCart.itemSummary.discount = 0;
          currentCart.itemSummary.discountPercentage = 0;
          currentCart.itemSummary.cartTotal = 0;
        }else{
          currentCart.itemSummary.discountReason = orderDiscount.discountReason; 
          currentCart.itemSummary.discount = orderDiscount.inAmount;
          currentCart.itemSummary.discountPercentage = orderDiscount.inPercentage;
          currentCart.itemSummary.cartTotal = currentCart.itemSummary.cartSubTotal - orderDiscount.inAmount;
        }
      
        this.calculateGST(currentCart);
      }
      
      public deleteDiscount(currentCart: any): void{  
    
        let orderDiscount: OrderDiscount={
          inPercentage: 0,
          inAmount: 0,
          amount: currentCart.itemSummary.cartSubTotal,
          discountReason: ''
        };
      
        this.calculateDiscount(currentCart, orderDiscount);
        
      }

      public initCart(currentCart: any): void{
        currentCart = { itemSummary : {
          cartSubTotal: 0,
          discount: 0,
          discountPercentage: 0,
          gst: 0,
          cartTotal: 0,
      },
      orderType: 'T',
      items: []
    }
    return currentCart;
      }

      public resetCarttest(currentCart: any): void{        
        currentCart.itemSummary.cartSubTotal = 0;
        currentCart.itemSummary.discount = 0;
        currentCart.itemSummary.discountPercentage = 0;
        currentCart.itemSummary.gst= 0;
        currentCart.itemSummary.cartTotal= 0;      
        currentCart.items = [];    
      }

  }