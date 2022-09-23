import { Component, Inject, OnInit } from '@angular/core';
import {MatDialog, MatDialogRef, MAT_DIALOG_DATA} from '@angular/material/dialog';
import {ModalDismissReasons, NgbModal} from '@ng-bootstrap/ng-bootstrap';
import { CategoryItem } from '../../models/category-item';
import { PaymentInput } from '../../models/payment-input';
import { Item } from '../../models/item';
import { DialogService } from '../../services/dialog.service';
import { ItemService } from '../../services/item.service';
import { AddCustomerComponent } from '../add-customer/add-customer.component';
import { BillPopupComponent } from '../bill-popup/bill-popup.component';
import { CartService } from '../../services/cart.service';
import { OrderDiscount } from '../../models/order-discount';
import { DiscountComponent } from '../discount/discount.component';
import { OrderService } from '../../services/order.service';
import { Order } from '../../models/order';
import { CartTabEnum } from '../../models/cart-tab-enum';

@Component({
  selector: 'app-sale',
  templateUrl: './sale.component.html',
  styleUrls: ['./sale.component.scss']
})
export class SaleComponent implements OnInit {
categoryItem: CategoryItem[] = [];
closeResult: string = '';
currentOrder!: Order;
currentCart: any;
onHoldCarts : any = [];
paymentModes: any[] = [{ paymentTypeId: '1', paymentType: 'Cash' },{ paymentTypeId: '8', paymentType: 'Card' } ,{ paymentTypeId: '3', paymentType: 'Online' }];
customerDetails: any = { name: '', mobile: '', address: ''};
paymentInput: PaymentInput = {balanceDue: 0, amountTendered: 0, paymentModeId: '1' };
paymentInputs: any[] = [];
showConfirmBlock = false;
showPosMain = true;
orderProcessing = false;
cartTabIndex : CartTabEnum = CartTabEnum.New_Cart;
filterItem!: string;
  constructor(public dialog: MatDialog, private modalService: NgbModal, private dialogService: DialogService,
    private itemService: ItemService, private cartService: CartService, private orderService: OrderService){ }

  ngOnInit(): void { 
    this.currentCart = this.cartService.initCart(this.currentCart);
    this.getItems();   
    this.setCartTab(CartTabEnum.New_Cart);     
  }

  setCartTab(tab : CartTabEnum){
    this.cartTabIndex = tab; 
  }
  
  getItems(): void{
    this.itemService.getItems().subscribe(x => {
      debugger;
      this.categoryItem = x; 
    } );
  }
  
  addToCart(item: Item): void{    
    this.cartService.addToCart(this.currentCart, item);    
}

removeFromCart(item: Item): void{  
  this.cartService.removeFromCart(this.currentCart, item);
}

removeAllFromCart(): void{
  this.currentCart = this.cartService.removeAllFromCart(this.currentCart);
}

  addQtyToCart(item: Item): void{
    this.cartService.addQtyToCart(this.currentCart, item);
  }

  removeQtyToCart(item: any): void{
    this.cartService.removeQtyToCart(this.currentCart, item);
  }

  cancelOrder(){
    this.dialogService.confirmDialog({
      title: 'Cancel Order',
      message: 'Would you like to cancel order?',
      confirmText: 'Yes',
      cancelText: 'No',
    }).subscribe(result => {
  
      if(result){
        this.removeAllFromCart();
        this.resetPayment();
      } 

      });
      
  }

  modifyOrdert(): void{
    this.resetPayment();
  }

  cartTabClick(tab: any) {
    if(tab.index == 1)
    {
        if(this.cartTabIndex === CartTabEnum.OnHold_Cart){
          this.setCartTab(CartTabEnum.New_Cart);
        } else{
          this.setCartTab(CartTabEnum.OnHold_Cart);
        }
    } else{
      this.setCartTab(CartTabEnum.New_Cart);
    }
  }

  resetPayment(): void{
    this.showConfirmBlock = false;
    this.paymentInputs = [];
    this.paymentInput = {
      balanceDue: 0,
      amountTendered: 0,
      paymentModeId: '1'
     }
  }
  onHoldCartId = 1;
  onholdCart(): void{  
    this.dialogService.confirmDialog({
      title: 'Onhold Order',
      message: 'Would you like to onhold order?',
      confirmText: 'Yes',
      cancelText: 'No',
    }).subscribe(result => {
  
      if(result){
        this.currentCart = this.cartService.onholdCart(this.currentCart, this.onHoldCarts);
      } 
           
      });

  }

  onHoldToCurrentCart(onHoldCartId:  number): void{  
    this.currentCart = this.cartService.onHoldToCurrentCart(this.currentCart, this.onHoldCarts, onHoldCartId);
    debugger;
   
    this.setCartTab(CartTabEnum.New_Cart);
  }

  gotoPayment(): void{
    if(!this.currentCart.itemSummary.cartTotal){
      this.dialogService.alertDialog({
        title: 'No item!',
        message: 'Please add item to process.',
        confirmText: 'Ok',
        cancelText: '',
      }).subscribe(result => {     
  
        });
    } 
    else {
    this.showConfirmBlock = true;    
    this.paymentInput = {
      balanceDue: parseFloat(this.currentCart.itemSummary.cartTotal.toFixed(2)),
      amountTendered: parseFloat(this.currentCart.itemSummary.cartTotal.toFixed(2)),
      paymentModeId: '1'
     }
    }
  }

  confirmOrder(): void{
    if(this.paymentInput.balanceDue === 0){
      this.orderProcessing = true;
    this.saveOrder();
    
    
    }else{      
      this.dialogService.alertDialog({
        title: 'Oops!!',
        message: 'The payment is pending, can not process.',
        confirmText: 'Ok',
        cancelText: '',
      }).subscribe(result => {     
  
        });

      
    }
  }

  private saveOrder(): void{

  this.currentOrder = {
    orderType: this.currentCart.orderType,
    orderId: 1,
    orderNo: '',
    billNo: '',
    quantityTotal: 0,
    subTotal: this.currentCart.itemSummary.cartSubTotal,
    discount: this.currentCart.itemSummary.discount,
    discountPercentage: this.currentCart.itemSummary.discountPercentage,
    discountReason: !this.currentCart.itemSummary.discountReason? '': this.currentCart.itemSummary.discountReason,
    gstPer: this.currentCart.itemSummary.gstPer,
    gstAmount: this.currentCart.itemSummary.gst,    
    roundOff: 0,
    total: this.currentCart.itemSummary.cartTotal,
    customerName: this.customerDetails.name,
    customerMobile: this.customerDetails.mobile,
    customerAddress: this.customerDetails.address,
    orderItems: [],
    paymentInputs: this.paymentInputs

  }



  this.currentCart.items.forEach((item: { itemID: any; itemName: any; itemPrice: any; qty: any; gstPer: any; }) => {
    this.currentOrder.orderItems.push({
      orderItemId: '',
      itemId: item.itemID,
      itemName: item.itemName,
      itemPrice: item.itemPrice,
      qty: item.qty,
      gstPer: item.gstPer,
    });
      qty: item.qty,
      this.currentOrder.quantityTotal += item.qty;
   }); 

    this.orderService.saveOrder(this.currentOrder).subscribe((response) =>{
      //console.log(response.orderId);
      this.orderProcessing = false;
      if(response && response.orderId !== '')
      {
        this.currentOrder.billNo = response.billNumber;
        this.currentOrder.orderId = Number(response.orderId);
        this.showPosMain = false;
        this.removeAllFromCart();
        this.resetPayment();
      }
      else{
        this.dialogService.alertDialog({
          title: 'Failed!',
          message: 'Something went wrong.',
          confirmText: 'Ok',
          cancelText: '',
        }).subscribe(result => {     
    
          });
      }

      
     },
     error => {
      console.log(error)
      this.dialogService.alertDialog({
        title: 'Failed!',
        message: error,
        confirmText: 'Ok',
        cancelText: '',
      }).subscribe(result => {     
  
        });
        this.orderProcessing = false;
     });


  }

  printOrder(): void {
    this.openBillDialog();
  }
  
  goToPosMain(): void{
    this.showPosMain = true;    
    this.cartService.initCart(this.currentCart);
  }

  getPaymentModeName(paymentTypeId: string): string{
    return this.paymentModes.filter(x => x.paymentTypeId == paymentTypeId)[0].paymentType;
  }
  addPayment(paymentInput : PaymentInput): void{
    const productExistInPayment = this.paymentInputs
    .find((x: { paymentModeId: string; }) => x.paymentModeId === paymentInput.paymentModeId);

    if(productExistInPayment){
    productExistInPayment.amountTendered += paymentInput.amountTendered;
    paymentInput.balanceDue =  parseFloat((paymentInput.balanceDue - paymentInput.amountTendered).toFixed(2));
      paymentInput.amountTendered = paymentInput.balanceDue;
    }
    else{
      this.paymentInputs.push({
        amountTendered: paymentInput.amountTendered, 
        paymentModeId: paymentInput.paymentModeId,
        paymentMode: this.getPaymentModeName(paymentInput.paymentModeId),
        balanceDue: 0
      });

      paymentInput.balanceDue =  parseFloat((paymentInput.balanceDue - paymentInput.amountTendered).toFixed(2));
      paymentInput.amountTendered = paymentInput.balanceDue;
    }    
  }

  removePayment(paymentInput : PaymentInput): void{

  this.paymentInputs.forEach((element,index)=>{
    if(element.paymentModeId == paymentInput.paymentModeId){ 
      this.paymentInputs.splice(index,1);
    this.paymentInput.balanceDue = this.paymentInput.balanceDue + element.amountTendered;
    this.paymentInput.amountTendered = 0;
    }

 });


}



  

  
  openDialog(): void {
    if(this.currentCart.items.length){
      let orderDiscount: OrderDiscount={
        inPercentage: 0,
        inAmount: 0,
        amount: this.currentCart.itemSummary.cartSubTotal,
        discountReason: ''
      };
    const dialogRef = this.dialog.open(DiscountComponent, {
      //width: '300px',
      data: orderDiscount,
      disableClose: true,
    });

    dialogRef.afterClosed().subscribe(result => {
      console.log('The dialog was closed');      
      let orderDiscount: OrderDiscount = result;
      this.calculateDiscount(orderDiscount); 
    });
  }
}

openDialogAddCustomer(): void {
  //if(this.currentCart.items.length){
    this.customerDetails = {
      name: '',
      mobile: '',
      address: ''
    }
  const dialogRef = this.dialog.open(AddCustomerComponent, {
    //width: '300px',
    disableClose: true,
    data: this.customerDetails,
  });

  dialogRef.afterClosed().subscribe(result => {    
console.log(this.customerDetails);
    
  });
//}
}

calculateDiscount(orderDiscount: OrderDiscount): void{
  this.cartService.calculateDiscount(this.currentCart, orderDiscount);
}

deleteDiscount(): void{  
  this.cartService.deleteDiscount(this.currentCart);
}


openBillDialog(): void {
  const dialogRef = this.dialog.open(BillPopupComponent, {
    //width: '340px',
    data: this.currentOrder,
  });

  dialogRef.afterClosed().subscribe(result => {
    console.log('The dialog was closed');      
    let orderDiscount: OrderDiscount = result;
    //this.calculateDiscount(orderDiscount); 
  });

}

open(content: any) {
  this.modalService.open(content, {scrollable: true, ariaLabelledBy: 'modal-basic-title'}).result.then((result) => {
    this.closeResult = `Closed with: ${result}`;
  }, (reason) => {
    this.closeResult = `Dismissed ${this.getDismissReason(reason)}`;
  });
}

private getDismissReason(reason: any): string {
  if (reason === ModalDismissReasons.ESC) {
    return 'by pressing ESC';
  } else if (reason === ModalDismissReasons.BACKDROP_CLICK) {
    return 'by clicking on a backdrop';
  } else {
    return  `with: ${reason}`;
  }
}


yesNoDialog() {
  this.dialogService.confirmDialog({
    title: 'Title',
    message: 'Are you sure you want to do this?',
    confirmText: 'Yes',
    cancelText: 'No',
  }).subscribe(result => {

alert(result);

  });
}

confirmCancel() {
  this.dialogService.confirmDialog({
    title: 'Please confirm action',
    message: 'Please confirm whether you want to do this!',
    confirmText: 'Confirm',
    cancelText: 'Cancel',
  }).subscribe(result => {

    alert(result);
    
      });
}

yesNotSure() {
  this.dialogService.confirmDialog({
    title: 'Are you sure?',
    message: 'Are you sure you want to do this?',
    confirmText: 'Yes',
    cancelText: 'Not sure!',
  });
}


}


