import { TYPES } from "../actions/carritoActions";

export const initCarrito = {
    productos:[
        {id:1,producto:"Producto 1",precio:"100"},
        {id:2,producto:"Producto 2",precio:"200"},
        {id:3,producto:"Producto 3",precio:"300"},
        {id:4,producto:"Producto 4",precio:"400"},
        {id:5,producto:"Producto 5",precio:"500"},
        {id:6,producto:"Producto 6",precio:"600"},
        {id:7,producto:"Producto 7",precio:"700"},
        {id:8,producto:"Producto 8",precio:"800"},
        {id:9,producto:"Producto 9",precio:"900"},
        {id:10,producto:"Producto 10",precio:"1000"}
    ],
    carrito:[],
    repeat:[0,0,0,0,0,0,0,0,0,0]
};

export const carritoReducer = (state,actions) =>{
    switch (actions.type) {
        case TYPES.ADD_TO_CART:
            {
            let {productos,carrito,repeat} = state;
            let auth = false;
            productos.forEach(producto=>{
                if (producto.id===actions.payload) {
                    carrito.forEach(carritos=>{
                        if (carritos === producto) {
                            repeat[actions.payload-1] = repeat[actions.payload-1] +.5;
                            auth = true;
                        }
                    })
                    if (auth === false){
                        carrito = [
                            ...carrito,
                            producto
                        ];
                        repeat[actions.payload-1] = 1;
                    } 
                }
            })
            
        return{productos,carrito,repeat}
            }
        case TYPES.DEL_FROM_CART:
            {
            let {productos,carrito,repeat} = state;
            if (repeat[actions.payload-1]===1) {
                carrito.pop(actions.payload);
                return{productos,carrito,repeat}
            }
            else{
                repeat[actions.payload-1] = repeat[actions.payload-1] -.5;
                return{productos,carrito,repeat}
            }
           
        }
        case TYPES.DEL_ALL_FROM_CART:
            {
                let {productos,carrito,repeat} = state;
                repeat[actions.payload-1] = 0;
                carrito.pop(actions.payload);
                return{productos,carrito,repeat}
            }
        case TYPES.CLEAR_CART:
            {
                let {productos,carrito,repeat} = state;
                carrito = [];
                repeat = [0,0,0,0,0,0,0,0,0,0];
                return{productos,carrito,repeat}
            }
            
        default:
            return state;
    }
}