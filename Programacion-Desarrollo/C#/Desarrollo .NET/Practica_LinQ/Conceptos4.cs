//Ahora se veran otros metodos bastante importantes y usables en LINQ el cual es el OrderBy, ThenBy,OrderByDescending y ThenByDescending los cuales se usan asi como en SQL para ordenar de manera ascendente o descendente dependiendo de las necesidades 

//El OrderBy() este metodo se utiliza mayormente para ordenar , como su nombre lo dice lo ordena de manera descendente , el cual necesita una instrucion lambda asi como los demas para que pueda funcionar , un ejemplo de esto puede ser
//listaEjemplo.where(x=>x.id>10).OrderBy(x=>x.Edad).ToList(); , en este ejemplo se le indica que se ordenara por la edad y en el where se dice que entren todos los que el id sea superior a 10 

//El ThenBy() este metodo es util ya que se utiliza en combinacion con el OrderBy() ya que si se usan varios OrderBy simultaneos ya sea "OrderBy(instruccion).OrderBy(instruccion)" se empalman y no se obtiene el resultado que se desea , por ello esta el ThenBy() el cual debe usarse despues de un OrderBy para que se ejecute despues de haberlos ordenados por X instruccion

//El OrderByDescending() es lo mismo que el OrderBy solo que los acomoda de una manera al reves , osease ascendente en vez de descendente

//El ThenByDescending() es lo mismo que el ThenBy() solo que los ordena de manera ascendente pues el ThenBy los ordena de manera descendente

//GroupBy() este metodo al igual que SQL se utiliza para poder agrupar un grupo de datos por una determinada instruccion el Lambda , muy util para utilizar los metodos , Sum(), Min(), Max(), Count() etc para poder usarlo y sacarle el provecho a lo dicho

//El Join() este metodo como su nombre lo dice , sirve para hacer un Inner Join a algunos datos que se vayan a traer ya sea desde la base de datos o desde datos ya escritos , este toma como parametro primero la lista o elementos donde se encontraran dichos objetos para separarse o traerlos con el id ejemplo listaEjemplo.Join(lista1,listaPart1=>listaPart1.id,ListaPart2=>ListaPart2.id,(lista1,lista2)=>new{lista1,lista2}).ToList();, en este ejemplo de lista1 se obtiene la lista de donde sacara dichos ids para juntar con las otras 2 tablas en este caso listaPart1 y listaPart2 , por ultimo pide regresar algo con una funcion anonima y en este caso devuelve un objeto anonimo con dichas partes de tablas para usarlas dicho metodo viene a remplazar al INNER Join de SQL

//El First() este metodo como su nombre lo dice , espera que entre solamente 1 registro osease el primer registro de datos entrantes , este en todo caso si detecta que hay mas registros entonces no hara nada , en todo caso para ello se debe estar seguro que devolvera solo 1 registro

//El Last() este metodo asi como First() devuelve solo 1 registro , pero este devolvera el ultimo , en todo caso , se debe asegurar que devuelva solo 1 registro para poder tomarlo y que no haya complicaciones

//El Single() este metodo es prohibitivamente extricto en que solo arroje 1 solo resultado, si no arroja 1 solo resultado entonces dara error , este metodo lo que hace es que solo separa a 1 dato de una cadena de datos para poder utilizarlo y mandarlo , es importante recalcar que solo debe enviar 1 dato a dicho Single si no dara error

//FirstDefault(),LastDefault(),SingleDefault() todos estos metodos hacen exactamente lo mismo que los anteriores , pero se recomienda usarlos ya que si no encuentran nada o no esperan dicho dato entonces se rellena con un dato por defecto para evitar problemas