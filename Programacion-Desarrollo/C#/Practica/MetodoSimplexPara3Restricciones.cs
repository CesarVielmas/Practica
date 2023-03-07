 if(ValoresDeZSimplex[0]<ValoresDeZSimplex[1]&&ValoresDeZSimplex[0]<ValoresDeZSimplex[2]&&ValoresDeZSimplex[0]<ValoresDeZSimplex[3]&&ValoresDeZSimplex[0]<ValoresDeZSimplex[4])
            {
                //Comienzo if dentro de la columna de X1 por Z1 , teniendo a la fila de la restriccion 1 como la menor osease S1
                 if((ValorSujetoARestriccion1/ValoresRestriccion1[0])<(ValorSujetoARestriccion2/ValoresRestriccion2[0])&&(ValorSujetoARestriccion1/ValoresRestriccion1[0])<(ValorSujetoARestriccion3/ValoresRestriccion3[0])&&(ValorSujetoARestriccion1/ValoresRestriccion1[0])<(ValorSujetoARestriccion4/ValoresRestriccion4[0])&&(ValorSujetoARestriccion1/ValoresRestriccion1[0])<(ValorSujetoARestriccion5/ValoresRestriccion5[0]))
                 {
                    System.Console.WriteLine("Segunda Tabla Simplex\n\n"); 
                    //Nuevos Valores Tabla Simplex 2
                    //Restriccion 1
                     ValorSujetoARestriccion1 = ValorSujetoARestriccion1/ValoresRestriccion1[0];
                    for(int i=0; i<ValoresRestriccion1.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion1[i] = ValoresRestriccion1[i]/ValoresRestriccion1[0];
                        }
                        //Valores S1,S2,S3,S4,S5 Para Columna X1
                        float S1X1 = 1/ValoresRestriccion1[0];
                        float S2X1 = 0/ValoresRestriccion1[0];
                        float S3X1 = 0 /ValoresRestriccion1[0];
                        float S4X1 = 0/ValoresRestriccion1[0];
                        float S5X1 = 0/ValoresRestriccion1[0];
                    //Restriccion 2
                        ValorSujetoARestriccion2 = ValorSujetoARestriccion2 - (ValoresRestriccion2[0]*ValorSujetoARestriccion1);

                     for(int i=0; i<ValoresRestriccion2.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion2[i] = ValoresRestriccion2[i]-(ValoresRestriccion2[0]*ValoresRestriccion1[i]);
                        }
                          //Valores S1,S2,S3,S4,S5 Para Columna X2
                        float S1X2 = 0 - (ValoresRestriccion2[0]*S1X1);
                        float S2X2 = 1 - (ValoresRestriccion2[0]*S2X1);
                        float S3X2 = 0 - (ValoresRestriccion2[0]*S3X1);
                        float S4X2 = 0 - (ValoresRestriccion2[0]*S4X1);
                        float S5X2 = 0 - (ValoresRestriccion2[0]*S5X1);
                    //Restriccion 3
                         ValorSujetoARestriccion3 = ValorSujetoARestriccion3 - (ValoresRestriccion3[0]*ValorSujetoARestriccion1);

                     for(int i=0; i<ValoresRestriccion3.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion3[i] = ValoresRestriccion3[i]-(ValoresRestriccion3[0]*ValoresRestriccion1[i]);
                        }
                         //Valores S1,S2,S3,S4,S5 Para Columna X3
                        float S1X3 = 0 - (ValoresRestriccion3[0]*S1X1);
                        float S2X3 = 0 - (ValoresRestriccion3[0]*S2X1);
                        float S3X3 = 1 - (ValoresRestriccion3[0]*S3X1);
                        float S4X3 = 0 - (ValoresRestriccion3[0]*S4X1);
                        float S5X3 = 0 - (ValoresRestriccion3[0]*S5X1);
                   
                        //Valor de Z
                         for(int i=0; i<ValoresDeZSimplex.Length; i++)                                   
                        {                                                                 
                            ValoresDeZSimplex[i] = ValoresDeZSimplex[i]-(ValoresDeZSimplex[0]*ValoresRestriccion1[i]);
                        }
                        //Valores Z y CR Para Columna Z
                        float Z = 1 - (ValoresDeZSimplex[0] * 0);
                        float CR = 0 - (ValoresDeZSimplex[0] * ValorSujetoARestriccion1);
                        //Tabla
                     System.Console.WriteLine($"Variables Basicas            Z            X1            X2            X3            X4            X5            S1            S2            S3            S4            S5            CR");
            System.Console.WriteLine($"         X1                  0            {ValoresRestriccion1[0]}           {ValoresRestriccion1[1]}           {ValoresRestriccion1[2]}           {ValoresRestriccion1[3]}           {ValoresRestriccion1[4]}           {S1X1}           {S2X1}           {S3X1}           {S4X1}           {S5X1}           {ValorSujetoARestriccion1}");
            System.Console.WriteLine($"         S2                  0            {ValoresRestriccion2[0]}           {ValoresRestriccion2[1]}           {ValoresRestriccion2[2]}           {ValoresRestriccion2[3]}           {ValoresRestriccion2[4]}           {S1X2}           {S2X2}           {S3X2}           {S4X2}           {S5X2}           {ValorSujetoARestriccion2}");
            System.Console.WriteLine($"         S3                  0            {ValoresRestriccion3[0]}           {ValoresRestriccion3[1]}           {ValoresRestriccion3[2]}           {ValoresRestriccion3[3]}           {ValoresRestriccion3[4]}           {S1X3}           {S2X3}           {S3X3}           {S4X3}           {S5X3}           {ValorSujetoARestriccion3}");
            System.Console.WriteLine($"         S4                  0            {ValoresRestriccion4[0]}           {ValoresRestriccion4[1]}           {ValoresRestriccion4[2]}           {ValoresRestriccion4[3]}           {ValoresRestriccion4[4]}           {S1X4}           {S2X4}           {S3X4}           {S4X4}           {S5X4}           {ValorSujetoARestriccion4}");
            System.Console.WriteLine($"         S5                  0            {ValoresRestriccion5[0]}           {ValoresRestriccion5[1]}           {ValoresRestriccion5[2]}           {ValoresRestriccion5[3]}           {ValoresRestriccion5[4]}           {S1X5}           {S2X5}           {S3X5}           {S4X5}           {S5X5}           {ValorSujetoARestriccion5}");
            System.Console.WriteLine($"          Z                  {Z}            {ValoresDeZSimplex[0]}           {ValoresDeZSimplex[1]}           {ValoresDeZSimplex[2]}           {ValoresDeZSimplex[3]}           {ValoresDeZSimplex[4]}           0           0           0           0           0           {CR}");

            //Tercera Tabla Simplex

                 } //Si es el caso de que la columna S1 sea el mas negativo 


                 else if((ValorSujetoARestriccion2/ValoresRestriccion2[0])<(ValorSujetoARestriccion1/ValoresRestriccion1[0])&&(ValorSujetoARestriccion2/ValoresRestriccion2[0])<(ValorSujetoARestriccion3/ValoresRestriccion3[0])&&(ValorSujetoARestriccion2/ValoresRestriccion2[0])<(ValorSujetoARestriccion4/ValoresRestriccion4[0])&&(ValorSujetoARestriccion2/ValoresRestriccion2[0])<(ValorSujetoARestriccion5/ValoresRestriccion5[0]))
                 {

                       System.Console.WriteLine("Segunda Tabla Simplex\n\n"); 
                    //Nuevos Valores Tabla Simplex 2
                    //Restriccion 2
                     ValorSujetoARestriccion2 = ValorSujetoARestriccion2/ValoresRestriccion2[0];
                    for(int i=0; i<ValoresRestriccion2.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion2[i] = ValoresRestriccion2[i]/ValoresRestriccion2[0];
                        }
                        //Valores S1,S2,S3,S4,S5 Para Columna X2
                        float S1X2 = 0/ValoresRestriccion2[0];
                        float S2X2 = 1/ValoresRestriccion2[0];
                        float S3X2 = 0 /ValoresRestriccion2[0];
                        float S4X2 = 0/ValoresRestriccion2[0];
                        float S5X2 = 0/ValoresRestriccion2[0];
                    //Restriccion 1
                        ValorSujetoARestriccion1 = ValorSujetoARestriccion1 - (ValoresRestriccion1[0]*ValorSujetoARestriccion2);

                     for(int i=0; i<ValoresRestriccion1.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion1[i] = ValoresRestriccion1[i]-(ValoresRestriccion1[0]*ValoresRestriccion2[i]);
                        }
                          //Valores S1,S2,S3,S4,S5 Para Columna X2
                        float S1X1 = 1 - (ValoresRestriccion1[0]*S1X2);
                        float S2X1 = 0 - (ValoresRestriccion1[0]*S2X2);
                        float S3X1 = 0 - (ValoresRestriccion1[0]*S3X2);
                        float S4X1 = 0 - (ValoresRestriccion1[0]*S4X2);
                        float S5X1 = 0 - (ValoresRestriccion1[0]*S5X2);
                    //Restriccion 3
                         ValorSujetoARestriccion3 = ValorSujetoARestriccion3 - (ValoresRestriccion3[0]*ValorSujetoARestriccion2);

                     for(int i=0; i<ValoresRestriccion3.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion3[i] = ValoresRestriccion3[i]-(ValoresRestriccion3[0]*ValoresRestriccion2[i]);
                        }
                         //Valores S1,S2,S3,S4,S5 Para Columna X3
                        float S1X3 = 0 - (ValoresRestriccion3[0]*S1X2);
                        float S2X3 = 0 - (ValoresRestriccion3[0]*S2X2);
                        float S3X3 = 1 - (ValoresRestriccion3[0]*S3X2);
                        float S4X3 = 0 - (ValoresRestriccion3[0]*S4X2);
                        float S5X3 = 0 - (ValoresRestriccion3[0]*S5X2);
                    
                        //Valor de Z
                         for(int i=0; i<ValoresDeZSimplex.Length; i++)                                   
                        {                                                                 
                            ValoresDeZSimplex[i] = ValoresDeZSimplex[i]-(ValoresDeZSimplex[0]*ValoresRestriccion2[i]);
                        }
                        //Valores Z y CR Para Columna Z
                        float Z = 1 - (ValoresDeZSimplex[0] * 0);
                        float CR = 0 - (ValoresDeZSimplex[0] * ValorSujetoARestriccion2);
                        //Tabla
                     System.Console.WriteLine($"Variables Basicas            Z            X1            X2            X3            X4            X5            S1            S2            S3            S4            S5            CR");
            System.Console.WriteLine($"         X1                  0            {ValoresRestriccion1[0]}           {ValoresRestriccion1[1]}           {ValoresRestriccion1[2]}           {ValoresRestriccion1[3]}           {ValoresRestriccion1[4]}           {S1X1}           {S2X1}           {S3X1}           {S4X1}           {S5X1}           {ValorSujetoARestriccion1}");
            System.Console.WriteLine($"         S2                  0            {ValoresRestriccion2[0]}           {ValoresRestriccion2[1]}           {ValoresRestriccion2[2]}           {ValoresRestriccion2[3]}           {ValoresRestriccion2[4]}           {S1X2}           {S2X2}           {S3X2}           {S4X2}           {S5X2}           {ValorSujetoARestriccion2}");
            System.Console.WriteLine($"         S3                  0            {ValoresRestriccion3[0]}           {ValoresRestriccion3[1]}           {ValoresRestriccion3[2]}           {ValoresRestriccion3[3]}           {ValoresRestriccion3[4]}           {S1X3}           {S2X3}           {S3X3}           {S4X3}           {S5X3}           {ValorSujetoARestriccion3}");
            System.Console.WriteLine($"         S4                  0            {ValoresRestriccion4[0]}           {ValoresRestriccion4[1]}           {ValoresRestriccion4[2]}           {ValoresRestriccion4[3]}           {ValoresRestriccion4[4]}           {S1X4}           {S2X4}           {S3X4}           {S4X4}           {S5X4}           {ValorSujetoARestriccion4}");
            System.Console.WriteLine($"         S5                  0            {ValoresRestriccion5[0]}           {ValoresRestriccion5[1]}           {ValoresRestriccion5[2]}           {ValoresRestriccion5[3]}           {ValoresRestriccion5[4]}           {S1X5}           {S2X5}           {S3X5}           {S4X5}           {S5X5}           {ValorSujetoARestriccion5}");
            System.Console.WriteLine($"          Z                  {Z}            {ValoresDeZSimplex[0]}           {ValoresDeZSimplex[1]}           {ValoresDeZSimplex[2]}           {ValoresDeZSimplex[3]}           {ValoresDeZSimplex[4]}           0           0           0           0           0           {CR}");

            //Tercera Tabla Simplex

                 } //Si es el caso de que la columna S2 sea el mas negativo



                  else if((ValorSujetoARestriccion3/ValoresRestriccion3[0])<(ValorSujetoARestriccion1/ValoresRestriccion1[0])&&(ValorSujetoARestriccion3/ValoresRestriccion3[0])<(ValorSujetoARestriccion2/ValoresRestriccion2[0])&&(ValorSujetoARestriccion3/ValoresRestriccion3[0])<(ValorSujetoARestriccion4/ValoresRestriccion4[0])&&(ValorSujetoARestriccion3/ValoresRestriccion3[0])<(ValorSujetoARestriccion5/ValoresRestriccion5[0]))
                 {

                     System.Console.WriteLine("Segunda Tabla Simplex\n\n"); 
                    //Nuevos Valores Tabla Simplex 2
                    //Restriccion 3
                     ValorSujetoARestriccion3 = ValorSujetoARestriccion3/ValoresRestriccion3[0];
                    for(int i=0; i<ValoresRestriccion3.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion3[i] = ValoresRestriccion3[i]/ValoresRestriccion3[0];
                        }
                        //Valores S1,S2,S3,S4,S5 Para Columna X2
                        float S1X3 = 0/ValoresRestriccion3[0];
                        float S2X3 = 0/ValoresRestriccion3[0];
                        float S3X3 = 1 /ValoresRestriccion3[0];
                        float S4X3 = 0/ValoresRestriccion3[0];
                        float S5X3 = 0/ValoresRestriccion3[0];
                    //Restriccion 1
                        ValorSujetoARestriccion1 = ValorSujetoARestriccion1 - (ValoresRestriccion1[0]*ValorSujetoARestriccion3);

                     for(int i=0; i<ValoresRestriccion1.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion1[i] = ValoresRestriccion1[i]-(ValoresRestriccion1[0]*ValoresRestriccion3[i]);
                        }
                          //Valores S1,S2,S3,S4,S5 Para Columna X2
                        float S1X1 = 1 - (ValoresRestriccion1[0]*S1X3);
                        float S2X1 = 0 - (ValoresRestriccion1[0]*S2X3);
                        float S3X1 = 0 - (ValoresRestriccion1[0]*S3X3);
                        float S4X1 = 0 - (ValoresRestriccion1[0]*S4X3);
                        float S5X1 = 0 - (ValoresRestriccion1[0]*S5X3);
                    //Restriccion 2
                         ValorSujetoARestriccion2 = ValorSujetoARestriccion2 - (ValoresRestriccion2[0]*ValorSujetoARestriccion3);

                     for(int i=0; i<ValoresRestriccion2.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion2[i] = ValoresRestriccion2[i]-(ValoresRestriccion2[0]*ValoresRestriccion3[i]);
                        }
                         //Valores S1,S2,S3,S4,S5 Para Columna X3
                        float S1X2 = 0 - (ValoresRestriccion2[0]*S1X3);
                        float S2X2 = 1 - (ValoresRestriccion2[0]*S2X3);
                        float S3X2 = 0 - (ValoresRestriccion2[0]*S3X3);
                        float S4X2 = 0 - (ValoresRestriccion2[0]*S4X3);
                        float S5X2 = 0 - (ValoresRestriccion2[0]*S5X3);
                   
                        //Valor de Z
                         for(int i=0; i<ValoresDeZSimplex.Length; i++)                                   
                        {                                                                 
                            ValoresDeZSimplex[i] = ValoresDeZSimplex[i]-(ValoresDeZSimplex[0]*ValoresRestriccion3[i]);
                        }
                        //Valores Z y CR Para Columna Z
                        float Z = 1 - (ValoresDeZSimplex[0] * 0);
                        float CR = 0 - (ValoresDeZSimplex[0] * ValorSujetoARestriccion3);
                        //Tabla
                     System.Console.WriteLine($"Variables Basicas            Z            X1            X2            X3            X4            X5            S1            S2            S3            S4            S5            CR");
            System.Console.WriteLine($"         X1                  0            {ValoresRestriccion1[0]}           {ValoresRestriccion1[1]}           {ValoresRestriccion1[2]}           {ValoresRestriccion1[3]}           {ValoresRestriccion1[4]}           {S1X1}           {S2X1}           {S3X1}           {S4X1}           {S5X1}           {ValorSujetoARestriccion1}");
            System.Console.WriteLine($"         S2                  0            {ValoresRestriccion2[0]}           {ValoresRestriccion2[1]}           {ValoresRestriccion2[2]}           {ValoresRestriccion2[3]}           {ValoresRestriccion2[4]}           {S1X2}           {S2X2}           {S3X2}           {S4X2}           {S5X2}           {ValorSujetoARestriccion2}");
            System.Console.WriteLine($"         S3                  0            {ValoresRestriccion3[0]}           {ValoresRestriccion3[1]}           {ValoresRestriccion3[2]}           {ValoresRestriccion3[3]}           {ValoresRestriccion3[4]}           {S1X3}           {S2X3}           {S3X3}           {S4X3}           {S5X3}           {ValorSujetoARestriccion3}");
            System.Console.WriteLine($"         S4                  0            {ValoresRestriccion4[0]}           {ValoresRestriccion4[1]}           {ValoresRestriccion4[2]}           {ValoresRestriccion4[3]}           {ValoresRestriccion4[4]}           {S1X4}           {S2X4}           {S3X4}           {S4X4}           {S5X4}           {ValorSujetoARestriccion4}");
            System.Console.WriteLine($"         S5                  0            {ValoresRestriccion5[0]}           {ValoresRestriccion5[1]}           {ValoresRestriccion5[2]}           {ValoresRestriccion5[3]}           {ValoresRestriccion5[4]}           {S1X5}           {S2X5}           {S3X5}           {S4X5}           {S5X5}           {ValorSujetoARestriccion5}");
            System.Console.WriteLine($"          Z                  {Z}            {ValoresDeZSimplex[0]}           {ValoresDeZSimplex[1]}           {ValoresDeZSimplex[2]}           {ValoresDeZSimplex[3]}           {ValoresDeZSimplex[4]}           0           0           0           0           0           {CR}");

            //Tercera Tabla Simplex

                 } //Si es el caso de que la columna S3 sea el mas negativo





            }//Final localizar valor mas negativo de Z para la X1
            

            //Inicio localizar valor mas negativo de Z para la X2
            else if(ValoresDeZSimplex[1]<ValoresDeZSimplex[0]&&ValoresDeZSimplex[1]<ValoresDeZSimplex[2]&&ValoresDeZSimplex[1]<ValoresDeZSimplex[3]&&ValoresDeZSimplex[1]<ValoresDeZSimplex[4])
            {
                 if((ValorSujetoARestriccion1/ValoresRestriccion1[1])<(ValorSujetoARestriccion2/ValoresRestriccion2[1])&&(ValorSujetoARestriccion1/ValoresRestriccion1[1])<(ValorSujetoARestriccion3/ValoresRestriccion3[1])&&(ValorSujetoARestriccion1/ValoresRestriccion1[1])<(ValorSujetoARestriccion4/ValoresRestriccion4[1])&&(ValorSujetoARestriccion1/ValoresRestriccion1[1])<(ValorSujetoARestriccion5/ValoresRestriccion5[1]))
                 {


                        System.Console.WriteLine("Segunda Tabla Simplex\n\n"); 
                    //Nuevos Valores Tabla Simplex 2
                    //Restriccion 1
                     ValorSujetoARestriccion1 = ValorSujetoARestriccion1/ValoresRestriccion1[1];
                    for(int i=0; i<ValoresRestriccion1.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion1[i] = ValoresRestriccion1[i]/ValoresRestriccion1[1];
                        }
                        //Valores S1,S2,S3,S4,S5 Para Columna X1
                        float S1X1 = 1/ValoresRestriccion1[1];
                        float S2X1 = 0/ValoresRestriccion1[1];
                        float S3X1 = 0 /ValoresRestriccion1[1];
                        float S4X1 = 0/ValoresRestriccion1[1];
                        float S5X1 = 0/ValoresRestriccion1[1];
                    //Restriccion 2
                        ValorSujetoARestriccion2 = ValorSujetoARestriccion2 - (ValoresRestriccion2[1]*ValorSujetoARestriccion1);

                     for(int i=0; i<ValoresRestriccion2.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion2[i] = ValoresRestriccion2[i]-(ValoresRestriccion2[1]*ValoresRestriccion1[i]);
                        }
                          //Valores S1,S2,S3,S4,S5 Para Columna X2
                        float S1X2 = 0 - (ValoresRestriccion2[1]*S1X1);
                        float S2X2 = 1 - (ValoresRestriccion2[1]*S2X1);
                        float S3X2 = 0 - (ValoresRestriccion2[1]*S3X1);
                        float S4X2 = 0 - (ValoresRestriccion2[1]*S4X1);
                        float S5X2 = 0 - (ValoresRestriccion2[1]*S5X1);
                    //Restriccion 3
                         ValorSujetoARestriccion3 = ValorSujetoARestriccion3 - (ValoresRestriccion3[1]*ValorSujetoARestriccion1);

                     for(int i=0; i<ValoresRestriccion3.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion3[i] = ValoresRestriccion3[i]-(ValoresRestriccion3[1]*ValoresRestriccion1[i]);
                        }
                         //Valores S1,S2,S3,S4,S5 Para Columna X3
                        float S1X3 = 0 - (ValoresRestriccion3[1]*S1X1);
                        float S2X3 = 0 - (ValoresRestriccion3[1]*S2X1);
                        float S3X3 = 1 - (ValoresRestriccion3[1]*S3X1);
                        float S4X3 = 0 - (ValoresRestriccion3[1]*S4X1);
                        float S5X3 = 0 - (ValoresRestriccion3[1]*S5X1);
                    
                   
                        //Valor de Z
                         for(int i=0; i<ValoresDeZSimplex.Length; i++)                                   
                        {                                                                 
                            ValoresDeZSimplex[i] = ValoresDeZSimplex[i]-(ValoresDeZSimplex[1]*ValoresRestriccion1[i]);
                        }
                        //Valores Z y CR Para Columna Z
                        float Z = 1 - (ValoresDeZSimplex[1] * 0);
                        float CR = 0 - (ValoresDeZSimplex[1] * ValorSujetoARestriccion1);
                        //Tabla
                     System.Console.WriteLine($"Variables Basicas            Z            X1            X2            X3            X4            X5            S1            S2            S3            S4            S5            CR");
            System.Console.WriteLine($"         X1                  0            {ValoresRestriccion1[0]}           {ValoresRestriccion1[1]}           {ValoresRestriccion1[2]}           {ValoresRestriccion1[3]}           {ValoresRestriccion1[4]}           {S1X1}           {S2X1}           {S3X1}           {S4X1}           {S5X1}           {ValorSujetoARestriccion1}");
            System.Console.WriteLine($"         S2                  0            {ValoresRestriccion2[0]}           {ValoresRestriccion2[1]}           {ValoresRestriccion2[2]}           {ValoresRestriccion2[3]}           {ValoresRestriccion2[4]}           {S1X2}           {S2X2}           {S3X2}           {S4X2}           {S5X2}           {ValorSujetoARestriccion2}");
            System.Console.WriteLine($"         S3                  0            {ValoresRestriccion3[0]}           {ValoresRestriccion3[1]}           {ValoresRestriccion3[2]}           {ValoresRestriccion3[3]}           {ValoresRestriccion3[4]}           {S1X3}           {S2X3}           {S3X3}           {S4X3}           {S5X3}           {ValorSujetoARestriccion3}");
            System.Console.WriteLine($"         S4                  0            {ValoresRestriccion4[0]}           {ValoresRestriccion4[1]}           {ValoresRestriccion4[2]}           {ValoresRestriccion4[3]}           {ValoresRestriccion4[4]}           {S1X4}           {S2X4}           {S3X4}           {S4X4}           {S5X4}           {ValorSujetoARestriccion4}");
            System.Console.WriteLine($"         S5                  0            {ValoresRestriccion5[0]}           {ValoresRestriccion5[1]}           {ValoresRestriccion5[2]}           {ValoresRestriccion5[3]}           {ValoresRestriccion5[4]}           {S1X5}           {S2X5}           {S3X5}           {S4X5}           {S5X5}           {ValorSujetoARestriccion5}");
            System.Console.WriteLine($"          Z                  {Z}            {ValoresDeZSimplex[0]}           {ValoresDeZSimplex[1]}           {ValoresDeZSimplex[2]}           {ValoresDeZSimplex[3]}           {ValoresDeZSimplex[4]}           0           0           0           0           0           {CR}");

            //Tercera Tabla Simplex



                 } //Si es el caso de que la columna S1 sea el mas negativo 



                 else if((ValorSujetoARestriccion2/ValoresRestriccion2[1])<(ValorSujetoARestriccion1/ValoresRestriccion1[1])&&(ValorSujetoARestriccion2/ValoresRestriccion2[1])<(ValorSujetoARestriccion3/ValoresRestriccion3[1])&&(ValorSujetoARestriccion2/ValoresRestriccion2[1])<(ValorSujetoARestriccion4/ValoresRestriccion4[1])&&(ValorSujetoARestriccion2/ValoresRestriccion2[1])<(ValorSujetoARestriccion5/ValoresRestriccion5[1]))
                 {
                       System.Console.WriteLine("Segunda Tabla Simplex\n\n"); 
                    //Nuevos Valores Tabla Simplex 2
                    //Restriccion 2
                     ValorSujetoARestriccion2 = ValorSujetoARestriccion2/ValoresRestriccion2[1];
                    for(int i=0; i<ValoresRestriccion2.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion2[i] = ValoresRestriccion2[i]/ValoresRestriccion2[1];
                        }
                        //Valores S1,S2,S3,S4,S5 Para Columna X2
                        float S1X2 = 0/ValoresRestriccion2[1];
                        float S2X2 = 1/ValoresRestriccion2[1];
                        float S3X2 = 0 /ValoresRestriccion2[1];
                        float S4X2 = 0/ValoresRestriccion2[1];
                        float S5X2 = 0/ValoresRestriccion2[1];
                    //Restriccion 1
                        ValorSujetoARestriccion1 = ValorSujetoARestriccion1 - (ValoresRestriccion1[1]*ValorSujetoARestriccion2);

                     for(int i=0; i<ValoresRestriccion1.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion1[i] = ValoresRestriccion1[i]-(ValoresRestriccion1[1]*ValoresRestriccion2[i]);
                        }
                          //Valores S1,S2,S3,S4,S5 Para Columna X1
                        float S1X1 = 1 - (ValoresRestriccion1[1]*S1X2);
                        float S2X1 = 0 - (ValoresRestriccion1[1]*S2X2);
                        float S3X1 = 0 - (ValoresRestriccion1[1]*S3X2);
                        float S4X1 = 0 - (ValoresRestriccion1[1]*S4X2);
                        float S5X1 = 0 - (ValoresRestriccion1[1]*S5X2);
                    //Restriccion 3
                         ValorSujetoARestriccion3 = ValorSujetoARestriccion3 - (ValoresRestriccion3[1]*ValorSujetoARestriccion2);

                     for(int i=0; i<ValoresRestriccion3.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion3[i] = ValoresRestriccion3[i]-(ValoresRestriccion3[1]*ValoresRestriccion2[i]);
                        }
                         //Valores S1,S2,S3,S4,S5 Para Columna X3
                        float S1X3 = 0 - (ValoresRestriccion3[1]*S1X2);
                        float S2X3 = 0 - (ValoresRestriccion3[1]*S2X2);
                        float S3X3 = 1 - (ValoresRestriccion3[1]*S3X2);
                        float S4X3 = 0 - (ValoresRestriccion3[1]*S4X2);
                        float S5X3 = 0 - (ValoresRestriccion3[1]*S5X2);
                   
                        //Valor de Z
                         for(int i=0; i<ValoresDeZSimplex.Length; i++)                                   
                        {                                                                 
                            ValoresDeZSimplex[i] = ValoresDeZSimplex[i]-(ValoresDeZSimplex[1]*ValoresRestriccion2[i]);
                        }
                        //Valores Z y CR Para Columna Z
                        float Z = 1 - (ValoresDeZSimplex[1] * 0);
                        float CR = 0 - (ValoresDeZSimplex[1] * ValorSujetoARestriccion2);
                        //Tabla
                     System.Console.WriteLine($"Variables Basicas            Z            X1            X2            X3            X4            X5            S1            S2            S3            S4            S5            CR");
            System.Console.WriteLine($"         X1                  0            {ValoresRestriccion1[0]}           {ValoresRestriccion1[1]}           {ValoresRestriccion1[2]}           {ValoresRestriccion1[3]}           {ValoresRestriccion1[4]}           {S1X1}           {S2X1}           {S3X1}           {S4X1}           {S5X1}           {ValorSujetoARestriccion1}");
            System.Console.WriteLine($"         S2                  0            {ValoresRestriccion2[0]}           {ValoresRestriccion2[1]}           {ValoresRestriccion2[2]}           {ValoresRestriccion2[3]}           {ValoresRestriccion2[4]}           {S1X2}           {S2X2}           {S3X2}           {S4X2}           {S5X2}           {ValorSujetoARestriccion2}");
            System.Console.WriteLine($"         S3                  0            {ValoresRestriccion3[0]}           {ValoresRestriccion3[1]}           {ValoresRestriccion3[2]}           {ValoresRestriccion3[3]}           {ValoresRestriccion3[4]}           {S1X3}           {S2X3}           {S3X3}           {S4X3}           {S5X3}           {ValorSujetoARestriccion3}");
            System.Console.WriteLine($"         S4                  0            {ValoresRestriccion4[0]}           {ValoresRestriccion4[1]}           {ValoresRestriccion4[2]}           {ValoresRestriccion4[3]}           {ValoresRestriccion4[4]}           {S1X4}           {S2X4}           {S3X4}           {S4X4}           {S5X4}           {ValorSujetoARestriccion4}");
            System.Console.WriteLine($"         S5                  0            {ValoresRestriccion5[0]}           {ValoresRestriccion5[1]}           {ValoresRestriccion5[2]}           {ValoresRestriccion5[3]}           {ValoresRestriccion5[4]}           {S1X5}           {S2X5}           {S3X5}           {S4X5}           {S5X5}           {ValorSujetoARestriccion5}");
            System.Console.WriteLine($"          Z                  {Z}            {ValoresDeZSimplex[0]}           {ValoresDeZSimplex[1]}           {ValoresDeZSimplex[2]}           {ValoresDeZSimplex[3]}           {ValoresDeZSimplex[4]}           0           0           0           0           0           {CR}");

            //Tercera Tabla Simplex

                 } //Si es el caso de que la columna S2 sea el mas negativo



                  else if((ValorSujetoARestriccion3/ValoresRestriccion3[1])<(ValorSujetoARestriccion1/ValoresRestriccion1[1])&&(ValorSujetoARestriccion3/ValoresRestriccion3[1])<(ValorSujetoARestriccion2/ValoresRestriccion2[1])&&(ValorSujetoARestriccion3/ValoresRestriccion3[1])<(ValorSujetoARestriccion4/ValoresRestriccion4[1])&&(ValorSujetoARestriccion3/ValoresRestriccion3[1])<(ValorSujetoARestriccion5/ValoresRestriccion5[1]))
                 {
                    System.Console.WriteLine("Segunda Tabla Simplex\n\n"); 
                    //Nuevos Valores Tabla Simplex 2
                    //Restriccion 3
                     ValorSujetoARestriccion3 = ValorSujetoARestriccion3/ValoresRestriccion3[1];
                    for(int i=0; i<ValoresRestriccion3.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion3[i] = ValoresRestriccion3[i]/ValoresRestriccion3[1];
                        }
                        //Valores S1,S2,S3,S4,S5 Para Columna X3
                        float S1X3 = 0/ValoresRestriccion3[1];
                        float S2X3 = 0/ValoresRestriccion3[1];
                        float S3X3 = 1 /ValoresRestriccion3[1];
                        float S4X3 = 0/ValoresRestriccion3[1];
                        float S5X3 = 0/ValoresRestriccion3[1];
                    //Restriccion 1
                        ValorSujetoARestriccion1 = ValorSujetoARestriccion1 - (ValoresRestriccion1[1]*ValorSujetoARestriccion3);

                     for(int i=0; i<ValoresRestriccion1.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion1[i] = ValoresRestriccion1[i]-(ValoresRestriccion1[1]*ValoresRestriccion3[i]);
                        }
                          //Valores S1,S2,S3,S4,S5 Para Columna X1
                        float S1X1 = 1 - (ValoresRestriccion1[1]*S1X3);
                        float S2X1 = 0 - (ValoresRestriccion1[1]*S2X3);
                        float S3X1 = 0 - (ValoresRestriccion1[1]*S3X3);
                        float S4X1 = 0 - (ValoresRestriccion1[1]*S4X3);
                        float S5X1 = 0 - (ValoresRestriccion1[1]*S5X3);
                    //Restriccion 3
                         ValorSujetoARestriccion2 = ValorSujetoARestriccion2 - (ValoresRestriccion2[1]*ValorSujetoARestriccion3);

                     for(int i=0; i<ValoresRestriccion2.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion2[i] = ValoresRestriccion2[i]-(ValoresRestriccion2[1]*ValoresRestriccion3[i]);
                        }
                         //Valores S1,S2,S3,S4,S5 Para Columna X3
                        float S1X2 = 0 - (ValoresRestriccion2[1]*S1X3);
                        float S2X2 = 1 - (ValoresRestriccion2[1]*S2X3);
                        float S3X2 = 0 - (ValoresRestriccion2[1]*S3X3);
                        float S4X2 = 0 - (ValoresRestriccion2[1]*S4X3);
                        float S5X2 = 0 - (ValoresRestriccion2[1]*S5X3);
                  
                        //Valor de Z
                         for(int i=0; i<ValoresDeZSimplex.Length; i++)                                   
                        {                                                                 
                            ValoresDeZSimplex[i] = ValoresDeZSimplex[i]-(ValoresDeZSimplex[1]*ValoresRestriccion3[i]);
                        }
                        //Valores Z y CR Para Columna Z
                        float Z = 1 - (ValoresDeZSimplex[1] * 0);
                        float CR = 0 - (ValoresDeZSimplex[1] * ValorSujetoARestriccion3);
                        //Tabla
                     System.Console.WriteLine($"Variables Basicas            Z            X1            X2            X3            X4            X5            S1            S2            S3            S4            S5            CR");
            System.Console.WriteLine($"         X1                  0            {ValoresRestriccion1[0]}           {ValoresRestriccion1[1]}           {ValoresRestriccion1[2]}           {ValoresRestriccion1[3]}           {ValoresRestriccion1[4]}           {S1X1}           {S2X1}           {S3X1}           {S4X1}           {S5X1}           {ValorSujetoARestriccion1}");
            System.Console.WriteLine($"         S2                  0            {ValoresRestriccion2[0]}           {ValoresRestriccion2[1]}           {ValoresRestriccion2[2]}           {ValoresRestriccion2[3]}           {ValoresRestriccion2[4]}           {S1X2}           {S2X2}           {S3X2}           {S4X2}           {S5X2}           {ValorSujetoARestriccion2}");
            System.Console.WriteLine($"         S3                  0            {ValoresRestriccion3[0]}           {ValoresRestriccion3[1]}           {ValoresRestriccion3[2]}           {ValoresRestriccion3[3]}           {ValoresRestriccion3[4]}           {S1X3}           {S2X3}           {S3X3}           {S4X3}           {S5X3}           {ValorSujetoARestriccion3}");
            System.Console.WriteLine($"         S4                  0            {ValoresRestriccion4[0]}           {ValoresRestriccion4[1]}           {ValoresRestriccion4[2]}           {ValoresRestriccion4[3]}           {ValoresRestriccion4[4]}           {S1X4}           {S2X4}           {S3X4}           {S4X4}           {S5X4}           {ValorSujetoARestriccion4}");
            System.Console.WriteLine($"         S5                  0            {ValoresRestriccion5[0]}           {ValoresRestriccion5[1]}           {ValoresRestriccion5[2]}           {ValoresRestriccion5[3]}           {ValoresRestriccion5[4]}           {S1X5}           {S2X5}           {S3X5}           {S4X5}           {S5X5}           {ValorSujetoARestriccion5}");
            System.Console.WriteLine($"          Z                  {Z}            {ValoresDeZSimplex[0]}           {ValoresDeZSimplex[1]}           {ValoresDeZSimplex[2]}           {ValoresDeZSimplex[3]}           {ValoresDeZSimplex[4]}           0           0           0           0           0           {CR}");

            //Tercera Tabla Simplex
                 } //Si es el caso de que la columna S3 sea el mas negativo



                   
            }//Final localizar valor mas negativo de Z para la X2
            

            //Inicio localizar valor mas negativo de Z para la X3
            else if(ValoresDeZSimplex[2]<ValoresDeZSimplex[1]&&ValoresDeZSimplex[2]<ValoresDeZSimplex[0]&&ValoresDeZSimplex[2]<ValoresDeZSimplex[3]&&ValoresDeZSimplex[2]<ValoresDeZSimplex[4])
            {
                 if((ValorSujetoARestriccion1/ValoresRestriccion1[2])<(ValorSujetoARestriccion2/ValoresRestriccion2[2])&&(ValorSujetoARestriccion1/ValoresRestriccion1[2])<(ValorSujetoARestriccion3/ValoresRestriccion3[2])&&(ValorSujetoARestriccion1/ValoresRestriccion1[2])<(ValorSujetoARestriccion4/ValoresRestriccion4[2])&&(ValorSujetoARestriccion1/ValoresRestriccion1[2])<(ValorSujetoARestriccion5/ValoresRestriccion5[2]))
                 {
                       System.Console.WriteLine("Segunda Tabla Simplex\n\n"); 
                    //Nuevos Valores Tabla Simplex 2
                    //Restriccion 1
                     ValorSujetoARestriccion1 = ValorSujetoARestriccion1/ValoresRestriccion1[2];
                    for(int i=0; i<ValoresRestriccion1.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion1[i] = ValoresRestriccion1[i]/ValoresRestriccion1[2];
                        }
                        //Valores S1,S2,S3,S4,S5 Para Columna X5
                        float S1X1 = 1/ValoresRestriccion1[2];
                        float S2X1 = 0/ValoresRestriccion1[2];
                        float S3X1 = 0/ValoresRestriccion1[2];
                        float S4X1 = 0/ValoresRestriccion1[2];
                        float S5X1 = 0/ValoresRestriccion1[2];

                    
                    //Restriccion 3
                         ValorSujetoARestriccion3 = ValorSujetoARestriccion3 - (ValoresRestriccion3[2]*ValorSujetoARestriccion1);

                     for(int i=0; i<ValoresRestriccion3.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion3[i] = ValoresRestriccion3[i]-(ValoresRestriccion3[2]*ValoresRestriccion1[i]);
                        }
                         //Valores S1,S2,S3,S4,S5 Para Columna X3
                        float S1X3 = 0 - (ValoresRestriccion3[2]*S1X1);
                        float S2X3 = 0 - (ValoresRestriccion3[2]*S2X1);
                        float S3X3 = 1 - (ValoresRestriccion3[2]*S3X1);
                        float S4X3 = 0 - (ValoresRestriccion3[2]*S4X1);
                        float S5X3 = 0 - (ValoresRestriccion3[2]*S5X1);
                    //Restriccion 2
                     ValorSujetoARestriccion2 = ValorSujetoARestriccion2 - (ValoresRestriccion2[2]*ValorSujetoARestriccion1);

                     for(int i=0; i<ValoresRestriccion2.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion2[i] = ValoresRestriccion2[i]-(ValoresRestriccion2[2]*ValoresRestriccion1[i]);
                        }
                    //Valores S1,S2,S3,S4,S5 Para Columna X2
                        float S1X2 = 0 - (ValoresRestriccion2[2]*S1X1);
                        float S2X2 = 1 - (ValoresRestriccion2[2]*S2X1);
                        float S3X2 = 0 - (ValoresRestriccion2[2]*S3X1);
                        float S4X2 = 0 - (ValoresRestriccion2[2]*S4X1);
                        float S5X2 = 0 - (ValoresRestriccion2[2]*S5X1);
                        //Valor de Z
                         for(int i=0; i<ValoresDeZSimplex.Length; i++)                                   
                        {                                                                 
                            ValoresDeZSimplex[i] = ValoresDeZSimplex[i]-(ValoresDeZSimplex[2]*ValoresRestriccion1[i]);
                        }
                        //Valores Z y CR Para Columna Z
                        float Z = 1 - (ValoresDeZSimplex[2] * 0);
                        float CR = 0 - (ValoresDeZSimplex[2] * ValorSujetoARestriccion1);
                        //Tabla
                     System.Console.WriteLine($"Variables Basicas            Z            X1            X2            X3            X4            X5            S1            S2            S3            S4            S5            CR");
            System.Console.WriteLine($"         X1                  0            {ValoresRestriccion1[0]}           {ValoresRestriccion1[1]}           {ValoresRestriccion1[2]}           {ValoresRestriccion1[3]}           {ValoresRestriccion1[4]}           {S1X1}           {S2X1}           {S3X1}           {S4X1}           {S5X1}           {ValorSujetoARestriccion1}");
            System.Console.WriteLine($"         S2                  0            {ValoresRestriccion2[0]}           {ValoresRestriccion2[1]}           {ValoresRestriccion2[2]}           {ValoresRestriccion2[3]}           {ValoresRestriccion2[4]}           {S1X2}           {S2X2}           {S3X2}           {S4X2}           {S5X2}           {ValorSujetoARestriccion2}");
            System.Console.WriteLine($"         S3                  0            {ValoresRestriccion3[0]}           {ValoresRestriccion3[1]}           {ValoresRestriccion3[2]}           {ValoresRestriccion3[3]}           {ValoresRestriccion3[4]}           {S1X3}           {S2X3}           {S3X3}           {S4X3}           {S5X3}           {ValorSujetoARestriccion3}");
            System.Console.WriteLine($"         S4                  0            {ValoresRestriccion4[0]}           {ValoresRestriccion4[1]}           {ValoresRestriccion4[2]}           {ValoresRestriccion4[3]}           {ValoresRestriccion4[4]}           {S1X4}           {S2X4}           {S3X4}           {S4X4}           {S5X4}           {ValorSujetoARestriccion4}");
            System.Console.WriteLine($"         S5                  0            {ValoresRestriccion5[0]}           {ValoresRestriccion5[1]}           {ValoresRestriccion5[2]}           {ValoresRestriccion5[3]}           {ValoresRestriccion5[4]}           {S1X5}           {S2X5}           {S3X5}           {S4X5}           {S5X5}           {ValorSujetoARestriccion5}");
            System.Console.WriteLine($"          Z                  {Z}            {ValoresDeZSimplex[0]}           {ValoresDeZSimplex[1]}           {ValoresDeZSimplex[2]}           {ValoresDeZSimplex[3]}           {ValoresDeZSimplex[4]}           0           0           0           0           0           {CR}");

            //Tercera Tabla Simplex
                 } //Si es el caso de que la columna S1 sea el mas negativo 

                 else if((ValorSujetoARestriccion2/ValoresRestriccion2[2])<(ValorSujetoARestriccion1/ValoresRestriccion1[2])&&(ValorSujetoARestriccion2/ValoresRestriccion2[2])<(ValorSujetoARestriccion3/ValoresRestriccion3[2])&&(ValorSujetoARestriccion2/ValoresRestriccion2[2])<(ValorSujetoARestriccion4/ValoresRestriccion4[2])&&(ValorSujetoARestriccion2/ValoresRestriccion2[2])<(ValorSujetoARestriccion5/ValoresRestriccion5[2]))
                 {
                      System.Console.WriteLine("Segunda Tabla Simplex\n\n"); 
                    //Nuevos Valores Tabla Simplex 2
                    //Restriccion 2
                     ValorSujetoARestriccion2 = ValorSujetoARestriccion2/ValoresRestriccion2[2];
                    for(int i=0; i<ValoresRestriccion2.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion2[i] = ValoresRestriccion2[i]/ValoresRestriccion2[2];
                        }
                        //Valores S1,S2,S3,S4,S5 Para Columna X2
                        float S1X2 = 0/ValoresRestriccion2[2];
                        float S2X2 = 1/ValoresRestriccion2[2];
                        float S3X2 = 0/ValoresRestriccion2[2];
                        float S4X2 = 0/ValoresRestriccion2[2];
                        float S5X2 = 0/ValoresRestriccion2[2];
                    //Restriccion 3
                         ValorSujetoARestriccion3 = ValorSujetoARestriccion3 - (ValoresRestriccion3[2]*ValorSujetoARestriccion2);

                     for(int i=0; i<ValoresRestriccion3.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion3[i] = ValoresRestriccion3[i]-(ValoresRestriccion3[2]*ValoresRestriccion2[i]);
                        }
                         //Valores S1,S2,S3,S4,S5 Para Columna X3
                        float S1X3 = 0 - (ValoresRestriccion3[2]*S1X2);
                        float S2X3 = 0 - (ValoresRestriccion3[2]*S2X2);
                        float S3X3 = 1 - (ValoresRestriccion3[2]*S3X2);
                        float S4X3 = 0 - (ValoresRestriccion3[2]*S4X2);
                        float S5X3 = 0 - (ValoresRestriccion3[2]*S5X2);
                    //Restriccion 2
                     ValorSujetoARestriccion1 = ValorSujetoARestriccion1 - (ValoresRestriccion1[2]*ValorSujetoARestriccion2);

                     for(int i=0; i<ValoresRestriccion1.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion1[i] = ValoresRestriccion1[i]-(ValoresRestriccion1[2]*ValoresRestriccion2[i]);
                        }
                    //Valores S1,S2,S3,S4,S5 Para Columna X2
                        float S1X1 = 1 - (ValoresRestriccion1[2]*S1X2);
                        float S2X1 = 0 - (ValoresRestriccion1[2]*S2X2);
                        float S3X1 = 0 - (ValoresRestriccion1[2]*S3X2);
                        float S4X1 = 0 - (ValoresRestriccion1[2]*S4X2);
                        float S5X1 = 0 - (ValoresRestriccion1[2]*S5X2);
                        //Valor de Z
                         for(int i=0; i<ValoresDeZSimplex.Length; i++)                                   
                        {                                                                 
                            ValoresDeZSimplex[i] = ValoresDeZSimplex[i]-(ValoresDeZSimplex[2]*ValoresRestriccion2[i]);
                        }
                        //Valores Z y CR Para Columna Z
                        float Z = 1 - (ValoresDeZSimplex[2] * 0);
                        float CR = 0 - (ValoresDeZSimplex[2] * ValorSujetoARestriccion2);
                        //Tabla
                     System.Console.WriteLine($"Variables Basicas            Z            X1            X2            X3            X4            X5            S1            S2            S3            S4            S5            CR");
            System.Console.WriteLine($"         X1                  0            {ValoresRestriccion1[0]}           {ValoresRestriccion1[1]}           {ValoresRestriccion1[2]}           {ValoresRestriccion1[3]}           {ValoresRestriccion1[4]}           {S1X1}           {S2X1}           {S3X1}           {S4X1}           {S5X1}           {ValorSujetoARestriccion1}");
            System.Console.WriteLine($"         S2                  0            {ValoresRestriccion2[0]}           {ValoresRestriccion2[1]}           {ValoresRestriccion2[2]}           {ValoresRestriccion2[3]}           {ValoresRestriccion2[4]}           {S1X2}           {S2X2}           {S3X2}           {S4X2}           {S5X2}           {ValorSujetoARestriccion2}");
            System.Console.WriteLine($"         S3                  0            {ValoresRestriccion3[0]}           {ValoresRestriccion3[1]}           {ValoresRestriccion3[2]}           {ValoresRestriccion3[3]}           {ValoresRestriccion3[4]}           {S1X3}           {S2X3}           {S3X3}           {S4X3}           {S5X3}           {ValorSujetoARestriccion3}");
            System.Console.WriteLine($"         S4                  0            {ValoresRestriccion4[0]}           {ValoresRestriccion4[1]}           {ValoresRestriccion4[2]}           {ValoresRestriccion4[3]}           {ValoresRestriccion4[4]}           {S1X4}           {S2X4}           {S3X4}           {S4X4}           {S5X4}           {ValorSujetoARestriccion4}");
            System.Console.WriteLine($"         S5                  0            {ValoresRestriccion5[0]}           {ValoresRestriccion5[1]}           {ValoresRestriccion5[2]}           {ValoresRestriccion5[3]}           {ValoresRestriccion5[4]}           {S1X5}           {S2X5}           {S3X5}           {S4X5}           {S5X5}           {ValorSujetoARestriccion5}");
            System.Console.WriteLine($"          Z                  {Z}            {ValoresDeZSimplex[0]}           {ValoresDeZSimplex[1]}           {ValoresDeZSimplex[2]}           {ValoresDeZSimplex[3]}           {ValoresDeZSimplex[4]}           0           0           0           0           0           {CR}");

            //Tercera Tabla Simplex
                 } //Si es el caso de que la columna S2 sea el mas negativo

                  else if((ValorSujetoARestriccion3/ValoresRestriccion3[2])<(ValorSujetoARestriccion1/ValoresRestriccion1[2])&&(ValorSujetoARestriccion3/ValoresRestriccion3[2])<(ValorSujetoARestriccion2/ValoresRestriccion2[2])&&(ValorSujetoARestriccion3/ValoresRestriccion3[2])<(ValorSujetoARestriccion4/ValoresRestriccion4[2])&&(ValorSujetoARestriccion3/ValoresRestriccion3[2])<(ValorSujetoARestriccion5/ValoresRestriccion5[2]))
                 {
                      System.Console.WriteLine("Segunda Tabla Simplex\n\n"); 
                    //Nuevos Valores Tabla Simplex 2
                    //Restriccion 3
                     ValorSujetoARestriccion3 = ValorSujetoARestriccion3/ValoresRestriccion3[2];
                    for(int i=0; i<ValoresRestriccion3.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion3[i] = ValoresRestriccion3[i]/ValoresRestriccion3[2];
                        }
                        //Valores S1,S2,S3,S4,S5 Para Columna X5
                        float S1X3 = 0/ValoresRestriccion3[2];
                        float S2X3 = 0/ValoresRestriccion3[2];
                        float S3X3 = 1/ValoresRestriccion3[2];
                        float S4X3 = 0/ValoresRestriccion3[2];
                        float S5X3 = 0/ValoresRestriccion3[2];
                    //Restriccion 1
                         ValorSujetoARestriccion1 = ValorSujetoARestriccion1 - (ValoresRestriccion1[2]*ValorSujetoARestriccion3);

                     for(int i=0; i<ValoresRestriccion1.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion1[i] = ValoresRestriccion1[i]-(ValoresRestriccion1[2]*ValoresRestriccion3[i]);
                        }
                         //Valores S1,S2,S3,S4,S5 Para Columna X1
                        float S1X1 = 1 - (ValoresRestriccion1[2]*S1X3);
                        float S2X1 = 0 - (ValoresRestriccion1[2]*S2X3);
                        float S3X1 = 0 - (ValoresRestriccion1[2]*S3X3);
                        float S4X1 = 0 - (ValoresRestriccion1[2]*S4X3);
                        float S5X1 = 0 - (ValoresRestriccion1[2]*S5X3);
                    //Restriccion 2
                     ValorSujetoARestriccion2 = ValorSujetoARestriccion2 - (ValoresRestriccion2[2]*ValorSujetoARestriccion3);

                     for(int i=0; i<ValoresRestriccion2.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion2[i] = ValoresRestriccion2[i]-(ValoresRestriccion2[2]*ValoresRestriccion3[i]);
                        }
                    //Valores S1,S2,S3,S4,S5 Para Columna X2
                        float S1X2 = 0 - (ValoresRestriccion2[2]*S1X3);
                        float S2X2 = 1 - (ValoresRestriccion2[2]*S2X3);
                        float S3X2 = 0 - (ValoresRestriccion2[2]*S3X3);
                        float S4X2 = 0 - (ValoresRestriccion2[2]*S4X3);
                        float S5X2 = 0 - (ValoresRestriccion2[2]*S5X3);
                        //Valor de Z
                         for(int i=0; i<ValoresDeZSimplex.Length; i++)                                   
                        {                                                                 
                            ValoresDeZSimplex[i] = ValoresDeZSimplex[i]-(ValoresDeZSimplex[2]*ValoresRestriccion3[i]);
                        }
                        //Valores Z y CR Para Columna Z
                        float Z = 1 - (ValoresDeZSimplex[2] * 0);
                        float CR = 0 - (ValoresDeZSimplex[2] * ValorSujetoARestriccion3);
                        //Tabla
                     System.Console.WriteLine($"Variables Basicas            Z            X1            X2            X3            X4            X5            S1            S2            S3            S4            S5            CR");
            System.Console.WriteLine($"         X1                  0            {ValoresRestriccion1[0]}           {ValoresRestriccion1[1]}           {ValoresRestriccion1[2]}           {ValoresRestriccion1[3]}           {ValoresRestriccion1[4]}           {S1X1}           {S2X1}           {S3X1}           {S4X1}           {S5X1}           {ValorSujetoARestriccion1}");
            System.Console.WriteLine($"         S2                  0            {ValoresRestriccion2[0]}           {ValoresRestriccion2[1]}           {ValoresRestriccion2[2]}           {ValoresRestriccion2[3]}           {ValoresRestriccion2[4]}           {S1X2}           {S2X2}           {S3X2}           {S4X2}           {S5X2}           {ValorSujetoARestriccion2}");
            System.Console.WriteLine($"         S3                  0            {ValoresRestriccion3[0]}           {ValoresRestriccion3[1]}           {ValoresRestriccion3[2]}           {ValoresRestriccion3[3]}           {ValoresRestriccion3[4]}           {S1X3}           {S2X3}           {S3X3}           {S4X3}           {S5X3}           {ValorSujetoARestriccion3}");
            System.Console.WriteLine($"         S4                  0            {ValoresRestriccion4[0]}           {ValoresRestriccion4[1]}           {ValoresRestriccion4[2]}           {ValoresRestriccion4[3]}           {ValoresRestriccion4[4]}           {S1X4}           {S2X4}           {S3X4}           {S4X4}           {S5X4}           {ValorSujetoARestriccion4}");
            System.Console.WriteLine($"         S5                  0            {ValoresRestriccion5[0]}           {ValoresRestriccion5[1]}           {ValoresRestriccion5[2]}           {ValoresRestriccion5[3]}           {ValoresRestriccion5[4]}           {S1X5}           {S2X5}           {S3X5}           {S4X5}           {S5X5}           {ValorSujetoARestriccion5}");
            System.Console.WriteLine($"          Z                  {Z}            {ValoresDeZSimplex[0]}           {ValoresDeZSimplex[1]}           {ValoresDeZSimplex[2]}           {ValoresDeZSimplex[3]}           {ValoresDeZSimplex[4]}           0           0           0           0           0           {CR}");

            //Tercera Tabla Simplex
                 } //Si es el caso de que la columna S3 sea el mas negativo

                   
            }//Final localizar valor mas negativo de Z para la X3


            //Inicio localizar valor mas negativo de Z para la X4
            if(ValoresDeZSimplex[3]<ValoresDeZSimplex[1]&&ValoresDeZSimplex[3]<ValoresDeZSimplex[2]&&ValoresDeZSimplex[3]<ValoresDeZSimplex[0]&&ValoresDeZSimplex[3]<ValoresDeZSimplex[4])
            {


                 if((ValorSujetoARestriccion1/ValoresRestriccion1[3])<(ValorSujetoARestriccion2/ValoresRestriccion2[3])&&(ValorSujetoARestriccion1/ValoresRestriccion1[3])<(ValorSujetoARestriccion3/ValoresRestriccion3[3])&&(ValorSujetoARestriccion1/ValoresRestriccion1[3])<(ValorSujetoARestriccion4/ValoresRestriccion4[3])&&(ValorSujetoARestriccion1/ValoresRestriccion1[3])<(ValorSujetoARestriccion5/ValoresRestriccion5[3]))
                 {
                     System.Console.WriteLine("Segunda Tabla Simplex\n\n"); 
                    //Nuevos Valores Tabla Simplex 2
                    //Restriccion 1
                     ValorSujetoARestriccion1 = ValorSujetoARestriccion1/ValoresRestriccion1[3];
                    for(int i=0; i<ValoresRestriccion1.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion1[i] = ValoresRestriccion1[i]/ValoresRestriccion1[3];
                        }
                        //Valores S1,S2,S3,S4,S5 Para Columna X4
                        float S1X1 = 1/ValoresRestriccion1[3];
                        float S2X1 = 0/ValoresRestriccion1[3];
                        float S3X1 = 0/ValoresRestriccion1[3];
                        float S4X1 = 0/ValoresRestriccion1[3];
                        float S5X1 = 0/ValoresRestriccion1[3];
                    //Restriccion 3
                         ValorSujetoARestriccion3 = ValorSujetoARestriccion3 - (ValoresRestriccion3[3]*ValorSujetoARestriccion1);

                     for(int i=0; i<ValoresRestriccion3.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion3[i] = ValoresRestriccion3[i]-(ValoresRestriccion3[3]*ValoresRestriccion1[i]);
                        }
                         //Valores S1,S2,S3,S4,S5 Para Columna X3
                        float S1X3 = 0 - (ValoresRestriccion3[3]*S1X1);
                        float S2X3 = 0 - (ValoresRestriccion3[3]*S2X1);
                        float S3X3 = 1 - (ValoresRestriccion3[3]*S3X1);
                        float S4X3 = 0 - (ValoresRestriccion3[3]*S4X1);
                        float S5X3 = 0 - (ValoresRestriccion3[3]*S5X1);
                    
                    //Restriccion 2
                     ValorSujetoARestriccion2 = ValorSujetoARestriccion2 - (ValoresRestriccion2[3]*ValorSujetoARestriccion1);

                     for(int i=0; i<ValoresRestriccion2.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion2[i] = ValoresRestriccion2[i]-(ValoresRestriccion2[3]*ValoresRestriccion1[i]);
                        }
                    //Valores S1,S2,S3,S4,S5 Para Columna X2
                        float S1X2 = 0 - (ValoresRestriccion2[3]*S1X1);
                        float S2X2 = 1 - (ValoresRestriccion2[3]*S2X1);
                        float S3X2 = 0 - (ValoresRestriccion2[3]*S3X1);
                        float S4X2 = 0 - (ValoresRestriccion2[3]*S4X1);
                        float S5X2 = 0 - (ValoresRestriccion2[3]*S5X1);
                        //Valor de Z
                         for(int i=0; i<ValoresDeZSimplex.Length; i++)                                   
                        {                                                                 
                            ValoresDeZSimplex[i] = ValoresDeZSimplex[i]-(ValoresDeZSimplex[3]*ValoresRestriccion1[i]);
                        }
                        //Valores Z y CR Para Columna Z
                        float Z = 1 - (ValoresDeZSimplex[3] * 0);
                        float CR = 0 - (ValoresDeZSimplex[3] * ValorSujetoARestriccion1);
                        //Tabla
                     System.Console.WriteLine($"Variables Basicas            Z            X1            X2            X3            X4            X5            S1            S2            S3            S4            S5            CR");
            System.Console.WriteLine($"         X1                  0            {ValoresRestriccion1[0]}           {ValoresRestriccion1[1]}           {ValoresRestriccion1[2]}           {ValoresRestriccion1[3]}           {ValoresRestriccion1[4]}           {S1X1}           {S2X1}           {S3X1}           {S4X1}           {S5X1}           {ValorSujetoARestriccion1}");
            System.Console.WriteLine($"         S2                  0            {ValoresRestriccion2[0]}           {ValoresRestriccion2[1]}           {ValoresRestriccion2[2]}           {ValoresRestriccion2[3]}           {ValoresRestriccion2[4]}           {S1X2}           {S2X2}           {S3X2}           {S4X2}           {S5X2}           {ValorSujetoARestriccion2}");
            System.Console.WriteLine($"         S3                  0            {ValoresRestriccion3[0]}           {ValoresRestriccion3[1]}           {ValoresRestriccion3[2]}           {ValoresRestriccion3[3]}           {ValoresRestriccion3[4]}           {S1X3}           {S2X3}           {S3X3}           {S4X3}           {S5X3}           {ValorSujetoARestriccion3}");
            System.Console.WriteLine($"         S4                  0            {ValoresRestriccion4[0]}           {ValoresRestriccion4[1]}           {ValoresRestriccion4[2]}           {ValoresRestriccion4[3]}           {ValoresRestriccion4[4]}           {S1X4}           {S2X4}           {S3X4}           {S4X4}           {S5X4}           {ValorSujetoARestriccion4}");
            System.Console.WriteLine($"         S5                  0            {ValoresRestriccion5[0]}           {ValoresRestriccion5[1]}           {ValoresRestriccion5[2]}           {ValoresRestriccion5[3]}           {ValoresRestriccion5[4]}           {S1X5}           {S2X5}           {S3X5}           {S4X5}           {S5X5}           {ValorSujetoARestriccion5}");
            System.Console.WriteLine($"          Z                  {Z}            {ValoresDeZSimplex[0]}           {ValoresDeZSimplex[1]}           {ValoresDeZSimplex[2]}           {ValoresDeZSimplex[3]}           {ValoresDeZSimplex[4]}           0           0           0           0           0           {CR}");

            //Tercera Tabla Simplex
                 } //Si es el caso de que la columna S1 sea el mas negativo 

                 else if((ValorSujetoARestriccion2/ValoresRestriccion2[3])<(ValorSujetoARestriccion1/ValoresRestriccion1[3])&&(ValorSujetoARestriccion2/ValoresRestriccion2[3])<(ValorSujetoARestriccion3/ValoresRestriccion3[3])&&(ValorSujetoARestriccion2/ValoresRestriccion2[3])<(ValorSujetoARestriccion4/ValoresRestriccion4[3])&&(ValorSujetoARestriccion2/ValoresRestriccion2[3])<(ValorSujetoARestriccion5/ValoresRestriccion5[3]))
                 {
                     System.Console.WriteLine("Segunda Tabla Simplex\n\n"); 
                    //Nuevos Valores Tabla Simplex 2
                    //Restriccion 2
                     ValorSujetoARestriccion2 = ValorSujetoARestriccion2/ValoresRestriccion2[3];
                    for(int i=0; i<ValoresRestriccion2.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion2[i] = ValoresRestriccion2[i]/ValoresRestriccion2[3];
                        }
                        //Valores S1,S2,S3,S4,S5 Para Columna X4
                        float S1X2 = 0/ValoresRestriccion2[3];
                        float S2X2 = 1/ValoresRestriccion2[3];
                        float S3X2 = 0/ValoresRestriccion2[3];
                        float S4X2 = 0/ValoresRestriccion2[3];
                        float S5X2 = 0/ValoresRestriccion2[3];
                  
                    //Restriccion 3
                         ValorSujetoARestriccion3 = ValorSujetoARestriccion3 - (ValoresRestriccion3[3]*ValorSujetoARestriccion2);

                     for(int i=0; i<ValoresRestriccion3.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion3[i] = ValoresRestriccion3[i]-(ValoresRestriccion3[3]*ValoresRestriccion2[i]);
                        }
                         //Valores S1,S2,S3,S4,S5 Para Columna X3
                        float S1X3 = 0 - (ValoresRestriccion3[3]*S1X2);
                        float S2X3 = 0 - (ValoresRestriccion3[3]*S2X2);
                        float S3X3 = 1 - (ValoresRestriccion3[3]*S3X2);
                        float S4X3 = 0 - (ValoresRestriccion3[3]*S4X2);
                        float S5X3 = 0 - (ValoresRestriccion3[3]*S5X2);
                   
                    //Restriccion 2
                     ValorSujetoARestriccion1 = ValorSujetoARestriccion1 - (ValoresRestriccion1[3]*ValorSujetoARestriccion2);

                     for(int i=0; i<ValoresRestriccion1.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion1[i] = ValoresRestriccion1[i]-(ValoresRestriccion1[3]*ValoresRestriccion2[i]);
                        }
                    //Valores S1,S2,S3,S4,S5 Para Columna X2
                        float S1X1 = 1 - (ValoresRestriccion1[3]*S1X2);
                        float S2X1 = 0 - (ValoresRestriccion1[3]*S2X2);
                        float S3X1 = 0 - (ValoresRestriccion1[3]*S3X2);
                        float S4X1 = 0 - (ValoresRestriccion1[3]*S4X2);
                        float S5X1 = 0 - (ValoresRestriccion1[3]*S5X2);
                        //Valor de Z
                         for(int i=0; i<ValoresDeZSimplex.Length; i++)                                   
                        {                                                                 
                            ValoresDeZSimplex[i] = ValoresDeZSimplex[i]-(ValoresDeZSimplex[3]*ValoresRestriccion2[i]);
                        }
                        //Valores Z y CR Para Columna Z
                        float Z = 1 - (ValoresDeZSimplex[3] * 0);
                        float CR = 0 - (ValoresDeZSimplex[3] * ValorSujetoARestriccion2);
                        //Tabla
                     System.Console.WriteLine($"Variables Basicas            Z            X1            X2            X3            X4            X5            S1            S2            S3            S4            S5            CR");
            System.Console.WriteLine($"         X1                  0            {ValoresRestriccion1[0]}           {ValoresRestriccion1[1]}           {ValoresRestriccion1[2]}           {ValoresRestriccion1[3]}           {ValoresRestriccion1[4]}           {S1X1}           {S2X1}           {S3X1}           {S4X1}           {S5X1}           {ValorSujetoARestriccion1}");
            System.Console.WriteLine($"         S2                  0            {ValoresRestriccion2[0]}           {ValoresRestriccion2[1]}           {ValoresRestriccion2[2]}           {ValoresRestriccion2[3]}           {ValoresRestriccion2[4]}           {S1X2}           {S2X2}           {S3X2}           {S4X2}           {S5X2}           {ValorSujetoARestriccion2}");
            System.Console.WriteLine($"         S3                  0            {ValoresRestriccion3[0]}           {ValoresRestriccion3[1]}           {ValoresRestriccion3[2]}           {ValoresRestriccion3[3]}           {ValoresRestriccion3[4]}           {S1X3}           {S2X3}           {S3X3}           {S4X3}           {S5X3}           {ValorSujetoARestriccion3}");
            System.Console.WriteLine($"         S4                  0            {ValoresRestriccion4[0]}           {ValoresRestriccion4[1]}           {ValoresRestriccion4[2]}           {ValoresRestriccion4[3]}           {ValoresRestriccion4[4]}           {S1X4}           {S2X4}           {S3X4}           {S4X4}           {S5X4}           {ValorSujetoARestriccion4}");
            System.Console.WriteLine($"         S5                  0            {ValoresRestriccion5[0]}           {ValoresRestriccion5[1]}           {ValoresRestriccion5[2]}           {ValoresRestriccion5[3]}           {ValoresRestriccion5[4]}           {S1X5}           {S2X5}           {S3X5}           {S4X5}           {S5X5}           {ValorSujetoARestriccion5}");
            System.Console.WriteLine($"          Z                  {Z}            {ValoresDeZSimplex[0]}           {ValoresDeZSimplex[1]}           {ValoresDeZSimplex[2]}           {ValoresDeZSimplex[3]}           {ValoresDeZSimplex[4]}           0           0           0           0           0           {CR}");

            //Tercera Tabla Simplex
                 } //Si es el caso de que la columna S2 sea el mas negativo

                  else if((ValorSujetoARestriccion3/ValoresRestriccion3[3])<(ValorSujetoARestriccion1/ValoresRestriccion1[3])&&(ValorSujetoARestriccion3/ValoresRestriccion3[3])<(ValorSujetoARestriccion2/ValoresRestriccion2[3])&&(ValorSujetoARestriccion3/ValoresRestriccion3[3])<(ValorSujetoARestriccion4/ValoresRestriccion4[3])&&(ValorSujetoARestriccion3/ValoresRestriccion3[3])<(ValorSujetoARestriccion5/ValoresRestriccion5[3]))
                 {
                     System.Console.WriteLine("Segunda Tabla Simplex\n\n"); 
                    //Nuevos Valores Tabla Simplex 2
                    //Restriccion 3
                     ValorSujetoARestriccion3 = ValorSujetoARestriccion3/ValoresRestriccion3[3];
                    for(int i=0; i<ValoresRestriccion3.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion3[i] = ValoresRestriccion3[i]/ValoresRestriccion3[3];
                        }
                        //Valores S1,S2,S3,S4,S5 Para Columna X4
                        float S1X3 = 0/ValoresRestriccion3[3];
                        float S2X3 = 0/ValoresRestriccion3[3];
                        float S3X3 = 1/ValoresRestriccion3[3];
                        float S4X3 = 0/ValoresRestriccion3[3];
                        float S5X3 = 0/ValoresRestriccion3[3];
                    //Restriccion 3
                         ValorSujetoARestriccion1 = ValorSujetoARestriccion1 - (ValoresRestriccion1[3]*ValorSujetoARestriccion3);

                     for(int i=0; i<ValoresRestriccion1.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion1[i] = ValoresRestriccion1[i]-(ValoresRestriccion1[3]*ValoresRestriccion3[i]);
                        }
                         //Valores S1,S2,S3,S4,S5 Para Columna X3
                        float S1X1 = 1 - (ValoresRestriccion1[3]*S1X3);
                        float S2X1 = 0 - (ValoresRestriccion1[3]*S2X3);
                        float S3X1 = 0 - (ValoresRestriccion1[3]*S3X3);
                        float S4X1 = 0 - (ValoresRestriccion1[3]*S4X3);
                        float S5X1 = 0 - (ValoresRestriccion1[3]*S5X3);
                   
                    //Restriccion 2
                     ValorSujetoARestriccion2 = ValorSujetoARestriccion2 - (ValoresRestriccion2[3]*ValorSujetoARestriccion3);

                     for(int i=0; i<ValoresRestriccion2.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion2[i] = ValoresRestriccion2[i]-(ValoresRestriccion2[3]*ValoresRestriccion3[i]);
                        }
                    //Valores S1,S2,S3,S4,S5 Para Columna X2
                        float S1X2 = 0 - (ValoresRestriccion2[3]*S1X3);
                        float S2X2 = 1 - (ValoresRestriccion2[3]*S2X3);
                        float S3X2 = 0 - (ValoresRestriccion2[3]*S3X3);
                        float S4X2 = 0 - (ValoresRestriccion2[3]*S4X3);
                        float S5X2 = 0 - (ValoresRestriccion2[3]*S5X3);
                        //Valor de Z
                         for(int i=0; i<ValoresDeZSimplex.Length; i++)                                   
                        {                                                                 
                            ValoresDeZSimplex[i] = ValoresDeZSimplex[i]-(ValoresDeZSimplex[3]*ValoresRestriccion3[i]);
                        }
                        //Valores Z y CR Para Columna Z
                        float Z = 1 - (ValoresDeZSimplex[3] * 0);
                        float CR = 0 - (ValoresDeZSimplex[3] * ValorSujetoARestriccion3);
                        //Tabla
                     System.Console.WriteLine($"Variables Basicas            Z            X1            X2            X3            X4            X5            S1            S2            S3            S4            S5            CR");
            System.Console.WriteLine($"         X1                  0            {ValoresRestriccion1[0]}           {ValoresRestriccion1[1]}           {ValoresRestriccion1[2]}           {ValoresRestriccion1[3]}           {ValoresRestriccion1[4]}           {S1X1}           {S2X1}           {S3X1}           {S4X1}           {S5X1}           {ValorSujetoARestriccion1}");
            System.Console.WriteLine($"         S2                  0            {ValoresRestriccion2[0]}           {ValoresRestriccion2[1]}           {ValoresRestriccion2[2]}           {ValoresRestriccion2[3]}           {ValoresRestriccion2[4]}           {S1X2}           {S2X2}           {S3X2}           {S4X2}           {S5X2}           {ValorSujetoARestriccion2}");
            System.Console.WriteLine($"         S3                  0            {ValoresRestriccion3[0]}           {ValoresRestriccion3[1]}           {ValoresRestriccion3[2]}           {ValoresRestriccion3[3]}           {ValoresRestriccion3[4]}           {S1X3}           {S2X3}           {S3X3}           {S4X3}           {S5X3}           {ValorSujetoARestriccion3}");
            System.Console.WriteLine($"         S4                  0            {ValoresRestriccion4[0]}           {ValoresRestriccion4[1]}           {ValoresRestriccion4[2]}           {ValoresRestriccion4[3]}           {ValoresRestriccion4[4]}           {S1X4}           {S2X4}           {S3X4}           {S4X4}           {S5X4}           {ValorSujetoARestriccion4}");
            System.Console.WriteLine($"         S5                  0            {ValoresRestriccion5[0]}           {ValoresRestriccion5[1]}           {ValoresRestriccion5[2]}           {ValoresRestriccion5[3]}           {ValoresRestriccion5[4]}           {S1X5}           {S2X5}           {S3X5}           {S4X5}           {S5X5}           {ValorSujetoARestriccion5}");
            System.Console.WriteLine($"          Z                  {Z}            {ValoresDeZSimplex[0]}           {ValoresDeZSimplex[1]}           {ValoresDeZSimplex[2]}           {ValoresDeZSimplex[3]}           {ValoresDeZSimplex[4]}           0           0           0           0           0           {CR}");

            //Tercera Tabla Simplex
                 } //Si es el caso de que la columna S3 sea el mas negativo

                 

            }//Final localizar valor mas negativo de Z para la X4
            
            
            //Inicio localizar valor mas negativo de Z para la X5
            if(ValoresDeZSimplex[4]<ValoresDeZSimplex[1]&&ValoresDeZSimplex[4]<ValoresDeZSimplex[2]&&ValoresDeZSimplex[4]<ValoresDeZSimplex[3]&&ValoresDeZSimplex[4]<ValoresDeZSimplex[0])
            {
                

                 if((ValorSujetoARestriccion1/ValoresRestriccion1[4])<(ValorSujetoARestriccion2/ValoresRestriccion2[4])&&(ValorSujetoARestriccion1/ValoresRestriccion1[4])<(ValorSujetoARestriccion3/ValoresRestriccion3[4])&&(ValorSujetoARestriccion1/ValoresRestriccion1[4])<(ValorSujetoARestriccion4/ValoresRestriccion4[4])&&(ValorSujetoARestriccion1/ValoresRestriccion1[4])<(ValorSujetoARestriccion5/ValoresRestriccion5[4]))
                 {
                     System.Console.WriteLine("Segunda Tabla Simplex\n\n"); 
                    //Nuevos Valores Tabla Simplex 2
                    //Restriccion 1
                     ValorSujetoARestriccion1 = ValorSujetoARestriccion1/ValoresRestriccion1[4];
                    for(int i=0; i<ValoresRestriccion1.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion1[i] = ValoresRestriccion1[i]/ValoresRestriccion1[4];
                        }
                        //Valores S1,S2,S3,S4,S5 Para Columna X4
                        float S1X1 = 1/ValoresRestriccion1[4];
                        float S2X1 = 0/ValoresRestriccion1[4];
                        float S3X1 = 0/ValoresRestriccion1[4];
                        float S4X1 = 0/ValoresRestriccion1[4];
                        float S5X1 = 0/ValoresRestriccion1[4];
                   
                    //Restriccion 3
                         ValorSujetoARestriccion3 = ValorSujetoARestriccion3 - (ValoresRestriccion3[4]*ValorSujetoARestriccion1);

                     for(int i=0; i<ValoresRestriccion3.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion3[i] = ValoresRestriccion3[i]-(ValoresRestriccion3[4]*ValoresRestriccion1[i]);
                        }
                         //Valores S1,S2,S3,S4,S5 Para Columna X3
                        float S1X3 = 0 - (ValoresRestriccion3[4]*S1X1);
                        float S2X3 = 0 - (ValoresRestriccion3[4]*S2X1);
                        float S3X3 = 1 - (ValoresRestriccion3[4]*S3X1);
                        float S4X3 = 0 - (ValoresRestriccion3[4]*S4X1);
                        float S5X3 = 0 - (ValoresRestriccion3[4]*S5X1);
                  
                    //Restriccion 2
                     ValorSujetoARestriccion2 = ValorSujetoARestriccion2 - (ValoresRestriccion2[4]*ValorSujetoARestriccion1);

                     for(int i=0; i<ValoresRestriccion2.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion2[i] = ValoresRestriccion2[i]-(ValoresRestriccion2[4]*ValoresRestriccion1[i]);
                        }
                    //Valores S1,S2,S3,S4,S5 Para Columna X2
                        float S1X2 = 0 - (ValoresRestriccion2[4]*S1X1);
                        float S2X2 = 1 - (ValoresRestriccion2[4]*S2X1);
                        float S3X2 = 0 - (ValoresRestriccion2[4]*S3X1);
                        float S4X2 = 0 - (ValoresRestriccion2[4]*S4X1);
                        float S5X2 = 0 - (ValoresRestriccion2[4]*S5X1);
                        //Valor de Z
                         for(int i=0; i<ValoresDeZSimplex.Length; i++)                                   
                        {                                                                 
                            ValoresDeZSimplex[i] = ValoresDeZSimplex[i]-(ValoresDeZSimplex[4]*ValoresRestriccion1[i]);
                        }
                        //Valores Z y CR Para Columna Z
                        float Z = 1 - (ValoresDeZSimplex[4] * 0);
                        float CR = 0 - (ValoresDeZSimplex[4] * ValorSujetoARestriccion1);
                        //Tabla
                     System.Console.WriteLine($"Variables Basicas            Z            X1            X2            X3            X4            X5            S1            S2            S3            S4            S5            CR");
            System.Console.WriteLine($"         X1                  0            {ValoresRestriccion1[0]}           {ValoresRestriccion1[1]}           {ValoresRestriccion1[2]}           {ValoresRestriccion1[3]}           {ValoresRestriccion1[4]}           {S1X1}           {S2X1}           {S3X1}           {S4X1}           {S5X1}           {ValorSujetoARestriccion1}");
            System.Console.WriteLine($"         S2                  0            {ValoresRestriccion2[0]}           {ValoresRestriccion2[1]}           {ValoresRestriccion2[2]}           {ValoresRestriccion2[3]}           {ValoresRestriccion2[4]}           {S1X2}           {S2X2}           {S3X2}           {S4X2}           {S5X2}           {ValorSujetoARestriccion2}");
            System.Console.WriteLine($"         S3                  0            {ValoresRestriccion3[0]}           {ValoresRestriccion3[1]}           {ValoresRestriccion3[2]}           {ValoresRestriccion3[3]}           {ValoresRestriccion3[4]}           {S1X3}           {S2X3}           {S3X3}           {S4X3}           {S5X3}           {ValorSujetoARestriccion3}");
            System.Console.WriteLine($"         S4                  0            {ValoresRestriccion4[0]}           {ValoresRestriccion4[1]}           {ValoresRestriccion4[2]}           {ValoresRestriccion4[3]}           {ValoresRestriccion4[4]}           {S1X4}           {S2X4}           {S3X4}           {S4X4}           {S5X4}           {ValorSujetoARestriccion4}");
            System.Console.WriteLine($"         S5                  0            {ValoresRestriccion5[0]}           {ValoresRestriccion5[1]}           {ValoresRestriccion5[2]}           {ValoresRestriccion5[3]}           {ValoresRestriccion5[4]}           {S1X5}           {S2X5}           {S3X5}           {S4X5}           {S5X5}           {ValorSujetoARestriccion5}");
            System.Console.WriteLine($"          Z                  {Z}            {ValoresDeZSimplex[0]}           {ValoresDeZSimplex[1]}           {ValoresDeZSimplex[2]}           {ValoresDeZSimplex[3]}           {ValoresDeZSimplex[4]}           0           0           0           0           0           {CR}");

            //Tercera Tabla Simplex
                 } //Si es el caso de que la columna S1 sea el mas negativo 

                 else if((ValorSujetoARestriccion2/ValoresRestriccion2[4])<(ValorSujetoARestriccion1/ValoresRestriccion1[4])&&(ValorSujetoARestriccion2/ValoresRestriccion2[4])<(ValorSujetoARestriccion3/ValoresRestriccion3[4])&&(ValorSujetoARestriccion2/ValoresRestriccion2[4])<(ValorSujetoARestriccion4/ValoresRestriccion4[4])&&(ValorSujetoARestriccion2/ValoresRestriccion2[4])<(ValorSujetoARestriccion5/ValoresRestriccion5[4]))
                 {
                     System.Console.WriteLine("Segunda Tabla Simplex\n\n"); 
                    //Nuevos Valores Tabla Simplex 2
                    //Restriccion 2
                     ValorSujetoARestriccion2 = ValorSujetoARestriccion2/ValoresRestriccion2[4];
                    for(int i=0; i<ValoresRestriccion2.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion2[i] = ValoresRestriccion2[i]/ValoresRestriccion2[4];
                        }
                        //Valores S1,S2,S3,S4,S5 Para Columna X4
                        float S1X2 = 0/ValoresRestriccion2[4];
                        float S2X2 = 1/ValoresRestriccion2[4];
                        float S3X2 = 0/ValoresRestriccion2[4];
                        float S4X2 = 0/ValoresRestriccion2[4];
                        float S5X2 = 0/ValoresRestriccion2[4];
                   
                    //Restriccion 3
                         ValorSujetoARestriccion3 = ValorSujetoARestriccion3 - (ValoresRestriccion3[4]*ValorSujetoARestriccion2);

                     for(int i=0; i<ValoresRestriccion3.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion3[i] = ValoresRestriccion3[i]-(ValoresRestriccion3[4]*ValoresRestriccion2[i]);
                        }
                         //Valores S1,S2,S3,S4,S5 Para Columna X3
                        float S1X3 = 0 - (ValoresRestriccion3[4]*S1X2);
                        float S2X3 = 0 - (ValoresRestriccion3[4]*S2X2);
                        float S3X3 = 1 - (ValoresRestriccion3[4]*S3X2);
                        float S4X3 = 0 - (ValoresRestriccion3[4]*S4X2);
                        float S5X3 = 0 - (ValoresRestriccion3[4]*S5X2);
                   
                    //Restriccion 2
                     ValorSujetoARestriccion1 = ValorSujetoARestriccion1 - (ValoresRestriccion1[4]*ValorSujetoARestriccion2);

                     for(int i=0; i<ValoresRestriccion1.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion1[i] = ValoresRestriccion1[i]-(ValoresRestriccion1[4]*ValoresRestriccion2[i]);
                        }
                    //Valores S1,S2,S3,S4,S5 Para Columna X2
                        float S1X1 = 1 - (ValoresRestriccion1[4]*S1X2);
                        float S2X1 = 0 - (ValoresRestriccion1[4]*S2X2);
                        float S3X1 = 0 - (ValoresRestriccion1[4]*S3X2);
                        float S4X1 = 0 - (ValoresRestriccion1[4]*S4X2);
                        float S5X1 = 0 - (ValoresRestriccion1[4]*S5X2);
                        //Valor de Z
                         for(int i=0; i<ValoresDeZSimplex.Length; i++)                                   
                        {                                                                 
                            ValoresDeZSimplex[i] = ValoresDeZSimplex[i]-(ValoresDeZSimplex[4]*ValoresRestriccion2[i]);
                        }
                        //Valores Z y CR Para Columna Z
                        float Z = 1 - (ValoresDeZSimplex[4] * 0);
                        float CR = 0 - (ValoresDeZSimplex[4] * ValorSujetoARestriccion2);
                        //Tabla
                     System.Console.WriteLine($"Variables Basicas            Z            X1            X2            X3            X4            X5            S1            S2            S3            S4            S5            CR");
            System.Console.WriteLine($"         X1                  0            {ValoresRestriccion1[0]}           {ValoresRestriccion1[1]}           {ValoresRestriccion1[2]}           {ValoresRestriccion1[3]}           {ValoresRestriccion1[4]}           {S1X1}           {S2X1}           {S3X1}           {S4X1}           {S5X1}           {ValorSujetoARestriccion1}");
            System.Console.WriteLine($"         S2                  0            {ValoresRestriccion2[0]}           {ValoresRestriccion2[1]}           {ValoresRestriccion2[2]}           {ValoresRestriccion2[3]}           {ValoresRestriccion2[4]}           {S1X2}           {S2X2}           {S3X2}           {S4X2}           {S5X2}           {ValorSujetoARestriccion2}");
            System.Console.WriteLine($"         S3                  0            {ValoresRestriccion3[0]}           {ValoresRestriccion3[1]}           {ValoresRestriccion3[2]}           {ValoresRestriccion3[3]}           {ValoresRestriccion3[4]}           {S1X3}           {S2X3}           {S3X3}           {S4X3}           {S5X3}           {ValorSujetoARestriccion3}");
            System.Console.WriteLine($"         S4                  0            {ValoresRestriccion4[0]}           {ValoresRestriccion4[1]}           {ValoresRestriccion4[2]}           {ValoresRestriccion4[3]}           {ValoresRestriccion4[4]}           {S1X4}           {S2X4}           {S3X4}           {S4X4}           {S5X4}           {ValorSujetoARestriccion4}");
            System.Console.WriteLine($"         S5                  0            {ValoresRestriccion5[0]}           {ValoresRestriccion5[1]}           {ValoresRestriccion5[2]}           {ValoresRestriccion5[3]}           {ValoresRestriccion5[4]}           {S1X5}           {S2X5}           {S3X5}           {S4X5}           {S5X5}           {ValorSujetoARestriccion5}");
            System.Console.WriteLine($"          Z                  {Z}            {ValoresDeZSimplex[0]}           {ValoresDeZSimplex[1]}           {ValoresDeZSimplex[2]}           {ValoresDeZSimplex[3]}           {ValoresDeZSimplex[4]}           0           0           0           0           0           {CR}");

            //Tercera Tabla Simplex
                 } //Si es el caso de que la columna S2 sea el mas negativo

                  else if((ValorSujetoARestriccion3/ValoresRestriccion3[4])<(ValorSujetoARestriccion1/ValoresRestriccion1[4])&&(ValorSujetoARestriccion3/ValoresRestriccion3[4])<(ValorSujetoARestriccion2/ValoresRestriccion2[4])&&(ValorSujetoARestriccion3/ValoresRestriccion3[4])<(ValorSujetoARestriccion4/ValoresRestriccion4[4])&&(ValorSujetoARestriccion3/ValoresRestriccion3[4])<(ValorSujetoARestriccion5/ValoresRestriccion5[4]))
                 {
                     System.Console.WriteLine("Segunda Tabla Simplex\n\n"); 
                    //Nuevos Valores Tabla Simplex 2
                    //Restriccion 3
                     ValorSujetoARestriccion3 = ValorSujetoARestriccion3/ValoresRestriccion3[4];
                    for(int i=0; i<ValoresRestriccion3.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion3[i] = ValoresRestriccion3[i]/ValoresRestriccion3[4];
                        }
                        //Valores S1,S2,S3,S4,S5 Para Columna X4
                        float S1X3 = 0/ValoresRestriccion3[4];
                        float S2X3 = 0/ValoresRestriccion3[4];
                        float S3X3 = 1/ValoresRestriccion3[4];
                        float S4X3 = 0/ValoresRestriccion3[4];
                        float S5X3 = 0/ValoresRestriccion3[4];
                   
                    //Restriccion 3
                         ValorSujetoARestriccion1 = ValorSujetoARestriccion1 - (ValoresRestriccion1[4]*ValorSujetoARestriccion3);

                     for(int i=0; i<ValoresRestriccion1.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion1[i] = ValoresRestriccion1[i]-(ValoresRestriccion1[4]*ValoresRestriccion3[i]);
                        }
                         //Valores S1,S2,S3,S4,S5 Para Columna X3
                        float S1X1 = 1 - (ValoresRestriccion1[4]*S1X3);
                        float S2X1 = 0 - (ValoresRestriccion1[4]*S2X3);
                        float S3X1 = 0 - (ValoresRestriccion1[4]*S3X3);
                        float S4X1 = 0 - (ValoresRestriccion1[4]*S4X3);
                        float S5X1 = 0 - (ValoresRestriccion1[4]*S5X3);
                   
                    //Restriccion 2
                     ValorSujetoARestriccion2 = ValorSujetoARestriccion2 - (ValoresRestriccion2[4]*ValorSujetoARestriccion3);

                     for(int i=0; i<ValoresRestriccion2.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion2[i] = ValoresRestriccion2[i]-(ValoresRestriccion2[4]*ValoresRestriccion3[i]);
                        }
                    //Valores S1,S2,S3,S4,S5 Para Columna X2
                        float S1X2 = 0 - (ValoresRestriccion2[4]*S1X3);
                        float S2X2 = 1 - (ValoresRestriccion2[4]*S2X3);
                        float S3X2 = 0 - (ValoresRestriccion2[4]*S3X3);
                        float S4X2 = 0 - (ValoresRestriccion2[4]*S4X3);
                        float S5X2 = 0 - (ValoresRestriccion2[4]*S5X3);
                        //Valor de Z
                         for(int i=0; i<ValoresDeZSimplex.Length; i++)                                   
                        {                                                                 
                            ValoresDeZSimplex[i] = ValoresDeZSimplex[i]-(ValoresDeZSimplex[4]*ValoresRestriccion3[i]);
                        }
                        //Valores Z y CR Para Columna Z
                        float Z = 1 - (ValoresDeZSimplex[4] * 0);
                        float CR = 0 - (ValoresDeZSimplex[4] * ValorSujetoARestriccion3);
                        //Tabla
                     System.Console.WriteLine($"Variables Basicas            Z            X1            X2            X3            X4            X5            S1            S2            S3            S4            S5            CR");
            System.Console.WriteLine($"         X1                  0            {ValoresRestriccion1[0]}           {ValoresRestriccion1[1]}           {ValoresRestriccion1[2]}           {ValoresRestriccion1[3]}           {ValoresRestriccion1[4]}           {S1X1}           {S2X1}           {S3X1}           {S4X1}           {S5X1}           {ValorSujetoARestriccion1}");
            System.Console.WriteLine($"         S2                  0            {ValoresRestriccion2[0]}           {ValoresRestriccion2[1]}           {ValoresRestriccion2[2]}           {ValoresRestriccion2[3]}           {ValoresRestriccion2[4]}           {S1X2}           {S2X2}           {S3X2}           {S4X2}           {S5X2}           {ValorSujetoARestriccion2}");
            System.Console.WriteLine($"         S3                  0            {ValoresRestriccion3[0]}           {ValoresRestriccion3[1]}           {ValoresRestriccion3[2]}           {ValoresRestriccion3[3]}           {ValoresRestriccion3[4]}           {S1X3}           {S2X3}           {S3X3}           {S4X3}           {S5X3}           {ValorSujetoARestriccion3}");
            System.Console.WriteLine($"         S4                  0            {ValoresRestriccion4[0]}           {ValoresRestriccion4[1]}           {ValoresRestriccion4[2]}           {ValoresRestriccion4[3]}           {ValoresRestriccion4[4]}           {S1X4}           {S2X4}           {S3X4}           {S4X4}           {S5X4}           {ValorSujetoARestriccion4}");
            System.Console.WriteLine($"         S5                  0            {ValoresRestriccion5[0]}           {ValoresRestriccion5[1]}           {ValoresRestriccion5[2]}           {ValoresRestriccion5[3]}           {ValoresRestriccion5[4]}           {S1X5}           {S2X5}           {S3X5}           {S4X5}           {S5X5}           {ValorSujetoARestriccion5}");
            System.Console.WriteLine($"          Z                  {Z}            {ValoresDeZSimplex[0]}           {ValoresDeZSimplex[1]}           {ValoresDeZSimplex[2]}           {ValoresDeZSimplex[3]}           {ValoresDeZSimplex[4]}           0           0           0           0           0           {CR}");

            //Tercera Tabla Simplex
                 } //Si es el caso de que la columna S3 sea el mas negativo




            }//Final localizar valor mas negativo de Z para la X5