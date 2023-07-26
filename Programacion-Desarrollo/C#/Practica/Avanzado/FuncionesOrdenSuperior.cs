using System;
namespace OrdenSuperior{
    public class Orden{
        //Ahora se veran lo que son las funciones de orden superior , estas funciones son sencillas para saber como usarlas , dichas funciones lo unico que hacen es poder retornar otras funciones o aceptar una funcion como parametro , son como los delegados pero mas genericos , dicha funcion puede ser lambda o cualquier otra , aqui se veran los ejemplos de 2 metodos que 1 devuelve una funcion y otro acepta una funcion para usarse es importante saber que se usa "Func<dato1,dato2>" en este caso el "dato1" es el valor que requiere y el "dato2" es el dato que arroja por ejemplo "Func<int,void>" significa que la funcion necesita un entero y devolvera un void osease vacio

        //Funcion de orden superior que acepta una funcion
        public static void ordenSuperior1(Func<int,int>funcion1,int valor){
            //En este caso como recibe una funcion dicha fucion devolvera un entero y dicho entero se mostrara en el WriteLine
           int resultado =  funcion1(valor);
           console.WriteLine("resultado:"+resultado);
        }
        //Funcion de orden superior que manda una funcion
        public static Func<int,int> ordenSuperior2(int valor2){
            
            return valor => valor+valor2;
        }

        //Funcion experimental de orden superior no usada
        public static Func<(int,int,int),float> ordenSuperior3(){
            return (valor1,valor2,valor3)=>valor1+valor2+valor3;
        }
         static void Main(string[] args){
            //Recogiendo la funcion en una variable
            var funcion1 = ordenSuperior2(10);
            int resultado = ordenSuperior1(funcion1,20);
            console.WriteLine("Resultado total:"+resultado);
            //OutPut:30 revisar el codigo por si no se llego a entender muy bien
         }
    }
}