import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { HijoComponent } from './Hijo/Hijo.component';
import { HijoPadreComponent } from './HijoPadre/HijoPadre.component';
import { PadreComponent } from './Padre/Padre.component';
import { PadreHijoComponent } from './PadreHijo/PadreHijo.component';
import { ServicioEjemploService } from './servicios/servicio-ejemplo.service';

@NgModule({
  declarations: [
    AppComponent,
    HijoComponent,
    PadreHijoComponent,
    HijoPadreComponent,
    PadreComponent
  ],
  imports: [
    BrowserModule,
    FormsModule
  ],
  providers: [ServicioEjemploService],
  bootstrap: [AppComponent]
})
export class AppModule { }
