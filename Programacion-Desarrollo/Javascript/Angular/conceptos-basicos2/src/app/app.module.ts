import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { BidireccionalBindingComponent } from './BidirrecionalBinding/Bidireccional.component';
import { CalculadoraComponent } from './Calculadora/Calculadora.component';
import { Directivas1Component } from './Directivas1/Directivas1.component';
import { Directivas2Component } from './Directivas2/Directivas2.component';
import { EventBindingComponent } from './EventBinding/EventBinding.component';

@NgModule({
  declarations: [
    AppComponent,
    EventBindingComponent,
    BidireccionalBindingComponent,
    CalculadoraComponent,
    Directivas1Component,
    Directivas2Component
  ],
  imports: [
    BrowserModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
