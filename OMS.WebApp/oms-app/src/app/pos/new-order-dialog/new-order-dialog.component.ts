import { Component, OnInit } from '@angular/core';
import { MatDialogRef } from '@angular/material/dialog';
import { DialogService } from '../../services/dialog.service';

@Component({
  selector: 'app-new-order-dialog',
  templateUrl: './new-order-dialog.component.html',
  styleUrls: ['./new-order-dialog.component.scss']
})
export class NewOrderDialogComponent implements OnInit {

  constructor(public dialogRef: MatDialogRef<NewOrderDialogComponent>, private dialogService: DialogService) { }

  ngOnInit(): void {
  }

  public acceptOrder():void{
    this.dialogService.alertDialog({
      title: 'Success!',
      message: 'Order has been acceped.',
      confirmText: 'Ok',
      cancelText: '',
    }).subscribe(result => {     

      this.dialogRef.close(); 
      });
  }

}
