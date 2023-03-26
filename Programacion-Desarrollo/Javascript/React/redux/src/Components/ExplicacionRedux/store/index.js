import { createStore } from "redux";
import reducers from "../reducers";
//Creacion del store el cual recibe los reducers
const store = createStore(reducers);
//Store funcionalidad el cual espera cualquier cambio en los reducers para ejecutar su accion
store.subscribe(()=>console.log(store));

export default store;