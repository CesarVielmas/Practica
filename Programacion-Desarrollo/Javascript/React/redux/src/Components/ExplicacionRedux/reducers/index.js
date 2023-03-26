import {combineReducers} from 'redux'
import { explicacionReducer } from './explicacionReducer';
//Combinacion de los reducers para pasarlo a store, el combine reducers recibe cada reducer
const reducers = combineReducers({
    contador:explicacionReducer
});

export default reducers;