import {combineReducers} from 'redux'
import { carritoReducer } from './carritoReducer';

const reducer = combineReducers({
    carritoCompras:carritoReducer
});


export default reducer;