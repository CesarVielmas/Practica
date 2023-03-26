import logo from './logo.svg';
import './App.css';
function App() {
  let nombre = "Cesar Vielmas";
  const edad = 22;
  //Lo que se vera sera la explicacion del lenguaje peculiar que utiliza react , este lenguaje llamado JSX tiene como objetivo unir javascript con html , sin embargo no es como tal html se parece muchisimo pero no es lo mismo exactamente que html , tiene sus ciertas caracteristicas especiales que se deben cuidar , empezando porque toda etiqueta creada debe cerrarse por ejemplo <html> </html> siempre debe tener a su etiqueta de cierre en este caso el </> o si es una etiqueta simple que no tiene su etiqueta de cierre como <img> o <input> añadirsela al final obligatoriamente de <img> a <img/> en este caso , por otro lado cambian algunas otras cosas mas , por ejemplo , asignarle una clase a un elemento creado del JSX debe cambiarse su nombre , de class a className o de for a htmlFor esto ya que como es javascript como tal , interferiria con Class para crear clases y For para hacer el bucle for , por ello tener cuidado con las palabras reservadas de javascript al crear las etiquetas JSX , por ultimo todo elemento creado en JSX siempre debe estar o dentro de otro o que solo haya 1 , no puede tener hermanos solo puede tener hijos
  return (
    //Si se necesita poner a un hermano de la etiqueta div y no se quiere poner una etiqueta como tal se pueden usar etiquetas vacias de apertura y cierre
    <>
    {      
      //etiqueta div que tiene la clase app
    }
    <div className="App">
      {
        //Para escribir codigo javascript dentro de una etiqueta semi html se deben usar "{}" para indicar que es codigo javascript y lo demas sin usar las "{}" para indicar que es codigo html , lo cual conforma JSX
      }
      {
        //header la cual contiene la clase app-header
      }
      <header className="App-header">
        {
          //imagen la cual tiene de src el logo y logo fue declarado por la url que esta hasta arriba del archivo ademas de contener la clase app-logo y tener como alt o nombre por si llegara a fallar logo
        }
        <img src={logo} className="App-logo" alt="logo" />
        {
          //Despues de la imagen y dentro del header tiene una etiqueta p de parrafo donde tiene dentro de esta una etiqueta <code> la cual solo es ilustrativo
        }
        <p>
          Cesar <code>src/App.js</code> and save to reload.
        </p>
        {
          //Por otro lado tiene un ancla la cual tiene de clase app-link , tiene un href la cual conduce al link de react oficial , de target tiene que lo enviara a una pestaña nueva en el navegador y un rel
        }
        <a
          className="App-link"
          href="https://reactjs.org"
          target="_blank"
          rel="noopener noreferrer"
        >
          Learn React
        </a>
        {
          //Se cierra lo que contiene header
        }
      </header>
      {
        //Se cierra lo que contiene div el cual contiene el header
      }
    </div>
    {
      //Etiqueta creadas por mi para hacer un ejemplo
    }
    <div>
      <h1>Hola soy {nombre}</h1>
      <br></br>
      <h2>Bienvenidos tengo {edad} años</h2>
    </div>
    </>
    //Es importante aclarar que babel es el que hace todo la transformacion de codigo JSX a javascript y html , se puede ver mejor en su pagina babel para ver como lo transforma como ejemplo
  );
}

export default App;
