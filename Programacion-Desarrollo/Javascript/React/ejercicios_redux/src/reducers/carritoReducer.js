import { ADD_CART, CLEAR_CART, REMOVE_ALL_FROM_CART, REMOVE_ONE_FROM_CART } from "../types";

const initCarrito = {
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
}

export const carritoReducer = (state = initCarrito,action)=>{

    switch (action.type) {
        case ADD_CART:
            {
                let {productos,carrito,repeat} = state;
                let auth  = true;

                productos.forEach(producto=>{
                    if (producto.id === action.payload) {
                        carrito.forEach(el=>{
                            if (el === producto) {
                                repeat[action.payload-1] = repeat[action.payload-1] + 1;
                                auth = false;
                            }
                        })
                        if (auth) {
                            carrito = [
                                ...carrito,
                                producto
                            ]
                            repeat[action.payload-1] = 1;
                        }
                    }
                })

                return {productos,carrito,repeat};
            }
        case REMOVE_ONE_FROM_CART:
            {
                let {productos,carrito,repeat} = state;
                if (repeat[action.payload-1]>1) {
                    repeat[action.payload-1] = repeat[action.payload-1] -1;
                }
                else{
                    carrito = carrito.filter(carro=>(carro.id!==productos[action.payload-1].id));
                    
                }
                return{productos,carrito,repeat};
            }
    
        case REMOVE_ALL_FROM_CART:
            {
                let {productos,carrito,repeat} = state;
                carrito = carrito.filter(carro=>(carro.id!==productos[action.payload-1].id));
                repeat[action.payload-1] = 0;
                return{productos,carrito,repeat}; 
            }
        case CLEAR_CART:
            {
                return initCarrito;
            }

        default:
            return state
    }
}