import { Component, ViewChild } from '@angular/core';
import { BreakpointObserver } from '@angular/cdk/layout';
import { MatSidenav } from '@angular/material/sidenav';
import { delay, filter } from 'rxjs/operators';
import { NavigationEnd, Router } from '@angular/router';
import { UntilDestroy, untilDestroyed } from '@ngneat/until-destroy';
import { SwUpdate } from '@angular/service-worker';
import { DialogService } from './services/dialog.service';

@UntilDestroy()
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  @ViewChild(MatSidenav)
  sidenav!: MatSidenav;

  constructor(private dialogService: DialogService, private observer: BreakpointObserver, private router: Router, private swUpdate: SwUpdate) {}

  ngOnInit() {
    //alert(this.swUpdate.isEnabled);
    if (this.swUpdate.isEnabled) {      
      this.swUpdate.available.subscribe(() => {
        
        this.dialogService.alertDialogSmall({
          title: 'New Release',
          message: `We've got some new updates!`,
          confirmText: 'Ok',
          cancelText: '',
        }).subscribe(result => {     
          window.location.reload();
          });
      });
    }
  }

  ngAfterViewInit() {

    this.observer
      .observe(['(max-width: 800px)'])
      .pipe(delay(1), untilDestroyed(this))
      .subscribe((res) => {
        if (res.matches) {
          this.sidenav.mode = 'over';
          this.sidenav.close();
        } else {
          this.sidenav.mode = 'side';
          this.sidenav.open();
        }
      }); 

    this.router.events
      .pipe(
        untilDestroyed(this),
        filter((e) => e instanceof NavigationEnd)
      )
      .subscribe(() => {
        if (this.sidenav.mode === 'over') {
          this.sidenav.close();
        }
      });
  }
}
