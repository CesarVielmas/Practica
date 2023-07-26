//Como no se cuenta aun con base de datos , aqui se mostraran diferentes metodos importantes y utiles de LINQ

//.ToAsyncList(); este funciona para cualquier respuesta de await o asincrona para poder realizar dicha lista

//El metodo Contains(); el cual sirve para buscar una cierta norma que debe seguir dicho dato para ser usada ejemplo
//listaEjemplo.Where(x=>new int[]{2018,2019}.Contains(x.fecha)).Select(x=>x).ToList(); Ejemplo en el que se busca que x.fecha sea un numero 2018 o 2019 , para que pueda entrar y lo tome el Select, dicho procedimiento sirve para obtener el IN que en SQL podria hacerse asi , y para el NOT IN solamente seria volver a falso el metodo Ejemplo
//listaEjemplo.Where(x=>!new int[]{2018,2019}.Contains(x.fecha)).Select(x=>x).ToList(); y ya estaria el NOT IN

//El metodo Any(); el cual sirve para aceptar todos los datos entrantes de la base de datos si en todo caso alguno de los elementos de la lista se cumple , osease si se busca en una lista un nombre y ese nombre esta entonces que arroje donde existe dicho nombre aqui un ejemplo usando dicho metodo
//listaEjemplo.Where(x=>x.productos.Any(y=>y.id==x.productos.edad)).Select(x=>x).ToList(); como en este ejemplo que toma todos los elementos cuyo cumplan con la asignacion de que si es igual el id de este al producto entonces que lo tome dicho metodo vino a remplazar totalmente al Exist de SQL para poder usarlo y para hacer un NOT EXIST entonces solo se usa "!" al principio para negarlo asi como en el contains

//El metodo All(); este metodo es parecido al any , solo que si no se cumple alguno de estos datos entonces no arrojara nada ,deben de cumplir a la perfeccion todos para que los pueda tomar un ejemplo de este metodo podria ser el siguiente
//listaEjemplo.Where(x=>x.productos.All(y=>y.id==x.productos.edad)).Select(x=>x).ToList(); como se puede ver se usa bastante parecido a Any(); solo que All(); se usa radicalmente para que todos los datos se cumplan , dicho metodo remplaza al AllExist de SQL para obtener su NOT solo es de negarlo al igual que el metodo Any();
