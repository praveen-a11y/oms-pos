import { Component, Inject, OnInit } from '@angular/core';
import {MatDialog, MatDialogRef, MAT_DIALOG_DATA} from '@angular/material/dialog';
import { Order } from 'src/app/models/order';
import { BillComponent } from '../bill/bill.component';

@Component({
  selector: 'app-bill-popup',
  templateUrl: './bill-popup.component.html',
  styleUrls: ['./bill-popup.component.scss']
})
export class BillPopupComponent implements OnInit {

  constructor(public dialogRef: MatDialogRef<BillComponent>,
    @Inject(MAT_DIALOG_DATA) 
    public currentOrder: Order) { }

  ngOnInit(): void {
  }
  onNoClick(): void {
    this.dialogRef.close();
  }
  
    printBill(element: any): void{
  element?.print('bill');
  element?.print('kot');
}
}
