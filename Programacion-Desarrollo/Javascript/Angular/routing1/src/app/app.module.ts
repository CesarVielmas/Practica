import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
//Importando routes para poder usarlo
import { Routes,RouterModule } from '@angular/router';
import { PrincipalComponent } from './principal/principal.component';
import { ProductosComponent } from './Productos/Productos.component';
import { ContactoComponent } from './Contacto/Contacto.component';
import { NoticiasComponent } from './Noticias/Noticias.component';
import { ParametrosComponent } from './parametros/parametros.component';
import { FormsModule } from '@angular/forms';
import { ErrorComponent } from './error/error.component';

//Creacion de la variable de rutas donde ira cada una de las rutas con su respectivo path
export const routes: Routes = [
  {path:'',component:PrincipalComponent},
  {path:'productos',component:ProductosComponent},
  {path:'contacto',component:ContactoComponent},
  {path:'noticias',component:NoticiasComponent},
  //Con los 2 puntos como en react se le dice que acepta 1 parametro opcional el cual sera enviado
  {path:'parametro/:datos',component:ParametrosComponent},
  //Pagina de error , para que detecte cualquier otra cosa y que no se encuentre en las paginas se pone doble asterisco
  {path:'**',component:ErrorComponent}

  
]
@NgModule({
  declarations: [
    AppComponent,
    PrincipalComponent,
    ParametrosComponent,
    NoticiasComponent,
    ErrorComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    //Importante en los imports poner el RouterModule y con su Root para las routes que fueron asignadas
    RouterModule.forRoot(routes)
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
