import { Component, Inject, OnInit } from '@angular/core';
import { MatDialog, MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { OrderDiscount } from '../../models/order-discount';

@Component({
  selector: 'app-pin-validate-dialog',
  templateUrl: './pin-validate-dialog.component.html',
  styleUrls: ['./pin-validate-dialog.component.scss']
})
export class PinValidateDialogComponent implements OnInit {
  errorMessage!: string;
  securityPin!: string;
  flag: boolean = true;
  constructor(public dialog: MatDialog,
    public dialogRef: MatDialogRef<PinValidateDialogComponent>,
    @Inject(MAT_DIALOG_DATA) 
    public orderDiscount: OrderDiscount,
  ) { 
    this.errorMessage = '';
  }

  ngOnInit(): void {
  }

  onNoClick(): void {
    this.dialogRef.close();
  }

  onApplyClick(securityPin: string): void {
    this.errorMessage = '';
    if(!securityPin){
      this.errorMessage = '(Required)';
    } else{
      this.dialogRef.close(this.orderDiscount);
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