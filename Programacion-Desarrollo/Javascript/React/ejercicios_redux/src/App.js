import React from 'react';
import { Provider } from 'react-redux';
import CarritoCompras from './Components/CarritoCompras/CarritoCompras';
import store from './store';

function App() {
  return (
    <div>
      <Provider store={store}>
        
      <CarritoCompras/>

      </Provider>
    </div>
  );
}

export default App;
