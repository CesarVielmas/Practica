using System;
namespace Lambda{
    public class LambdaClasico{
        //Ahora lo que se vera aqui sera el uso de lambda el cual es muy similar a javascript , pero con sus pocas diferencias y ademas de lo nuevo que le sucedio a lambda desde c# version 10
        //Lambda es una manera de expresar una funcion de una manera mas corta y precisa para no batallar con las funciones , facilita la escritura y ademas se puede guardar en variables aqui se veran algunos ejemplos
         static void Main(string[] args){
            //Forma 1 Lambda mediante Func<> funcion de orden superior con llaves
            Func<int,int> lambda1 = (numero)=>{
                return numero *numero;
            };
            int resultado = lambda1(5);//Resultado: 25
            //Forma 2 lambda simplificado mediante Func<>
            Func<int,int> lambda2 = (numero)=>numero*numero;
            int resultado2 = lambda2(2);//Resultado: 4

            //Forma 3 lambda con el objeto Action el cual siempre retorna un "void" no puede retornar enteros ni floats etc etc pero recibe "x" parametros
            Action<int,int,int> lambda3 = (numero1,numero2,numero3)=> console.WriteLine(numero1+numero2+numero3);
            
            //Forma 4 Lambda un poco avanzada
            Func<int,Func<int,string>,int> lambda4 = (numero1,funcion1)=>{
              return int.Parse(funcion1(numero1));
            };
            int resultado4 = lambda4(10,(numero)=>numero.ToString());//Resultado 10 en int

            //Forma 5 Lambda con predicate el cual se usa para retornar un booleano asi como action retorna un void
            Predicate<int> lambda5 = (numero)=> numero>10?true:false;
            bool resultado5 = lambda5(11);//Resultado true;

            //Forma 6 Lambda moderna con .net 6 
            var lambda6 = (int numero)=>{
                return numero*2;
            };
            int resultado6 = lambda6(10);
            //si no quedo muy claro mirar de nuevo el codigo importante decir que tambien se puede usar el operador ternario en el return de un lambda 
            
         }
    }
}