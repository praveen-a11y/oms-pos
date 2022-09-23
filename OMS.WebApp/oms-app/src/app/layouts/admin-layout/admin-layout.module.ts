import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { AdminLayoutRoutingModule } from './admin-layout-routing.module';



@NgModule({
  declarations: [],
  imports: [
    RouterModule.forChild(AdminLayoutRoutingModule)
  ],
  exports: [RouterModule]
})
export class AdminLayoutModule { }
