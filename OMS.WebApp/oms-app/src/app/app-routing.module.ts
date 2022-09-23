import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DashboardComponent } from './components/dashboard/dashboard.component';
import { LoginComponent } from './components/login/login.component';
import { AdminLayoutComponent } from './layouts/admin-layout/admin-layout.component';
import { PosLayoutComponent } from './layouts/pos-layout/pos-layout.component';

const routes: Routes = [  {
  path: '',
  pathMatch: 'full',
  redirectTo: 'login',
},
{
  path: 'login',
  component: LoginComponent,
},
{ 
  path: '', 
  component: AdminLayoutComponent,
  children: [
    { path: '', 
    loadChildren: () => import('./layouts/admin-layout/admin-layout.module').then(m => m.AdminLayoutModule)
  }
  ]
},

{ 
  path: '', 
  component: PosLayoutComponent,
  children: [
    { path: '', 
    loadChildren: () => import('./layouts/pos-layout/pos-layout.module').then(m => m.PosLayoutModule)
  }
  ]
}, {
  path: '**',
  redirectTo: 'sale'
}
];

@NgModule({
  imports: [RouterModule.forRoot(routes, {useHash: true })],
  exports: [RouterModule]
})
export class AppRoutingModule { }
