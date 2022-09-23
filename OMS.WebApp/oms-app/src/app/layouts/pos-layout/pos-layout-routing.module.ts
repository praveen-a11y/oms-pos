import { Routes } from '@angular/router';
import { OrderHistoryComponent } from 'src/app/pos/order-history/order-history.component';
import { AuthGuard } from '../../helpers/auth.guard';
import { SaleComponent } from '../../pos/sale/sale.component';


export const PosLayoutRoutingModule: Routes = [
  { path: 'sale',      component: SaleComponent, canActivate: [AuthGuard] },
  { path: 'order-history',      component: OrderHistoryComponent, canActivate: [AuthGuard] }
 ];
 