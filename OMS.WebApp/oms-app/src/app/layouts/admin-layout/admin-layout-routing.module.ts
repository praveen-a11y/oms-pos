import { Routes } from '@angular/router';
import { DashboardComponent } from '../../components/dashboard/dashboard.component';
import { OrdersComponent } from '../../components/orders/orders.component';
import { AuthGuard } from '../../helpers/auth.guard';


export const AdminLayoutRoutingModule: Routes = [
  { path: 'dashboard',      component: DashboardComponent, canActivate: [AuthGuard] },
  { path: 'orders',      component: OrdersComponent, canActivate: [AuthGuard] },
 ];
 