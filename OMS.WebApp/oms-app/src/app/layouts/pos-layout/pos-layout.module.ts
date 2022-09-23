import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';

import { PosLayoutRoutingModule } from './pos-layout-routing.module';



@NgModule({
  declarations: [],
  imports: [
    RouterModule.forChild(PosLayoutRoutingModule),
  ],
  exports: [RouterModule]
})
export class PosLayoutModule { }
