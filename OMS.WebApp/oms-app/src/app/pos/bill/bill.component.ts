import { Component, Inject, Input, OnInit } from '@angular/core';
import { NgxPrintElementService } from 'ngx-print-element';
import {MatDialog, MatDialogRef, MAT_DIALOG_DATA} from '@angular/material/dialog';
import { Order } from 'src/app/models/order';

@Component({
  selector: 'app-bill',
  templateUrl: './bill.component.html',
  styleUrls: ['./bill.component.scss']
})
export class BillComponent implements OnInit {
  closeResult: string = '';
  @Input()
  currentOrder!: Order;
  constructor() { }

  ngOnInit(): void {
    console.log("bill->");
    console.log(this.currentOrder);
  }


  onNoClick(): void {
    
  }

  
}
