import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
//Importacion del httpClientModule para la conexion con la base de datos
import {HttpClientModule} from '@angular/common/http'
import { AppComponent } from './app.component';
import { DatosServicio } from './servicios/datos.services';
import { FormularioComponent } from './formulario/formulario.component';
import { FormsModule } from '@angular/forms';
import { InformacionComponent } from './informacion/informacion.component';

@NgModule({
  declarations: [
    AppComponent,
    FormularioComponent,
    InformacionComponent
  ],
  imports: [
    BrowserModule,
    //Para HttpClientModule lo que sirve es poder conectarla directamente a la base de datos mediante firebase el cual se puede ver en su servicio de datos
    HttpClientModule,
    FormsModule
  ],
  providers: [
    //Servicios
    DatosServicio
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
