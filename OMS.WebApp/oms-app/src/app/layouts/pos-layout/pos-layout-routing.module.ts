import { Routes } from '@angular/router';
import { OrderHistoryComponent } from '../../pos/order-history/order-history.component';
import { OrderReportComponent } from '../../pos/order-report/order-report.component';
import { AuthGuard } from '../../helpers/auth.guard';
import { SaleComponent } from '../../pos/sale/sale.component';
import { OrderReportItemWiseComponent } from '../../pos/order-report-item-wise/order-report-item-wise.component';
import { OrderReportItemSummaryComponent } from '../../pos/order-report-item-summary/order-report-item-summary.component';
import { NewOrderComponent } from '../../pos/new-order/new-order.component';


export const PosLayoutRoutingModule: Routes = [
  { path: 'sale',      component: SaleComponent, canActivate: [AuthGuard] },
  { path: 'order-history',      component: OrderHistoryComponent, canActivate: [AuthGuard] },
  { path: 'order-report',      component: OrderReportComponent, canActivate: [AuthGuard] },
  { path: 'order-report-item-wise',      component: OrderReportItemWiseComponent, canActivate: [AuthGuard] },
  { path: 'order-report-item-summary',      component: OrderReportItemSummaryComponent, canActivate: [AuthGuard] },
  { path: 'orders-new',      component: NewOrderComponent, canActivate: [AuthGuard] },
  
 ];
 