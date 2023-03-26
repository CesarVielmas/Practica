import React from 'react';
import { Provider } from 'react-redux';
import { ExplicacionContador } from './Components/ExplicacionRedux/ExplicacionContador';
import store from './Components/ExplicacionRedux/store';


function App() {
  //Uso del provider el cual es de redux y este mismo toma el store , para ver cualquier cambio en los reducers que el programa pueda tener 
  return (
    <div>
     <Provider store={store}>
     <ExplicacionContador/>
     </Provider>
    </div>
  );
}

export default App;
