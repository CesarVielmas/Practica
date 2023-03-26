import React from 'react';
//Ahora se vera la navegacion por las rutas , con 2 diferentes componentes o elementos , los cuales son NavLink y link los cuales son similares pero NavLink es como la mejora de Link
import {Link,NavLink} from 'react-router-dom';
export const Navegacion = () =>{

    return(
        <>
        <nav>
            {
                //Con estiquetas normales de html ( no recomendable , pues estas etiquetas vuelven a cargar el dom y lo que se quiere en la single pages no es volver a cargar una pagina si no , que simule , sin embargo con una carga ya lo haga todo )
            }
            <h3>Con las anclas de html</h3>
            <li>
                <a href='/'>Home</a>
                <a href='/contacto'>Contacto</a>
                <a href='/error'>Error</a>
                <a href='/productos'>Productos</a>
           
            </li>
            {
                //Con Link el cual es una mucho mejor manera de hacer las redirecciones de la pagina , pues este no vuelve a cargar la pagina , lo hace en automatico y es recomendable usar esta manera, para ello se cambia el href por 'to' 
            }
            <h3>Links</h3>
            <li>
             <Link to="/" >Home</Link>
             <Link to="/contacto">Contacto</Link>
             <Link to="/error">Error</Link>
             <Link to="/productos">Productos</Link>
            </li>
            {
                //Ahora para las NavLink son muy similares o casi iguales a las link pero lo unico que cambia es que se le puede dar diseños al estar activo o no activo con el objeto que recibe de className
            }
            <h3>NavLinks</h3>
            <li>
            <NavLink  to="/" className={Objeto => (Objeto.isActive)?'activo':''}>Home</NavLink>
            <NavLink  to="/contacto"className={Objeto => (Objeto.isActive)?'activo':''}>Contacto</NavLink>
            <NavLink  to="/productos"className={Objeto => (Objeto.isActive)?'activo':''}>Productos</NavLink>
            <NavLink  to="/error" className={Objeto => (Objeto.isActive)?'activo':''}>Error</NavLink>
            <NavLink  to="/datos2" className={Objeto => (Objeto.isActive)?'activo':''}>Datos2</NavLink>
            </li>
            {
             //Redirecciones
            }
            <h3>Redirecciones</h3>
            <li>
             <Link to="/contact">Contact</Link>
             <Link to="/products">Products</Link>
            </li>
        </nav>
        </>
    )
}