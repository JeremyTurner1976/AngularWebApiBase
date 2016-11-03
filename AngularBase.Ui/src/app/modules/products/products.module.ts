import { NgModule } from '@angular/core';
import { SharedModule } from '../../shared/shared.module';
import { ProductsComponent } from './products.component';

@NgModule({
  declarations: [
    ProductsComponent
  ],
  imports: [
    SharedModule
  ],
  bootstrap: [ProductsComponent]
})
export class ProductsModule { }
