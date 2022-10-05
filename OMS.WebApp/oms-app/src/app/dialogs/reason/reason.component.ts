import { Component, Inject, OnInit } from '@angular/core';
import { MatDialog, MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { OrderUpdateRequest } from 'src/app/models/order-update-request';

@Component({
  selector: 'app-reason',
  templateUrl: './reason.component.html',
  styleUrls: ['./reason.component.scss']
})
export class ReasonComponent implements OnInit {
  errorMessage!: string;
  constructor(public dialog: MatDialog,
    public dialogRef: MatDialogRef<ReasonComponent>,
    @Inject(MAT_DIALOG_DATA) 
    public orderUpdateRequest: OrderUpdateRequest,) { 
      this.errorMessage = '';
    }

  ngOnInit(): void {
  }
  onNoClick(): void {
    this.dialogRef.close();
  }

  onConfirm(orderUpdateRequest: OrderUpdateRequest): void {
    this.errorMessage = '';
    if(!orderUpdateRequest.comment.length){
      this.errorMessage = '(Required)';
    } else{
      this.dialogRef.close(this.orderUpdateRequest);
    }
    
  }
}
