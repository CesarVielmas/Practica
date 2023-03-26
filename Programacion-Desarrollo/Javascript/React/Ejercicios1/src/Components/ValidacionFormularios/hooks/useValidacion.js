import { useState } from 'react';

export const useValidacion = (valorInicial,valorCorrecto) =>{
    const [form,setForm] = useState(valorInicial);
    const [correcto,setCorrecto] = useState(valorCorrecto);
    const [error,setError] = useState({});

    const handlerChange = (e) =>{
        if (e.target.type === "text") {
           let regExNa =/^([A-Za-zÁÉÍÓÚñáéíóúÑ]{0}?[A-Za-zÁÉÍÓÚñáéíóúÑ\\']+[\s])+([A-Za-zÁÉÍÓÚñáéíóúÑ]{0}?[A-Za-zÁÉÍÓÚñáéíóúÑ\\'])+[\s]?([A-Za-zÁÉÍÓÚñáéíóúÑ]{0}?[A-Za-zÁÉÍÓÚñáéíóúÑ\\'])?$/;
           setForm({
            ...form,
            [e.target.name]:e.target.value
        });
        if(regExNa.test(e.target.value)) {
            setCorrecto(
                {
                    ...correcto,
                    [e.target.name]:true
                }
            )

        }
        else{
            setCorrecto(
                {
                    ...correcto,
                    [e.target.name]:false
                }
            )
            setError(
                {
                ...error,
                [e.target.name]:`El nombre proporcionado no es valido`
                }
            );
            
            }

        }
        if (e.target.type === "email") {
           let regExEm = /^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$/;
           setForm({
            ...form,
            [e.target.name]:e.target.value
        });

        if(regExEm.test(e.target.value)) {
            setCorrecto(
                {
                    ...correcto,
                    [e.target.name]:true
                }
            )

        }
        else{
            setCorrecto(
                {
                    ...correcto,
                    [e.target.name]:false
                }
            )
            setError(
                {
                ...error,
                [e.target.name]:`El email proporcionado no es valido`
                }
            );
            
            }

        }
        if (e.target.type === "password") {

            if (e.target.name === "confirmarContrasenia") {
                setForm({
                    ...form,
                    [e.target.name]:e.target.value
                }
                )
                if (e.target.value!==form.contrasenia) {
                    setCorrecto(
                        {
                            ...correcto,
                            [e.target.name]:false
                        }
                    )
                    setError(
                        {
                        ...error,
                        [e.target.name]:`Las contraseñas no coinciden`
                        }
                    );
                }
                else{
                    setCorrecto(
                        {
                            ...correcto,
                            [e.target.name]:true
                        }
                    )
                }
            }
            else{
                let regExPas = /^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[$@$!%*?&])[A-Za-z\d$@$!%*?&]{8,15}/;

            setForm({
                ...form,
                [e.target.name]:e.target.value
            }
            )

            if (regExPas.test(e.target.value)) {
                setCorrecto(
                    {
                        ...correcto,
                        [e.target.name]:true
                    }
                )

            }
            else{
                setCorrecto(
                    {
                        ...correcto,
                        [e.target.name]:false
                    }
                )
                setError(
                    {
                    ...error,
                    [e.target.name]:`La contraseña no cumple con lo requerido`
                    }
                );
                
                }
            }
        }
    }

    const handlerSubmit = (e) =>{
        e.preventDefault();
        if (correcto.nombre===false||correcto.contrasenia===false||correcto.confirmarContrasenia===false||correcto.correo===false) {
            alert("Verifique los datos , hay errores y no se puede mandar asi un formulario");
        }
        else{
        fetch("https://formsubmit.co/ajax/florbonilla112114@gmail.com",
        {
            method:"POST",
            headers:{
                'Content-Type': 'application/json'
            },
            body:JSON.stringify(form)
    
        });
        }
        
    }

    return {form,correcto,handlerChange,handlerSubmit,error};
}