import { Component, Inject, OnInit } from '@angular/core';
import {MatDialog, MatDialogRef, MAT_DIALOG_DATA} from '@angular/material/dialog';

@Component({
  selector: 'app-add-customer',
  templateUrl: './add-customer.component.html',
  styleUrls: ['./add-customer.component.scss']
})
export class AddCustomerComponent implements OnInit {

  constructor(public dialogRef: MatDialogRef<AddCustomerComponent>,
    @Inject(MAT_DIALOG_DATA) 
    public customerDetails: any) { }

  ngOnInit(): void {
  }

  onNoClick(): void {
    this.dialogRef.close();
  }


  allowNumericDigitsOnlyOnKeyUp(e: any) {		
		const charCode = e.which ? e.which : e.keyCode;
		
		if (charCode > 31 && (charCode < 48 || charCode > 57)) {
			//return false;
		}
	}

}
