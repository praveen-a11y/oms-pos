import { Component, Inject, OnInit } from '@angular/core';
import { MatDialog, MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { OrderDiscount } from '../../models/order-discount';
import { PinValidateDialogComponent } from '../pin-validate-dialog/pin-validate-dialog.component';

@Component({
  selector: 'app-discount',
  templateUrl: './discount.component.html',
  styleUrls: ['./discount.component.scss']
})
export class DiscountComponent {
  errorMessage!: string;
  constructor(public dialog: MatDialog,
    public dialogRef: MatDialogRef<DiscountComponent>,
    @Inject(MAT_DIALOG_DATA) 
    public orderDiscount: OrderDiscount,
  ) { 
    this.errorMessage = '';
  }

  onNoClick(): void {
    this.dialogRef.close();
  }

  onApplyClick(orderDiscount: OrderDiscount): void {
    this.errorMessage = '';
    if(!orderDiscount.discountReason.length && orderDiscount.inPercentage > 0){
      this.errorMessage = '(Required)';
    } else{

      const dialogRef = this.dialog.open(PinValidateDialogComponent, {
        width: '300px',
        data: orderDiscount,
        disableClose: true,
      });

      dialogRef.afterClosed().subscribe(result => {
        console.log('The dialog was closed');      
        let orderDiscount: OrderDiscount = result;
        this.dialogRef.close(orderDiscount);
      });
    
      
    }
    
  }

  calculateDiscountPer(): void{
    if(this.orderDiscount.inPercentage > 100){
      this.orderDiscount.inPercentage = 100;
    }
    this.orderDiscount.inAmount = (this.orderDiscount.amount/100)*this.orderDiscount.inPercentage;   
    this.orderDiscount.inAmount = parseFloat(this.orderDiscount.inAmount.toFixed(2));
  }

  calculateDiscountAmt(): void{      
    if(this.orderDiscount.inAmount > this.orderDiscount.amount){
      this.orderDiscount.inAmount = parseFloat(this.orderDiscount.amount.toFixed(2));
    }
    this.orderDiscount.inPercentage = (this.orderDiscount.inAmount/this.orderDiscount.amount)*100;
    this.orderDiscount.inPercentage = parseFloat(this.orderDiscount.inPercentage.toFixed(2));
  }
}