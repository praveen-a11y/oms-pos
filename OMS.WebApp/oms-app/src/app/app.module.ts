import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FlexLayoutModule } from "@angular/flex-layout";
import { NgxPrintElementModule } from 'ngx-print-element';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { NgMaterialModule } from './ng-material.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { ServiceWorkerModule } from '@angular/service-worker';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from './components/login/login.component';
import { DashboardComponent } from './components/dashboard/dashboard.component';
import { AdminLayoutComponent } from './layouts/admin-layout/admin-layout.component';
import { OrdersComponent } from './components/orders/orders.component';
import { PosLayoutComponent } from './layouts/pos-layout/pos-layout.component';
import { SaleComponent } from './pos/sale/sale.component';
import { HomeComponent } from './pos/home/home.component';
import { BillComponent } from './pos/bill/bill.component';
import { BillPopupComponent } from './pos/bill-popup/bill-popup.component';
import { environment } from '../environments/environment';
import { AddCustomerComponent } from './pos/add-customer/add-customer.component';
import { ConfirmComponent } from './dialogs/confirm/confirm.component';
import { AlertComponent } from './dialogs/alert/alert.component';
import { DiscountComponent } from './pos/discount/discount.component';
import { TokenInterceptorService } from './helpers/token-interceptor.service';
import { OrderHistoryComponent } from './pos/order-history/order-history.component';
import { NewOrderDialogComponent } from './pos/new-order-dialog/new-order-dialog.component';
import { Ng2SearchPipeModule  } from 'ng2-search-filter';
import { KeyboardComponent } from './keyboard/keyboard.component';
import { KeyboardService } from './keyboard/keyboard.service';
import { OskInputDirective } from './keyboard/osk-input.directive';
import { KeyboardKeyDirective } from './keyboard/keyboard-key.directive';
import { PinValidateDialogComponent } from './pos/pin-validate-dialog/pin-validate-dialog.component';



@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,    
    AdminLayoutComponent, 
    OrdersComponent,
    DashboardComponent,
    PosLayoutComponent,
    SaleComponent,
    HomeComponent,
    BillComponent,
    BillPopupComponent,
    AddCustomerComponent,
    ConfirmComponent,
    AlertComponent,
    DiscountComponent,
    OrderHistoryComponent,
    NewOrderDialogComponent,
    KeyboardComponent,
    OskInputDirective, 
    KeyboardKeyDirective, PinValidateDialogComponent  
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    NgMaterialModule,
    ReactiveFormsModule,
    FlexLayoutModule,
    FormsModule,
    NgxPrintElementModule,
    NgbModule,
    Ng2SearchPipeModule,
    
    ServiceWorkerModule.register('ngsw-worker.js', {
      enabled: environment.production,
      // Register the ServiceWorker as soon as the application is stable
      // or after 30 seconds (whichever comes first).
      registrationStrategy: 'registerWhenStable:30000'
    })
  ],
  providers: [{
    provide: HTTP_INTERCEPTORS,
    useClass: TokenInterceptorService,
    multi: true
  }, KeyboardService],
  bootstrap: [AppComponent]
})
export class AppModule { }
