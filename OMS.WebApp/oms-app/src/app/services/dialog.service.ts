import { Injectable } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { Observable } from 'rxjs';
import { AlertComponent } from '../dialogs/alert/alert.component';
import { ConfirmComponent } from '../dialogs/confirm/confirm.component';
import { ConfirmDialogData } from '../models/confirm-dialog-data';

@Injectable({
  providedIn: 'root'
})
export class DialogService {

  constructor(private dialog: MatDialog) { }

  public confirmDialog(data: ConfirmDialogData): Observable<boolean> {
    return this.dialog
      .open(ConfirmComponent, {
        data,
        width: '400px',
        disableClose: true,
      })
      .afterClosed();
  }

  public alertDialog(data: ConfirmDialogData): Observable<boolean> {
    return this.dialog
      .open(AlertComponent, {
        data,
        width: '400px',
        disableClose: true,
      })
      .afterClosed();
  }
}
