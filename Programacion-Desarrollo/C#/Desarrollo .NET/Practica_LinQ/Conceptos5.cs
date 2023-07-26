//Ahora se veran mas metodos importantes de LINQ para poder usarlos y poder sacarle su maximo provecho

//El metodo Skip() sirve para saltar registros , por ejemplo si se usa listaEjemplo.Skip(10).ToList(); entonces lo que hara sera que ignorara los primeros 10 registros que tome y despues comenzara a tomar los otros registros osease de 20 registros solo tomara los ultimos 10

//El metodo Take() este metodo sirve para tomar registros , por ejemplo listaEjemplo.Take(10).ToList(); entonce lo que hara aqui sera que solo tomara 10 elementos y en este caso como van corridos , tomara los 10 primeros , pero anteriormente se pueden usar otros metodos para que pueda servir bastante mas por ejemplo listaEjemplo.Skip(10).Take(10).ToList(); en este caso como se omiten los primeros 10 , tomara los ultimos 10 con Take

//El metodo TakeWhile() este metodo asi como su nombre lo dice toma registros mientras se cumpla su condicion , cuando deje de cumplirse su condicion para y ya no tomara ningun otro registro aunque cumpla con dicha condicion ,bastante util y es especial de LINQ

//El metodo SkipWhile() este metodo asi como su nombre indica , no tomara los registros que cumplan con dicha condicion , pero cuando no cumpla alguno con dicha condicion tomara todos los demas excepto los que ya ignoro anteriormente , algo asi como la version reversa de TakeWhile()