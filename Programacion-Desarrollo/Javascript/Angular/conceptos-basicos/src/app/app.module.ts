import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { BindingComponent } from './Binding/Binding.component';
import { EmpleadoComponent } from './Empleado/Empleado.component';
import { EmpleadoInlineComponent } from './EmpleadoInline/EmpleadoInline.component';
import { EmpleadosComponent } from './Empleados/Empleados.component';
import { InterpolacionComponent } from './Interpolacion/Interpolacion.component';

//Aqui en app.module.ts es donde se importara cada componente, despues se indagara mas sobre esto
@NgModule({
  //En declaration es donde iria los componentes que obtendra
  declarations: [
    AppComponent,
    EmpleadosComponent,
    EmpleadoComponent,
    EmpleadoInlineComponent,
    InterpolacionComponent,
    BindingComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
