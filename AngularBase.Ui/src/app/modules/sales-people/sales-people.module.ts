import { NgModule } from '@angular/core';
import { SharedModule } from '../../shared/shared.module';
import { SalesPeopleComponent } from './sales-people.component';

@NgModule({
  declarations: [
    SalesPeopleComponent
  ],
  imports: [
    SharedModule
  ],
  bootstrap: [SalesPeopleComponent]
})
export class SalesPeopleModule { }
