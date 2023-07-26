//Lo que se vera aqui sera el concepto basico de LINQ , LINQ es una extension o libreria adicional muy importante en .NET su proposito principal es poder hacer modificaciones a datos ya sean IEnumerable "arrays,Objetos,Strings" etc o a Objetos Genericos "Listas" etc , con el objetivo de poder modificar o mover los datos de diferentes maneras para que se pueda obtener algun resultado en especifico , para ello utiliza 2 formas para hacerlo , 1-Metodos anidados , el cual utiliza los metodos de LINQ para poder hacer dicha modificacion en la consulta o a los datos y 2-Metodo de consultas ,que este ya utiliza directamente codigo SQL para poder modificar los datos o consulta para obtener en si 1 resultado satisfactorio , se usaran ambos para verlos de ejemplo aqui 
List<String> listaAnidada = new List<string>();
listaAnidada.Add("Cesar1");
listaAnidada.Add("Cesar2");
listaAnidada.Add("Cesar3");
listaAnidada.Add("Cesar4");
//uso de metodos Anidados de LINQ, uso del Select , que le dice en pocas palabras , seleccioname los datos donde sea igual a "Cesar1"
var resultado = listaAnidada.Where(Dato=>Dato=="Cesar1").Select(Dato=>Dato).ToArray();
 foreach (var item in resultado)
    {
        Console.WriteLine("Metodo Anidado:"+item);
    }
//uso de metodo de consultads de LINQ, lo mismo con el Select pero de consultas , donde se hara exactamente lo mismo que el anterior
List<String> listaConsultas = new List<string>();
listaConsultas.Add("Flor1");
listaConsultas.Add("Flor2");
listaConsultas.Add("Flor3");
listaConsultas.Add("Flor4");
var resultado2 = (from nombres in listaConsultas
                    where nombres == "Flor1"
                    select nombres).ToArray();
                    
    foreach (var item in resultado2)
    {
        Console.WriteLine("Metodo Consultas:"+item);
    }
