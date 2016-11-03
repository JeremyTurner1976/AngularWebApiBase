import { from } from 'rxjs/observable/from';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from
  './app.component';

import { APP_PROVIDERS } from
  './app.providers';

//Shared Helpers
import{ CommonModule } from
  './shared/common';
import{ ExceptionsModule } from
  './shared/exceptions';

//Shared Components
import { PopoutComponent } from
  './shared/components/popout/popout.component';
import { ToasterComponent } from
  './shared/components/toaster/toaster.component';

//Features
import { ProductsModule } from
  './modules/products/products.module';
import { SalesPeopleModule } from
  './modules/sales-people/sales-people.module';




@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    ReactiveFormsModule,
    HttpModule,
    ProductsModule,
    SalesPeopleModule
  ],
  providers: [
    APP_PROVIDERS
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
