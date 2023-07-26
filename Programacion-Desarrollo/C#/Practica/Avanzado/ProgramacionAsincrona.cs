using System;
using System.Threading.Tasks;
using System.Threading;
namespace asincronia{
    public class asincronia{
        //Ahora se vera la asincronia en c# para ello se utiliza el objeto Task , junto con async y await , Task es para poder crear metodos asincronos, aqui se veran algunos ejemplos y un buen uso de dichos metodos ademas de ver unos ejemplos para entenderlos

        //Metodo 1 para un metodo asincrono el cual no devolvera ningun valor 
        public static async Task asincrono1(){
            Thread.Sleep(1000); //Thread.Sleep() para esperar cierto tiempo para que se ejecute el metodo
            console.WriteLine("metodo asincrono1");
        }
        //Metodo 2 para un metodo asincrono el cual devolvera un entero y como se puede ver para indicar eso , en el Task se debe indicar que devolvera en este caso un int "Task<int>" pero si se quiere otro dato o hasta funcion solo seria de cambiarlo
        public static async Task<int> asincrono2(int numero){
            Thread.Sleep(1000);
            return await numero * numero;
        }
          static async Task Main(string[] args){
           await asincrono1();//await asi como en javascript para esperar un metodo asincrono o cualquier cosa asincrona y que se ejecute primero antes que lo de abajo y que lo espere
           int resultado = await asincrono2(10);//await de igual manera para poder recibir dicha respuesta

           //Metodo 3 Task con lambda para crear dicho objeto y usarlo
           Task asincrono3 = new Task(()=>{
            console.WriteLine("Tarea Ejecutada por asincrono 3");
           });
           asincrono3.Start();//Para iniciar lo que lleva dentro 
           await asincrono3;// Para esperarlo y que e ejecute
          }
    }

}