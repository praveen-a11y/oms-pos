import { Component, OnInit } from '@angular/core';
import { DialogService } from '../../services/dialog.service';
import { AccountService } from '../../services/account.service';
import { NewOrderDialogComponent } from 'src/app/pos/new-order-dialog/new-order-dialog.component';
import { MatDialog } from '@angular/material/dialog';

@Component({
  selector: 'app-pos-layout',
  templateUrl: './pos-layout.component.html',
  styleUrls: ['./pos-layout.component.scss']
})
export class PosLayoutComponent implements OnInit {

  constructor(private accountService: AccountService, private dialog: MatDialog) { }

  ngOnInit(): void {
  }

  logout() {
    this.accountService.logout();
}

public viewOrder(): void{
    
   this.dialog
  .open(NewOrderDialogComponent, {    
    width: '500px',
    disableClose: true,
  });
}

}
