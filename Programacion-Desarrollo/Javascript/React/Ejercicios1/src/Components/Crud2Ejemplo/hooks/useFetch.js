import React,{useState,useEffect} from 'react';

export const useFetch = (url) =>{
    const[value,setValue] = useState();
    useEffect(()=>{
        const asincronismo =async () =>{
            try {
                let res =await fetch(url);
                if (!res.ok) {
                    throw res;
                }
                let json =await res.json();   
                setValue(await json); 
            } catch (error) {
                alert("No se pudo llevar a cabo la accion por:",error);
            }
            

        }

        asincronismo();
    },[url])
    return value;
}