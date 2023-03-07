using System;                                                
namespace MetodoSimplex                                          
 {                                                               
     public class Simplex                                             
      {                                                                         
         static void Main(string[] args)                                  
          {
    System.Console.WriteLine("Este sera un programa para el metodo simplex");  
    System.Console.WriteLine("Seleccione que metodo se usara ");                                                                
    System.Console.WriteLine("1-Maximizacion             2-Minimizacion");
     int variable =Int32.Parse(System.Console.ReadLine());           
      casos(variable); 

      }

        //metodo para resolver si es maximizacion o minimizacion
        public static  void casos(int variableParaEleccion)
        {        
             float[] ValoresDeZ;                                                                 
             do {
                 //Maximizacion
        if(variableParaEleccion == 1)
        {
        System.Console.WriteLine("usted selecciono Maximizacion");
        System.Console.WriteLine("Empezemos por la funcion objetivo");                                                                      
        ValoresDeZ = ValoresX();
        System.Console.WriteLine("Usted Ingreso los siguientes valores:");
        for(int i=0;i<ValoresDeZ.Length; i++)
        {                                                                                                                                        
        System.Console.WriteLine("X"+(i+1)+":"+ValoresDeZ[i]);   
        }     
      System.Console.WriteLine("\nAhora pasemos con las restricciones\n");
      System.Console.WriteLine("¿Cuantas restricciones tiene su problema?\n\nMaximo 5 Restricciones");
      int RestriccionesNumero = Int32.Parse(System.Console.ReadLine());
      restriccionesXD(RestriccionesNumero,ValoresDeZ,variableParaEleccion);  
        //Minimizacion
        }
        else if(variableParaEleccion ==2)
        {
        System.Console.WriteLine("usted selecciono Minimizacion");
        System.Console.WriteLine("Empezemos por la funcion objetivo");    
        ValoresDeZ = ValoresX();                                  
        System.Console.WriteLine("Usted Ingreso los siguientes valores:");
for(int i=0;i<ValoresDeZ.Length; i++)
 {
System.Console.WriteLine("X"+(i+1)+":"+ValoresDeZ[i]);                                      
 }
    System.Console.WriteLine("\nAhora pasemos con las restricciones\n");
      System.Console.WriteLine("¿Cuantas restricciones tiene su problema?\n\nMaximo 5 Restricciones");
      int RestriccionesNumero = Int32.Parse(System.Console.ReadLine());
      restriccionesXD(RestriccionesNumero,ValoresDeZ,variableParaEleccion);                                             
} 
                                                               
else 
{                                                         
System.Console.WriteLine("Seleccione una opcion valida");         
System.Console.WriteLine("1-Maximizar      2-Minimizar");        
variableParaEleccion = Int32.Parse(System.Console.ReadLine());                                                                      
if(variableParaEleccion == 1)                                            
 {
System.Console.WriteLine("usted selecciono Maximizacion");
System.Console.WriteLine("Empezemos por la funcion objetivo");
ValoresDeZ = ValoresX();                                  
System.Console.WriteLine("Usted Ingreso los siguientes valores"); 
for(int i=0;i<ValoresDeZ.Length; i++)                                
{
    System.Console.WriteLine("X"+(i+1)+":"+ValoresDeZ[i]);
}  
    System.Console.WriteLine("\nAhora pasemos con las restricciones\n");
      System.Console.WriteLine("¿Cuantas restricciones tiene su problema?\n\nMaximo 5 Restricciones");
      int RestriccionesNumero = Int32.Parse(System.Console.ReadLine());
      restriccionesXD(RestriccionesNumero,ValoresDeZ,variableParaEleccion);                                                                                 
}                                                         
else if(variableParaEleccion ==2)
        {                                                                
System.Console.WriteLine("usted selecciono Minimizacion");
System.Console.WriteLine("Empezemos por la funcion objetivo");                                                                                      
ValoresDeZ = ValoresX();                  
System.Console.WriteLine("Usted Ingreso los siguientes valores");                 
for(int i=0;i<ValoresDeZ.Length; i++)
                   {                                                                       
System.Console.WriteLine("X"+(i+1)+":"+ValoresDeZ[i]);                                                                                                                                                                                                         
}          
    System.Console.WriteLine("\nAhora pasemos con las restricciones\n");
      System.Console.WriteLine("¿Cuantas restricciones tiene su problema?\n\nMaximo 5 Restricciones");
      int RestriccionesNumero = Int32.Parse(System.Console.ReadLine());
      restriccionesXD(RestriccionesNumero,ValoresDeZ,variableParaEleccion);
}
else 
{                                                                

}   

}                                      

}while(variableParaEleccion !=1 && variableParaEleccion !=2);

}
    //Termina el metodo para la seleccion

    //Metodo para las restricciones
    public static void restriccionesXD(int variablesRestricciones,float[] ValoresDeZRestriccion,int variableEleccion)
    {
         string decisionRestriccion1,decisionRestriccion2,decisionRestriccion3,decisionRestriccion4,decisionRestriccion5;
         
         float SujetoARestriccion1,SujetoARestriccion2,SujetoARestriccion3,SujetoARestriccion4,SujetoARestriccion5;
         SujetoARestriccion1 = SujetoARestriccion2 = SujetoARestriccion3 = SujetoARestriccion4 = SujetoARestriccion5 =0;
        do
        {
            //Con una restriccion
            if(variablesRestricciones ==1)
            {
              System.Console.WriteLine("Perfecto Usted tiene solo 1 restriccion");
              System.Console.WriteLine("De su restriccion\n");
             float[] Restriccion1 = ValoresX();
            decisionRestriccion1 = VariableDecision();
            SujetoARestriccion1 = SujetoARestriccionGeneral();
             //Segunda restriccion de mentira
            float[] Restriccion2 = {0,0,0,0,0};
             decisionRestriccion2 = "=";
            SujetoARestriccion2 =0;
             //Tercera restriccion de mentira
            float[] Restriccion3 = {0,0,0,0,0};
             decisionRestriccion3 = "=";
            SujetoARestriccion3 =0;
             //Cuarta restriccion de mentira
            float[] Restriccion4 = {0,0,0,0,0};
             decisionRestriccion4 = "=";
            SujetoARestriccion4 =0;
             //Quinta restriccion de mentira
            float[] Restriccion5 = {0,0,0,0,0};
             decisionRestriccion5 = "=";
            SujetoARestriccion5 =0;
            System.Console.WriteLine("Bien sus restricciones quedarian de la siguiente manera: \nRestriccion 1");
            for(int i =0;i<Restriccion1.Length;i++)
            {
                System.Console.WriteLine("X"+(i+1)+": "+Restriccion1[i]);
            }
             System.Console.WriteLine("Y esta sujeto a: "+decisionRestriccion1+" "+SujetoARestriccion1);
             //Ejecucion de todo el metodo simplex
             METODOSIMPLEX1Restriccion(variableEleccion,ValoresDeZRestriccion,Restriccion1,decisionRestriccion1,SujetoARestriccion1);
            }

            else if (variablesRestricciones ==2)
            {
            System.Console.WriteLine("Perfecto Usted tiene 2 restricciones");
            System.Console.WriteLine("De su primera restriccion");
            float[] Restriccion1 = ValoresX();
             decisionRestriccion1 = VariableDecision();
            SujetoARestriccion1 = SujetoARestriccionGeneral();
            System.Console.WriteLine("Ahora de su segunda restriccion");
            float[] Restriccion2 = ValoresX();
            decisionRestriccion2 = VariableDecision();
            SujetoARestriccion2 = SujetoARestriccionGeneral();
             //Tercera restriccion de mentira
            float[] Restriccion3 = {0,0,0,0,0};
             decisionRestriccion3 = "=";
            SujetoARestriccion3 =0;
             //Cuarta restriccion de mentira
            float[] Restriccion4 = {0,0,0,0,0};
             decisionRestriccion4 = "=";
            SujetoARestriccion4 =0;
             //Quinta restriccion de mentira
            float[] Restriccion5 = {0,0,0,0,0};
             decisionRestriccion5 = "=";
            SujetoARestriccion5 =0;
            System.Console.WriteLine("Bien sus restricciones quedarian de la siguiente manera: \nRestriccion 1");
            for(int i =0;i<Restriccion1.Length;i++)
            {
                System.Console.WriteLine("X"+(i+1)+": "+Restriccion1[i]);
            }
             System.Console.WriteLine("Y esta sujeto a: "+decisionRestriccion1+" "+SujetoARestriccion1);
            System.Console.WriteLine("Restriccion 2");
            for(int j =0;j<Restriccion2.Length;j++)
            {
                System.Console.WriteLine("X"+(j+1)+": "+Restriccion2[j]);
            }
             System.Console.WriteLine("Y esta sujeto a: "+decisionRestriccion2+" "+SujetoARestriccion2);
            METODOSIMPLEX2Restriccion(variableEleccion,ValoresDeZRestriccion,Restriccion1,Restriccion2,decisionRestriccion1,decisionRestriccion2,SujetoARestriccion1,SujetoARestriccion2);
            }
             else if (variablesRestricciones ==3)
            {
            System.Console.WriteLine("Perfecto Usted tiene 3 restricciones");
            System.Console.WriteLine("De su primera restriccion");
            float[] Restriccion1 = ValoresX();
             decisionRestriccion1 = VariableDecision();
            SujetoARestriccion1 = SujetoARestriccionGeneral();
            System.Console.WriteLine("Ahora de su segunda restriccion");
            float[] Restriccion2 = ValoresX();
             decisionRestriccion2 = VariableDecision();
            SujetoARestriccion2 = SujetoARestriccionGeneral();
             System.Console.WriteLine("Ahora de su tercera restriccion");
            float[] Restriccion3 = ValoresX();
            decisionRestriccion3 = VariableDecision();
            SujetoARestriccion3 = SujetoARestriccionGeneral();
             //Cuarta restriccion de mentira
            float[] Restriccion4 = {0,0,0,0,0};
             decisionRestriccion4 = "=";
            SujetoARestriccion4 =0;
             //Quinta restriccion de mentira
            float[] Restriccion5 = {0,0,0,0,0};
             decisionRestriccion5 = "=";
            SujetoARestriccion5 =0;
            System.Console.WriteLine("Bien sus restricciones quedarian de la siguiente manera: \nRestriccion 1");
            for(int i =0;i<Restriccion1.Length;i++)
            {
                System.Console.WriteLine("X"+(i+1)+": "+Restriccion1[i]);
            }
             System.Console.WriteLine("Y esta sujeto a: "+decisionRestriccion1+" "+SujetoARestriccion1);
            System.Console.WriteLine("Restriccion 2");
            for(int j =0;j<Restriccion2.Length;j++)
            {
                System.Console.WriteLine("X"+(j+1)+": "+Restriccion2[j]);
            }
             System.Console.WriteLine("Y esta sujeto a: "+decisionRestriccion2+" "+SujetoARestriccion2);
             System.Console.WriteLine("Restriccion 3");
            for(int k =0;k<Restriccion3.Length;k++)
            {
                System.Console.WriteLine("X"+(k+1)+": "+Restriccion3[k]);
            }
             System.Console.WriteLine("Y esta sujeto a: "+decisionRestriccion3+" "+SujetoARestriccion3);
              METODOSIMPLEX3Restriccion(variableEleccion,ValoresDeZRestriccion,Restriccion1,Restriccion2,Restriccion3,decisionRestriccion1,decisionRestriccion2,decisionRestriccion3,SujetoARestriccion1,SujetoARestriccion2,SujetoARestriccion3);
            }
             else if (variablesRestricciones ==4)
            {
            System.Console.WriteLine("Perfecto Usted tiene 4 restricciones");
            System.Console.WriteLine("De su primera restriccion");
            float[] Restriccion1 = ValoresX();
             decisionRestriccion1 = VariableDecision();
            SujetoARestriccion1 = SujetoARestriccionGeneral();
            System.Console.WriteLine("Ahora de su segunda restriccion");
            float[] Restriccion2 = ValoresX();
             decisionRestriccion2 = VariableDecision();
            SujetoARestriccion2 = SujetoARestriccionGeneral();
             System.Console.WriteLine("Ahora de su tercera restriccion");
            float[] Restriccion3 = ValoresX();
             decisionRestriccion3 = VariableDecision();
            SujetoARestriccion3 = SujetoARestriccionGeneral();
             System.Console.WriteLine("Ahora de su cuarta restriccion");
            float[] Restriccion4 = ValoresX();
             decisionRestriccion4 = VariableDecision();
            SujetoARestriccion4 = SujetoARestriccionGeneral();
             //Quinta restriccion de mentira
            float[] Restriccion5 = {0,0,0,0,0};
             decisionRestriccion5 = "=";
            SujetoARestriccion5 =0;
             System.Console.WriteLine("Bien sus restricciones quedarian de la siguiente manera: \nRestriccion 1");
            for(int i =0;i<Restriccion1.Length;i++)
            {
                System.Console.WriteLine("X"+(i+1)+": "+Restriccion1[i]);
            }
             System.Console.WriteLine("Y esta sujeto a: "+decisionRestriccion1+" "+SujetoARestriccion1);
            System.Console.WriteLine("Restriccion 2");
            for(int j =0;j<Restriccion2.Length;j++)
            {
                System.Console.WriteLine("X"+(j+1)+": "+Restriccion2[j]);
            }
             System.Console.WriteLine("Y esta sujeto a: "+decisionRestriccion2+" "+SujetoARestriccion2);
             System.Console.WriteLine("Restriccion 3");
            for(int k =0;k<Restriccion3.Length;k++)
            {
                System.Console.WriteLine("X"+(k+1)+": "+Restriccion3[k]);
            }
             System.Console.WriteLine("Y esta sujeto a: "+decisionRestriccion3+" "+SujetoARestriccion3);
            System.Console.WriteLine("Restriccion 4");
            for(int N =0;N<Restriccion4.Length;N++)
            {
                System.Console.WriteLine("X"+(N+1)+": "+Restriccion4[N]);
            }
             System.Console.WriteLine("Y esta sujeto a: "+decisionRestriccion4+" "+SujetoARestriccion4);
             METODOSIMPLEX4Restriccion(variableEleccion,ValoresDeZRestriccion,Restriccion1,Restriccion2,Restriccion3,Restriccion4,decisionRestriccion1,decisionRestriccion2,decisionRestriccion3,decisionRestriccion4,SujetoARestriccion1,SujetoARestriccion2,SujetoARestriccion3,SujetoARestriccion4);
            }
             else if (variablesRestricciones ==5)
            {
            System.Console.WriteLine("Perfecto Usted tiene 5 restricciones");
            System.Console.WriteLine("De su primera restriccion");
            float[] Restriccion1 = ValoresX();
             decisionRestriccion1 = VariableDecision();
            SujetoARestriccion1 = SujetoARestriccionGeneral();
            System.Console.WriteLine("Ahora de su segunda restriccion");
            float[] Restriccion2 = ValoresX();
             decisionRestriccion2 = VariableDecision();
            SujetoARestriccion2 = SujetoARestriccionGeneral();
             System.Console.WriteLine("Ahora de su tercera restriccion");
            float[] Restriccion3 = ValoresX();
             decisionRestriccion3 = VariableDecision();
            SujetoARestriccion3 = SujetoARestriccionGeneral();
             System.Console.WriteLine("Ahora de su cuarta restriccion");
            float[] Restriccion4 = ValoresX();
             decisionRestriccion4 = VariableDecision();
            SujetoARestriccion4 = SujetoARestriccionGeneral();
             System.Console.WriteLine("Ahora de su quinta restriccion");
            float[] Restriccion5 = ValoresX();
             decisionRestriccion5 = VariableDecision();
            SujetoARestriccion5 = SujetoARestriccionGeneral();
             System.Console.WriteLine("Bien sus restricciones quedarian de la siguiente manera: \nRestriccion 1");
            for(int i =0;i<Restriccion1.Length;i++)
            {
                System.Console.WriteLine("X"+(i+1)+": "+Restriccion1[i]);
            }
             System.Console.WriteLine("Y esta sujeto a: "+decisionRestriccion1+" "+SujetoARestriccion1);
            System.Console.WriteLine("Restriccion 2");
            for(int j =0;j<Restriccion2.Length;j++)
            {
                System.Console.WriteLine("X"+(j+1)+": "+Restriccion2[j]);
            }
             System.Console.WriteLine("Y esta sujeto a: "+decisionRestriccion2+" "+SujetoARestriccion2);
             System.Console.WriteLine("Restriccion 3");
            for(int k =0;k<Restriccion3.Length;k++)
            {
                System.Console.WriteLine("X"+(k+1)+": "+Restriccion3[k]);
            }
             System.Console.WriteLine("Y esta sujeto a: "+decisionRestriccion3+" "+SujetoARestriccion3);
            System.Console.WriteLine("Restriccion 4");
            for(int N =0;N<Restriccion4.Length;N++)
            {
                System.Console.WriteLine("X"+(N+1)+": "+Restriccion4[N]);
            }
             System.Console.WriteLine("Y esta sujeto a: "+decisionRestriccion4+" "+SujetoARestriccion4);
            System.Console.WriteLine("Restriccion 5");
            for(int P =0;P<Restriccion5.Length;P++)
            {
                System.Console.WriteLine("X"+(P+1)+": "+Restriccion5[P]);
            }
             System.Console.WriteLine("Y esta sujeto a: "+decisionRestriccion5+" "+SujetoARestriccion5);
             METODOSIMPLEX5Restriccion(variableEleccion,ValoresDeZRestriccion,Restriccion1,Restriccion2,Restriccion3,Restriccion4,Restriccion5,decisionRestriccion1,decisionRestriccion2,decisionRestriccion3,decisionRestriccion4,decisionRestriccion5,SujetoARestriccion1,SujetoARestriccion2,SujetoARestriccion3,SujetoARestriccion4,SujetoARestriccion5);
            }

             else  
            {
                System.Console.WriteLine("\n\nSeleccione una opcion valida");
                System.Console.WriteLine("¿Cuantas restricciones tiene su problema?\n\nMaximo 5 Restricciones");
                variablesRestricciones = Int32.Parse(System.Console.ReadLine());
                 if(variablesRestricciones ==1)
            {
              System.Console.WriteLine("Perfecto Usted tiene solo 1 restriccion");
              System.Console.WriteLine("De su restriccion\n");
             float[] Restriccion1 = ValoresX();
            decisionRestriccion1 = VariableDecision();
            SujetoARestriccion1 = SujetoARestriccionGeneral();
             //Segunda restriccion de mentira
            float[] Restriccion2 = {0,0,0,0,0};
             decisionRestriccion2 = "=";
            SujetoARestriccion2 =0;
             //Tercera restriccion de mentira
            float[] Restriccion3 = {0,0,0,0,0};
             decisionRestriccion3 = "=";
            SujetoARestriccion3 =0;
             //Cuarta restriccion de mentira
            float[] Restriccion4 = {0,0,0,0,0};
             decisionRestriccion4 = "=";
            SujetoARestriccion4 =0;
             //Quinta restriccion de mentira
            float[] Restriccion5 = {0,0,0,0,0};
             decisionRestriccion5 = "=";
            SujetoARestriccion5 =0;
            System.Console.WriteLine("Bien sus restricciones quedarian de la siguiente manera: \nRestriccion 1");
            for(int i =0;i<Restriccion1.Length;i++)
            {
                System.Console.WriteLine("X"+(i+1)+": "+Restriccion1[i]);
            }
             System.Console.WriteLine("Y esta sujeto a: "+decisionRestriccion1+" "+SujetoARestriccion1);
             //Ejecucion de todo el metodo simplex
             METODOSIMPLEX1Restriccion(variableEleccion,ValoresDeZRestriccion,Restriccion1,decisionRestriccion1,SujetoARestriccion1);
            }

            else if (variablesRestricciones ==2)
            {
            System.Console.WriteLine("Perfecto Usted tiene 2 restricciones");
            System.Console.WriteLine("De su primera restriccion");
            float[] Restriccion1 = ValoresX();
             decisionRestriccion1 = VariableDecision();
            SujetoARestriccion1 = SujetoARestriccionGeneral();
            System.Console.WriteLine("Ahora de su segunda restriccion");
            float[] Restriccion2 = ValoresX();
            decisionRestriccion2 = VariableDecision();
            SujetoARestriccion2 = SujetoARestriccionGeneral();
             //Tercera restriccion de mentira
            float[] Restriccion3 = {0,0,0,0,0};
             decisionRestriccion3 = "=";
            SujetoARestriccion3 =0;
             //Cuarta restriccion de mentira
            float[] Restriccion4 = {0,0,0,0,0};
             decisionRestriccion4 = "=";
            SujetoARestriccion4 =0;
             //Quinta restriccion de mentira
            float[] Restriccion5 = {0,0,0,0,0};
             decisionRestriccion5 = "=";
            SujetoARestriccion5 =0;
            System.Console.WriteLine("Bien sus restricciones quedarian de la siguiente manera: \nRestriccion 1");
            for(int i =0;i<Restriccion1.Length;i++)
            {
                System.Console.WriteLine("X"+(i+1)+": "+Restriccion1[i]);
            }
             System.Console.WriteLine("Y esta sujeto a: "+decisionRestriccion1+" "+SujetoARestriccion1);
            System.Console.WriteLine("Restriccion 2");
            for(int j =0;j<Restriccion2.Length;j++)
            {
                System.Console.WriteLine("X"+(j+1)+": "+Restriccion2[j]);
            }
             System.Console.WriteLine("Y esta sujeto a: "+decisionRestriccion2+" "+SujetoARestriccion2);
            METODOSIMPLEX2Restriccion(variableEleccion,ValoresDeZRestriccion,Restriccion1,Restriccion2,decisionRestriccion1,decisionRestriccion2,SujetoARestriccion1,SujetoARestriccion2);
            }
             else if (variablesRestricciones ==3)
            {
            System.Console.WriteLine("Perfecto Usted tiene 3 restricciones");
            System.Console.WriteLine("De su primera restriccion");
            float[] Restriccion1 = ValoresX();
             decisionRestriccion1 = VariableDecision();
            SujetoARestriccion1 = SujetoARestriccionGeneral();
            System.Console.WriteLine("Ahora de su segunda restriccion");
            float[] Restriccion2 = ValoresX();
             decisionRestriccion2 = VariableDecision();
            SujetoARestriccion2 = SujetoARestriccionGeneral();
             System.Console.WriteLine("Ahora de su tercera restriccion");
            float[] Restriccion3 = ValoresX();
            decisionRestriccion3 = VariableDecision();
            SujetoARestriccion3 = SujetoARestriccionGeneral();
             //Cuarta restriccion de mentira
            float[] Restriccion4 = {0,0,0,0,0};
             decisionRestriccion4 = "=";
            SujetoARestriccion4 =0;
             //Quinta restriccion de mentira
            float[] Restriccion5 = {0,0,0,0,0};
             decisionRestriccion5 = "=";
            SujetoARestriccion5 =0;
            System.Console.WriteLine("Bien sus restricciones quedarian de la siguiente manera: \nRestriccion 1");
            for(int i =0;i<Restriccion1.Length;i++)
            {
                System.Console.WriteLine("X"+(i+1)+": "+Restriccion1[i]);
            }
             System.Console.WriteLine("Y esta sujeto a: "+decisionRestriccion1+" "+SujetoARestriccion1);
            System.Console.WriteLine("Restriccion 2");
            for(int j =0;j<Restriccion2.Length;j++)
            {
                System.Console.WriteLine("X"+(j+1)+": "+Restriccion2[j]);
            }
             System.Console.WriteLine("Y esta sujeto a: "+decisionRestriccion2+" "+SujetoARestriccion2);
             System.Console.WriteLine("Restriccion 3");
            for(int k =0;k<Restriccion3.Length;k++)
            {
                System.Console.WriteLine("X"+(k+1)+": "+Restriccion3[k]);
            }
             System.Console.WriteLine("Y esta sujeto a: "+decisionRestriccion3+" "+SujetoARestriccion3);
              METODOSIMPLEX3Restriccion(variableEleccion,ValoresDeZRestriccion,Restriccion1,Restriccion2,Restriccion3,decisionRestriccion1,decisionRestriccion2,decisionRestriccion3,SujetoARestriccion1,SujetoARestriccion2,SujetoARestriccion3);
            }
             else if (variablesRestricciones ==4)
            {
            System.Console.WriteLine("Perfecto Usted tiene 4 restricciones");
            System.Console.WriteLine("De su primera restriccion");
            float[] Restriccion1 = ValoresX();
             decisionRestriccion1 = VariableDecision();
            SujetoARestriccion1 = SujetoARestriccionGeneral();
            System.Console.WriteLine("Ahora de su segunda restriccion");
            float[] Restriccion2 = ValoresX();
             decisionRestriccion2 = VariableDecision();
            SujetoARestriccion2 = SujetoARestriccionGeneral();
             System.Console.WriteLine("Ahora de su tercera restriccion");
            float[] Restriccion3 = ValoresX();
             decisionRestriccion3 = VariableDecision();
            SujetoARestriccion3 = SujetoARestriccionGeneral();
             System.Console.WriteLine("Ahora de su cuarta restriccion");
            float[] Restriccion4 = ValoresX();
             decisionRestriccion4 = VariableDecision();
            SujetoARestriccion4 = SujetoARestriccionGeneral();
            //Quinta restriccion de mentira
            float[] Restriccion5 = {0,0,0,0,0};
             decisionRestriccion5 = "=";
            SujetoARestriccion5 =0;
             System.Console.WriteLine("Bien sus restricciones quedarian de la siguiente manera: \nRestriccion 1");
            for(int i =0;i<Restriccion1.Length;i++)
            {
                System.Console.WriteLine("X"+(i+1)+": "+Restriccion1[i]);
            }
             System.Console.WriteLine("Y esta sujeto a: "+decisionRestriccion1+" "+SujetoARestriccion1);
            System.Console.WriteLine("Restriccion 2");
            for(int j =0;j<Restriccion2.Length;j++)
            {
                System.Console.WriteLine("X"+(j+1)+": "+Restriccion2[j]);
            }
             System.Console.WriteLine("Y esta sujeto a: "+decisionRestriccion2+" "+SujetoARestriccion2);
             System.Console.WriteLine("Restriccion 3");
            for(int k =0;k<Restriccion3.Length;k++)
            {
                System.Console.WriteLine("X"+(k+1)+": "+Restriccion3[k]);
            }
             System.Console.WriteLine("Y esta sujeto a: "+decisionRestriccion3+" "+SujetoARestriccion3);
            System.Console.WriteLine("Restriccion 4");
            for(int N =0;N<Restriccion4.Length;N++)
            {
                System.Console.WriteLine("X"+(N+1)+": "+Restriccion4[N]);
            }
             System.Console.WriteLine("Y esta sujeto a: "+decisionRestriccion4+" "+SujetoARestriccion4);
             METODOSIMPLEX4Restriccion(variableEleccion,ValoresDeZRestriccion,Restriccion1,Restriccion2,Restriccion3,Restriccion4,decisionRestriccion1,decisionRestriccion2,decisionRestriccion3,decisionRestriccion4,SujetoARestriccion1,SujetoARestriccion2,SujetoARestriccion3,SujetoARestriccion4);
            }
             else if (variablesRestricciones ==5)
            {
            System.Console.WriteLine("Perfecto Usted tiene 5 restricciones");
            System.Console.WriteLine("De su primera restriccion");
            float[] Restriccion1 = ValoresX();
             decisionRestriccion1 = VariableDecision();
            SujetoARestriccion1 = SujetoARestriccionGeneral();
            System.Console.WriteLine("Ahora de su segunda restriccion");
            float[] Restriccion2 = ValoresX();
             decisionRestriccion2 = VariableDecision();
            SujetoARestriccion2 = SujetoARestriccionGeneral();
             System.Console.WriteLine("Ahora de su tercera restriccion");
            float[] Restriccion3 = ValoresX();
             decisionRestriccion3 = VariableDecision();
            SujetoARestriccion3 = SujetoARestriccionGeneral();
             System.Console.WriteLine("Ahora de su cuarta restriccion");
            float[] Restriccion4 = ValoresX();
             decisionRestriccion4 = VariableDecision();
            SujetoARestriccion4 = SujetoARestriccionGeneral();
             System.Console.WriteLine("Ahora de su quinta restriccion");
            float[] Restriccion5 = ValoresX();
             decisionRestriccion5 = VariableDecision();
            SujetoARestriccion5 = SujetoARestriccionGeneral();
             System.Console.WriteLine("Bien sus restricciones quedarian de la siguiente manera: \nRestriccion 1");
            for(int i =0;i<Restriccion1.Length;i++)
            {
                System.Console.WriteLine("X"+(i+1)+": "+Restriccion1[i]);
            }
             System.Console.WriteLine("Y esta sujeto a: "+decisionRestriccion1+" "+SujetoARestriccion1);
            System.Console.WriteLine("Restriccion 2");
            for(int j =0;j<Restriccion2.Length;j++)
            {
                System.Console.WriteLine("X"+(j+1)+": "+Restriccion2[j]);
            }
             System.Console.WriteLine("Y esta sujeto a: "+decisionRestriccion2+" "+SujetoARestriccion2);
             System.Console.WriteLine("Restriccion 3");
            for(int k =0;k<Restriccion3.Length;k++)
            {
                System.Console.WriteLine("X"+(k+1)+": "+Restriccion3[k]);
            }
             System.Console.WriteLine("Y esta sujeto a: "+decisionRestriccion3+" "+SujetoARestriccion3);
            System.Console.WriteLine("Restriccion 4");
            for(int N =0;N<Restriccion4.Length;N++)
            {
                System.Console.WriteLine("X"+(N+1)+": "+Restriccion4[N]);
            }
             System.Console.WriteLine("Y esta sujeto a: "+decisionRestriccion4+" "+SujetoARestriccion4);
            System.Console.WriteLine("Restriccion 5");
            for(int P =0;P<Restriccion5.Length;P++)
            {
                System.Console.WriteLine("X"+(P+1)+": "+Restriccion5[P]);
            }
             System.Console.WriteLine("Y esta sujeto a: "+decisionRestriccion5+" "+SujetoARestriccion5);
             METODOSIMPLEX5Restriccion(variableEleccion,ValoresDeZRestriccion,Restriccion1,Restriccion2,Restriccion3,Restriccion4,Restriccion5,decisionRestriccion1,decisionRestriccion2,decisionRestriccion3,decisionRestriccion4,decisionRestriccion5,SujetoARestriccion1,SujetoARestriccion2,SujetoARestriccion3,SujetoARestriccion4,SujetoARestriccion5);
            }

            else
            {

            }
                
            }
        }while(variablesRestricciones!=1 && variablesRestricciones!=2 && variablesRestricciones !=3 && variablesRestricciones!=4 && variablesRestricciones!=5);
    }

    public static string VariableDecision()
    {
          string decisionRestriccion;
            System.Console.WriteLine("Bien ahora seleccione a que esta sujeto su restriccion\n1-<=\n2-=>\n3-=");
            decisionRestriccion = System.Console.ReadLine();

         do {
                if( decisionRestriccion== "<=")
                {
                System.Console.WriteLine("Bien selecciono <= ahora digame el valor del numero al que es <=");
                }

                else if (decisionRestriccion ==  "=>")
                {
                System.Console.WriteLine("Bien selecciono => ahora digame el valor del numero al que es =>");
                }

                else if(decisionRestriccion == "=")
                {
                 System.Console.WriteLine("Bien selecciono = ahora digame el valor del numero al que es =");
                }
                else
                {
                System.Console.WriteLine("Seleccione una opcion valida");
                System.Console.WriteLine("seleccione a que esta sujeto su restriccion\n1-<=\n2-=>\n3-=");
                decisionRestriccion = System.Console.ReadLine();
                
                   if( decisionRestriccion== "<=")
                {
                System.Console.WriteLine("Bien selecciono <= ahora digame el valor del numero al que es <=");
                }

                else if (decisionRestriccion ==  "=>")
                {
                System.Console.WriteLine("Bien selecciono => ahora digame el valor del numero al que es =>");
                }

                else if(decisionRestriccion == "=")
                {
                 System.Console.WriteLine("Bien selecciono = ahora digame el valor del numero al que es =");
                }
                else
                {
                
                }
                }
            }while(decisionRestriccion != "<="&& decisionRestriccion!= "=" && decisionRestriccion !="=>");
             return decisionRestriccion;
    }
    public static float SujetoARestriccionGeneral()
    {
        float SujetoARestriccion = float.Parse(System.Console.ReadLine());
        return SujetoARestriccion;
    }
    //METODO SIMPLEX CON TODO Y TODO
    // METODOSIMPLEX1Restriccion(variableEleccion,ValoresDeZRestriccion,Restriccion1,decisionRestriccion1,SujetoARestriccion1);
    //Metodo Simplex Con 1 Restriccion
    public static void METODOSIMPLEX1Restriccion(int variableMaximizacionOMinimizacion,float[]ValoresDeZSimplex,float[]ValoresRestriccion1,string ValordecisionRestriccion1,float ValorSujetoARestriccion1)
    {

        if(variableMaximizacionOMinimizacion ==1)
        {
            System.Console.WriteLine("\nMaximizar");
            if(ValoresDeZSimplex.Length ==1)
            {
            System.Console.WriteLine("Z = "+ValoresDeZSimplex[0]+"X");
            }
            else if(ValoresDeZSimplex.Length ==2)
            {
            System.Console.WriteLine("Z = "+ValoresDeZSimplex[0]+"X +" + ValoresDeZSimplex[1]+"X");
            }
             else if(ValoresDeZSimplex.Length ==3)
            {
             System.Console.WriteLine("Z = "+ValoresDeZSimplex[0]+"X +" + ValoresDeZSimplex[1]+"X +"+ValoresDeZSimplex[2]+"X"); 
            }
             else if(ValoresDeZSimplex.Length ==4)
            {
                System.Console.WriteLine("Z = "+ValoresDeZSimplex[0]+"X +" + ValoresDeZSimplex[1]+"X +"+ValoresDeZSimplex[2]+"X +"+ValoresDeZSimplex[3]+"X"); 
            }
             else if(ValoresDeZSimplex.Length ==5)
            {
                 System.Console.WriteLine("Z = "+ValoresDeZSimplex[0]+"X +" + ValoresDeZSimplex[1]+"X +"+ValoresDeZSimplex[2]+"X +"+ValoresDeZSimplex[3]+"X +"+ValoresDeZSimplex[4]+"X"); 
            }
        }
        else if(variableMaximizacionOMinimizacion ==2)
        {
             System.Console.WriteLine("\nMinimizar");
            if(ValoresDeZSimplex.Length ==1)
            {
            System.Console.WriteLine("Z = "+ValoresDeZSimplex[0]+"X");
            }
            else if(ValoresDeZSimplex.Length ==2)
            {
            System.Console.WriteLine("Z = "+ValoresDeZSimplex[0]+"X +" + ValoresDeZSimplex[1]+"X");
            }
             else if(ValoresDeZSimplex.Length ==3)
            {
             System.Console.WriteLine("Z = "+ValoresDeZSimplex[0]+"X +" + ValoresDeZSimplex[1]+"X +"+ValoresDeZSimplex[2]+"X"); 
            }
             else if(ValoresDeZSimplex.Length ==4)
            {
                System.Console.WriteLine("Z = "+ValoresDeZSimplex[0]+"X +" + ValoresDeZSimplex[1]+"X +"+ValoresDeZSimplex[2]+"X +"+ValoresDeZSimplex[3]+"X"); 
            }
             else if(ValoresDeZSimplex.Length ==5)
            {
                 System.Console.WriteLine("Z = "+ValoresDeZSimplex[0]+"X +" + ValoresDeZSimplex[1]+"X +"+ValoresDeZSimplex[2]+"X +"+ValoresDeZSimplex[3]+"X +"+ValoresDeZSimplex[4]+"X"); 
            }
        }
        System.Console.WriteLine("Restricciones");
         if(ValoresRestriccion1.Length ==1)
            {
            System.Console.WriteLine("Restriccion 1 = "+"("+ValoresRestriccion1[0]+"X) "+ValordecisionRestriccion1+" "+ValorSujetoARestriccion1);
            }
            else if(ValoresRestriccion1.Length ==2)
            {
            System.Console.WriteLine("Restriccion 1 = "+"("+ValoresRestriccion1[0]+"X) +"+"("+ValoresRestriccion1[1]+"X) "+ValordecisionRestriccion1+" "+ValorSujetoARestriccion1);
            }
             else if(ValoresRestriccion1.Length ==3)
            {
             System.Console.WriteLine("Restriccion 1 = "+"("+ValoresRestriccion1[0]+"X) +" +"("+ValoresRestriccion1[1]+"X) +"+"("+ValoresRestriccion1[2]+"X) "+ValordecisionRestriccion1+" "+ValorSujetoARestriccion1); 
            }
             else if(ValoresRestriccion1.Length ==4)
            {
                System.Console.WriteLine("Restriccion 1 = "+"("+ValoresRestriccion1[0]+"X) +" +"("+ValoresRestriccion1[1]+"X) +"+"("+ValoresRestriccion1[2]+"X) +"+"("+ValoresRestriccion1[3]+"X) "+ValordecisionRestriccion1+" "+ValorSujetoARestriccion1); 
            }
             else if(ValoresRestriccion1.Length ==5)
            {
                 System.Console.WriteLine("Restriccion 1 = "+"("+ValoresRestriccion1[0]+"X) +"+"("+ValoresRestriccion1[1]+"X) +"+"("+ValoresRestriccion1[2]+"X) +"+"("+ValoresRestriccion1[3]+"X) +"+"("+ValoresRestriccion1[4]+"X) "+ValordecisionRestriccion1+" "+ValorSujetoARestriccion1); 
            }

            System.Console.WriteLine("Primer Tabla Simplex\n\n");
            ValoresDeZSimplex = ValoresXParaZEnSimplex(ValoresDeZSimplex);
            System.Console.WriteLine($"Variables Basicas            Z            X1            X2            X3            X4            X5            S1            S2            S3            S4            S5            CR");
            System.Console.WriteLine($"         S1                  0            {ValoresRestriccion1[0]}           {ValoresRestriccion1[1]}           {ValoresRestriccion1[2]}           {ValoresRestriccion1[3]}           {ValoresRestriccion1[4]}           1           0           0           0           0           {ValorSujetoARestriccion1}");
            System.Console.WriteLine($"          Z                  1            {ValoresDeZSimplex[0]}           {ValoresDeZSimplex[1]}           {ValoresDeZSimplex[2]}           {ValoresDeZSimplex[3]}           {ValoresDeZSimplex[4]}           0           0           0           0           0           0"); 

            //Inicio localizar valor mas negativo de Z para la X1
            if(ValoresDeZSimplex[0]<ValoresDeZSimplex[1]&&ValoresDeZSimplex[0]<ValoresDeZSimplex[2]&&ValoresDeZSimplex[0]<ValoresDeZSimplex[3]&&ValoresDeZSimplex[0]<ValoresDeZSimplex[4])
            {
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

                     for(int i=0; i<ValoresDeZSimplex.Length; i++)                                   
                        {                                                                 
                            ValoresDeZSimplex[i] = ValoresDeZSimplex[i]-(ValoresDeZSimplex[0]*ValoresRestriccion1[i]);
                        }
                        //Valores Z y CR Para Columna Z
                        float Z = 1 - (ValoresDeZSimplex[0] * 0);
                        float CR = 0 - (ValoresDeZSimplex[0] * ValorSujetoARestriccion1);

                        //Tabla
                         System.Console.WriteLine("Segunda Tabla Simplex\n\n");
            ValoresDeZSimplex = ValoresXParaZEnSimplex(ValoresDeZSimplex);
            System.Console.WriteLine($"Variables Basicas            Z            X1            X2            X3            X4            X5            S1            S2            S3            S4            S5            CR");
            System.Console.WriteLine($"         S1                  0            {ValoresRestriccion1[0]}           {ValoresRestriccion1[1]}           {ValoresRestriccion1[2]}           {ValoresRestriccion1[3]}           {ValoresRestriccion1[4]}           {S1X1}           {S2X1}           {S3X1}           {S4X1}           {S5X1}           {ValorSujetoARestriccion1}");
            System.Console.WriteLine($"          Z                  {Z}            {ValoresDeZSimplex[0]}           {ValoresDeZSimplex[1]}           {ValoresDeZSimplex[2]}           {ValoresDeZSimplex[3]}           {ValoresDeZSimplex[4]}           0           0           0           0           0           {CR}"); 

            System.Console.WriteLine("Tercera Tabla Simplex");
            TerceraTablaSimplex1Restriccion(variableMaximizacionOMinimizacion,ValoresDeZSimplex,ValoresRestriccion1,ValordecisionRestriccion1, ValorSujetoARestriccion1);

            }//Final localizar valor mas negativo de Z para la X1
            

            //Inicio localizar valor mas negativo de Z para la X2
            else if(ValoresDeZSimplex[1]<ValoresDeZSimplex[0]&&ValoresDeZSimplex[1]<ValoresDeZSimplex[2]&&ValoresDeZSimplex[1]<ValoresDeZSimplex[3]&&ValoresDeZSimplex[1]<ValoresDeZSimplex[4])
            {
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
                          for(int i=0; i<ValoresDeZSimplex.Length; i++)                                   
                        {                                                                 
                            ValoresDeZSimplex[i] = ValoresDeZSimplex[i]-(ValoresDeZSimplex[1]*ValoresRestriccion1[i]);
                        }
                        //Valores Z y CR Para Columna Z
                        float Z = 1 - (ValoresDeZSimplex[1] * 0);
                        float CR = 0 - (ValoresDeZSimplex[1] * ValorSujetoARestriccion1);

                        //Tabla
                         System.Console.WriteLine("Segunda Tabla Simplex\n\n");
            ValoresDeZSimplex = ValoresXParaZEnSimplex(ValoresDeZSimplex);
            System.Console.WriteLine($"Variables Basicas            Z            X1            X2            X3            X4            X5            S1            S2            S3            S4            S5            CR");
            System.Console.WriteLine($"         S1                  0            {ValoresRestriccion1[0]}           {ValoresRestriccion1[1]}           {ValoresRestriccion1[2]}           {ValoresRestriccion1[3]}           {ValoresRestriccion1[4]}           {S1X1}           {S2X1}           {S3X1}           {S4X1}           {S5X1}           {ValorSujetoARestriccion1}");
            System.Console.WriteLine($"          Z                  {Z}            {ValoresDeZSimplex[0]}           {ValoresDeZSimplex[1]}           {ValoresDeZSimplex[2]}           {ValoresDeZSimplex[3]}           {ValoresDeZSimplex[4]}           0           0           0           0           0           {CR}"); 

             System.Console.WriteLine("Tercera Tabla Simplex");
            TerceraTablaSimplex1Restriccion(variableMaximizacionOMinimizacion,ValoresDeZSimplex,ValoresRestriccion1,ValordecisionRestriccion1, ValorSujetoARestriccion1);
            }//Final localizar valor mas negativo de Z para la X2
            

            //Inicio localizar valor mas negativo de Z para la X3
            else if(ValoresDeZSimplex[2]<ValoresDeZSimplex[1]&&ValoresDeZSimplex[2]<ValoresDeZSimplex[0]&&ValoresDeZSimplex[2]<ValoresDeZSimplex[3]&&ValoresDeZSimplex[2]<ValoresDeZSimplex[4])
            {
                 //Restriccion 1
                     ValorSujetoARestriccion1 = ValorSujetoARestriccion1/ValoresRestriccion1[2];
                    for(int i=0; i<ValoresRestriccion1.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion1[i] = ValoresRestriccion1[i]/ValoresRestriccion1[2];
                        }
                        //Valores S1,S2,S3,S4,S5 Para Columna X1
                        float S1X1 = 1/ValoresRestriccion1[2];
                        float S2X1 = 0/ValoresRestriccion1[2];
                        float S3X1 = 0 /ValoresRestriccion1[2];
                        float S4X1 = 0/ValoresRestriccion1[2];
                        float S5X1 = 0/ValoresRestriccion1[2];
                          for(int i=0; i<ValoresDeZSimplex.Length; i++)                                   
                        {                                                                 
                            ValoresDeZSimplex[i] = ValoresDeZSimplex[i]-(ValoresDeZSimplex[2]*ValoresRestriccion1[i]);
                        }
                        //Valores Z y CR Para Columna Z
                        float Z = 1 - (ValoresDeZSimplex[2] * 0);
                        float CR = 0 - (ValoresDeZSimplex[2] * ValorSujetoARestriccion1);

                        //Tabla
                         System.Console.WriteLine("Segunda Tabla Simplex\n\n");
            ValoresDeZSimplex = ValoresXParaZEnSimplex(ValoresDeZSimplex);
            System.Console.WriteLine($"Variables Basicas            Z            X1            X2            X3            X4            X5            S1            S2            S3            S4            S5            CR");
            System.Console.WriteLine($"         S1                  0            {ValoresRestriccion1[0]}           {ValoresRestriccion1[1]}           {ValoresRestriccion1[2]}           {ValoresRestriccion1[3]}           {ValoresRestriccion1[4]}           {S1X1}           {S2X1}           {S3X1}           {S4X1}           {S5X1}           {ValorSujetoARestriccion1}");
            System.Console.WriteLine($"          Z                  {Z}            {ValoresDeZSimplex[0]}           {ValoresDeZSimplex[1]}           {ValoresDeZSimplex[2]}           {ValoresDeZSimplex[3]}           {ValoresDeZSimplex[4]}           0           0           0           0           0           {CR}"); 
             System.Console.WriteLine("Tercera Tabla Simplex");
            TerceraTablaSimplex1Restriccion(variableMaximizacionOMinimizacion,ValoresDeZSimplex,ValoresRestriccion1,ValordecisionRestriccion1, ValorSujetoARestriccion1);
            }//Final localizar valor mas negativo de Z para la X3


            //Inicio localizar valor mas negativo de Z para la X4
            if(ValoresDeZSimplex[3]<ValoresDeZSimplex[1]&&ValoresDeZSimplex[3]<ValoresDeZSimplex[2]&&ValoresDeZSimplex[3]<ValoresDeZSimplex[0]&&ValoresDeZSimplex[3]<ValoresDeZSimplex[4])
            {
                 //Restriccion 1
                     ValorSujetoARestriccion1 = ValorSujetoARestriccion1/ValoresRestriccion1[3];
                    for(int i=0; i<ValoresRestriccion1.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion1[i] = ValoresRestriccion1[i]/ValoresRestriccion1[3];
                        }
                        //Valores S1,S2,S3,S4,S5 Para Columna X1
                        float S1X1 = 1/ValoresRestriccion1[3];
                        float S2X1 = 0/ValoresRestriccion1[3];
                        float S3X1 = 0 /ValoresRestriccion1[3];
                        float S4X1 = 0/ValoresRestriccion1[3];
                        float S5X1 = 0/ValoresRestriccion1[3];
                          for(int i=0; i<ValoresDeZSimplex.Length; i++)                                   
                        {                                                                 
                            ValoresDeZSimplex[i] = ValoresDeZSimplex[i]-(ValoresDeZSimplex[3]*ValoresRestriccion1[i]);
                        }
                        //Valores Z y CR Para Columna Z
                        float Z = 1 - (ValoresDeZSimplex[3] * 0);
                        float CR = 0 - (ValoresDeZSimplex[3] * ValorSujetoARestriccion1);

                        //Tabla
                         System.Console.WriteLine("Segunda Tabla Simplex\n\n");
            ValoresDeZSimplex = ValoresXParaZEnSimplex(ValoresDeZSimplex);
            System.Console.WriteLine($"Variables Basicas            Z            X1            X2            X3            X4            X5            S1            S2            S3            S4            S5            CR");
            System.Console.WriteLine($"         S1                  0            {ValoresRestriccion1[0]}           {ValoresRestriccion1[1]}           {ValoresRestriccion1[2]}           {ValoresRestriccion1[3]}           {ValoresRestriccion1[4]}           {S1X1}           {S2X1}           {S3X1}           {S4X1}           {S5X1}           {ValorSujetoARestriccion1}");
            System.Console.WriteLine($"          Z                  {Z}            {ValoresDeZSimplex[0]}           {ValoresDeZSimplex[1]}           {ValoresDeZSimplex[2]}           {ValoresDeZSimplex[3]}           {ValoresDeZSimplex[4]}           0           0           0           0           0           {CR}"); 

             System.Console.WriteLine("Tercera Tabla Simplex");
            TerceraTablaSimplex1Restriccion(variableMaximizacionOMinimizacion,ValoresDeZSimplex,ValoresRestriccion1,ValordecisionRestriccion1, ValorSujetoARestriccion1);
            }//Final localizar valor mas negativo de Z para la X4
            
            
            //Inicio localizar valor mas negativo de Z para la X5
            if(ValoresDeZSimplex[4]<ValoresDeZSimplex[1]&&ValoresDeZSimplex[4]<ValoresDeZSimplex[2]&&ValoresDeZSimplex[4]<ValoresDeZSimplex[3]&&ValoresDeZSimplex[4]<ValoresDeZSimplex[0])
            {
                 //Restriccion 1
                     ValorSujetoARestriccion1 = ValorSujetoARestriccion1/ValoresRestriccion1[4];
                    for(int i=0; i<ValoresRestriccion1.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion1[i] = ValoresRestriccion1[i]/ValoresRestriccion1[4];
                        }
                        //Valores S1,S2,S3,S4,S5 Para Columna X1
                        float S1X1 = 1/ValoresRestriccion1[4];
                        float S2X1 = 0/ValoresRestriccion1[4];
                        float S3X1 = 0 /ValoresRestriccion1[4];
                        float S4X1 = 0/ValoresRestriccion1[4];
                        float S5X1 = 0/ValoresRestriccion1[4];
                          for(int i=0; i<ValoresDeZSimplex.Length; i++)                                   
                        {                                                                 
                            ValoresDeZSimplex[i] = ValoresDeZSimplex[i]-(ValoresDeZSimplex[4]*ValoresRestriccion1[i]);
                        }
                        //Valores Z y CR Para Columna Z
                        float Z = 1 - (ValoresDeZSimplex[4] * 0);
                        float CR = 0 - (ValoresDeZSimplex[4] * ValorSujetoARestriccion1);

                        //Tabla
                         System.Console.WriteLine("Segunda Tabla Simplex\n\n");
            ValoresDeZSimplex = ValoresXParaZEnSimplex(ValoresDeZSimplex);
            System.Console.WriteLine($"Variables Basicas            Z            X1            X2            X3            X4            X5            S1            S2            S3            S4            S5            CR");
            System.Console.WriteLine($"         S1                  0            {ValoresRestriccion1[0]}           {ValoresRestriccion1[1]}           {ValoresRestriccion1[2]}           {ValoresRestriccion1[3]}           {ValoresRestriccion1[4]}           {S1X1}           {S2X1}           {S3X1}           {S4X1}           {S5X1}           {ValorSujetoARestriccion1}");
            System.Console.WriteLine($"          Z                  {Z}            {ValoresDeZSimplex[0]}           {ValoresDeZSimplex[1]}           {ValoresDeZSimplex[2]}           {ValoresDeZSimplex[3]}           {ValoresDeZSimplex[4]}           0           0           0           0           0           {CR}"); 

             System.Console.WriteLine("Tercera Tabla Simplex");
            TerceraTablaSimplex1Restriccion(variableMaximizacionOMinimizacion,ValoresDeZSimplex,ValoresRestriccion1,ValordecisionRestriccion1, ValorSujetoARestriccion1);
            }//Final localizar valor mas negativo de Z para la X5
            


    }//Acaba Metodo Simplex con 1 Restriccion








    //Metodo Para Tercera Tabla Simplex de 1 restriccion
    public static void TerceraTablaSimplex1Restriccion(int variableMaximizacionOMinimizacion,float[]ValoresDeZSimplexTerceraTabla,float[]ValoresRestriccion1TerceraTabla,string ValordecisionRestriccion1,float ValorSujetoARestriccion1TerceraTabla)
    {
         if(ValoresDeZSimplexTerceraTabla[0]<ValoresDeZSimplexTerceraTabla[1]&&ValoresDeZSimplexTerceraTabla[0]<ValoresDeZSimplexTerceraTabla[2]&&ValoresDeZSimplexTerceraTabla[0]<ValoresDeZSimplexTerceraTabla[3]&&ValoresDeZSimplexTerceraTabla[0]<ValoresDeZSimplexTerceraTabla[4])
            {
                    //Nuevos Valores Tabla Simplex 2
                    //Restriccion 1
                     ValorSujetoARestriccion1TerceraTabla = ValorSujetoARestriccion1TerceraTabla/ValoresRestriccion1TerceraTabla[0];
                    for(int i=0; i<ValoresRestriccion1TerceraTabla.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion1TerceraTabla[i] = ValoresRestriccion1TerceraTabla[i]/ValoresRestriccion1TerceraTabla[0];
                        }
                        //Valores S1,S2,S3,S4,S5 Para Columna X1
                        float S1X1 = 1/ValoresRestriccion1TerceraTabla[0];
                        float S2X1 = 0/ValoresRestriccion1TerceraTabla[0];
                        float S3X1 = 0 /ValoresRestriccion1TerceraTabla[0];
                        float S4X1 = 0/ValoresRestriccion1TerceraTabla[0];
                        float S5X1 = 0/ValoresRestriccion1TerceraTabla[0];

                     for(int i=0; i<ValoresDeZSimplexTerceraTabla.Length; i++)                                   
                        {                                                                 
                            ValoresDeZSimplexTerceraTabla[i] = ValoresDeZSimplexTerceraTabla[i]-(ValoresDeZSimplexTerceraTabla[0]*ValoresRestriccion1TerceraTabla[i]);
                        }
                        //Valores Z y CR Para Columna Z
                        float Z = 1 - (ValoresDeZSimplexTerceraTabla[0] * 0);
                        float CR = 0 - (ValoresDeZSimplexTerceraTabla[0] * ValorSujetoARestriccion1TerceraTabla);

                        //Tabla
                         System.Console.WriteLine("Tercera Tabla Simplex\n\n");
            ValoresDeZSimplexTerceraTabla = ValoresXParaZEnSimplex(ValoresDeZSimplexTerceraTabla);
            System.Console.WriteLine($"Variables Basicas            Z            X1            X2            X3            X4            X5            S1            S2            S3            S4            S5            CR");
            System.Console.WriteLine($"         S1                  0            {ValoresRestriccion1TerceraTabla[0]}           {ValoresRestriccion1TerceraTabla[1]}           {ValoresRestriccion1TerceraTabla[2]}           {ValoresRestriccion1TerceraTabla[3]}           {ValoresRestriccion1TerceraTabla[4]}           {S1X1}           {S2X1}           {S3X1}           {S4X1}           {S5X1}           {ValorSujetoARestriccion1TerceraTabla}");
            System.Console.WriteLine($"          Z                  {Z}            {ValoresDeZSimplexTerceraTabla[0]}           {ValoresDeZSimplexTerceraTabla[1]}           {ValoresDeZSimplexTerceraTabla[2]}           {ValoresDeZSimplexTerceraTabla[3]}           {ValoresDeZSimplexTerceraTabla[4]}           0           0           0           0           0           {CR}"); 

               }//Final localizar valor mas negativo de Z para la X1
            

            //Inicio localizar valor mas negativo de Z para la X2
            else if(ValoresDeZSimplexTerceraTabla[1]<ValoresDeZSimplexTerceraTabla[0]&&ValoresDeZSimplexTerceraTabla[1]<ValoresDeZSimplexTerceraTabla[2]&&ValoresDeZSimplexTerceraTabla[1]<ValoresDeZSimplexTerceraTabla[3]&&ValoresDeZSimplexTerceraTabla[1]<ValoresDeZSimplexTerceraTabla[4])
            {
                 //Restriccion 1
                     ValorSujetoARestriccion1TerceraTabla = ValorSujetoARestriccion1TerceraTabla/ValoresRestriccion1TerceraTabla[1];
                    for(int i=0; i<ValoresRestriccion1TerceraTabla.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion1TerceraTabla[i] = ValoresRestriccion1TerceraTabla[i]/ValoresRestriccion1TerceraTabla[1];
                        }
                        //Valores S1,S2,S3,S4,S5 Para Columna X1
                        float S1X1 = 1/ValoresRestriccion1TerceraTabla[1];
                        float S2X1 = 0/ValoresRestriccion1TerceraTabla[1];
                        float S3X1 = 0 /ValoresRestriccion1TerceraTabla[0];
                        float S4X1 = 0/ValoresRestriccion1TerceraTabla[1];
                        float S5X1 = 0/ValoresRestriccion1TerceraTabla[1];
                          for(int i=0; i<ValoresDeZSimplexTerceraTabla.Length; i++)                                   
                        {                                                                 
                            ValoresDeZSimplexTerceraTabla[i] = ValoresDeZSimplexTerceraTabla[i]-(ValoresDeZSimplexTerceraTabla[1]*ValoresRestriccion1TerceraTabla[i]);
                        }
                        //Valores Z y CR Para Columna Z
                        float Z = 1 - (ValoresDeZSimplexTerceraTabla[1] * 0);
                        float CR = 0 - (ValoresDeZSimplexTerceraTabla[1] * ValorSujetoARestriccion1TerceraTabla);

                        //Tabla
                         System.Console.WriteLine("Tercera Tabla Simplex\n\n");
            ValoresDeZSimplexTerceraTabla = ValoresXParaZEnSimplex(ValoresDeZSimplexTerceraTabla);
            System.Console.WriteLine($"Variables Basicas            Z            X1            X2            X3            X4            X5            S1            S2            S3            S4            S5            CR");
            System.Console.WriteLine($"         S1                  0            {ValoresRestriccion1TerceraTabla[0]}           {ValoresRestriccion1TerceraTabla[1]}           {ValoresRestriccion1TerceraTabla[2]}           {ValoresRestriccion1TerceraTabla[3]}           {ValoresRestriccion1TerceraTabla[4]}           {S1X1}           {S2X1}           {S3X1}           {S4X1}           {S5X1}           {ValorSujetoARestriccion1TerceraTabla}");
            System.Console.WriteLine($"          Z                  {Z}            {ValoresDeZSimplexTerceraTabla[0]}           {ValoresDeZSimplexTerceraTabla[1]}           {ValoresDeZSimplexTerceraTabla[2]}           {ValoresDeZSimplexTerceraTabla[3]}           {ValoresDeZSimplexTerceraTabla[4]}           0           0           0           0           0           {CR}"); 

            }//Final localizar valor mas negativo de Z para la X2
            

            //Inicio localizar valor mas negativo de Z para la X3
            else if(ValoresDeZSimplexTerceraTabla[2]<ValoresDeZSimplexTerceraTabla[1]&&ValoresDeZSimplexTerceraTabla[2]<ValoresDeZSimplexTerceraTabla[0]&&ValoresDeZSimplexTerceraTabla[2]<ValoresDeZSimplexTerceraTabla[3]&&ValoresDeZSimplexTerceraTabla[2]<ValoresDeZSimplexTerceraTabla[4])
            {
                 //Restriccion 1
                     ValorSujetoARestriccion1TerceraTabla = ValorSujetoARestriccion1TerceraTabla/ValoresRestriccion1TerceraTabla[2];
                    for(int i=0; i<ValoresRestriccion1TerceraTabla.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion1TerceraTabla[i] = ValoresRestriccion1TerceraTabla[i]/ValoresRestriccion1TerceraTabla[2];
                        }
                        //Valores S1,S2,S3,S4,S5 Para Columna X1
                        float S1X1 = 1/ValoresRestriccion1TerceraTabla[2];
                        float S2X1 = 0/ValoresRestriccion1TerceraTabla[2];
                        float S3X1 = 0 /ValoresRestriccion1TerceraTabla[2];
                        float S4X1 = 0/ValoresRestriccion1TerceraTabla[2];
                        float S5X1 = 0/ValoresRestriccion1TerceraTabla[2];
                          for(int i=0; i<ValoresDeZSimplexTerceraTabla.Length; i++)                                   
                        {                                                                 
                            ValoresDeZSimplexTerceraTabla[i] = ValoresDeZSimplexTerceraTabla[i]-(ValoresDeZSimplexTerceraTabla[2]*ValoresRestriccion1TerceraTabla[i]);
                        }
                        //Valores Z y CR Para Columna Z
                        float Z = 1 - (ValoresDeZSimplexTerceraTabla[2] * 0);
                        float CR = 0 - (ValoresDeZSimplexTerceraTabla[2] * ValorSujetoARestriccion1TerceraTabla);

                        //Tabla
                         System.Console.WriteLine("Tercera Tabla Simplex\n\n");
            ValoresDeZSimplexTerceraTabla = ValoresXParaZEnSimplex(ValoresDeZSimplexTerceraTabla);
            System.Console.WriteLine($"Variables Basicas            Z            X1            X2            X3            X4            X5            S1            S2            S3            S4            S5            CR");
            System.Console.WriteLine($"         S1                  0            {ValoresRestriccion1TerceraTabla[0]}           {ValoresRestriccion1TerceraTabla[1]}           {ValoresRestriccion1TerceraTabla[2]}           {ValoresRestriccion1TerceraTabla[3]}           {ValoresRestriccion1TerceraTabla[4]}           {S1X1}           {S2X1}           {S3X1}           {S4X1}           {S5X1}           {ValorSujetoARestriccion1TerceraTabla}");
            System.Console.WriteLine($"          Z                  {Z}            {ValoresDeZSimplexTerceraTabla[0]}           {ValoresDeZSimplexTerceraTabla[1]}           {ValoresDeZSimplexTerceraTabla[2]}           {ValoresDeZSimplexTerceraTabla[3]}           {ValoresDeZSimplexTerceraTabla[4]}           0           0           0           0           0           {CR}"); 

            }//Final localizar valor mas negativo de Z para la X3


            //Inicio localizar valor mas negativo de Z para la X4
            if(ValoresDeZSimplexTerceraTabla[3]<ValoresDeZSimplexTerceraTabla[1]&&ValoresDeZSimplexTerceraTabla[3]<ValoresDeZSimplexTerceraTabla[2]&&ValoresDeZSimplexTerceraTabla[3]<ValoresDeZSimplexTerceraTabla[0]&&ValoresDeZSimplexTerceraTabla[3]<ValoresDeZSimplexTerceraTabla[4])
            {
                 //Restriccion 1
                     ValorSujetoARestriccion1TerceraTabla = ValorSujetoARestriccion1TerceraTabla/ValoresRestriccion1TerceraTabla[3];
                    for(int i=0; i<ValoresRestriccion1TerceraTabla.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion1TerceraTabla[i] = ValoresRestriccion1TerceraTabla[i]/ValoresRestriccion1TerceraTabla[3];
                        }
                        //Valores S1,S2,S3,S4,S5 Para Columna X1
                        float S1X1 = 1/ValoresRestriccion1TerceraTabla[3];
                        float S2X1 = 0/ValoresRestriccion1TerceraTabla[3];
                        float S3X1 = 0 /ValoresRestriccion1TerceraTabla[3];
                        float S4X1 = 0/ValoresRestriccion1TerceraTabla[3];
                        float S5X1 = 0/ValoresRestriccion1TerceraTabla[3];
                          for(int i=0; i<ValoresDeZSimplexTerceraTabla.Length; i++)                                   
                        {                                                                 
                            ValoresDeZSimplexTerceraTabla[i] = ValoresDeZSimplexTerceraTabla[i]-(ValoresDeZSimplexTerceraTabla[3]*ValoresRestriccion1TerceraTabla[i]);
                        }
                        //Valores Z y CR Para Columna Z
                        float Z = 1 - (ValoresDeZSimplexTerceraTabla[3] * 0);
                        float CR = 0 - (ValoresDeZSimplexTerceraTabla[3] * ValorSujetoARestriccion1TerceraTabla);

                        //Tabla
                         System.Console.WriteLine("Primer Tercera Simplex\n\n");
            ValoresDeZSimplexTerceraTabla = ValoresXParaZEnSimplex(ValoresDeZSimplexTerceraTabla);
            System.Console.WriteLine($"Variables Basicas            Z            X1            X2            X3            X4            X5            S1            S2            S3            S4            S5            CR");
            System.Console.WriteLine($"         S1                  0            {ValoresRestriccion1TerceraTabla[0]}           {ValoresRestriccion1TerceraTabla[1]}           {ValoresRestriccion1TerceraTabla[2]}           {ValoresRestriccion1TerceraTabla[3]}           {ValoresRestriccion1TerceraTabla[4]}           {S1X1}           {S2X1}           {S3X1}           {S4X1}           {S5X1}           {ValorSujetoARestriccion1TerceraTabla}");
            System.Console.WriteLine($"          Z                  {Z}            {ValoresDeZSimplexTerceraTabla[0]}           {ValoresDeZSimplexTerceraTabla[1]}           {ValoresDeZSimplexTerceraTabla[2]}           {ValoresDeZSimplexTerceraTabla[3]}           {ValoresDeZSimplexTerceraTabla[4]}           0           0           0           0           0           {CR}"); 

            }//Final localizar valor mas negativo de Z para la X4
            
            
            //Inicio localizar valor mas negativo de Z para la X5
            if(ValoresDeZSimplexTerceraTabla[4]<ValoresDeZSimplexTerceraTabla[1]&&ValoresDeZSimplexTerceraTabla[4]<ValoresDeZSimplexTerceraTabla[2]&&ValoresDeZSimplexTerceraTabla[4]<ValoresDeZSimplexTerceraTabla[3]&&ValoresDeZSimplexTerceraTabla[4]<ValoresDeZSimplexTerceraTabla[0])
            {
                 //Restriccion 1
                     ValorSujetoARestriccion1TerceraTabla = ValorSujetoARestriccion1TerceraTabla/ValoresRestriccion1TerceraTabla[4];
                    for(int i=0; i<ValoresRestriccion1TerceraTabla.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion1TerceraTabla[i] = ValoresRestriccion1TerceraTabla[i]/ValoresRestriccion1TerceraTabla[4];
                        }
                        //Valores S1,S2,S3,S4,S5 Para Columna X1
                        float S1X1 = 1/ValoresRestriccion1TerceraTabla[4];
                        float S2X1 = 0/ValoresRestriccion1TerceraTabla[4];
                        float S3X1 = 0 /ValoresRestriccion1TerceraTabla[4];
                        float S4X1 = 0/ValoresRestriccion1TerceraTabla[4];
                        float S5X1 = 0/ValoresRestriccion1TerceraTabla[4];
                          for(int i=0; i<ValoresDeZSimplexTerceraTabla.Length; i++)                                   
                        {                                                                 
                            ValoresDeZSimplexTerceraTabla[i] = ValoresDeZSimplexTerceraTabla[i]-(ValoresDeZSimplexTerceraTabla[4]*ValoresRestriccion1TerceraTabla[i]);
                        }
                        //Valores Z y CR Para Columna Z
                        float Z = 1 - (ValoresDeZSimplexTerceraTabla[4] * 0);
                        float CR = 0 - (ValoresDeZSimplexTerceraTabla[4] * ValorSujetoARestriccion1TerceraTabla);

                        //Tabla
                         System.Console.WriteLine("Primer Tercera Simplex\n\n");
            ValoresDeZSimplexTerceraTabla = ValoresXParaZEnSimplex(ValoresDeZSimplexTerceraTabla);
            System.Console.WriteLine($"Variables Basicas            Z            X1            X2            X3            X4            X5            S1            S2            S3            S4            S5            CR");
            System.Console.WriteLine($"         S1                  0            {ValoresRestriccion1TerceraTabla[0]}           {ValoresRestriccion1TerceraTabla[1]}           {ValoresRestriccion1TerceraTabla[2]}           {ValoresRestriccion1TerceraTabla[3]}           {ValoresRestriccion1TerceraTabla[4]}           {S1X1}           {S2X1}           {S3X1}           {S4X1}           {S5X1}           {ValorSujetoARestriccion1TerceraTabla}");
            System.Console.WriteLine($"          Z                  {Z}            {ValoresDeZSimplexTerceraTabla[0]}           {ValoresDeZSimplexTerceraTabla[1]}           {ValoresDeZSimplexTerceraTabla[2]}           {ValoresDeZSimplexTerceraTabla[3]}           {ValoresDeZSimplexTerceraTabla[4]}           0           0           0           0           0           {CR}"); 

            }//Final localizar valor mas negativo de Z para la X5

    }//Final metodo tercera tabla simplex con 1 restriccion








    //Metodo Simplex Con 2 Restricciones
     public static void METODOSIMPLEX2Restriccion(int variableMaximizacionOMinimizacion,float[]ValoresDeZSimplex,float[]ValoresRestriccion1,float[]ValoresRestriccion2,string ValordecisionRestriccion1,string ValordecisionRestriccion2,float ValorSujetoARestriccion1,float ValorSujetoARestriccion2)
    {

         if(variableMaximizacionOMinimizacion ==1)
        {
            System.Console.WriteLine("\nMaximizar");
            if(ValoresDeZSimplex.Length ==1)
            {
            System.Console.WriteLine("Z = "+ValoresDeZSimplex[0]+"X");
            }
            else if(ValoresDeZSimplex.Length ==2)
            {
            System.Console.WriteLine("Z = "+ValoresDeZSimplex[0]+"X +" + ValoresDeZSimplex[1]+"X");
            }
             else if(ValoresDeZSimplex.Length ==3)
            {
             System.Console.WriteLine("Z = "+ValoresDeZSimplex[0]+"X +" + ValoresDeZSimplex[1]+"X +"+ValoresDeZSimplex[2]+"X"); 
            }
             else if(ValoresDeZSimplex.Length ==4)
            {
                System.Console.WriteLine("Z = "+ValoresDeZSimplex[0]+"X +" + ValoresDeZSimplex[1]+"X +"+ValoresDeZSimplex[2]+"X +"+ValoresDeZSimplex[3]+"X"); 
            }
             else if(ValoresDeZSimplex.Length ==5)
            {
                 System.Console.WriteLine("Z = "+ValoresDeZSimplex[0]+"X +" + ValoresDeZSimplex[1]+"X +"+ValoresDeZSimplex[2]+"X +"+ValoresDeZSimplex[3]+"X +"+ValoresDeZSimplex[4]+"X"); 
            }
        }
        else if(variableMaximizacionOMinimizacion ==2)
        {
             System.Console.WriteLine("\nMinimizar");
            if(ValoresDeZSimplex.Length ==1)
            {
            System.Console.WriteLine("Z = "+ValoresDeZSimplex[0]+"X");
            }
            else if(ValoresDeZSimplex.Length ==2)
            {
            System.Console.WriteLine("Z = "+ValoresDeZSimplex[0]+"X +" + ValoresDeZSimplex[1]+"X");
            }
             else if(ValoresDeZSimplex.Length ==3)
            {
             System.Console.WriteLine("Z = "+ValoresDeZSimplex[0]+"X +" + ValoresDeZSimplex[1]+"X +"+ValoresDeZSimplex[2]+"X"); 
            }
             else if(ValoresDeZSimplex.Length ==4)
            {
                System.Console.WriteLine("Z = "+ValoresDeZSimplex[0]+"X +" + ValoresDeZSimplex[1]+"X +"+ValoresDeZSimplex[2]+"X +"+ValoresDeZSimplex[3]+"X"); 
            }
             else if(ValoresDeZSimplex.Length ==5)
            {
                 System.Console.WriteLine("Z = "+ValoresDeZSimplex[0]+"X +" + ValoresDeZSimplex[1]+"X +"+ValoresDeZSimplex[2]+"X +"+ValoresDeZSimplex[3]+"X +"+ValoresDeZSimplex[4]+"X"); 
            }
        }
        System.Console.WriteLine("Restricciones");
         if(ValoresRestriccion1.Length ==1)
            {
            System.Console.WriteLine("Restriccion 1 = "+"("+ValoresRestriccion1[0]+"X) "+ValordecisionRestriccion1+" "+ValorSujetoARestriccion1);
            }
            else if(ValoresRestriccion1.Length ==2)
            {
            System.Console.WriteLine("Restriccion 1 = "+"("+ValoresRestriccion1[0]+"X) +"+"("+ValoresRestriccion1[1]+"X) "+ValordecisionRestriccion1+" "+ValorSujetoARestriccion1);
            }
             else if(ValoresRestriccion1.Length ==3)
            {
             System.Console.WriteLine("Restriccion 1 = "+"("+ValoresRestriccion1[0]+"X) +" +"("+ValoresRestriccion1[1]+"X) +"+"("+ValoresRestriccion1[2]+"X) "+ValordecisionRestriccion1+" "+ValorSujetoARestriccion1); 
            }
             else if(ValoresRestriccion1.Length ==4)
            {
                System.Console.WriteLine("Restriccion 1 = "+"("+ValoresRestriccion1[0]+"X) +" +"("+ValoresRestriccion1[1]+"X) +"+"("+ValoresRestriccion1[2]+"X) +"+"("+ValoresRestriccion1[3]+"X) "+ValordecisionRestriccion1+" "+ValorSujetoARestriccion1); 
            }
             else if(ValoresRestriccion1.Length ==5)
            {
                 System.Console.WriteLine("Restriccion 1 = "+"("+ValoresRestriccion1[0]+"X) +"+"("+ValoresRestriccion1[1]+"X) +"+"("+ValoresRestriccion1[2]+"X) +"+"("+ValoresRestriccion1[3]+"X) +"+"("+ValoresRestriccion1[4]+"X) "+ValordecisionRestriccion1+" "+ValorSujetoARestriccion1); 
            }

             if(ValoresRestriccion2.Length ==1)
            {
            System.Console.WriteLine("Restriccion 2 = "+"("+ValoresRestriccion2[0]+"X) "+ValordecisionRestriccion2+" "+ValorSujetoARestriccion2);
            }
            else if(ValoresRestriccion2.Length ==2)
            {
            System.Console.WriteLine("Restriccion 2 = "+"("+ValoresRestriccion2[0]+"X) +"+"("+ValoresRestriccion2[1]+"X) "+ValordecisionRestriccion2+" "+ValorSujetoARestriccion2);
            }
             else if(ValoresRestriccion2.Length ==3)
            {
             System.Console.WriteLine("Restriccion 2 = "+"("+ValoresRestriccion2[0]+"X) +" +"("+ValoresRestriccion2[1]+"X) +"+"("+ValoresRestriccion2[2]+"X) "+ValordecisionRestriccion2+" "+ValorSujetoARestriccion2); 
            }
             else if(ValoresRestriccion2.Length ==4)
            {
                System.Console.WriteLine("Restriccion 2 = "+"("+ValoresRestriccion2[0]+"X) +" +"("+ValoresRestriccion2[1]+"X) +"+"("+ValoresRestriccion2[2]+"X) +"+"("+ValoresRestriccion2[3]+"X) "+ValordecisionRestriccion2+" "+ValorSujetoARestriccion2); 
            }
             else if(ValoresRestriccion2.Length ==5)
            {
                 System.Console.WriteLine("Restriccion 2 = "+"("+ValoresRestriccion2[0]+"X) +"+"("+ValoresRestriccion2[1]+"X) +"+"("+ValoresRestriccion2[2]+"X) +"+"("+ValoresRestriccion2[3]+"X) +"+"("+ValoresRestriccion2[4]+"X) "+ValordecisionRestriccion2+" "+ValorSujetoARestriccion2); 
            }
             System.Console.WriteLine("Primer Tabla Simplex\n\n");
            ValoresDeZSimplex = ValoresXParaZEnSimplex(ValoresDeZSimplex);
            System.Console.WriteLine($"Variables Basicas            Z            X1            X2            X3            X4            X5            S1            S2            S3            S4            S5            CR");
            System.Console.WriteLine($"         S1                  0            {ValoresRestriccion1[0]}           {ValoresRestriccion1[1]}           {ValoresRestriccion1[2]}           {ValoresRestriccion1[3]}           {ValoresRestriccion1[4]}           1           0           0           0           0           {ValorSujetoARestriccion1}");
            System.Console.WriteLine($"         S2                  0            {ValoresRestriccion2[0]}           {ValoresRestriccion2[1]}           {ValoresRestriccion2[2]}           {ValoresRestriccion2[3]}           {ValoresRestriccion2[4]}           0           1           0           0           0           {ValorSujetoARestriccion2}");
            System.Console.WriteLine($"          Z                  1            {ValoresDeZSimplex[0]}           {ValoresDeZSimplex[1]}           {ValoresDeZSimplex[2]}           {ValoresDeZSimplex[3]}           {ValoresDeZSimplex[4]}           0           0           0           0           0           0");
          
            //Segunda Tabla 
            if(ValoresDeZSimplex[0]<ValoresDeZSimplex[1]&&ValoresDeZSimplex[0]<ValoresDeZSimplex[2]&&ValoresDeZSimplex[0]<ValoresDeZSimplex[3]&&ValoresDeZSimplex[0]<ValoresDeZSimplex[4])
            {
                //Comienzo if dentro de la columna de X1 por Z1 , teniendo a la fila de la restriccion 1 como la menor osease S1
                 if((ValorSujetoARestriccion1/ValoresRestriccion1[0])<(ValorSujetoARestriccion2/ValoresRestriccion2[0]))
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
            System.Console.WriteLine($"         S1                  0            {ValoresRestriccion1[0]}           {ValoresRestriccion1[1]}           {ValoresRestriccion1[2]}           {ValoresRestriccion1[3]}           {ValoresRestriccion1[4]}           {S1X1}          {S2X1}           {S3X1}           {S4X1}           {S5X1}           {ValorSujetoARestriccion1}");
            System.Console.WriteLine($"         S2                  0            {ValoresRestriccion2[0]}           {ValoresRestriccion2[1]}           {ValoresRestriccion2[2]}           {ValoresRestriccion2[3]}           {ValoresRestriccion2[4]}           {S1X2}           {S2X2}           {S3X2}           {S4X2}           {S5X2}           {ValorSujetoARestriccion2}");
            System.Console.WriteLine($"          Z                  {Z}            {ValoresDeZSimplex[0]}           {ValoresDeZSimplex[1]}           {ValoresDeZSimplex[2]}           {ValoresDeZSimplex[3]}           {ValoresDeZSimplex[4]}           0           0           0           0           0           {CR}");

            //Tercera Tabla Simplex
        METODOSIMPLEX2RestriccionTerceraTabla(variableMaximizacionOMinimizacion,ValoresDeZSimplex,ValoresRestriccion1,ValoresRestriccion2,ValordecisionRestriccion1, ValordecisionRestriccion2, ValorSujetoARestriccion1,ValorSujetoARestriccion2);
                 } //Si es el caso de que la columna S1 sea el mas negativo 


                 else if((ValorSujetoARestriccion2/ValoresRestriccion2[0])<(ValorSujetoARestriccion1/ValoresRestriccion1[0]))
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
            System.Console.WriteLine($"         S1                  0            {ValoresRestriccion1[0]}           {ValoresRestriccion1[1]}           {ValoresRestriccion1[2]}           {ValoresRestriccion1[3]}           {ValoresRestriccion1[4]}           {S1X1}          {S2X1}           {S3X1}           {S4X1}           {S5X1}           {ValorSujetoARestriccion1}");
            System.Console.WriteLine($"         S2                  0            {ValoresRestriccion2[0]}           {ValoresRestriccion2[1]}           {ValoresRestriccion2[2]}           {ValoresRestriccion2[3]}           {ValoresRestriccion2[4]}           {S1X2}           {S2X2}           {S3X2}           {S4X2}           {S5X2}           {ValorSujetoARestriccion2}");
            System.Console.WriteLine($"          Z                  {Z}            {ValoresDeZSimplex[0]}           {ValoresDeZSimplex[1]}           {ValoresDeZSimplex[2]}           {ValoresDeZSimplex[3]}           {ValoresDeZSimplex[4]}           0           0           0           0           0           {CR}");

            //Tercera Tabla Simplex
         METODOSIMPLEX2RestriccionTerceraTabla(variableMaximizacionOMinimizacion,ValoresDeZSimplex,ValoresRestriccion1,ValoresRestriccion2,ValordecisionRestriccion1, ValordecisionRestriccion2, ValorSujetoARestriccion1,ValorSujetoARestriccion2);
                 } //Si es el caso de que la columna S2 sea el mas negativo

            }//Final localizar valor mas negativo de Z para la X1
            

            //Inicio localizar valor mas negativo de Z para la X2
            else if(ValoresDeZSimplex[1]<ValoresDeZSimplex[0]&&ValoresDeZSimplex[1]<ValoresDeZSimplex[2]&&ValoresDeZSimplex[1]<ValoresDeZSimplex[3]&&ValoresDeZSimplex[1]<ValoresDeZSimplex[4])
            {
                 if((ValorSujetoARestriccion1/ValoresRestriccion1[1])<(ValorSujetoARestriccion2/ValoresRestriccion2[1]))
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
            System.Console.WriteLine($"         S1                  0            {ValoresRestriccion1[0]}           {ValoresRestriccion1[1]}           {ValoresRestriccion1[2]}           {ValoresRestriccion1[3]}           {ValoresRestriccion1[4]}           {S1X1}          {S2X1}           {S3X1}           {S4X1}           {S5X1}           {ValorSujetoARestriccion1}");
            System.Console.WriteLine($"         S2                  0            {ValoresRestriccion2[0]}           {ValoresRestriccion2[1]}           {ValoresRestriccion2[2]}           {ValoresRestriccion2[3]}           {ValoresRestriccion2[4]}           {S1X2}           {S2X2}           {S3X2}           {S4X2}           {S5X2}           {ValorSujetoARestriccion2}");
            System.Console.WriteLine($"          Z                  {Z}            {ValoresDeZSimplex[0]}           {ValoresDeZSimplex[1]}           {ValoresDeZSimplex[2]}           {ValoresDeZSimplex[3]}           {ValoresDeZSimplex[4]}           0           0           0           0           0           {CR}");

            //Tercera Tabla Simplex
             METODOSIMPLEX2RestriccionTerceraTabla(variableMaximizacionOMinimizacion,ValoresDeZSimplex,ValoresRestriccion1,ValoresRestriccion2,ValordecisionRestriccion1, ValordecisionRestriccion2, ValorSujetoARestriccion1,ValorSujetoARestriccion2);


                 } //Si es el caso de que la columna S1 sea el mas negativo 



                 else if((ValorSujetoARestriccion2/ValoresRestriccion2[1])<(ValorSujetoARestriccion1/ValoresRestriccion1[1]))
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
            System.Console.WriteLine($"         S1                  0            {ValoresRestriccion1[0]}           {ValoresRestriccion1[1]}           {ValoresRestriccion1[2]}           {ValoresRestriccion1[3]}           {ValoresRestriccion1[4]}           {S1X1}          {S2X1}           {S3X1}           {S4X1}           {S5X1}           {ValorSujetoARestriccion1}");
            System.Console.WriteLine($"         S2                  0            {ValoresRestriccion2[0]}           {ValoresRestriccion2[1]}           {ValoresRestriccion2[2]}           {ValoresRestriccion2[3]}           {ValoresRestriccion2[4]}           {S1X2}           {S2X2}           {S3X2}           {S4X2}           {S5X2}           {ValorSujetoARestriccion2}");
            System.Console.WriteLine($"          Z                  {Z}            {ValoresDeZSimplex[0]}           {ValoresDeZSimplex[1]}           {ValoresDeZSimplex[2]}           {ValoresDeZSimplex[3]}           {ValoresDeZSimplex[4]}           0           0           0           0           0           {CR}");

            //Tercera Tabla Simplex
             METODOSIMPLEX2RestriccionTerceraTabla(variableMaximizacionOMinimizacion,ValoresDeZSimplex,ValoresRestriccion1,ValoresRestriccion2,ValordecisionRestriccion1, ValordecisionRestriccion2, ValorSujetoARestriccion1,ValorSujetoARestriccion2);
                 } //Si es el caso de que la columna S2 sea el mas negativo

            }//Final localizar valor mas negativo de Z para la X2
            

            //Inicio localizar valor mas negativo de Z para la X3
            else if(ValoresDeZSimplex[2]<ValoresDeZSimplex[1]&&ValoresDeZSimplex[2]<ValoresDeZSimplex[0]&&ValoresDeZSimplex[2]<ValoresDeZSimplex[3]&&ValoresDeZSimplex[2]<ValoresDeZSimplex[4])
            {
                 if((ValorSujetoARestriccion1/ValoresRestriccion1[2])<(ValorSujetoARestriccion2/ValoresRestriccion2[2]))
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
            System.Console.WriteLine($"         S1                  0            {ValoresRestriccion1[0]}           {ValoresRestriccion1[1]}           {ValoresRestriccion1[2]}           {ValoresRestriccion1[3]}           {ValoresRestriccion1[4]}           {S1X1}          {S2X1}           {S3X1}           {S4X1}           {S5X1}           {ValorSujetoARestriccion1}");
            System.Console.WriteLine($"         S2                  0            {ValoresRestriccion2[0]}           {ValoresRestriccion2[1]}           {ValoresRestriccion2[2]}           {ValoresRestriccion2[3]}           {ValoresRestriccion2[4]}           {S1X2}           {S2X2}           {S3X2}           {S4X2}           {S5X2}           {ValorSujetoARestriccion2}");
            System.Console.WriteLine($"          Z                  {Z}            {ValoresDeZSimplex[0]}           {ValoresDeZSimplex[1]}           {ValoresDeZSimplex[2]}           {ValoresDeZSimplex[3]}           {ValoresDeZSimplex[4]}           0           0           0           0           0           {CR}");

            //Tercera Tabla Simplex
             METODOSIMPLEX2RestriccionTerceraTabla(variableMaximizacionOMinimizacion,ValoresDeZSimplex,ValoresRestriccion1,ValoresRestriccion2,ValordecisionRestriccion1, ValordecisionRestriccion2, ValorSujetoARestriccion1,ValorSujetoARestriccion2);
                 } //Si es el caso de que la columna S1 sea el mas negativo 

                 else if((ValorSujetoARestriccion2/ValoresRestriccion2[2])<(ValorSujetoARestriccion1/ValoresRestriccion1[2]))
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
            System.Console.WriteLine($"         S1                  0            {ValoresRestriccion1[0]}           {ValoresRestriccion1[1]}           {ValoresRestriccion1[2]}           {ValoresRestriccion1[3]}           {ValoresRestriccion1[4]}           {S1X1}          {S2X1}           {S3X1}           {S4X1}           {S5X1}           {ValorSujetoARestriccion1}");
            System.Console.WriteLine($"         S2                  0            {ValoresRestriccion2[0]}           {ValoresRestriccion2[1]}           {ValoresRestriccion2[2]}           {ValoresRestriccion2[3]}           {ValoresRestriccion2[4]}           {S1X2}           {S2X2}           {S3X2}           {S4X2}           {S5X2}           {ValorSujetoARestriccion2}");
            System.Console.WriteLine($"          Z                  {Z}            {ValoresDeZSimplex[0]}           {ValoresDeZSimplex[1]}           {ValoresDeZSimplex[2]}           {ValoresDeZSimplex[3]}           {ValoresDeZSimplex[4]}           0           0           0           0           0           {CR}");
            //Tercera Tabla Simplex
             METODOSIMPLEX2RestriccionTerceraTabla(variableMaximizacionOMinimizacion,ValoresDeZSimplex,ValoresRestriccion1,ValoresRestriccion2,ValordecisionRestriccion1, ValordecisionRestriccion2, ValorSujetoARestriccion1,ValorSujetoARestriccion2);
                 } //Si es el caso de que la columna S2 sea el mas negativo

            }//Final localizar valor mas negativo de Z para la X3


            //Inicio localizar valor mas negativo de Z para la X4
            if(ValoresDeZSimplex[3]<ValoresDeZSimplex[1]&&ValoresDeZSimplex[3]<ValoresDeZSimplex[2]&&ValoresDeZSimplex[3]<ValoresDeZSimplex[0]&&ValoresDeZSimplex[3]<ValoresDeZSimplex[4])
            {


                 if((ValorSujetoARestriccion1/ValoresRestriccion1[3])<(ValorSujetoARestriccion2/ValoresRestriccion2[3]))
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
            System.Console.WriteLine($"         S1                  0            {ValoresRestriccion1[0]}           {ValoresRestriccion1[1]}           {ValoresRestriccion1[2]}           {ValoresRestriccion1[3]}           {ValoresRestriccion1[4]}           {S1X1}          {S2X1}           {S3X1}           {S4X1}           {S5X1}           {ValorSujetoARestriccion1}");
            System.Console.WriteLine($"         S2                  0            {ValoresRestriccion2[0]}           {ValoresRestriccion2[1]}           {ValoresRestriccion2[2]}           {ValoresRestriccion2[3]}           {ValoresRestriccion2[4]}           {S1X2}           {S2X2}           {S3X2}           {S4X2}           {S5X2}           {ValorSujetoARestriccion2}");
            System.Console.WriteLine($"          Z                  {Z}            {ValoresDeZSimplex[0]}           {ValoresDeZSimplex[1]}           {ValoresDeZSimplex[2]}           {ValoresDeZSimplex[3]}           {ValoresDeZSimplex[4]}           0           0           0           0           0           {CR}");

            //Tercera Tabla Simplex
             METODOSIMPLEX2RestriccionTerceraTabla(variableMaximizacionOMinimizacion,ValoresDeZSimplex,ValoresRestriccion1,ValoresRestriccion2,ValordecisionRestriccion1, ValordecisionRestriccion2, ValorSujetoARestriccion1,ValorSujetoARestriccion2);
                 } //Si es el caso de que la columna S1 sea el mas negativo 

                 else if((ValorSujetoARestriccion2/ValoresRestriccion2[3])<(ValorSujetoARestriccion1/ValoresRestriccion1[3]))
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
                
                    //Restriccion 1
                     ValorSujetoARestriccion1 = ValorSujetoARestriccion1 - (ValoresRestriccion1[3]*ValorSujetoARestriccion2);

                     for(int i=0; i<ValoresRestriccion1.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion1[i] = ValoresRestriccion1[i]-(ValoresRestriccion1[3]*ValoresRestriccion2[i]);
                        }
                    //Valores S1,S2,S3,S4,S5 Para Columna X1
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
            System.Console.WriteLine($"         S1                  0            {ValoresRestriccion1[0]}           {ValoresRestriccion1[1]}           {ValoresRestriccion1[2]}           {ValoresRestriccion1[3]}           {ValoresRestriccion1[4]}           {S1X1}          {S2X1}           {S3X1}           {S4X1}           {S5X1}           {ValorSujetoARestriccion1}");
            System.Console.WriteLine($"         S2                  0            {ValoresRestriccion2[0]}           {ValoresRestriccion2[1]}           {ValoresRestriccion2[2]}           {ValoresRestriccion2[3]}           {ValoresRestriccion2[4]}           {S1X2}           {S2X2}           {S3X2}           {S4X2}           {S5X2}           {ValorSujetoARestriccion2}");
            System.Console.WriteLine($"          Z                  {Z}            {ValoresDeZSimplex[0]}           {ValoresDeZSimplex[1]}           {ValoresDeZSimplex[2]}           {ValoresDeZSimplex[3]}           {ValoresDeZSimplex[4]}           0           0           0           0           0           {CR}");

            //Tercera Tabla Simplex
             METODOSIMPLEX2RestriccionTerceraTabla(variableMaximizacionOMinimizacion,ValoresDeZSimplex,ValoresRestriccion1,ValoresRestriccion2,ValordecisionRestriccion1, ValordecisionRestriccion2, ValorSujetoARestriccion1,ValorSujetoARestriccion2);
                 } //Si es el caso de que la columna S2 sea el mas negativo


            }//Final localizar valor mas negativo de Z para la X4
            
            
            //Inicio localizar valor mas negativo de Z para la X5
            if(ValoresDeZSimplex[4]<ValoresDeZSimplex[1]&&ValoresDeZSimplex[4]<ValoresDeZSimplex[2]&&ValoresDeZSimplex[4]<ValoresDeZSimplex[3]&&ValoresDeZSimplex[4]<ValoresDeZSimplex[0])
            {
                

                 if((ValorSujetoARestriccion1/ValoresRestriccion1[4])<(ValorSujetoARestriccion2/ValoresRestriccion2[4]))
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
                      System.Console.WriteLine($"Variables Basicas            Z            X1            X2            X3            X4            X5            S1            S2            S3            S4            S5            CR");
            System.Console.WriteLine($"         S1                  0            {ValoresRestriccion1[0]}           {ValoresRestriccion1[1]}           {ValoresRestriccion1[2]}           {ValoresRestriccion1[3]}           {ValoresRestriccion1[4]}           {S1X1}          {S2X1}           {S3X1}           {S4X1}           {S5X1}           {ValorSujetoARestriccion1}");
            System.Console.WriteLine($"         S2                  0            {ValoresRestriccion2[0]}           {ValoresRestriccion2[1]}           {ValoresRestriccion2[2]}           {ValoresRestriccion2[3]}           {ValoresRestriccion2[4]}           {S1X2}           {S2X2}           {S3X2}           {S4X2}           {S5X2}           {ValorSujetoARestriccion2}");
            System.Console.WriteLine($"          Z                  {Z}            {ValoresDeZSimplex[0]}           {ValoresDeZSimplex[1]}           {ValoresDeZSimplex[2]}           {ValoresDeZSimplex[3]}           {ValoresDeZSimplex[4]}           0           0           0           0           0           {CR}");

            //Tercera Tabla Simplex
             METODOSIMPLEX2RestriccionTerceraTabla(variableMaximizacionOMinimizacion,ValoresDeZSimplex,ValoresRestriccion1,ValoresRestriccion2,ValordecisionRestriccion1, ValordecisionRestriccion2, ValorSujetoARestriccion1,ValorSujetoARestriccion2);
                 } //Si es el caso de que la columna S1 sea el mas negativo 

                 else if((ValorSujetoARestriccion2/ValoresRestriccion2[4])<(ValorSujetoARestriccion1/ValoresRestriccion1[4]))
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
                    //Restriccion 1
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
            System.Console.WriteLine($"         S1                  0            {ValoresRestriccion1[0]}           {ValoresRestriccion1[1]}           {ValoresRestriccion1[2]}           {ValoresRestriccion1[3]}           {ValoresRestriccion1[4]}           {S1X1}          {S2X1}           {S3X1}           {S4X1}           {S5X1}           {ValorSujetoARestriccion1}");
            System.Console.WriteLine($"         S2                  0            {ValoresRestriccion2[0]}           {ValoresRestriccion2[1]}           {ValoresRestriccion2[2]}           {ValoresRestriccion2[3]}           {ValoresRestriccion2[4]}           {S1X2}           {S2X2}           {S3X2}           {S4X2}           {S5X2}           {ValorSujetoARestriccion2}");
            System.Console.WriteLine($"          Z                  {Z}            {ValoresDeZSimplex[0]}           {ValoresDeZSimplex[1]}           {ValoresDeZSimplex[2]}           {ValoresDeZSimplex[3]}           {ValoresDeZSimplex[4]}           0           0           0           0           0           {CR}");

            //Tercera Tabla Simplex
             METODOSIMPLEX2RestriccionTerceraTabla(variableMaximizacionOMinimizacion,ValoresDeZSimplex,ValoresRestriccion1,ValoresRestriccion2,ValordecisionRestriccion1, ValordecisionRestriccion2, ValorSujetoARestriccion1,ValorSujetoARestriccion2);
                 } //Si es el caso de que la columna S2 sea el mas negativo

            }//Final localizar valor mas negativo de Z para la X5
    }//Acaba Metodo Simplex con 2 Restricciones


    //Metodo Simplex 2 Restricciones Tercera Tabla
     public static void METODOSIMPLEX2RestriccionTerceraTabla(int variableMaximizacionOMinimizacion,float[]ValoresDeZSimplexTerceraTabla,float[]ValoresRestriccion1TerceraTabla,float[]ValoresRestriccion2TerceraTabla,string ValordecisionRestriccion1,string ValordecisionRestriccion2,float ValorSujetoARestriccion1TerceraTabla,float ValorSujetoARestriccion2TerceraTabla)  
     {

          //Segunda Tabla 
            if(ValoresDeZSimplexTerceraTabla[0]<ValoresDeZSimplexTerceraTabla[1]&&ValoresDeZSimplexTerceraTabla[0]<ValoresDeZSimplexTerceraTabla[2]&&ValoresDeZSimplexTerceraTabla[0]<ValoresDeZSimplexTerceraTabla[3]&&ValoresDeZSimplexTerceraTabla[0]<ValoresDeZSimplexTerceraTabla[4])
            {
                //Comienzo if dentro de la columna de X1 por Z1 , teniendo a la fila de la restriccion 1 como la menor osease S1
                 if((ValorSujetoARestriccion1TerceraTabla/ValoresRestriccion1TerceraTabla[0])<(ValorSujetoARestriccion2TerceraTabla/ValoresRestriccion2TerceraTabla[0]))
                 {
                    System.Console.WriteLine("Tercera Tabla Simplex\n\n"); 
                    //Nuevos Valores Tabla Simplex 2
                    //Restriccion 1
                     ValorSujetoARestriccion1TerceraTabla = ValorSujetoARestriccion1TerceraTabla/ValoresRestriccion1TerceraTabla[0];
                    for(int i=0; i<ValoresRestriccion1TerceraTabla.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion1TerceraTabla[i] = ValoresRestriccion1TerceraTabla[i]/ValoresRestriccion1TerceraTabla[0];
                        }
                        //Valores S1,S2,S3,S4,S5 Para Columna X1
                        float S1X1 = 1/ValoresRestriccion1TerceraTabla[0];
                        float S2X1 = 0/ValoresRestriccion1TerceraTabla[0];
                        float S3X1 = 0 /ValoresRestriccion1TerceraTabla[0];
                        float S4X1 = 0/ValoresRestriccion1TerceraTabla[0];
                        float S5X1 = 0/ValoresRestriccion1TerceraTabla[0];
                    //Restriccion 2
                        ValorSujetoARestriccion2TerceraTabla = ValorSujetoARestriccion2TerceraTabla - (ValoresRestriccion2TerceraTabla[0]*ValorSujetoARestriccion1TerceraTabla);

                     for(int i=0; i<ValoresRestriccion2TerceraTabla.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion2TerceraTabla[i] = ValoresRestriccion2TerceraTabla[i]-(ValoresRestriccion2TerceraTabla[0]*ValoresRestriccion1TerceraTabla[i]);
                        }
                          //Valores S1,S2,S3,S4,S5 Para Columna X2
                        float S1X2 = 0 - (ValoresRestriccion2TerceraTabla[0]*S1X1);
                        float S2X2 = 1 - (ValoresRestriccion2TerceraTabla[0]*S2X1);
                        float S3X2 = 0 - (ValoresRestriccion2TerceraTabla[0]*S3X1);
                        float S4X2 = 0 - (ValoresRestriccion2TerceraTabla[0]*S4X1);
                        float S5X2 = 0 - (ValoresRestriccion2TerceraTabla[0]*S5X1);
                        //Valor de Z
                         for(int i=0; i<ValoresDeZSimplexTerceraTabla.Length; i++)                                   
                        {                                                                 
                            ValoresDeZSimplexTerceraTabla[i] = ValoresDeZSimplexTerceraTabla[i]-(ValoresDeZSimplexTerceraTabla[0]*ValoresRestriccion1TerceraTabla[i]);
                        }
                        //Valores Z y CR Para Columna Z
                        float Z = 1 - (ValoresDeZSimplexTerceraTabla[0] * 0);
                        float CR = 0 - (ValoresDeZSimplexTerceraTabla[0] * ValorSujetoARestriccion1TerceraTabla);
                        //Tabla
                      System.Console.WriteLine($"Variables Basicas            Z            X1            X2            X3            X4            X5            S1            S2            S3            S4            S5            CR");
            System.Console.WriteLine($"         S1                  0            {ValoresRestriccion1TerceraTabla[0]}           {ValoresRestriccion1TerceraTabla[1]}           {ValoresRestriccion1TerceraTabla[2]}           {ValoresRestriccion1TerceraTabla[3]}           {ValoresRestriccion1TerceraTabla[4]}           {S1X1}          {S2X1}           {S3X1}           {S4X1}           {S5X1}           {ValorSujetoARestriccion1TerceraTabla}");
            System.Console.WriteLine($"         S2                  0            {ValoresRestriccion2TerceraTabla[0]}           {ValoresRestriccion2TerceraTabla[1]}           {ValoresRestriccion2TerceraTabla[2]}           {ValoresRestriccion2TerceraTabla[3]}           {ValoresRestriccion2TerceraTabla[4]}           {S1X2}           {S2X2}           {S3X2}           {S4X2}           {S5X2}           {ValorSujetoARestriccion2TerceraTabla}");
            System.Console.WriteLine($"          Z                  {Z}            {ValoresDeZSimplexTerceraTabla[0]}           {ValoresDeZSimplexTerceraTabla[1]}           {ValoresDeZSimplexTerceraTabla[2]}           {ValoresDeZSimplexTerceraTabla[3]}           {ValoresDeZSimplexTerceraTabla[4]}           0           0           0           0           0           {CR}");

            //Tercera Tabla Simplex

                 } //Si es el caso de que la columna S1 sea el mas negativo 


                 else if((ValorSujetoARestriccion2TerceraTabla/ValoresRestriccion2TerceraTabla[0])<(ValorSujetoARestriccion1TerceraTabla/ValoresRestriccion1TerceraTabla[0]))
                 {

                       System.Console.WriteLine("Tercera Tabla Simplex\n\n"); 
                    //Nuevos Valores Tabla Simplex 2
                    //Restriccion 2
                     ValorSujetoARestriccion2TerceraTabla = ValorSujetoARestriccion2TerceraTabla/ValoresRestriccion2TerceraTabla[0];
                    for(int i=0; i<ValoresRestriccion2TerceraTabla.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion2TerceraTabla[i] = ValoresRestriccion2TerceraTabla[i]/ValoresRestriccion2TerceraTabla[0];
                        }
                        //Valores S1,S2,S3,S4,S5 Para Columna X2
                        float S1X2 = 0/ValoresRestriccion2TerceraTabla[0];
                        float S2X2 = 1/ValoresRestriccion2TerceraTabla[0];
                        float S3X2 = 0 /ValoresRestriccion2TerceraTabla[0];
                        float S4X2 = 0/ValoresRestriccion2TerceraTabla[0];
                        float S5X2 = 0/ValoresRestriccion2TerceraTabla[0];
                    //Restriccion 1
                        ValorSujetoARestriccion1TerceraTabla = ValorSujetoARestriccion1TerceraTabla - (ValoresRestriccion1TerceraTabla[0]*ValorSujetoARestriccion2TerceraTabla);

                     for(int i=0; i<ValoresRestriccion1TerceraTabla.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion1TerceraTabla[i] = ValoresRestriccion1TerceraTabla[i]-(ValoresRestriccion1TerceraTabla[0]*ValoresRestriccion2TerceraTabla[i]);
                        }
                          //Valores S1,S2,S3,S4,S5 Para Columna X2
                        float S1X1 = 1 - (ValoresRestriccion1TerceraTabla[0]*S1X2);
                        float S2X1 = 0 - (ValoresRestriccion1TerceraTabla[0]*S2X2);
                        float S3X1 = 0 - (ValoresRestriccion1TerceraTabla[0]*S3X2);
                        float S4X1 = 0 - (ValoresRestriccion1TerceraTabla[0]*S4X2);
                        float S5X1 = 0 - (ValoresRestriccion1TerceraTabla[0]*S5X2);
                        //Valor de Z
                         for(int i=0; i<ValoresDeZSimplexTerceraTabla.Length; i++)                                   
                        {                                                                 
                            ValoresDeZSimplexTerceraTabla[i] = ValoresDeZSimplexTerceraTabla[i]-(ValoresDeZSimplexTerceraTabla[0]*ValoresRestriccion2TerceraTabla[i]);
                        }
                        //Valores Z y CR Para Columna Z
                        float Z = 1 - (ValoresDeZSimplexTerceraTabla[0] * 0);
                        float CR = 0 - (ValoresDeZSimplexTerceraTabla[0] * ValorSujetoARestriccion2TerceraTabla);
                        //Tabla
                      System.Console.WriteLine($"Variables Basicas            Z            X1            X2            X3            X4            X5            S1            S2            S3            S4            S5            CR");
            System.Console.WriteLine($"         S1                  0            {ValoresRestriccion1TerceraTabla[0]}           {ValoresRestriccion1TerceraTabla[1]}           {ValoresRestriccion1TerceraTabla[2]}           {ValoresRestriccion1TerceraTabla[3]}           {ValoresRestriccion1TerceraTabla[4]}           {S1X1}          {S2X1}           {S3X1}           {S4X1}           {S5X1}           {ValorSujetoARestriccion1TerceraTabla}");
            System.Console.WriteLine($"         S2                  0            {ValoresRestriccion2TerceraTabla[0]}           {ValoresRestriccion2TerceraTabla[1]}           {ValoresRestriccion2TerceraTabla[2]}           {ValoresRestriccion2TerceraTabla[3]}           {ValoresRestriccion2TerceraTabla[4]}           {S1X2}           {S2X2}           {S3X2}           {S4X2}           {S5X2}           {ValorSujetoARestriccion2TerceraTabla}");
            System.Console.WriteLine($"          Z                  {Z}            {ValoresDeZSimplexTerceraTabla[0]}           {ValoresDeZSimplexTerceraTabla[1]}           {ValoresDeZSimplexTerceraTabla[2]}           {ValoresDeZSimplexTerceraTabla[3]}           {ValoresDeZSimplexTerceraTabla[4]}           0           0           0           0           0           {CR}");

            //Tercera Tabla Simplex

                 } //Si es el caso de que la columna S2 sea el mas negativo

            }//Final localizar valor mas negativo de Z para la X1
            

            //Inicio localizar valor mas negativo de Z para la X2
            else if(ValoresDeZSimplexTerceraTabla[1]<ValoresDeZSimplexTerceraTabla[0]&&ValoresDeZSimplexTerceraTabla[1]<ValoresDeZSimplexTerceraTabla[2]&&ValoresDeZSimplexTerceraTabla[1]<ValoresDeZSimplexTerceraTabla[3]&&ValoresDeZSimplexTerceraTabla[1]<ValoresDeZSimplexTerceraTabla[4])
            {
                 if((ValorSujetoARestriccion1TerceraTabla/ValoresRestriccion1TerceraTabla[1])<(ValorSujetoARestriccion2TerceraTabla/ValoresRestriccion2TerceraTabla[1]))
                 {


                        System.Console.WriteLine("Tercera Tabla Simplex\n\n"); 
                    //Nuevos Valores Tabla Simplex 2
                    //Restriccion 1
                     ValorSujetoARestriccion1TerceraTabla = ValorSujetoARestriccion1TerceraTabla/ValoresRestriccion1TerceraTabla[1];
                    for(int i=0; i<ValoresRestriccion1TerceraTabla.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion1TerceraTabla[i] = ValoresRestriccion1TerceraTabla[i]/ValoresRestriccion1TerceraTabla[1];
                        }
                        //Valores S1,S2,S3,S4,S5 Para Columna X1
                        float S1X1 = 1/ValoresRestriccion1TerceraTabla[1];
                        float S2X1 = 0/ValoresRestriccion1TerceraTabla[1];
                        float S3X1 = 0 /ValoresRestriccion1TerceraTabla[1];
                        float S4X1 = 0/ValoresRestriccion1TerceraTabla[1];
                        float S5X1 = 0/ValoresRestriccion1TerceraTabla[1];
                    //Restriccion 2
                        ValorSujetoARestriccion2TerceraTabla = ValorSujetoARestriccion2TerceraTabla - (ValoresRestriccion2TerceraTabla[1]*ValorSujetoARestriccion1TerceraTabla);

                     for(int i=0; i<ValoresRestriccion2TerceraTabla.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion2TerceraTabla[i] = ValoresRestriccion2TerceraTabla[i]-(ValoresRestriccion2TerceraTabla[1]*ValoresRestriccion1TerceraTabla[i]);
                        }
                          //Valores S1,S2,S3,S4,S5 Para Columna X2
                        float S1X2 = 0 - (ValoresRestriccion2TerceraTabla[1]*S1X1);
                        float S2X2 = 1 - (ValoresRestriccion2TerceraTabla[1]*S2X1);
                        float S3X2 = 0 - (ValoresRestriccion2TerceraTabla[1]*S3X1);
                        float S4X2 = 0 - (ValoresRestriccion2TerceraTabla[1]*S4X1);
                        float S5X2 = 0 - (ValoresRestriccion2TerceraTabla[1]*S5X1);
                        //Valor de Z
                         for(int i=0; i<ValoresDeZSimplexTerceraTabla.Length; i++)                                   
                        {                                                                 
                            ValoresDeZSimplexTerceraTabla[i] = ValoresDeZSimplexTerceraTabla[i]-(ValoresDeZSimplexTerceraTabla[1]*ValoresRestriccion1TerceraTabla[i]);
                        }
                        //Valores Z y CR Para Columna Z
                        float Z = 1 - (ValoresDeZSimplexTerceraTabla[1] * 0);
                        float CR = 0 - (ValoresDeZSimplexTerceraTabla[1] * ValorSujetoARestriccion1TerceraTabla);
                        //Tabla
                       System.Console.WriteLine($"Variables Basicas            Z            X1            X2            X3            X4            X5            S1            S2            S3            S4            S5            CR");
            System.Console.WriteLine($"         S1                  0            {ValoresRestriccion1TerceraTabla[0]}           {ValoresRestriccion1TerceraTabla[1]}           {ValoresRestriccion1TerceraTabla[2]}           {ValoresRestriccion1TerceraTabla[3]}           {ValoresRestriccion1TerceraTabla[4]}           {S1X1}          {S2X1}           {S3X1}           {S4X1}           {S5X1}           {ValorSujetoARestriccion1TerceraTabla}");
            System.Console.WriteLine($"         S2                  0            {ValoresRestriccion2TerceraTabla[0]}           {ValoresRestriccion2TerceraTabla[1]}           {ValoresRestriccion2TerceraTabla[2]}           {ValoresRestriccion2TerceraTabla[3]}           {ValoresRestriccion2TerceraTabla[4]}           {S1X2}           {S2X2}           {S3X2}           {S4X2}           {S5X2}           {ValorSujetoARestriccion2TerceraTabla}");
            System.Console.WriteLine($"          Z                  {Z}            {ValoresDeZSimplexTerceraTabla[0]}           {ValoresDeZSimplexTerceraTabla[1]}           {ValoresDeZSimplexTerceraTabla[2]}           {ValoresDeZSimplexTerceraTabla[3]}           {ValoresDeZSimplexTerceraTabla[4]}           0           0           0           0           0           {CR}");

            //Tercera Tabla Simplex



                 } //Si es el caso de que la columna S1 sea el mas negativo 



                 else if((ValorSujetoARestriccion2TerceraTabla/ValoresRestriccion2TerceraTabla[1])<(ValorSujetoARestriccion1TerceraTabla/ValoresRestriccion1TerceraTabla[1]))
                 {
                       System.Console.WriteLine("Tercera Tabla Simplex\n\n"); 
                    //Nuevos Valores Tabla Simplex 2
                    //Restriccion 2
                     ValorSujetoARestriccion2TerceraTabla = ValorSujetoARestriccion2TerceraTabla/ValoresRestriccion2TerceraTabla[1];
                    for(int i=0; i<ValoresRestriccion2TerceraTabla.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion2TerceraTabla[i] = ValoresRestriccion2TerceraTabla[i]/ValoresRestriccion2TerceraTabla[1];
                        }
                        //Valores S1,S2,S3,S4,S5 Para Columna X2
                        float S1X2 = 0/ValoresRestriccion2TerceraTabla[1];
                        float S2X2 = 1/ValoresRestriccion2TerceraTabla[1];
                        float S3X2 = 0 /ValoresRestriccion2TerceraTabla[1];
                        float S4X2 = 0/ValoresRestriccion2TerceraTabla[1];
                        float S5X2 = 0/ValoresRestriccion2TerceraTabla[1];
                    //Restriccion 1
                        ValorSujetoARestriccion1TerceraTabla = ValorSujetoARestriccion1TerceraTabla - (ValoresRestriccion1TerceraTabla[1]*ValorSujetoARestriccion2TerceraTabla);

                     for(int i=0; i<ValoresRestriccion1TerceraTabla.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion1TerceraTabla[i] = ValoresRestriccion1TerceraTabla[i]-(ValoresRestriccion1TerceraTabla[1]*ValoresRestriccion2TerceraTabla[i]);
                        }
                          //Valores S1,S2,S3,S4,S5 Para Columna X1
                        float S1X1 = 1 - (ValoresRestriccion1TerceraTabla[1]*S1X2);
                        float S2X1 = 0 - (ValoresRestriccion1TerceraTabla[1]*S2X2);
                        float S3X1 = 0 - (ValoresRestriccion1TerceraTabla[1]*S3X2);
                        float S4X1 = 0 - (ValoresRestriccion1TerceraTabla[1]*S4X2);
                        float S5X1 = 0 - (ValoresRestriccion1TerceraTabla[1]*S5X2);
                        //Valor de Z
                         for(int i=0; i<ValoresDeZSimplexTerceraTabla.Length; i++)                                   
                        {                                                                 
                            ValoresDeZSimplexTerceraTabla[i] = ValoresDeZSimplexTerceraTabla[i]-(ValoresDeZSimplexTerceraTabla[1]*ValoresRestriccion2TerceraTabla[i]);
                        }
                        //Valores Z y CR Para Columna Z
                        float Z = 1 - (ValoresDeZSimplexTerceraTabla[1] * 0);
                        float CR = 0 - (ValoresDeZSimplexTerceraTabla[1] * ValorSujetoARestriccion2TerceraTabla);
                        //Tabla
                      System.Console.WriteLine($"Variables Basicas            Z            X1            X2            X3            X4            X5            S1            S2            S3            S4            S5            CR");
            System.Console.WriteLine($"         S1                  0            {ValoresRestriccion1TerceraTabla[0]}           {ValoresRestriccion1TerceraTabla[1]}           {ValoresRestriccion1TerceraTabla[2]}           {ValoresRestriccion1TerceraTabla[3]}           {ValoresRestriccion1TerceraTabla[4]}           {S1X1}          {S2X1}           {S3X1}           {S4X1}           {S5X1}           {ValorSujetoARestriccion1TerceraTabla}");
            System.Console.WriteLine($"         S2                  0            {ValoresRestriccion2TerceraTabla[0]}           {ValoresRestriccion2TerceraTabla[1]}           {ValoresRestriccion2TerceraTabla[2]}           {ValoresRestriccion2TerceraTabla[3]}           {ValoresRestriccion2TerceraTabla[4]}           {S1X2}           {S2X2}           {S3X2}           {S4X2}           {S5X2}           {ValorSujetoARestriccion2TerceraTabla}");
            System.Console.WriteLine($"          Z                  {Z}            {ValoresDeZSimplexTerceraTabla[0]}           {ValoresDeZSimplexTerceraTabla[1]}           {ValoresDeZSimplexTerceraTabla[2]}           {ValoresDeZSimplexTerceraTabla[3]}           {ValoresDeZSimplexTerceraTabla[4]}           0           0           0           0           0           {CR}");

            //Tercera Tabla Simplex

                 } //Si es el caso de que la columna S2 sea el mas negativo

            }//Final localizar valor mas negativo de Z para la X2
            

            //Inicio localizar valor mas negativo de Z para la X3
            else if(ValoresDeZSimplexTerceraTabla[2]<ValoresDeZSimplexTerceraTabla[1]&&ValoresDeZSimplexTerceraTabla[2]<ValoresDeZSimplexTerceraTabla[0]&&ValoresDeZSimplexTerceraTabla[2]<ValoresDeZSimplexTerceraTabla[3]&&ValoresDeZSimplexTerceraTabla[2]<ValoresDeZSimplexTerceraTabla[4])
            {
                 if((ValorSujetoARestriccion1TerceraTabla/ValoresRestriccion1TerceraTabla[2])<(ValorSujetoARestriccion2TerceraTabla/ValoresRestriccion2TerceraTabla[2]))
                 {
                       System.Console.WriteLine("Tercera Tabla Simplex\n\n"); 
                    //Nuevos Valores Tabla Simplex 2
                    //Restriccion 1
                     ValorSujetoARestriccion1TerceraTabla = ValorSujetoARestriccion1TerceraTabla/ValoresRestriccion1TerceraTabla[2];
                    for(int i=0; i<ValoresRestriccion1TerceraTabla.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion1TerceraTabla[i] = ValoresRestriccion1TerceraTabla[i]/ValoresRestriccion1TerceraTabla[2];
                        }
                        //Valores S1,S2,S3,S4,S5 Para Columna X5
                        float S1X1 = 1/ValoresRestriccion1TerceraTabla[2];
                        float S2X1 = 0/ValoresRestriccion1TerceraTabla[2];
                        float S3X1 = 0/ValoresRestriccion1TerceraTabla[2];
                        float S4X1 = 0/ValoresRestriccion1TerceraTabla[2];
                        float S5X1 = 0/ValoresRestriccion1TerceraTabla[2];
                    //Restriccion 2
                     ValorSujetoARestriccion2TerceraTabla = ValorSujetoARestriccion2TerceraTabla - (ValoresRestriccion2TerceraTabla[2]*ValorSujetoARestriccion1TerceraTabla);

                     for(int i=0; i<ValoresRestriccion2TerceraTabla.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion2TerceraTabla[i] = ValoresRestriccion2TerceraTabla[i]-(ValoresRestriccion2TerceraTabla[2]*ValoresRestriccion1TerceraTabla[i]);
                        }
                    //Valores S1,S2,S3,S4,S5 Para Columna X2
                        float S1X2 = 0 - (ValoresRestriccion2TerceraTabla[2]*S1X1);
                        float S2X2 = 1 - (ValoresRestriccion2TerceraTabla[2]*S2X1);
                        float S3X2 = 0 - (ValoresRestriccion2TerceraTabla[2]*S3X1);
                        float S4X2 = 0 - (ValoresRestriccion2TerceraTabla[2]*S4X1);
                        float S5X2 = 0 - (ValoresRestriccion2TerceraTabla[2]*S5X1);
                        //Valor de Z
                         for(int i=0; i<ValoresDeZSimplexTerceraTabla.Length; i++)                                   
                        {                                                                 
                            ValoresDeZSimplexTerceraTabla[i] = ValoresDeZSimplexTerceraTabla[i]-(ValoresDeZSimplexTerceraTabla[2]*ValoresRestriccion1TerceraTabla[i]);
                        }
                        //Valores Z y CR Para Columna Z
                        float Z = 1 - (ValoresDeZSimplexTerceraTabla[2] * 0);
                        float CR = 0 - (ValoresDeZSimplexTerceraTabla[2] * ValorSujetoARestriccion1TerceraTabla);
                        //Tabla
                     System.Console.WriteLine($"Variables Basicas            Z            X1            X2            X3            X4            X5            S1            S2            S3            S4            S5            CR");
            System.Console.WriteLine($"         S1                  0            {ValoresRestriccion1TerceraTabla[0]}           {ValoresRestriccion1TerceraTabla[1]}           {ValoresRestriccion1TerceraTabla[2]}           {ValoresRestriccion1TerceraTabla[3]}           {ValoresRestriccion1TerceraTabla[4]}           {S1X1}          {S2X1}           {S3X1}           {S4X1}           {S5X1}           {ValorSujetoARestriccion1TerceraTabla}");
            System.Console.WriteLine($"         S2                  0            {ValoresRestriccion2TerceraTabla[0]}           {ValoresRestriccion2TerceraTabla[1]}           {ValoresRestriccion2TerceraTabla[2]}           {ValoresRestriccion2TerceraTabla[3]}           {ValoresRestriccion2TerceraTabla[4]}           {S1X2}           {S2X2}           {S3X2}           {S4X2}           {S5X2}           {ValorSujetoARestriccion2TerceraTabla}");
            System.Console.WriteLine($"          Z                  {Z}            {ValoresDeZSimplexTerceraTabla[0]}           {ValoresDeZSimplexTerceraTabla[1]}           {ValoresDeZSimplexTerceraTabla[2]}           {ValoresDeZSimplexTerceraTabla[3]}           {ValoresDeZSimplexTerceraTabla[4]}           0           0           0           0           0           {CR}");

            //Tercera Tabla Simplex
                 } //Si es el caso de que la columna S1 sea el mas negativo 

                 else if((ValorSujetoARestriccion2TerceraTabla/ValoresRestriccion2TerceraTabla[2])<(ValorSujetoARestriccion1TerceraTabla/ValoresRestriccion1TerceraTabla[2]))
                 {
                      System.Console.WriteLine("Tercera Tabla Simplex\n\n"); 
                    //Nuevos Valores Tabla Simplex 2
                    //Restriccion 2
                     ValorSujetoARestriccion2TerceraTabla = ValorSujetoARestriccion2TerceraTabla/ValoresRestriccion2TerceraTabla[2];
                    for(int i=0; i<ValoresRestriccion2TerceraTabla.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion2TerceraTabla[i] = ValoresRestriccion2TerceraTabla[i]/ValoresRestriccion2TerceraTabla[2];
                        }
                        //Valores S1,S2,S3,S4,S5 Para Columna X2
                        float S1X2 = 0/ValoresRestriccion2TerceraTabla[2];
                        float S2X2 = 1/ValoresRestriccion2TerceraTabla[2];
                        float S3X2 = 0/ValoresRestriccion2TerceraTabla[2];
                        float S4X2 = 0/ValoresRestriccion2TerceraTabla[2];
                        float S5X2 = 0/ValoresRestriccion2TerceraTabla[2];
                    //Restriccion 2
                     ValorSujetoARestriccion1TerceraTabla = ValorSujetoARestriccion1TerceraTabla - (ValoresRestriccion1TerceraTabla[2]*ValorSujetoARestriccion2TerceraTabla);

                     for(int i=0; i<ValoresRestriccion1TerceraTabla.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion1TerceraTabla[i] = ValoresRestriccion1TerceraTabla[i]-(ValoresRestriccion1TerceraTabla[2]*ValoresRestriccion2TerceraTabla[i]);
                        }
                    //Valores S1,S2,S3,S4,S5 Para Columna X2
                        float S1X1 = 1 - (ValoresRestriccion1TerceraTabla[2]*S1X2);
                        float S2X1 = 0 - (ValoresRestriccion1TerceraTabla[2]*S2X2);
                        float S3X1 = 0 - (ValoresRestriccion1TerceraTabla[2]*S3X2);
                        float S4X1 = 0 - (ValoresRestriccion1TerceraTabla[2]*S4X2);
                        float S5X1 = 0 - (ValoresRestriccion1TerceraTabla[2]*S5X2);
                        //Valor de Z
                         for(int i=0; i<ValoresDeZSimplexTerceraTabla.Length; i++)                                   
                        {                                                                 
                            ValoresDeZSimplexTerceraTabla[i] = ValoresDeZSimplexTerceraTabla[i]-(ValoresDeZSimplexTerceraTabla[2]*ValoresRestriccion2TerceraTabla[i]);
                        }
                        //Valores Z y CR Para Columna Z
                        float Z = 1 - (ValoresDeZSimplexTerceraTabla[2] * 0);
                        float CR = 0 - (ValoresDeZSimplexTerceraTabla[2] * ValorSujetoARestriccion2TerceraTabla);
                        //Tabla
                      System.Console.WriteLine($"Variables Basicas            Z            X1            X2            X3            X4            X5            S1            S2            S3            S4            S5            CR");
            System.Console.WriteLine($"         S1                  0            {ValoresRestriccion1TerceraTabla[0]}           {ValoresRestriccion1TerceraTabla[1]}           {ValoresRestriccion1TerceraTabla[2]}           {ValoresRestriccion1TerceraTabla[3]}           {ValoresRestriccion1TerceraTabla[4]}           {S1X1}          {S2X1}           {S3X1}           {S4X1}           {S5X1}           {ValorSujetoARestriccion1TerceraTabla}");
            System.Console.WriteLine($"         S2                  0            {ValoresRestriccion2TerceraTabla[0]}           {ValoresRestriccion2TerceraTabla[1]}           {ValoresRestriccion2TerceraTabla[2]}           {ValoresRestriccion2TerceraTabla[3]}           {ValoresRestriccion2TerceraTabla[4]}           {S1X2}           {S2X2}           {S3X2}           {S4X2}           {S5X2}           {ValorSujetoARestriccion2TerceraTabla}");
            System.Console.WriteLine($"          Z                  {Z}            {ValoresDeZSimplexTerceraTabla[0]}           {ValoresDeZSimplexTerceraTabla[1]}           {ValoresDeZSimplexTerceraTabla[2]}           {ValoresDeZSimplexTerceraTabla[3]}           {ValoresDeZSimplexTerceraTabla[4]}           0           0           0           0           0           {CR}");
            //Tercera Tabla Simplex
                 } //Si es el caso de que la columna S2 sea el mas negativo

            }//Final localizar valor mas negativo de Z para la X3


            //Inicio localizar valor mas negativo de Z para la X4
            if(ValoresDeZSimplexTerceraTabla[3]<ValoresDeZSimplexTerceraTabla[1]&&ValoresDeZSimplexTerceraTabla[3]<ValoresDeZSimplexTerceraTabla[2]&&ValoresDeZSimplexTerceraTabla[3]<ValoresDeZSimplexTerceraTabla[0]&&ValoresDeZSimplexTerceraTabla[3]<ValoresDeZSimplexTerceraTabla[4])
            {


                 if((ValorSujetoARestriccion1TerceraTabla/ValoresRestriccion1TerceraTabla[3])<(ValorSujetoARestriccion2TerceraTabla/ValoresRestriccion2TerceraTabla[3]))
                 {
                     System.Console.WriteLine("Tercera Tabla Simplex\n\n"); 
                    //Nuevos Valores Tabla Simplex 2
                    //Restriccion 1
                     ValorSujetoARestriccion1TerceraTabla = ValorSujetoARestriccion1TerceraTabla/ValoresRestriccion1TerceraTabla[3];
                    for(int i=0; i<ValoresRestriccion1TerceraTabla.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion1TerceraTabla[i] = ValoresRestriccion1TerceraTabla[i]/ValoresRestriccion1TerceraTabla[3];
                        }
                        //Valores S1,S2,S3,S4,S5 Para Columna X4
                        float S1X1 = 1/ValoresRestriccion1TerceraTabla[3];
                        float S2X1 = 0/ValoresRestriccion1TerceraTabla[3];
                        float S3X1 = 0/ValoresRestriccion1TerceraTabla[3];
                        float S4X1 = 0/ValoresRestriccion1TerceraTabla[3];
                        float S5X1 = 0/ValoresRestriccion1TerceraTabla[3];
                    //Restriccion 2
                     ValorSujetoARestriccion2TerceraTabla = ValorSujetoARestriccion2TerceraTabla - (ValoresRestriccion2TerceraTabla[3]*ValorSujetoARestriccion1TerceraTabla);

                     for(int i=0; i<ValoresRestriccion2TerceraTabla.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion2TerceraTabla[i] = ValoresRestriccion2TerceraTabla[i]-(ValoresRestriccion2TerceraTabla[3]*ValoresRestriccion1TerceraTabla[i]);
                        }
                    //Valores S1,S2,S3,S4,S5 Para Columna X2
                        float S1X2 = 0 - (ValoresRestriccion2TerceraTabla[3]*S1X1);
                        float S2X2 = 1 - (ValoresRestriccion2TerceraTabla[3]*S2X1);
                        float S3X2 = 0 - (ValoresRestriccion2TerceraTabla[3]*S3X1);
                        float S4X2 = 0 - (ValoresRestriccion2TerceraTabla[3]*S4X1);
                        float S5X2 = 0 - (ValoresRestriccion2TerceraTabla[3]*S5X1);
                        //Valor de Z
                         for(int i=0; i<ValoresDeZSimplexTerceraTabla.Length; i++)                                   
                        {                                                                 
                            ValoresDeZSimplexTerceraTabla[i] = ValoresDeZSimplexTerceraTabla[i]-(ValoresDeZSimplexTerceraTabla[3]*ValoresRestriccion1TerceraTabla[i]);
                        }
                        //Valores Z y CR Para Columna Z
                        float Z = 1 - (ValoresDeZSimplexTerceraTabla[3] * 0);
                        float CR = 0 - (ValoresDeZSimplexTerceraTabla[3] * ValorSujetoARestriccion1TerceraTabla);
                        //Tabla
                      System.Console.WriteLine($"Variables Basicas            Z            X1            X2            X3            X4            X5            S1            S2            S3            S4            S5            CR");
            System.Console.WriteLine($"         S1                  0            {ValoresRestriccion1TerceraTabla[0]}           {ValoresRestriccion1TerceraTabla[1]}           {ValoresRestriccion1TerceraTabla[2]}           {ValoresRestriccion1TerceraTabla[3]}           {ValoresRestriccion1TerceraTabla[4]}           {S1X1}          {S2X1}           {S3X1}           {S4X1}           {S5X1}           {ValorSujetoARestriccion1TerceraTabla}");
            System.Console.WriteLine($"         S2                  0            {ValoresRestriccion2TerceraTabla[0]}           {ValoresRestriccion2TerceraTabla[1]}           {ValoresRestriccion2TerceraTabla[2]}           {ValoresRestriccion2TerceraTabla[3]}           {ValoresRestriccion2TerceraTabla[4]}           {S1X2}           {S2X2}           {S3X2}           {S4X2}           {S5X2}           {ValorSujetoARestriccion2TerceraTabla}");
            System.Console.WriteLine($"          Z                  {Z}            {ValoresDeZSimplexTerceraTabla[0]}           {ValoresDeZSimplexTerceraTabla[1]}           {ValoresDeZSimplexTerceraTabla[2]}           {ValoresDeZSimplexTerceraTabla[3]}           {ValoresDeZSimplexTerceraTabla[4]}           0           0           0           0           0           {CR}");

            //Tercera Tabla Simplex
                 } //Si es el caso de que la columna S1 sea el mas negativo 

                 else if((ValorSujetoARestriccion2TerceraTabla/ValoresRestriccion2TerceraTabla[3])<(ValorSujetoARestriccion1TerceraTabla/ValoresRestriccion1TerceraTabla[3]))
                 {
                     System.Console.WriteLine("Tercera Tabla Simplex\n\n"); 
                    //Nuevos Valores Tabla Simplex 2
                    //Restriccion 2
                     ValorSujetoARestriccion2TerceraTabla = ValorSujetoARestriccion2TerceraTabla/ValoresRestriccion2TerceraTabla[3];
                    for(int i=0; i<ValoresRestriccion2TerceraTabla.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion2TerceraTabla[i] = ValoresRestriccion2TerceraTabla[i]/ValoresRestriccion2TerceraTabla[3];
                        }
                        //Valores S1,S2,S3,S4,S5 Para Columna X4
                        float S1X2 = 0/ValoresRestriccion2TerceraTabla[3];
                        float S2X2 = 1/ValoresRestriccion2TerceraTabla[3];
                        float S3X2 = 0/ValoresRestriccion2TerceraTabla[3];
                        float S4X2 = 0/ValoresRestriccion2TerceraTabla[3];
                        float S5X2 = 0/ValoresRestriccion2TerceraTabla[3];
                
                    //Restriccion 1
                     ValorSujetoARestriccion1TerceraTabla = ValorSujetoARestriccion1TerceraTabla - (ValoresRestriccion1TerceraTabla[3]*ValorSujetoARestriccion2TerceraTabla);

                     for(int i=0; i<ValoresRestriccion1TerceraTabla.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion1TerceraTabla[i] = ValoresRestriccion1TerceraTabla[i]-(ValoresRestriccion1TerceraTabla[3]*ValoresRestriccion2TerceraTabla[i]);
                        }
                    //Valores S1,S2,S3,S4,S5 Para Columna X1
                        float S1X1 = 1 - (ValoresRestriccion1TerceraTabla[3]*S1X2);
                        float S2X1 = 0 - (ValoresRestriccion1TerceraTabla[3]*S2X2);
                        float S3X1 = 0 - (ValoresRestriccion1TerceraTabla[3]*S3X2);
                        float S4X1 = 0 - (ValoresRestriccion1TerceraTabla[3]*S4X2);
                        float S5X1 = 0 - (ValoresRestriccion1TerceraTabla[3]*S5X2);
                        //Valor de Z
                         for(int i=0; i<ValoresDeZSimplexTerceraTabla.Length; i++)                                   
                        {                                                                 
                            ValoresDeZSimplexTerceraTabla[i] = ValoresDeZSimplexTerceraTabla[i]-(ValoresDeZSimplexTerceraTabla[3]*ValoresRestriccion2TerceraTabla[i]);
                        }
                        //Valores Z y CR Para Columna Z
                        float Z = 1 - (ValoresDeZSimplexTerceraTabla[3] * 0);
                        float CR = 0 - (ValoresDeZSimplexTerceraTabla[3] * ValorSujetoARestriccion2TerceraTabla);
                        //Tabla
                       System.Console.WriteLine($"Variables Basicas            Z            X1            X2            X3            X4            X5            S1            S2            S3            S4            S5            CR");
            System.Console.WriteLine($"         S1                  0            {ValoresRestriccion1TerceraTabla[0]}           {ValoresRestriccion1TerceraTabla[1]}           {ValoresRestriccion1TerceraTabla[2]}           {ValoresRestriccion1TerceraTabla[3]}           {ValoresRestriccion1TerceraTabla[4]}           {S1X1}          {S2X1}           {S3X1}           {S4X1}           {S5X1}           {ValorSujetoARestriccion1TerceraTabla}");
            System.Console.WriteLine($"         S2                  0            {ValoresRestriccion2TerceraTabla[0]}           {ValoresRestriccion2TerceraTabla[1]}           {ValoresRestriccion2TerceraTabla[2]}           {ValoresRestriccion2TerceraTabla[3]}           {ValoresRestriccion2TerceraTabla[4]}           {S1X2}           {S2X2}           {S3X2}           {S4X2}           {S5X2}           {ValorSujetoARestriccion2TerceraTabla}");
            System.Console.WriteLine($"          Z                  {Z}            {ValoresDeZSimplexTerceraTabla[0]}           {ValoresDeZSimplexTerceraTabla[1]}           {ValoresDeZSimplexTerceraTabla[2]}           {ValoresDeZSimplexTerceraTabla[3]}           {ValoresDeZSimplexTerceraTabla[4]}           0           0           0           0           0           {CR}");

            //Tercera Tabla Simplex
                 } //Si es el caso de que la columna S2 sea el mas negativo


            }//Final localizar valor mas negativo de Z para la X4
            
            
            //Inicio localizar valor mas negativo de Z para la X5
            if(ValoresDeZSimplexTerceraTabla[4]<ValoresDeZSimplexTerceraTabla[1]&&ValoresDeZSimplexTerceraTabla[4]<ValoresDeZSimplexTerceraTabla[2]&&ValoresDeZSimplexTerceraTabla[4]<ValoresDeZSimplexTerceraTabla[3]&&ValoresDeZSimplexTerceraTabla[4]<ValoresDeZSimplexTerceraTabla[0])
            {
                

                 if((ValorSujetoARestriccion1TerceraTabla/ValoresRestriccion1TerceraTabla[4])<(ValorSujetoARestriccion2TerceraTabla/ValoresRestriccion2TerceraTabla[4]))
                 {
                     System.Console.WriteLine("Tercera Tabla Simplex\n\n"); 
                    //Nuevos Valores Tabla Simplex 2
                    //Restriccion 1
                     ValorSujetoARestriccion1TerceraTabla = ValorSujetoARestriccion1TerceraTabla/ValoresRestriccion1TerceraTabla[4];
                    for(int i=0; i<ValoresRestriccion1TerceraTabla.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion1TerceraTabla[i] = ValoresRestriccion1TerceraTabla[i]/ValoresRestriccion1TerceraTabla[4];
                        }
                        //Valores S1,S2,S3,S4,S5 Para Columna X4
                        float S1X1 = 1/ValoresRestriccion1TerceraTabla[4];
                        float S2X1 = 0/ValoresRestriccion1TerceraTabla[4];
                        float S3X1 = 0/ValoresRestriccion1TerceraTabla[4];
                        float S4X1 = 0/ValoresRestriccion1TerceraTabla[4];
                        float S5X1 = 0/ValoresRestriccion1TerceraTabla[4];
                    //Restriccion 2
                     ValorSujetoARestriccion2TerceraTabla = ValorSujetoARestriccion2TerceraTabla - (ValoresRestriccion2TerceraTabla[4]*ValorSujetoARestriccion1TerceraTabla);

                     for(int i=0; i<ValoresRestriccion2TerceraTabla.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion2TerceraTabla[i] = ValoresRestriccion2TerceraTabla[i]-(ValoresRestriccion2TerceraTabla[4]*ValoresRestriccion1TerceraTabla[i]);
                        }
                    //Valores S1,S2,S3,S4,S5 Para Columna X2
                        float S1X2 = 0 - (ValoresRestriccion2TerceraTabla[4]*S1X1);
                        float S2X2 = 1 - (ValoresRestriccion2TerceraTabla[4]*S2X1);
                        float S3X2 = 0 - (ValoresRestriccion2TerceraTabla[4]*S3X1);
                        float S4X2 = 0 - (ValoresRestriccion2TerceraTabla[4]*S4X1);
                        float S5X2 = 0 - (ValoresRestriccion2TerceraTabla[4]*S5X1);
                        //Valor de Z
                         for(int i=0; i<ValoresDeZSimplexTerceraTabla.Length; i++)                                   
                        {                                                                 
                            ValoresDeZSimplexTerceraTabla[i] = ValoresDeZSimplexTerceraTabla[i]-(ValoresDeZSimplexTerceraTabla[4]*ValoresRestriccion1TerceraTabla[i]);
                        }
                        //Valores Z y CR Para Columna Z
                        float Z = 1 - (ValoresDeZSimplexTerceraTabla[4] * 0);
                        float CR = 0 - (ValoresDeZSimplexTerceraTabla[4] * ValorSujetoARestriccion1TerceraTabla);
                      System.Console.WriteLine($"Variables Basicas            Z            X1            X2            X3            X4            X5            S1            S2            S3            S4            S5            CR");
            System.Console.WriteLine($"         S1                  0            {ValoresRestriccion1TerceraTabla[0]}           {ValoresRestriccion1TerceraTabla[1]}           {ValoresRestriccion1TerceraTabla[2]}           {ValoresRestriccion1TerceraTabla[3]}           {ValoresRestriccion1TerceraTabla[4]}           {S1X1}          {S2X1}           {S3X1}           {S4X1}           {S5X1}           {ValorSujetoARestriccion1TerceraTabla}");
            System.Console.WriteLine($"         S2                  0            {ValoresRestriccion2TerceraTabla[0]}           {ValoresRestriccion2TerceraTabla[1]}           {ValoresRestriccion2TerceraTabla[2]}           {ValoresRestriccion2TerceraTabla[3]}           {ValoresRestriccion2TerceraTabla[4]}           {S1X2}           {S2X2}           {S3X2}           {S4X2}           {S5X2}           {ValorSujetoARestriccion2TerceraTabla}");
            System.Console.WriteLine($"          Z                  {Z}            {ValoresDeZSimplexTerceraTabla[0]}           {ValoresDeZSimplexTerceraTabla[1]}           {ValoresDeZSimplexTerceraTabla[2]}           {ValoresDeZSimplexTerceraTabla[3]}           {ValoresDeZSimplexTerceraTabla[4]}           0           0           0           0           0           {CR}");

            //Tercera Tabla Simplex
                 } //Si es el caso de que la columna S1 sea el mas negativo 

                 else if((ValorSujetoARestriccion2TerceraTabla/ValoresRestriccion2TerceraTabla[4])<(ValorSujetoARestriccion1TerceraTabla/ValoresRestriccion1TerceraTabla[4]))
                 {
                     System.Console.WriteLine("Tercera Tabla Simplex\n\n"); 
                    //Nuevos Valores Tabla Simplex 2
                    //Restriccion 2
                     ValorSujetoARestriccion2TerceraTabla = ValorSujetoARestriccion2TerceraTabla/ValoresRestriccion2TerceraTabla[4];
                    for(int i=0; i<ValoresRestriccion2TerceraTabla.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion2TerceraTabla[i] = ValoresRestriccion2TerceraTabla[i]/ValoresRestriccion2TerceraTabla[4];
                        }
                        //Valores S1,S2,S3,S4,S5 Para Columna X4
                        float S1X2 = 0/ValoresRestriccion2TerceraTabla[4];
                        float S2X2 = 1/ValoresRestriccion2TerceraTabla[4];
                        float S3X2 = 0/ValoresRestriccion2TerceraTabla[4];
                        float S4X2 = 0/ValoresRestriccion2TerceraTabla[4];
                        float S5X2 = 0/ValoresRestriccion2TerceraTabla[4];
                    //Restriccion 1
                     ValorSujetoARestriccion1TerceraTabla = ValorSujetoARestriccion1TerceraTabla - (ValoresRestriccion1TerceraTabla[4]*ValorSujetoARestriccion2TerceraTabla);

                     for(int i=0; i<ValoresRestriccion1TerceraTabla.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion1TerceraTabla[i] = ValoresRestriccion1TerceraTabla[i]-(ValoresRestriccion1TerceraTabla[4]*ValoresRestriccion2TerceraTabla[i]);
                        }
                    //Valores S1,S2,S3,S4,S5 Para Columna X2
                        float S1X1 = 1 - (ValoresRestriccion1TerceraTabla[4]*S1X2);
                        float S2X1 = 0 - (ValoresRestriccion1TerceraTabla[4]*S2X2);
                        float S3X1 = 0 - (ValoresRestriccion1TerceraTabla[4]*S3X2);
                        float S4X1 = 0 - (ValoresRestriccion1TerceraTabla[4]*S4X2);
                        float S5X1 = 0 - (ValoresRestriccion1TerceraTabla[4]*S5X2);
                        //Valor de Z
                         for(int i=0; i<ValoresDeZSimplexTerceraTabla.Length; i++)                                   
                        {                                                                 
                            ValoresDeZSimplexTerceraTabla[i] = ValoresDeZSimplexTerceraTabla[i]-(ValoresDeZSimplexTerceraTabla[4]*ValoresRestriccion2TerceraTabla[i]);
                        }
                        //Valores Z y CR Para Columna Z
                        float Z = 1 - (ValoresDeZSimplexTerceraTabla[4] * 0);
                        float CR = 0 - (ValoresDeZSimplexTerceraTabla[4] * ValorSujetoARestriccion2TerceraTabla);
                        //Tabla
                    System.Console.WriteLine($"Variables Basicas            Z            X1            X2            X3            X4            X5            S1            S2            S3            S4            S5            CR");
            System.Console.WriteLine($"         S1                  0            {ValoresRestriccion1TerceraTabla[0]}           {ValoresRestriccion1TerceraTabla[1]}           {ValoresRestriccion1TerceraTabla[2]}           {ValoresRestriccion1TerceraTabla[3]}           {ValoresRestriccion1TerceraTabla[4]}           {S1X1}          {S2X1}           {S3X1}           {S4X1}           {S5X1}           {ValorSujetoARestriccion1TerceraTabla}");
            System.Console.WriteLine($"         S2                  0            {ValoresRestriccion2TerceraTabla[0]}           {ValoresRestriccion2TerceraTabla[1]}           {ValoresRestriccion2TerceraTabla[2]}           {ValoresRestriccion2TerceraTabla[3]}           {ValoresRestriccion2TerceraTabla[4]}           {S1X2}           {S2X2}           {S3X2}           {S4X2}           {S5X2}           {ValorSujetoARestriccion2TerceraTabla}");
            System.Console.WriteLine($"          Z                  {Z}            {ValoresDeZSimplexTerceraTabla[0]}           {ValoresDeZSimplexTerceraTabla[1]}           {ValoresDeZSimplexTerceraTabla[2]}           {ValoresDeZSimplexTerceraTabla[3]}           {ValoresDeZSimplexTerceraTabla[4]}           0           0           0           0           0           {CR}");

            //Tercera Tabla Simplex
                 } //Si es el caso de que la columna S2 sea el mas negativo

            }//Final localizar valor mas negativo de Z para la X5


     }  



    //Metodo Simplex Con 3 Restricciones
     public static void METODOSIMPLEX3Restriccion(int variableMaximizacionOMinimizacion,float[]ValoresDeZSimplex,float[]ValoresRestriccion1,float[]ValoresRestriccion2,float[]ValoresRestriccion3,string ValordecisionRestriccion1,string ValordecisionRestriccion2,string ValordecisionRestriccion3,float ValorSujetoARestriccion1,float ValorSujetoARestriccion2,float ValorSujetoARestriccion3)
    {
          if(variableMaximizacionOMinimizacion ==1)
        {
            System.Console.WriteLine("\nMaximizar");
            if(ValoresDeZSimplex.Length ==1)
            {
            System.Console.WriteLine("Z = "+ValoresDeZSimplex[0]+"X");
            }
            else if(ValoresDeZSimplex.Length ==2)
            {
            System.Console.WriteLine("Z = "+ValoresDeZSimplex[0]+"X +" + ValoresDeZSimplex[1]+"X");
            }
             else if(ValoresDeZSimplex.Length ==3)
            {
             System.Console.WriteLine("Z = "+ValoresDeZSimplex[0]+"X +" + ValoresDeZSimplex[1]+"X +"+ValoresDeZSimplex[2]+"X"); 
            }
             else if(ValoresDeZSimplex.Length ==4)
            {
                System.Console.WriteLine("Z = "+ValoresDeZSimplex[0]+"X +" + ValoresDeZSimplex[1]+"X +"+ValoresDeZSimplex[2]+"X +"+ValoresDeZSimplex[3]+"X"); 
            }
             else if(ValoresDeZSimplex.Length ==5)
            {
                 System.Console.WriteLine("Z = "+ValoresDeZSimplex[0]+"X +" + ValoresDeZSimplex[1]+"X +"+ValoresDeZSimplex[2]+"X +"+ValoresDeZSimplex[3]+"X +"+ValoresDeZSimplex[4]+"X"); 
            }
        }
        else if(variableMaximizacionOMinimizacion ==2)
        {
             System.Console.WriteLine("\nMinimizar");
            if(ValoresDeZSimplex.Length ==1)
            {
            System.Console.WriteLine("Z = "+ValoresDeZSimplex[0]+"X");
            }
            else if(ValoresDeZSimplex.Length ==2)
            {
            System.Console.WriteLine("Z = "+ValoresDeZSimplex[0]+"X +" + ValoresDeZSimplex[1]+"X");
            }
             else if(ValoresDeZSimplex.Length ==3)
            {
             System.Console.WriteLine("Z = "+ValoresDeZSimplex[0]+"X +" + ValoresDeZSimplex[1]+"X +"+ValoresDeZSimplex[2]+"X"); 
            }
             else if(ValoresDeZSimplex.Length ==4)
            {
                System.Console.WriteLine("Z = "+ValoresDeZSimplex[0]+"X +" + ValoresDeZSimplex[1]+"X +"+ValoresDeZSimplex[2]+"X +"+ValoresDeZSimplex[3]+"X"); 
            }
             else if(ValoresDeZSimplex.Length ==5)
            {
                 System.Console.WriteLine("Z = "+ValoresDeZSimplex[0]+"X +" + ValoresDeZSimplex[1]+"X +"+ValoresDeZSimplex[2]+"X +"+ValoresDeZSimplex[3]+"X +"+ValoresDeZSimplex[4]+"X"); 
            }
        }
        System.Console.WriteLine("Restricciones");
         if(ValoresRestriccion1.Length ==1)
            {
            System.Console.WriteLine("Restriccion 1 = "+"("+ValoresRestriccion1[0]+"X) "+ValordecisionRestriccion1+" "+ValorSujetoARestriccion1);
            }
            else if(ValoresRestriccion1.Length ==2)
            {
            System.Console.WriteLine("Restriccion 1 = "+"("+ValoresRestriccion1[0]+"X) +"+"("+ValoresRestriccion1[1]+"X) "+ValordecisionRestriccion1+" "+ValorSujetoARestriccion1);
            }
             else if(ValoresRestriccion1.Length ==3)
            {
             System.Console.WriteLine("Restriccion 1 = "+"("+ValoresRestriccion1[0]+"X) +" +"("+ValoresRestriccion1[1]+"X) +"+"("+ValoresRestriccion1[2]+"X) "+ValordecisionRestriccion1+" "+ValorSujetoARestriccion1); 
            }
             else if(ValoresRestriccion1.Length ==4)
            {
                System.Console.WriteLine("Restriccion 1 = "+"("+ValoresRestriccion1[0]+"X) +" +"("+ValoresRestriccion1[1]+"X) +"+"("+ValoresRestriccion1[2]+"X) +"+"("+ValoresRestriccion1[3]+"X) "+ValordecisionRestriccion1+" "+ValorSujetoARestriccion1); 
            }
             else if(ValoresRestriccion1.Length ==5)
            {
                 System.Console.WriteLine("Restriccion 1 = "+"("+ValoresRestriccion1[0]+"X) +"+"("+ValoresRestriccion1[1]+"X) +"+"("+ValoresRestriccion1[2]+"X) +"+"("+ValoresRestriccion1[3]+"X) +"+"("+ValoresRestriccion1[4]+"X) "+ValordecisionRestriccion1+" "+ValorSujetoARestriccion1); 
            }

             if(ValoresRestriccion2.Length ==1)
            {
            System.Console.WriteLine("Restriccion 2 = "+"("+ValoresRestriccion2[0]+"X) "+ValordecisionRestriccion2+" "+ValorSujetoARestriccion2);
            }
            else if(ValoresRestriccion2.Length ==2)
            {
            System.Console.WriteLine("Restriccion 2 = "+"("+ValoresRestriccion2[0]+"X) +"+"("+ValoresRestriccion2[1]+"X) "+ValordecisionRestriccion2+" "+ValorSujetoARestriccion2);
            }
             else if(ValoresRestriccion2.Length ==3)
            {
             System.Console.WriteLine("Restriccion 2 = "+"("+ValoresRestriccion2[0]+"X) +" +"("+ValoresRestriccion2[1]+"X) +"+"("+ValoresRestriccion2[2]+"X) "+ValordecisionRestriccion2+" "+ValorSujetoARestriccion2); 
            }
             else if(ValoresRestriccion2.Length ==4)
            {
                System.Console.WriteLine("Restriccion 2 = "+"("+ValoresRestriccion2[0]+"X) +" +"("+ValoresRestriccion2[1]+"X) +"+"("+ValoresRestriccion2[2]+"X) +"+"("+ValoresRestriccion2[3]+"X) "+ValordecisionRestriccion2+" "+ValorSujetoARestriccion2); 
            }
             else if(ValoresRestriccion2.Length ==5)
            {
                 System.Console.WriteLine("Restriccion 2 = "+"("+ValoresRestriccion2[0]+"X) +"+"("+ValoresRestriccion2[1]+"X) +"+"("+ValoresRestriccion2[2]+"X) +"+"("+ValoresRestriccion2[3]+"X) +"+"("+ValoresRestriccion2[4]+"X) "+ValordecisionRestriccion2+" "+ValorSujetoARestriccion2); 
            }

             if(ValoresRestriccion3.Length ==1)
            {
            System.Console.WriteLine("Restriccion 3 = "+"("+ValoresRestriccion3[0]+"X) "+ValordecisionRestriccion3+" "+ValorSujetoARestriccion3);
            }
            else if(ValoresRestriccion3.Length ==2)
            {
            System.Console.WriteLine("Restriccion 3 = "+"("+ValoresRestriccion3[0]+"X) +"+"("+ValoresRestriccion3[1]+"X) "+ValordecisionRestriccion3+" "+ValorSujetoARestriccion3);
            }
             else if(ValoresRestriccion3.Length ==3)
            {
             System.Console.WriteLine("Restriccion 3 = "+"("+ValoresRestriccion3[0]+"X) +" +"("+ValoresRestriccion3[1]+"X) +"+"("+ValoresRestriccion3[2]+"X) "+ValordecisionRestriccion3+" "+ValorSujetoARestriccion3); 
            }
             else if(ValoresRestriccion3.Length ==4)
            {
                System.Console.WriteLine("Restriccion 3 = "+"("+ValoresRestriccion3[0]+"X) +" +"("+ValoresRestriccion3[1]+"X) +"+"("+ValoresRestriccion3[2]+"X) +"+"("+ValoresRestriccion3[3]+"X) "+ValordecisionRestriccion3+" "+ValorSujetoARestriccion3); 
            }
             else if(ValoresRestriccion3.Length ==5)
            {
                 System.Console.WriteLine("Restriccion 3 = "+"("+ValoresRestriccion3[0]+"X) +"+"("+ValoresRestriccion3[1]+"X) +"+"("+ValoresRestriccion3[2]+"X) +"+"("+ValoresRestriccion3[3]+"X) +"+"("+ValoresRestriccion3[4]+"X) "+ValordecisionRestriccion3+" "+ValorSujetoARestriccion3); 
            }
             System.Console.WriteLine("Primer Tabla Simplex\n\n");
            ValoresDeZSimplex = ValoresXParaZEnSimplex(ValoresDeZSimplex);
            System.Console.WriteLine($"Variables Basicas            Z            X1            X2            X3            X4            X5            S1            S2            S3            S4            S5            CR");
            System.Console.WriteLine($"         S1                  0            {ValoresRestriccion1[0]}           {ValoresRestriccion1[1]}           {ValoresRestriccion1[2]}           {ValoresRestriccion1[3]}           {ValoresRestriccion1[4]}           1           0           0           0           0           {ValorSujetoARestriccion1}");
            System.Console.WriteLine($"         S2                  0            {ValoresRestriccion2[0]}           {ValoresRestriccion2[1]}           {ValoresRestriccion2[2]}           {ValoresRestriccion2[3]}           {ValoresRestriccion2[4]}           0           1           0           0           0           {ValorSujetoARestriccion2}");
            System.Console.WriteLine($"         S3                  0            {ValoresRestriccion3[0]}           {ValoresRestriccion3[1]}           {ValoresRestriccion3[2]}           {ValoresRestriccion3[3]}           {ValoresRestriccion3[4]}           0           0           1           0           0           {ValorSujetoARestriccion3}");
            System.Console.WriteLine($"          Z                  1            {ValoresDeZSimplex[0]}           {ValoresDeZSimplex[1]}           {ValoresDeZSimplex[2]}           {ValoresDeZSimplex[3]}           {ValoresDeZSimplex[4]}           0           0           0           0           0           0");

    }//Acaba Metodo Simplex con 3 Restricciones

    //Metodo Simplex Con 4 Restricciones
     public static void METODOSIMPLEX4Restriccion(int variableMaximizacionOMinimizacion,float[]ValoresDeZSimplex,float[]ValoresRestriccion1,float[]ValoresRestriccion2,float[]ValoresRestriccion3,float[]ValoresRestriccion4,string ValordecisionRestriccion1,string ValordecisionRestriccion2,string ValordecisionRestriccion3,string ValordecisionRestriccion4,float ValorSujetoARestriccion1,float ValorSujetoARestriccion2,float ValorSujetoARestriccion3,float ValorSujetoARestriccion4)
    {
          if(variableMaximizacionOMinimizacion ==1)
        {
            System.Console.WriteLine("\nMaximizar");
            if(ValoresDeZSimplex.Length ==1)
            {
            System.Console.WriteLine("Z = "+ValoresDeZSimplex[0]+"X");
            }
            else if(ValoresDeZSimplex.Length ==2)
            {
            System.Console.WriteLine("Z = "+ValoresDeZSimplex[0]+"X +" + ValoresDeZSimplex[1]+"X");
            }
             else if(ValoresDeZSimplex.Length ==3)
            {
             System.Console.WriteLine("Z = "+ValoresDeZSimplex[0]+"X +" + ValoresDeZSimplex[1]+"X +"+ValoresDeZSimplex[2]+"X"); 
            }
             else if(ValoresDeZSimplex.Length ==4)
            {
                System.Console.WriteLine("Z = "+ValoresDeZSimplex[0]+"X +" + ValoresDeZSimplex[1]+"X +"+ValoresDeZSimplex[2]+"X +"+ValoresDeZSimplex[3]+"X"); 
            }
             else if(ValoresDeZSimplex.Length ==5)
            {
                 System.Console.WriteLine("Z = "+ValoresDeZSimplex[0]+"X +" + ValoresDeZSimplex[1]+"X +"+ValoresDeZSimplex[2]+"X +"+ValoresDeZSimplex[3]+"X +"+ValoresDeZSimplex[4]+"X"); 
            }
        }
        else if(variableMaximizacionOMinimizacion ==2)
        {
             System.Console.WriteLine("\nMinimizar");
            if(ValoresDeZSimplex.Length ==1)
            {
            System.Console.WriteLine("Z = "+ValoresDeZSimplex[0]+"X");
            }
            else if(ValoresDeZSimplex.Length ==2)
            {
            System.Console.WriteLine("Z = "+ValoresDeZSimplex[0]+"X +" + ValoresDeZSimplex[1]+"X");
            }
             else if(ValoresDeZSimplex.Length ==3)
            {
             System.Console.WriteLine("Z = "+ValoresDeZSimplex[0]+"X +" + ValoresDeZSimplex[1]+"X +"+ValoresDeZSimplex[2]+"X"); 
            }
             else if(ValoresDeZSimplex.Length ==4)
            {
                System.Console.WriteLine("Z = "+ValoresDeZSimplex[0]+"X +" + ValoresDeZSimplex[1]+"X +"+ValoresDeZSimplex[2]+"X +"+ValoresDeZSimplex[3]+"X"); 
            }
             else if(ValoresDeZSimplex.Length ==5)
            {
                 System.Console.WriteLine("Z = "+ValoresDeZSimplex[0]+"X +" + ValoresDeZSimplex[1]+"X +"+ValoresDeZSimplex[2]+"X +"+ValoresDeZSimplex[3]+"X +"+ValoresDeZSimplex[4]+"X"); 
            }
        }
        System.Console.WriteLine("Restricciones");
         if(ValoresRestriccion1.Length ==1)
            {
            System.Console.WriteLine("Restriccion 1 = "+"("+ValoresRestriccion1[0]+"X) "+ValordecisionRestriccion1+" "+ValorSujetoARestriccion1);
            }
            else if(ValoresRestriccion1.Length ==2)
            {
            System.Console.WriteLine("Restriccion 1 = "+"("+ValoresRestriccion1[0]+"X) +"+"("+ValoresRestriccion1[1]+"X) "+ValordecisionRestriccion1+" "+ValorSujetoARestriccion1);
            }
             else if(ValoresRestriccion1.Length ==3)
            {
             System.Console.WriteLine("Restriccion 1 = "+"("+ValoresRestriccion1[0]+"X) +" +"("+ValoresRestriccion1[1]+"X) +"+"("+ValoresRestriccion1[2]+"X) "+ValordecisionRestriccion1+" "+ValorSujetoARestriccion1); 
            }
             else if(ValoresRestriccion1.Length ==4)
            {
                System.Console.WriteLine("Restriccion 1 = "+"("+ValoresRestriccion1[0]+"X) +" +"("+ValoresRestriccion1[1]+"X) +"+"("+ValoresRestriccion1[2]+"X) +"+"("+ValoresRestriccion1[3]+"X) "+ValordecisionRestriccion1+" "+ValorSujetoARestriccion1); 
            }
             else if(ValoresRestriccion1.Length ==5)
            {
                 System.Console.WriteLine("Restriccion 1 = "+"("+ValoresRestriccion1[0]+"X) +"+"("+ValoresRestriccion1[1]+"X) +"+"("+ValoresRestriccion1[2]+"X) +"+"("+ValoresRestriccion1[3]+"X) +"+"("+ValoresRestriccion1[4]+"X) "+ValordecisionRestriccion1+" "+ValorSujetoARestriccion1); 
            }

             if(ValoresRestriccion2.Length ==1)
            {
            System.Console.WriteLine("Restriccion 2 = "+"("+ValoresRestriccion2[0]+"X) "+ValordecisionRestriccion2+" "+ValorSujetoARestriccion2);
            }
            else if(ValoresRestriccion2.Length ==2)
            {
            System.Console.WriteLine("Restriccion 2 = "+"("+ValoresRestriccion2[0]+"X) +"+"("+ValoresRestriccion2[1]+"X) "+ValordecisionRestriccion2+" "+ValorSujetoARestriccion2);
            }
             else if(ValoresRestriccion2.Length ==3)
            {
             System.Console.WriteLine("Restriccion 2 = "+"("+ValoresRestriccion2[0]+"X) +" +"("+ValoresRestriccion2[1]+"X) +"+"("+ValoresRestriccion2[2]+"X) "+ValordecisionRestriccion2+" "+ValorSujetoARestriccion2); 
            }
             else if(ValoresRestriccion2.Length ==4)
            {
                System.Console.WriteLine("Restriccion 2 = "+"("+ValoresRestriccion2[0]+"X) +" +"("+ValoresRestriccion2[1]+"X) +"+"("+ValoresRestriccion2[2]+"X) +"+"("+ValoresRestriccion2[3]+"X) "+ValordecisionRestriccion2+" "+ValorSujetoARestriccion2); 
            }
             else if(ValoresRestriccion2.Length ==5)
            {
                 System.Console.WriteLine("Restriccion 2 = "+"("+ValoresRestriccion2[0]+"X) +"+"("+ValoresRestriccion2[1]+"X) +"+"("+ValoresRestriccion2[2]+"X) +"+"("+ValoresRestriccion2[3]+"X) +"+"("+ValoresRestriccion2[4]+"X) "+ValordecisionRestriccion2+" "+ValorSujetoARestriccion2); 
            }

             if(ValoresRestriccion3.Length ==1)
            {
            System.Console.WriteLine("Restriccion 3 = "+"("+ValoresRestriccion3[0]+"X) "+ValordecisionRestriccion3+" "+ValorSujetoARestriccion3);
            }
            else if(ValoresRestriccion3.Length ==2)
            {
            System.Console.WriteLine("Restriccion 3 = "+"("+ValoresRestriccion3[0]+"X) +"+"("+ValoresRestriccion3[1]+"X) "+ValordecisionRestriccion3+" "+ValorSujetoARestriccion3);
            }
             else if(ValoresRestriccion3.Length ==3)
            {
             System.Console.WriteLine("Restriccion 3 = "+"("+ValoresRestriccion3[0]+"X) +" +"("+ValoresRestriccion3[1]+"X) +"+"("+ValoresRestriccion3[2]+"X) "+ValordecisionRestriccion3+" "+ValorSujetoARestriccion3); 
            }
             else if(ValoresRestriccion3.Length ==4)
            {
                System.Console.WriteLine("Restriccion 3 = "+"("+ValoresRestriccion3[0]+"X) +" +"("+ValoresRestriccion3[1]+"X) +"+"("+ValoresRestriccion3[2]+"X) +"+"("+ValoresRestriccion3[3]+"X) "+ValordecisionRestriccion3+" "+ValorSujetoARestriccion3); 
            }
             else if(ValoresRestriccion3.Length ==5)
            {
                 System.Console.WriteLine("Restriccion 3 = "+"("+ValoresRestriccion3[0]+"X) +"+"("+ValoresRestriccion3[1]+"X) +"+"("+ValoresRestriccion3[2]+"X) +"+"("+ValoresRestriccion3[3]+"X) +"+"("+ValoresRestriccion3[4]+"X) "+ValordecisionRestriccion3+" "+ValorSujetoARestriccion3); 
            }

             if(ValoresRestriccion4.Length ==1)
            {
            System.Console.WriteLine("Restriccion 4 = "+"("+ValoresRestriccion4[0]+"X) "+ValordecisionRestriccion4+" "+ValorSujetoARestriccion4);
            }
            else if(ValoresRestriccion4.Length ==2)
            {
            System.Console.WriteLine("Restriccion 4 = "+"("+ValoresRestriccion4[0]+"X) +"+"("+ValoresRestriccion4[1]+"X) "+ValordecisionRestriccion4+" "+ValorSujetoARestriccion4);
            }
             else if(ValoresRestriccion4.Length ==3)
            {
             System.Console.WriteLine("Restriccion 4 = "+"("+ValoresRestriccion4[0]+"X) +" +"("+ValoresRestriccion4[1]+"X) +"+"("+ValoresRestriccion4[2]+"X) "+ValordecisionRestriccion4+" "+ValorSujetoARestriccion4); 
            }
             else if(ValoresRestriccion4.Length ==4)
            {
                System.Console.WriteLine("Restriccion 4 = "+"("+ValoresRestriccion4[0]+"X) +" +"("+ValoresRestriccion4[1]+"X) +"+"("+ValoresRestriccion4[2]+"X) +"+"("+ValoresRestriccion4[3]+"X) "+ValordecisionRestriccion4+" "+ValorSujetoARestriccion4); 
            }
             else if(ValoresRestriccion4.Length ==5)
            {
                 System.Console.WriteLine("Restriccion 4 = "+"("+ValoresRestriccion4[0]+"X) +"+"("+ValoresRestriccion4[1]+"X) +"+"("+ValoresRestriccion4[2]+"X) +"+"("+ValoresRestriccion4[3]+"X) +"+"("+ValoresRestriccion4[4]+"X) "+ValordecisionRestriccion4+" "+ValorSujetoARestriccion4); 
            }
             System.Console.WriteLine("Primer Tabla Simplex\n\n");
              ValoresDeZSimplex = ValoresXParaZEnSimplex(ValoresDeZSimplex);
            System.Console.WriteLine($"Variables Basicas            Z            X1            X2            X3            X4            X5            S1            S2            S3            S4            S5            CR");
            System.Console.WriteLine($"         S1                  0            {ValoresRestriccion1[0]}           {ValoresRestriccion1[1]}           {ValoresRestriccion1[2]}           {ValoresRestriccion1[3]}           {ValoresRestriccion1[4]}           1           0           0           0           0           {ValorSujetoARestriccion1}");
            System.Console.WriteLine($"         S2                  0            {ValoresRestriccion2[0]}           {ValoresRestriccion2[1]}           {ValoresRestriccion2[2]}           {ValoresRestriccion2[3]}           {ValoresRestriccion2[4]}           0           1           0           0           0           {ValorSujetoARestriccion2}");
            System.Console.WriteLine($"         S3                  0            {ValoresRestriccion3[0]}           {ValoresRestriccion3[1]}           {ValoresRestriccion3[2]}           {ValoresRestriccion3[3]}           {ValoresRestriccion3[4]}           0           0           1           0           0           {ValorSujetoARestriccion3}");
            System.Console.WriteLine($"         S4                  0            {ValoresRestriccion4[0]}           {ValoresRestriccion4[1]}           {ValoresRestriccion4[2]}           {ValoresRestriccion4[3]}           {ValoresRestriccion4[4]}           0           0           0           1           0           {ValorSujetoARestriccion4}");
            System.Console.WriteLine($"          Z                  1            {ValoresDeZSimplex[0]}           {ValoresDeZSimplex[1]}           {ValoresDeZSimplex[2]}           {ValoresDeZSimplex[3]}           {ValoresDeZSimplex[4]}           0           0           0           0           0           0");

    }//Acaba Metodo Simplex con 4 Restricciones

    //Metodo Simplex Con 5 Restricciones
     public static void METODOSIMPLEX5Restriccion(int variableMaximizacionOMinimizacion,float[]ValoresDeZSimplex,float[]ValoresRestriccion1,float[]ValoresRestriccion2,float[]ValoresRestriccion3,float[]ValoresRestriccion4,float[]ValoresRestriccion5,string ValordecisionRestriccion1,string ValordecisionRestriccion2,string ValordecisionRestriccion3,string ValordecisionRestriccion4,string ValordecisionRestriccion5,float ValorSujetoARestriccion1,float ValorSujetoARestriccion2,float ValorSujetoARestriccion3,float ValorSujetoARestriccion4,float ValorSujetoARestriccion5)
    {

          if(variableMaximizacionOMinimizacion ==1)
        {
            System.Console.WriteLine("\nMaximizar");
            if(ValoresDeZSimplex.Length ==1)
            {
            System.Console.WriteLine("Z = "+ValoresDeZSimplex[0]+"X");
            }
            else if(ValoresDeZSimplex.Length ==2)
            {
            System.Console.WriteLine("Z = "+ValoresDeZSimplex[0]+"X +" + ValoresDeZSimplex[1]+"X");
            }
             else if(ValoresDeZSimplex.Length ==3)
            {
             System.Console.WriteLine("Z = "+ValoresDeZSimplex[0]+"X +" + ValoresDeZSimplex[1]+"X +"+ValoresDeZSimplex[2]+"X"); 
            }
             else if(ValoresDeZSimplex.Length ==4)
            {
                System.Console.WriteLine("Z = "+ValoresDeZSimplex[0]+"X +" + ValoresDeZSimplex[1]+"X +"+ValoresDeZSimplex[2]+"X +"+ValoresDeZSimplex[3]+"X"); 
            }
             else if(ValoresDeZSimplex.Length ==5)
            {
                 System.Console.WriteLine("Z = "+ValoresDeZSimplex[0]+"X +" + ValoresDeZSimplex[1]+"X +"+ValoresDeZSimplex[2]+"X +"+ValoresDeZSimplex[3]+"X +"+ValoresDeZSimplex[4]+"X"); 
            }
        }
        else if(variableMaximizacionOMinimizacion ==2)
        {
             System.Console.WriteLine("\nMinimizar");
            if(ValoresDeZSimplex.Length ==1)
            {
            System.Console.WriteLine("Z = "+ValoresDeZSimplex[0]+"X");
            }
            else if(ValoresDeZSimplex.Length ==2)
            {
            System.Console.WriteLine("Z = "+ValoresDeZSimplex[0]+"X +" + ValoresDeZSimplex[1]+"X");
            }
             else if(ValoresDeZSimplex.Length ==3)
            {
             System.Console.WriteLine("Z = "+ValoresDeZSimplex[0]+"X +" + ValoresDeZSimplex[1]+"X +"+ValoresDeZSimplex[2]+"X"); 
            }
             else if(ValoresDeZSimplex.Length ==4)
            {
                System.Console.WriteLine("Z = "+ValoresDeZSimplex[0]+"X +" + ValoresDeZSimplex[1]+"X +"+ValoresDeZSimplex[2]+"X +"+ValoresDeZSimplex[3]+"X"); 
            }
             else if(ValoresDeZSimplex.Length ==5)
            {
                 System.Console.WriteLine("Z = "+ValoresDeZSimplex[0]+"X +" + ValoresDeZSimplex[1]+"X +"+ValoresDeZSimplex[2]+"X +"+ValoresDeZSimplex[3]+"X +"+ValoresDeZSimplex[4]+"X"); 
            }
        }
        System.Console.WriteLine("Restricciones");
         if(ValoresRestriccion1.Length ==1)
            {
            System.Console.WriteLine("Restriccion 1 = "+"("+ValoresRestriccion1[0]+"X) "+ValordecisionRestriccion1+" "+ValorSujetoARestriccion1);
            }
            else if(ValoresRestriccion1.Length ==2)
            {
            System.Console.WriteLine("Restriccion 1 = "+"("+ValoresRestriccion1[0]+"X) +"+"("+ValoresRestriccion1[1]+"X) "+ValordecisionRestriccion1+" "+ValorSujetoARestriccion1);
            }
             else if(ValoresRestriccion1.Length ==3)
            {
             System.Console.WriteLine("Restriccion 1 = "+"("+ValoresRestriccion1[0]+"X) +" +"("+ValoresRestriccion1[1]+"X) +"+"("+ValoresRestriccion1[2]+"X) "+ValordecisionRestriccion1+" "+ValorSujetoARestriccion1); 
            }
             else if(ValoresRestriccion1.Length ==4)
            {
                System.Console.WriteLine("Restriccion 1 = "+"("+ValoresRestriccion1[0]+"X) +" +"("+ValoresRestriccion1[1]+"X) +"+"("+ValoresRestriccion1[2]+"X) +"+"("+ValoresRestriccion1[3]+"X) "+ValordecisionRestriccion1+" "+ValorSujetoARestriccion1); 
            }
             else if(ValoresRestriccion1.Length ==5)
            {
                 System.Console.WriteLine("Restriccion 1 = "+"("+ValoresRestriccion1[0]+"X) +"+"("+ValoresRestriccion1[1]+"X) +"+"("+ValoresRestriccion1[2]+"X) +"+"("+ValoresRestriccion1[3]+"X) +"+"("+ValoresRestriccion1[4]+"X) "+ValordecisionRestriccion1+" "+ValorSujetoARestriccion1); 
            }

             if(ValoresRestriccion2.Length ==1)
            {
            System.Console.WriteLine("Restriccion 2 = "+"("+ValoresRestriccion2[0]+"X) "+ValordecisionRestriccion2+" "+ValorSujetoARestriccion2);
            }
            else if(ValoresRestriccion2.Length ==2)
            {
            System.Console.WriteLine("Restriccion 2 = "+"("+ValoresRestriccion2[0]+"X) +"+"("+ValoresRestriccion2[1]+"X) "+ValordecisionRestriccion2+" "+ValorSujetoARestriccion2);
            }
             else if(ValoresRestriccion2.Length ==3)
            {
             System.Console.WriteLine("Restriccion 2 = "+"("+ValoresRestriccion2[0]+"X) +" +"("+ValoresRestriccion2[1]+"X) +"+"("+ValoresRestriccion2[2]+"X) "+ValordecisionRestriccion2+" "+ValorSujetoARestriccion2); 
            }
             else if(ValoresRestriccion2.Length ==4)
            {
                System.Console.WriteLine("Restriccion 2 = "+"("+ValoresRestriccion2[0]+"X) +" +"("+ValoresRestriccion2[1]+"X) +"+"("+ValoresRestriccion2[2]+"X) +"+"("+ValoresRestriccion2[3]+"X) "+ValordecisionRestriccion2+" "+ValorSujetoARestriccion2); 
            }
             else if(ValoresRestriccion2.Length ==5)
            {
                 System.Console.WriteLine("Restriccion 2 = "+"("+ValoresRestriccion2[0]+"X) +"+"("+ValoresRestriccion2[1]+"X) +"+"("+ValoresRestriccion2[2]+"X) +"+"("+ValoresRestriccion2[3]+"X) +"+"("+ValoresRestriccion2[4]+"X) "+ValordecisionRestriccion2+" "+ValorSujetoARestriccion2); 
            }

             if(ValoresRestriccion3.Length ==1)
            {
            System.Console.WriteLine("Restriccion 3 = "+"("+ValoresRestriccion3[0]+"X) "+ValordecisionRestriccion3+" "+ValorSujetoARestriccion3);
            }
            else if(ValoresRestriccion3.Length ==2)
            {
            System.Console.WriteLine("Restriccion 3 = "+"("+ValoresRestriccion3[0]+"X) +"+"("+ValoresRestriccion3[1]+"X) "+ValordecisionRestriccion3+" "+ValorSujetoARestriccion3);
            }
             else if(ValoresRestriccion3.Length ==3)
            {
             System.Console.WriteLine("Restriccion 3 = "+"("+ValoresRestriccion3[0]+"X) +" +"("+ValoresRestriccion3[1]+"X) +"+"("+ValoresRestriccion3[2]+"X) "+ValordecisionRestriccion3+" "+ValorSujetoARestriccion3); 
            }
             else if(ValoresRestriccion3.Length ==4)
            {
                System.Console.WriteLine("Restriccion 3 = "+"("+ValoresRestriccion3[0]+"X) +" +"("+ValoresRestriccion3[1]+"X) +"+"("+ValoresRestriccion3[2]+"X) +"+"("+ValoresRestriccion3[3]+"X) "+ValordecisionRestriccion3+" "+ValorSujetoARestriccion3); 
            }
             else if(ValoresRestriccion3.Length ==5)
            {
                 System.Console.WriteLine("Restriccion 3 = "+"("+ValoresRestriccion3[0]+"X) +"+"("+ValoresRestriccion3[1]+"X) +"+"("+ValoresRestriccion3[2]+"X) +"+"("+ValoresRestriccion3[3]+"X) +"+"("+ValoresRestriccion3[4]+"X) "+ValordecisionRestriccion3+" "+ValorSujetoARestriccion3); 
            }

             if(ValoresRestriccion4.Length ==1)
            {
            System.Console.WriteLine("Restriccion 4 = "+"("+ValoresRestriccion4[0]+"X) "+ValordecisionRestriccion4+" "+ValorSujetoARestriccion4);
            }
            else if(ValoresRestriccion4.Length ==2)
            {
            System.Console.WriteLine("Restriccion 4 = "+"("+ValoresRestriccion4[0]+"X) +"+"("+ValoresRestriccion4[1]+"X) "+ValordecisionRestriccion4+" "+ValorSujetoARestriccion4);
            }
             else if(ValoresRestriccion4.Length ==3)
            {
             System.Console.WriteLine("Restriccion 4 = "+"("+ValoresRestriccion4[0]+"X) +" +"("+ValoresRestriccion4[1]+"X) +"+"("+ValoresRestriccion4[2]+"X) "+ValordecisionRestriccion4+" "+ValorSujetoARestriccion4); 
            }
             else if(ValoresRestriccion4.Length ==4)
            {
                System.Console.WriteLine("Restriccion 4 = "+"("+ValoresRestriccion4[0]+"X) +" +"("+ValoresRestriccion4[1]+"X) +"+"("+ValoresRestriccion4[2]+"X) +"+"("+ValoresRestriccion4[3]+"X) "+ValordecisionRestriccion4+" "+ValorSujetoARestriccion4); 
            }
             else if(ValoresRestriccion4.Length ==5)
            {
                 System.Console.WriteLine("Restriccion 4 = "+"("+ValoresRestriccion4[0]+"X) +"+"("+ValoresRestriccion4[1]+"X) +"+"("+ValoresRestriccion4[2]+"X) +"+"("+ValoresRestriccion4[3]+"X) +"+"("+ValoresRestriccion4[4]+"X) "+ValordecisionRestriccion4+" "+ValorSujetoARestriccion4); 
            }

             if(ValoresRestriccion5.Length ==1)
            {
            System.Console.WriteLine("Restriccion 5 = "+"("+ValoresRestriccion5[0]+"X) "+ValordecisionRestriccion5+" "+ValorSujetoARestriccion5);
            }
            else if(ValoresRestriccion5.Length ==2)
            {
            System.Console.WriteLine("Restriccion 5 = "+"("+ValoresRestriccion5[0]+"X) +"+"("+ValoresRestriccion5[1]+"X) "+ValordecisionRestriccion5+" "+ValorSujetoARestriccion5);
            }
             else if(ValoresRestriccion5.Length ==3)
            {
             System.Console.WriteLine("Restriccion 5 = "+"("+ValoresRestriccion5[0]+"X) +" +"("+ValoresRestriccion5[1]+"X) +"+"("+ValoresRestriccion5[2]+"X) "+ValordecisionRestriccion5+" "+ValorSujetoARestriccion5); 
            }
             else if(ValoresRestriccion5.Length ==4)
            {
                System.Console.WriteLine("Restriccion 5 = "+"("+ValoresRestriccion5[0]+"X) +" +"("+ValoresRestriccion5[1]+"X) +"+"("+ValoresRestriccion5[2]+"X) +"+"("+ValoresRestriccion5[3]+"X) "+ValordecisionRestriccion5+" "+ValorSujetoARestriccion5); 
            }
             else if(ValoresRestriccion5.Length ==5)
            {
                 System.Console.WriteLine("Restriccion 5 = "+"("+ValoresRestriccion5[0]+"X) +"+"("+ValoresRestriccion5[1]+"X) +"+"("+ValoresRestriccion5[2]+"X) +"+"("+ValoresRestriccion5[3]+"X) +"+"("+ValoresRestriccion5[4]+"X) "+ValordecisionRestriccion5+" "+ValorSujetoARestriccion5); 
            }
             System.Console.WriteLine("Primer Tabla Simplex\n\n");
              ValoresDeZSimplex = ValoresXParaZEnSimplex(ValoresDeZSimplex);
            System.Console.WriteLine($"Variables Basicas            Z            X1            X2            X3            X4            X5            S1            S2            S3            S4            S5            CR");
            System.Console.WriteLine($"         S1                  0            {ValoresRestriccion1[0]}           {ValoresRestriccion1[1]}           {ValoresRestriccion1[2]}           {ValoresRestriccion1[3]}           {ValoresRestriccion1[4]}           1           0           0           0           0           {ValorSujetoARestriccion1}");
            System.Console.WriteLine($"         S2                  0            {ValoresRestriccion2[0]}           {ValoresRestriccion2[1]}           {ValoresRestriccion2[2]}           {ValoresRestriccion2[3]}           {ValoresRestriccion2[4]}           0           1           0           0           0           {ValorSujetoARestriccion2}");
            System.Console.WriteLine($"         S3                  0            {ValoresRestriccion3[0]}           {ValoresRestriccion3[1]}           {ValoresRestriccion3[2]}           {ValoresRestriccion3[3]}           {ValoresRestriccion3[4]}           0           0           1           0           0           {ValorSujetoARestriccion3}");
            System.Console.WriteLine($"         S4                  0            {ValoresRestriccion4[0]}           {ValoresRestriccion4[1]}           {ValoresRestriccion4[2]}           {ValoresRestriccion4[3]}           {ValoresRestriccion4[4]}           0           0           0           1           0           {ValorSujetoARestriccion4}");
            System.Console.WriteLine($"         S5                  0            {ValoresRestriccion5[0]}           {ValoresRestriccion5[1]}           {ValoresRestriccion5[2]}           {ValoresRestriccion5[3]}           {ValoresRestriccion5[4]}           0           0           0           0           1           {ValorSujetoARestriccion5}");
            System.Console.WriteLine($"          Z                  1            {ValoresDeZSimplex[0]}           {ValoresDeZSimplex[1]}           {ValoresDeZSimplex[2]}           {ValoresDeZSimplex[3]}           {ValoresDeZSimplex[4]}           0           0           0           0           0           0");
            //Comienzo if para el valor de Z1 como el menor de todos Para tomar X1 como la fila
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
                    //Restriccion 4
                     ValorSujetoARestriccion4 = ValorSujetoARestriccion4 - (ValoresRestriccion4[0]*ValorSujetoARestriccion1);

                     for(int i=0; i<ValoresRestriccion4.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion4[i] = ValoresRestriccion4[i]-(ValoresRestriccion4[0]*ValoresRestriccion1[i]);
                        }
                         //Valores S1,S2,S3,S4,S5 Para Columna X4
                        float S1X4 = 0 - (ValoresRestriccion4[0]*S1X1);
                        float S2X4 = 0 - (ValoresRestriccion4[0]*S2X1);
                        float S3X4 = 0 - (ValoresRestriccion4[0]*S3X1);
                        float S4X4 = 1 - (ValoresRestriccion4[0]*S4X1);
                        float S5X4 = 0 - (ValoresRestriccion4[0]*S5X1);
                    //Restriccion 5
                     ValorSujetoARestriccion5 = ValorSujetoARestriccion5 - (ValoresRestriccion5[0]*ValorSujetoARestriccion1);

                     for(int i=0; i<ValoresRestriccion5.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion5[i] = ValoresRestriccion5[i]-(ValoresRestriccion5[0]*ValoresRestriccion1[i]);
                        }
                    //Valores S1,S2,S3,S4,S5 Para Columna X5
                        float S1X5 = 0 - (ValoresRestriccion5[0]*S1X1);
                        float S2X5 = 0 - (ValoresRestriccion5[0]*S2X1);
                        float S3X5 = 0 - (ValoresRestriccion5[0]*S3X1);
                        float S4X5 = 0 - (ValoresRestriccion5[0]*S4X1);
                        float S5X5 = 1 - (ValoresRestriccion5[0]*S5X1);
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
                    //Restriccion 4
                     ValorSujetoARestriccion4 = ValorSujetoARestriccion4 - (ValoresRestriccion4[0]*ValorSujetoARestriccion2);

                     for(int i=0; i<ValoresRestriccion4.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion4[i] = ValoresRestriccion4[i]-(ValoresRestriccion4[0]*ValoresRestriccion2[i]);
                        }
                         //Valores S1,S2,S3,S4,S5 Para Columna X4
                        float S1X4 = 0 - (ValoresRestriccion4[0]*S1X2);
                        float S2X4 = 0 - (ValoresRestriccion4[0]*S2X2);
                        float S3X4 = 0 - (ValoresRestriccion4[0]*S3X2);
                        float S4X4 = 1 - (ValoresRestriccion4[0]*S4X2);
                        float S5X4 = 0 - (ValoresRestriccion4[0]*S5X2);
                    //Restriccion 5
                     ValorSujetoARestriccion5 = ValorSujetoARestriccion5 - (ValoresRestriccion5[0]*ValorSujetoARestriccion2);

                     for(int i=0; i<ValoresRestriccion5.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion5[i] = ValoresRestriccion5[i]-(ValoresRestriccion5[0]*ValoresRestriccion2[i]);
                        }
                    //Valores S1,S2,S3,S4,S5 Para Columna X5
                        float S1X5 = 0 - (ValoresRestriccion5[0]*S1X2);
                        float S2X5 = 0 - (ValoresRestriccion5[0]*S2X2);
                        float S3X5 = 0 - (ValoresRestriccion5[0]*S3X2);
                        float S4X5 = 0 - (ValoresRestriccion5[0]*S4X2);
                        float S5X5 = 1 - (ValoresRestriccion5[0]*S5X2);
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
                    //Restriccion 4
                     ValorSujetoARestriccion4 = ValorSujetoARestriccion4 - (ValoresRestriccion4[0]*ValorSujetoARestriccion3);

                     for(int i=0; i<ValoresRestriccion4.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion4[i] = ValoresRestriccion4[i]-(ValoresRestriccion4[0]*ValoresRestriccion3[i]);
                        }
                         //Valores S1,S2,S3,S4,S5 Para Columna X4
                        float S1X4 = 0 - (ValoresRestriccion4[0]*S1X3);
                        float S2X4 = 0 - (ValoresRestriccion4[0]*S2X3);
                        float S3X4 = 0 - (ValoresRestriccion4[0]*S3X3);
                        float S4X4 = 1 - (ValoresRestriccion4[0]*S4X3);
                        float S5X4 = 0 - (ValoresRestriccion4[0]*S5X3);
                    //Restriccion 5
                     ValorSujetoARestriccion5 = ValorSujetoARestriccion5 - (ValoresRestriccion5[0]*ValorSujetoARestriccion3);

                     for(int i=0; i<ValoresRestriccion5.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion5[i] = ValoresRestriccion5[i]-(ValoresRestriccion5[0]*ValoresRestriccion3[i]);
                        }
                    //Valores S1,S2,S3,S4,S5 Para Columna X5
                        float S1X5 = 0 - (ValoresRestriccion5[0]*S1X3);
                        float S2X5 = 0 - (ValoresRestriccion5[0]*S2X3);
                        float S3X5 = 0 - (ValoresRestriccion5[0]*S3X3);
                        float S4X5 = 0 - (ValoresRestriccion5[0]*S4X3);
                        float S5X5 = 1 - (ValoresRestriccion5[0]*S5X3);
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




                   else if((ValorSujetoARestriccion4/ValoresRestriccion4[0])<(ValorSujetoARestriccion1/ValoresRestriccion1[0])&&(ValorSujetoARestriccion4/ValoresRestriccion4[0])<(ValorSujetoARestriccion2/ValoresRestriccion2[0])&&(ValorSujetoARestriccion4/ValoresRestriccion4[0])<(ValorSujetoARestriccion3/ValoresRestriccion3[0])&&(ValorSujetoARestriccion4/ValoresRestriccion4[0])<(ValorSujetoARestriccion5/ValoresRestriccion5[0]))
                 {

                      System.Console.WriteLine("Segunda Tabla Simplex\n\n"); 
                    //Nuevos Valores Tabla Simplex 2
                    //Restriccion 4
                     ValorSujetoARestriccion4 = ValorSujetoARestriccion4/ValoresRestriccion4[0];
                    for(int i=0; i<ValoresRestriccion4.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion4[i] = ValoresRestriccion4[i]/ValoresRestriccion4[0];
                        }
                        //Valores S1,S2,S3,S4,S5 Para Columna X4
                        float S1X4 = 0/ValoresRestriccion4[0];
                        float S2X4 = 0/ValoresRestriccion4[0];
                        float S3X4 = 0 /ValoresRestriccion4[0];
                        float S4X4 = 1/ValoresRestriccion4[0];
                        float S5X4 = 0/ValoresRestriccion4[0];
                    //Restriccion 1
                        ValorSujetoARestriccion1 = ValorSujetoARestriccion1 - (ValoresRestriccion1[0]*ValorSujetoARestriccion4);

                     for(int i=0; i<ValoresRestriccion1.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion1[i] = ValoresRestriccion1[i]-(ValoresRestriccion1[0]*ValoresRestriccion4[i]);
                        }
                          //Valores S1,S2,S3,S4,S5 Para Columna X2
                        float S1X1 = 1 - (ValoresRestriccion1[0]*S1X4);
                        float S2X1 = 0 - (ValoresRestriccion1[0]*S2X4);
                        float S3X1 = 0 - (ValoresRestriccion1[0]*S3X4);
                        float S4X1 = 0 - (ValoresRestriccion1[0]*S4X4);
                        float S5X1 = 0 - (ValoresRestriccion1[0]*S5X4);
                    //Restriccion 3
                         ValorSujetoARestriccion3 = ValorSujetoARestriccion3 - (ValoresRestriccion3[0]*ValorSujetoARestriccion4);

                     for(int i=0; i<ValoresRestriccion3.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion3[i] = ValoresRestriccion3[i]-(ValoresRestriccion3[0]*ValoresRestriccion4[i]);
                        }
                         //Valores S1,S2,S3,S4,S5 Para Columna X3
                        float S1X3 = 0 - (ValoresRestriccion3[0]*S1X4);
                        float S2X3 = 0 - (ValoresRestriccion3[0]*S2X4);
                        float S3X3 = 1 - (ValoresRestriccion3[0]*S3X4);
                        float S4X3 = 0 - (ValoresRestriccion3[0]*S4X4);
                        float S5X3 = 0 - (ValoresRestriccion3[0]*S5X4);
                    //Restriccion 2
                     ValorSujetoARestriccion2 = ValorSujetoARestriccion2 - (ValoresRestriccion2[0]*ValorSujetoARestriccion4);

                     for(int i=0; i<ValoresRestriccion2.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion2[i] = ValoresRestriccion2[i]-(ValoresRestriccion2[0]*ValoresRestriccion4[i]);
                        }
                         //Valores S1,S2,S3,S4,S5 Para Columna X4
                        float S1X2 = 0 - (ValoresRestriccion2[0]*S1X4);
                        float S2X2 = 1 - (ValoresRestriccion2[0]*S2X4);
                        float S3X2 = 0 - (ValoresRestriccion2[0]*S3X4);
                        float S4X2 = 0 - (ValoresRestriccion2[0]*S4X4);
                        float S5X2 = 0 - (ValoresRestriccion2[0]*S5X4);
                    //Restriccion 5
                     ValorSujetoARestriccion5 = ValorSujetoARestriccion5 - (ValoresRestriccion5[0]*ValorSujetoARestriccion4);

                     for(int i=0; i<ValoresRestriccion5.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion5[i] = ValoresRestriccion5[i]-(ValoresRestriccion5[0]*ValoresRestriccion4[i]);
                        }
                    //Valores S1,S2,S3,S4,S5 Para Columna X5
                        float S1X5 = 0 - (ValoresRestriccion5[0]*S1X4);
                        float S2X5 = 0 - (ValoresRestriccion5[0]*S2X4);
                        float S3X5 = 0 - (ValoresRestriccion5[0]*S3X4);
                        float S4X5 = 0 - (ValoresRestriccion5[0]*S4X4);
                        float S5X5 = 1 - (ValoresRestriccion5[0]*S5X4);
                        //Valor de Z
                         for(int i=0; i<ValoresDeZSimplex.Length; i++)                                   
                        {                                                                 
                            ValoresDeZSimplex[i] = ValoresDeZSimplex[i]-(ValoresDeZSimplex[0]*ValoresRestriccion4[i]);
                        }
                        //Valores Z y CR Para Columna Z
                        float Z = 1 - (ValoresDeZSimplex[0] * 0);
                        float CR = 0 - (ValoresDeZSimplex[0] * ValorSujetoARestriccion4);
                        //Tabla
                     System.Console.WriteLine($"Variables Basicas            Z            X1            X2            X3            X4            X5            S1            S2            S3            S4            S5            CR");
            System.Console.WriteLine($"         X1                  0            {ValoresRestriccion1[0]}           {ValoresRestriccion1[1]}           {ValoresRestriccion1[2]}           {ValoresRestriccion1[3]}           {ValoresRestriccion1[4]}           {S1X1}           {S2X1}           {S3X1}           {S4X1}           {S5X1}           {ValorSujetoARestriccion1}");
            System.Console.WriteLine($"         S2                  0            {ValoresRestriccion2[0]}           {ValoresRestriccion2[1]}           {ValoresRestriccion2[2]}           {ValoresRestriccion2[3]}           {ValoresRestriccion2[4]}           {S1X2}           {S2X2}           {S3X2}           {S4X2}           {S5X2}           {ValorSujetoARestriccion2}");
            System.Console.WriteLine($"         S3                  0            {ValoresRestriccion3[0]}           {ValoresRestriccion3[1]}           {ValoresRestriccion3[2]}           {ValoresRestriccion3[3]}           {ValoresRestriccion3[4]}           {S1X3}           {S2X3}           {S3X3}           {S4X3}           {S5X3}           {ValorSujetoARestriccion3}");
            System.Console.WriteLine($"         S4                  0            {ValoresRestriccion4[0]}           {ValoresRestriccion4[1]}           {ValoresRestriccion4[2]}           {ValoresRestriccion4[3]}           {ValoresRestriccion4[4]}           {S1X4}           {S2X4}           {S3X4}           {S4X4}           {S5X4}           {ValorSujetoARestriccion4}");
            System.Console.WriteLine($"         S5                  0            {ValoresRestriccion5[0]}           {ValoresRestriccion5[1]}           {ValoresRestriccion5[2]}           {ValoresRestriccion5[3]}           {ValoresRestriccion5[4]}           {S1X5}           {S2X5}           {S3X5}           {S4X5}           {S5X5}           {ValorSujetoARestriccion5}");
            System.Console.WriteLine($"          Z                  {Z}            {ValoresDeZSimplex[0]}           {ValoresDeZSimplex[1]}           {ValoresDeZSimplex[2]}           {ValoresDeZSimplex[3]}           {ValoresDeZSimplex[4]}           0           0           0           0           0           {CR}");

            //Tercera Tabla Simplex


                 } //Si es el caso de que la columna S4 sea el mas negativo

                   else if((ValorSujetoARestriccion5/ValoresRestriccion5[0])<(ValorSujetoARestriccion1/ValoresRestriccion1[0])&&(ValorSujetoARestriccion5/ValoresRestriccion5[0])<(ValorSujetoARestriccion2/ValoresRestriccion2[0])&&(ValorSujetoARestriccion5/ValoresRestriccion5[0])<(ValorSujetoARestriccion4/ValoresRestriccion4[0])&&(ValorSujetoARestriccion5/ValoresRestriccion5[0])<(ValorSujetoARestriccion3/ValoresRestriccion3[0]))
                 {

                        System.Console.WriteLine("Segunda Tabla Simplex\n\n"); 
                    //Nuevos Valores Tabla Simplex 2
                    //Restriccion 5
                     ValorSujetoARestriccion5 = ValorSujetoARestriccion5/ValoresRestriccion5[0];
                    for(int i=0; i<ValoresRestriccion5.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion5[i] = ValoresRestriccion5[i]/ValoresRestriccion5[0];
                        }
                        //Valores S1,S2,S3,S4,S5 Para Columna X5
                        float S1X5 = 0/ValoresRestriccion5[0];
                        float S2X5 = 0/ValoresRestriccion5[0];
                        float S3X5 = 0 /ValoresRestriccion5[0];
                        float S4X5 = 0/ValoresRestriccion5[0];
                        float S5X5 = 1/ValoresRestriccion5[0];
                    //Restriccion 1
                        ValorSujetoARestriccion1 = ValorSujetoARestriccion1 - (ValoresRestriccion1[0]*ValorSujetoARestriccion5);

                     for(int i=0; i<ValoresRestriccion1.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion1[i] = ValoresRestriccion1[i]-(ValoresRestriccion1[0]*ValoresRestriccion5[i]);
                        }
                          //Valores S1,S2,S3,S4,S5 Para Columna X2
                        float S1X1 = 1 - (ValoresRestriccion1[0]*S1X5);
                        float S2X1 = 0 - (ValoresRestriccion1[0]*S2X5);
                        float S3X1 = 0 - (ValoresRestriccion1[0]*S3X5);
                        float S4X1 = 0 - (ValoresRestriccion1[0]*S4X5);
                        float S5X1 = 0 - (ValoresRestriccion1[0]*S5X5);
                    //Restriccion 3
                         ValorSujetoARestriccion3 = ValorSujetoARestriccion3 - (ValoresRestriccion3[0]*ValorSujetoARestriccion5);

                     for(int i=0; i<ValoresRestriccion3.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion3[i] = ValoresRestriccion3[i]-(ValoresRestriccion3[0]*ValoresRestriccion5[i]);
                        }
                         //Valores S1,S2,S3,S4,S5 Para Columna X3
                        float S1X3 = 0 - (ValoresRestriccion3[0]*S1X5);
                        float S2X3 = 0 - (ValoresRestriccion3[0]*S2X5);
                        float S3X3 = 1 - (ValoresRestriccion3[0]*S3X5);
                        float S4X3 = 0 - (ValoresRestriccion3[0]*S4X5);
                        float S5X3 = 0 - (ValoresRestriccion3[0]*S5X5);
                    //Restriccion 4
                     ValorSujetoARestriccion4 = ValorSujetoARestriccion4 - (ValoresRestriccion4[0]*ValorSujetoARestriccion5);

                     for(int i=0; i<ValoresRestriccion4.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion4[i] = ValoresRestriccion4[i]-(ValoresRestriccion4[0]*ValoresRestriccion5[i]);
                        }
                         //Valores S1,S2,S3,S4,S5 Para Columna X4
                        float S1X4 = 0 - (ValoresRestriccion4[0]*S1X5);
                        float S2X4 = 0 - (ValoresRestriccion4[0]*S2X5);
                        float S3X4 = 0 - (ValoresRestriccion4[0]*S3X5);
                        float S4X4 = 1 - (ValoresRestriccion4[0]*S4X5);
                        float S5X4 = 0 - (ValoresRestriccion4[0]*S5X5);
                    //Restriccion 5
                     ValorSujetoARestriccion2 = ValorSujetoARestriccion2 - (ValoresRestriccion2[0]*ValorSujetoARestriccion5);

                     for(int i=0; i<ValoresRestriccion2.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion2[i] = ValoresRestriccion2[i]-(ValoresRestriccion2[0]*ValoresRestriccion5[i]);
                        }
                    //Valores S1,S2,S3,S4,S5 Para Columna X2
                        float S1X2 = 0 - (ValoresRestriccion2[0]*S1X5);
                        float S2X2 = 1 - (ValoresRestriccion2[0]*S2X5);
                        float S3X2 = 0 - (ValoresRestriccion2[0]*S3X5);
                        float S4X2 = 0 - (ValoresRestriccion2[0]*S4X5);
                        float S5X2 = 0 - (ValoresRestriccion2[0]*S5X5);
                        //Valor de Z
                         for(int i=0; i<ValoresDeZSimplex.Length; i++)                                   
                        {                                                                 
                            ValoresDeZSimplex[i] = ValoresDeZSimplex[i]-(ValoresDeZSimplex[0]*ValoresRestriccion5[i]);
                        }
                        //Valores Z y CR Para Columna Z
                        float Z = 1 - (ValoresDeZSimplex[0] * 0);
                        float CR = 0 - (ValoresDeZSimplex[0] * ValorSujetoARestriccion5);
                        //Tabla
                     System.Console.WriteLine($"Variables Basicas            Z            X1            X2            X3            X4            X5            S1            S2            S3            S4            S5            CR");
            System.Console.WriteLine($"         X1                  0            {ValoresRestriccion1[0]}           {ValoresRestriccion1[1]}           {ValoresRestriccion1[2]}           {ValoresRestriccion1[3]}           {ValoresRestriccion1[4]}           {S1X1}           {S2X1}           {S3X1}           {S4X1}           {S5X1}           {ValorSujetoARestriccion1}");
            System.Console.WriteLine($"         S2                  0            {ValoresRestriccion2[0]}           {ValoresRestriccion2[1]}           {ValoresRestriccion2[2]}           {ValoresRestriccion2[3]}           {ValoresRestriccion2[4]}           {S1X2}           {S2X2}           {S3X2}           {S4X2}           {S5X2}           {ValorSujetoARestriccion2}");
            System.Console.WriteLine($"         S3                  0            {ValoresRestriccion3[0]}           {ValoresRestriccion3[1]}           {ValoresRestriccion3[2]}           {ValoresRestriccion3[3]}           {ValoresRestriccion3[4]}           {S1X3}           {S2X3}           {S3X3}           {S4X3}           {S5X3}           {ValorSujetoARestriccion3}");
            System.Console.WriteLine($"         S4                  0            {ValoresRestriccion4[0]}           {ValoresRestriccion4[1]}           {ValoresRestriccion4[2]}           {ValoresRestriccion4[3]}           {ValoresRestriccion4[4]}           {S1X4}           {S2X4}           {S3X4}           {S4X4}           {S5X4}           {ValorSujetoARestriccion4}");
            System.Console.WriteLine($"         S5                  0            {ValoresRestriccion5[0]}           {ValoresRestriccion5[1]}           {ValoresRestriccion5[2]}           {ValoresRestriccion5[3]}           {ValoresRestriccion5[4]}           {S1X5}           {S2X5}           {S3X5}           {S4X5}           {S5X5}           {ValorSujetoARestriccion5}");
            System.Console.WriteLine($"          Z                  {Z}            {ValoresDeZSimplex[0]}           {ValoresDeZSimplex[1]}           {ValoresDeZSimplex[2]}           {ValoresDeZSimplex[3]}           {ValoresDeZSimplex[4]}           0           0           0           0           0           {CR}");

            //Tercera Tabla Simplex

                 } //Si es el caso de que la columna S5 sea el mas negativo

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
                    //Restriccion 4
                     ValorSujetoARestriccion4 = ValorSujetoARestriccion4 - (ValoresRestriccion4[1]*ValorSujetoARestriccion1);

                     for(int i=0; i<ValoresRestriccion4.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion4[i] = ValoresRestriccion4[i]-(ValoresRestriccion4[1]*ValoresRestriccion1[i]);
                        }
                         //Valores S1,S2,S3,S4,S5 Para Columna X4
                        float S1X4 = 0 - (ValoresRestriccion4[1]*S1X1);
                        float S2X4 = 0 - (ValoresRestriccion4[1]*S2X1);
                        float S3X4 = 0 - (ValoresRestriccion4[1]*S3X1);
                        float S4X4 = 1 - (ValoresRestriccion4[1]*S4X1);
                        float S5X4 = 0 - (ValoresRestriccion4[1]*S5X1);
                    //Restriccion 5
                     ValorSujetoARestriccion5 = ValorSujetoARestriccion5 - (ValoresRestriccion5[1]*ValorSujetoARestriccion1);

                     for(int i=0; i<ValoresRestriccion5.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion5[i] = ValoresRestriccion5[i]-(ValoresRestriccion5[1]*ValoresRestriccion1[i]);
                        }
                    //Valores S1,S2,S3,S4,S5 Para Columna X5
                        float S1X5 = 0 - (ValoresRestriccion5[1]*S1X1);
                        float S2X5 = 0 - (ValoresRestriccion5[1]*S2X1);
                        float S3X5 = 0 - (ValoresRestriccion5[1]*S3X1);
                        float S4X5 = 0 - (ValoresRestriccion5[1]*S4X1);
                        float S5X5 = 1 - (ValoresRestriccion5[1]*S5X1);
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
                    //Restriccion 4
                     ValorSujetoARestriccion4 = ValorSujetoARestriccion4 - (ValoresRestriccion4[1]*ValorSujetoARestriccion2);

                     for(int i=0; i<ValoresRestriccion4.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion4[i] = ValoresRestriccion4[i]-(ValoresRestriccion4[1]*ValoresRestriccion2[i]);
                        }
                         //Valores S1,S2,S3,S4,S5 Para Columna X4
                        float S1X4 = 0 - (ValoresRestriccion4[1]*S1X2);
                        float S2X4 = 0 - (ValoresRestriccion4[1]*S2X2);
                        float S3X4 = 0 - (ValoresRestriccion4[1]*S3X2);
                        float S4X4 = 1 - (ValoresRestriccion4[1]*S4X2);
                        float S5X4 = 0 - (ValoresRestriccion4[1]*S5X2);
                    //Restriccion 5
                     ValorSujetoARestriccion5 = ValorSujetoARestriccion5 - (ValoresRestriccion5[1]*ValorSujetoARestriccion2);

                     for(int i=0; i<ValoresRestriccion5.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion5[i] = ValoresRestriccion5[i]-(ValoresRestriccion5[1]*ValoresRestriccion2[i]);
                        }
                    //Valores S1,S2,S3,S4,S5 Para Columna X5
                        float S1X5 = 0 - (ValoresRestriccion5[1]*S1X2);
                        float S2X5 = 0 - (ValoresRestriccion5[1]*S2X2);
                        float S3X5 = 0 - (ValoresRestriccion5[1]*S3X2);
                        float S4X5 = 0 - (ValoresRestriccion5[1]*S4X2);
                        float S5X5 = 1 - (ValoresRestriccion5[1]*S5X2);
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
                    //Restriccion 4
                     ValorSujetoARestriccion4 = ValorSujetoARestriccion4 - (ValoresRestriccion4[1]*ValorSujetoARestriccion3);

                     for(int i=0; i<ValoresRestriccion4.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion4[i] = ValoresRestriccion4[i]-(ValoresRestriccion4[1]*ValoresRestriccion3[i]);
                        }
                         //Valores S1,S2,S3,S4,S5 Para Columna X4
                        float S1X4 = 0 - (ValoresRestriccion4[1]*S1X3);
                        float S2X4 = 0 - (ValoresRestriccion4[1]*S2X3);
                        float S3X4 = 0 - (ValoresRestriccion4[1]*S3X3);
                        float S4X4 = 1 - (ValoresRestriccion4[1]*S4X3);
                        float S5X4 = 0 - (ValoresRestriccion4[1]*S5X3);
                    //Restriccion 5
                     ValorSujetoARestriccion5 = ValorSujetoARestriccion5 - (ValoresRestriccion5[1]*ValorSujetoARestriccion3);

                     for(int i=0; i<ValoresRestriccion5.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion5[i] = ValoresRestriccion5[i]-(ValoresRestriccion5[1]*ValoresRestriccion3[i]);
                        }
                    //Valores S1,S2,S3,S4,S5 Para Columna X5
                        float S1X5 = 0 - (ValoresRestriccion5[1]*S1X3);
                        float S2X5 = 0 - (ValoresRestriccion5[1]*S2X3);
                        float S3X5 = 0 - (ValoresRestriccion5[1]*S3X3);
                        float S4X5 = 0 - (ValoresRestriccion5[1]*S4X3);
                        float S5X5 = 1 - (ValoresRestriccion5[1]*S5X3);
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



                   else if((ValorSujetoARestriccion4/ValoresRestriccion4[1])<(ValorSujetoARestriccion1/ValoresRestriccion1[1])&&(ValorSujetoARestriccion4/ValoresRestriccion4[1])<(ValorSujetoARestriccion2/ValoresRestriccion2[1])&&(ValorSujetoARestriccion4/ValoresRestriccion4[1])<(ValorSujetoARestriccion3/ValoresRestriccion3[1])&&(ValorSujetoARestriccion4/ValoresRestriccion4[1])<(ValorSujetoARestriccion5/ValoresRestriccion5[1]))
                 {
                     System.Console.WriteLine("Segunda Tabla Simplex\n\n"); 
                    //Nuevos Valores Tabla Simplex 2
                    //Restriccion 4
                     ValorSujetoARestriccion4 = ValorSujetoARestriccion4/ValoresRestriccion4[1];
                    for(int i=0; i<ValoresRestriccion4.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion4[i] = ValoresRestriccion4[i]/ValoresRestriccion4[1];
                        }
                        //Valores S1,S2,S3,S4,S5 Para Columna X4
                        float S1X4 = 0/ValoresRestriccion4[1];
                        float S2X4 = 0/ValoresRestriccion4[1];
                        float S3X4 = 0 /ValoresRestriccion4[1];
                        float S4X4 = 1/ValoresRestriccion4[1];
                        float S5X4 = 0/ValoresRestriccion4[1];
                    //Restriccion 1
                        ValorSujetoARestriccion1 = ValorSujetoARestriccion1 - (ValoresRestriccion1[1]*ValorSujetoARestriccion4);

                     for(int i=0; i<ValoresRestriccion1.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion1[i] = ValoresRestriccion1[i]-(ValoresRestriccion1[1]*ValoresRestriccion4[i]);
                        }
                          //Valores S1,S2,S3,S4,S5 Para Columna X1
                        float S1X1 = 1 - (ValoresRestriccion1[1]*S1X4);
                        float S2X1 = 0 - (ValoresRestriccion1[1]*S2X4);
                        float S3X1 = 0 - (ValoresRestriccion1[1]*S3X4);
                        float S4X1 = 0 - (ValoresRestriccion1[1]*S4X4);
                        float S5X1 = 0 - (ValoresRestriccion1[1]*S5X4);
                    //Restriccion 3
                         ValorSujetoARestriccion3 = ValorSujetoARestriccion3 - (ValoresRestriccion3[1]*ValorSujetoARestriccion4);

                     for(int i=0; i<ValoresRestriccion3.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion3[i] = ValoresRestriccion3[i]-(ValoresRestriccion3[1]*ValoresRestriccion4[i]);
                        }
                         //Valores S1,S2,S3,S4,S5 Para Columna X3
                        float S1X3 = 0 - (ValoresRestriccion3[1]*S1X4);
                        float S2X3 = 0 - (ValoresRestriccion3[1]*S2X4);
                        float S3X3 = 1 - (ValoresRestriccion3[1]*S3X4);
                        float S4X3 = 0 - (ValoresRestriccion3[1]*S4X4);
                        float S5X3 = 0 - (ValoresRestriccion3[1]*S5X4);
                    //Restriccion 2
                     ValorSujetoARestriccion2 = ValorSujetoARestriccion2 - (ValoresRestriccion2[1]*ValorSujetoARestriccion4);

                     for(int i=0; i<ValoresRestriccion2.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion2[i] = ValoresRestriccion2[i]-(ValoresRestriccion2[1]*ValoresRestriccion4[i]);
                        }
                         //Valores S1,S2,S3,S4,S5 Para Columna X4
                        float S1X2 = 0 - (ValoresRestriccion2[1]*S1X4);
                        float S2X2 = 1 - (ValoresRestriccion2[1]*S2X4);
                        float S3X2 = 0 - (ValoresRestriccion2[1]*S3X4);
                        float S4X2 = 0 - (ValoresRestriccion2[1]*S4X4);
                        float S5X2 = 0 - (ValoresRestriccion2[1]*S5X4);
                    //Restriccion 5
                     ValorSujetoARestriccion5 = ValorSujetoARestriccion5 - (ValoresRestriccion5[1]*ValorSujetoARestriccion4);

                     for(int i=0; i<ValoresRestriccion5.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion5[i] = ValoresRestriccion5[i]-(ValoresRestriccion5[1]*ValoresRestriccion4[i]);
                        }
                    //Valores S1,S2,S3,S4,S5 Para Columna X5
                        float S1X5 = 0 - (ValoresRestriccion5[1]*S1X4);
                        float S2X5 = 0 - (ValoresRestriccion5[1]*S2X4);
                        float S3X5 = 0 - (ValoresRestriccion5[1]*S3X4);
                        float S4X5 = 0 - (ValoresRestriccion5[1]*S4X4);
                        float S5X5 = 1 - (ValoresRestriccion5[1]*S5X4);
                        //Valor de Z
                         for(int i=0; i<ValoresDeZSimplex.Length; i++)                                   
                        {                                                                 
                            ValoresDeZSimplex[i] = ValoresDeZSimplex[i]-(ValoresDeZSimplex[1]*ValoresRestriccion4[i]);
                        }
                        //Valores Z y CR Para Columna Z
                        float Z = 1 - (ValoresDeZSimplex[1] * 0);
                        float CR = 0 - (ValoresDeZSimplex[1] * ValorSujetoARestriccion4);
                        //Tabla
                     System.Console.WriteLine($"Variables Basicas            Z            X1            X2            X3            X4            X5            S1            S2            S3            S4            S5            CR");
            System.Console.WriteLine($"         X1                  0            {ValoresRestriccion1[0]}           {ValoresRestriccion1[1]}           {ValoresRestriccion1[2]}           {ValoresRestriccion1[3]}           {ValoresRestriccion1[4]}           {S1X1}           {S2X1}           {S3X1}           {S4X1}           {S5X1}           {ValorSujetoARestriccion1}");
            System.Console.WriteLine($"         S2                  0            {ValoresRestriccion2[0]}           {ValoresRestriccion2[1]}           {ValoresRestriccion2[2]}           {ValoresRestriccion2[3]}           {ValoresRestriccion2[4]}           {S1X2}           {S2X2}           {S3X2}           {S4X2}           {S5X2}           {ValorSujetoARestriccion2}");
            System.Console.WriteLine($"         S3                  0            {ValoresRestriccion3[0]}           {ValoresRestriccion3[1]}           {ValoresRestriccion3[2]}           {ValoresRestriccion3[3]}           {ValoresRestriccion3[4]}           {S1X3}           {S2X3}           {S3X3}           {S4X3}           {S5X3}           {ValorSujetoARestriccion3}");
            System.Console.WriteLine($"         S4                  0            {ValoresRestriccion4[0]}           {ValoresRestriccion4[1]}           {ValoresRestriccion4[2]}           {ValoresRestriccion4[3]}           {ValoresRestriccion4[4]}           {S1X4}           {S2X4}           {S3X4}           {S4X4}           {S5X4}           {ValorSujetoARestriccion4}");
            System.Console.WriteLine($"         S5                  0            {ValoresRestriccion5[0]}           {ValoresRestriccion5[1]}           {ValoresRestriccion5[2]}           {ValoresRestriccion5[3]}           {ValoresRestriccion5[4]}           {S1X5}           {S2X5}           {S3X5}           {S4X5}           {S5X5}           {ValorSujetoARestriccion5}");
            System.Console.WriteLine($"          Z                  {Z}            {ValoresDeZSimplex[0]}           {ValoresDeZSimplex[1]}           {ValoresDeZSimplex[2]}           {ValoresDeZSimplex[3]}           {ValoresDeZSimplex[4]}           0           0           0           0           0           {CR}");

            //Tercera Tabla Simplex
                 } //Si es el caso de que la columna S4 sea el mas negativo



                   else if((ValorSujetoARestriccion5/ValoresRestriccion5[1])<(ValorSujetoARestriccion1/ValoresRestriccion1[1])&&(ValorSujetoARestriccion5/ValoresRestriccion5[1])<(ValorSujetoARestriccion2/ValoresRestriccion2[1])&&(ValorSujetoARestriccion5/ValoresRestriccion5[1])<(ValorSujetoARestriccion4/ValoresRestriccion4[1])&&(ValorSujetoARestriccion5/ValoresRestriccion5[1])<(ValorSujetoARestriccion3/ValoresRestriccion3[1]))
                 {
                     System.Console.WriteLine("Segunda Tabla Simplex\n\n"); 
                    //Nuevos Valores Tabla Simplex 2
                    //Restriccion 5
                     ValorSujetoARestriccion5 = ValorSujetoARestriccion5/ValoresRestriccion5[1];
                    for(int i=0; i<ValoresRestriccion5.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion5[i] = ValoresRestriccion5[i]/ValoresRestriccion5[1];
                        }
                        //Valores S1,S2,S3,S4,S5 Para Columna X5
                        float S1X5 = 0/ValoresRestriccion5[1];
                        float S2X5 = 0/ValoresRestriccion5[1];
                        float S3X5 = 0 /ValoresRestriccion5[1];
                        float S4X5 = 0/ValoresRestriccion5[1];
                        float S5X5 = 1/ValoresRestriccion5[1];
                    //Restriccion 1
                        ValorSujetoARestriccion1 = ValorSujetoARestriccion1 - (ValoresRestriccion1[1]*ValorSujetoARestriccion5);

                     for(int i=0; i<ValoresRestriccion1.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion1[i] = ValoresRestriccion1[i]-(ValoresRestriccion1[1]*ValoresRestriccion5[i]);
                        }
                          //Valores S1,S2,S3,S4,S5 Para Columna X1
                        float S1X1 = 1 - (ValoresRestriccion1[1]*S1X5);
                        float S2X1 = 0 - (ValoresRestriccion1[1]*S2X5);
                        float S3X1 = 0 - (ValoresRestriccion1[1]*S3X5);
                        float S4X1 = 0 - (ValoresRestriccion1[1]*S4X5);
                        float S5X1 = 0 - (ValoresRestriccion1[1]*S5X5);
                    //Restriccion 3
                         ValorSujetoARestriccion3 = ValorSujetoARestriccion3 - (ValoresRestriccion3[1]*ValorSujetoARestriccion5);

                     for(int i=0; i<ValoresRestriccion3.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion3[i] = ValoresRestriccion3[i]-(ValoresRestriccion3[1]*ValoresRestriccion5[i]);
                        }
                         //Valores S1,S2,S3,S4,S5 Para Columna X3
                        float S1X3 = 0 - (ValoresRestriccion3[1]*S1X5);
                        float S2X3 = 0 - (ValoresRestriccion3[1]*S2X5);
                        float S3X3 = 1 - (ValoresRestriccion3[1]*S3X5);
                        float S4X3 = 0 - (ValoresRestriccion3[1]*S4X5);
                        float S5X3 = 0 - (ValoresRestriccion3[1]*S5X5);
                    //Restriccion 4
                     ValorSujetoARestriccion4 = ValorSujetoARestriccion4 - (ValoresRestriccion4[1]*ValorSujetoARestriccion5);

                     for(int i=0; i<ValoresRestriccion4.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion4[i] = ValoresRestriccion4[i]-(ValoresRestriccion4[1]*ValoresRestriccion5[i]);
                        }
                         //Valores S1,S2,S3,S4,S5 Para Columna X4
                        float S1X4 = 0 - (ValoresRestriccion4[1]*S1X5);
                        float S2X4 = 0 - (ValoresRestriccion4[1]*S2X5);
                        float S3X4 = 0 - (ValoresRestriccion4[1]*S3X5);
                        float S4X4 = 1 - (ValoresRestriccion4[1]*S4X5);
                        float S5X4 = 0 - (ValoresRestriccion4[1]*S5X5);
                    //Restriccion 2
                     ValorSujetoARestriccion2 = ValorSujetoARestriccion2 - (ValoresRestriccion2[1]*ValorSujetoARestriccion5);

                     for(int i=0; i<ValoresRestriccion2.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion2[i] = ValoresRestriccion2[i]-(ValoresRestriccion2[1]*ValoresRestriccion5[i]);
                        }
                    //Valores S1,S2,S3,S4,S5 Para Columna X2
                        float S1X2 = 0 - (ValoresRestriccion2[1]*S1X5);
                        float S2X2 = 1 - (ValoresRestriccion2[1]*S2X5);
                        float S3X2 = 0 - (ValoresRestriccion2[1]*S3X5);
                        float S4X2 = 0 - (ValoresRestriccion2[1]*S4X5);
                        float S5X2 = 0 - (ValoresRestriccion2[1]*S5X5);
                        //Valor de Z
                         for(int i=0; i<ValoresDeZSimplex.Length; i++)                                   
                        {                                                                 
                            ValoresDeZSimplex[i] = ValoresDeZSimplex[i]-(ValoresDeZSimplex[1]*ValoresRestriccion5[i]);
                        }
                        //Valores Z y CR Para Columna Z
                        float Z = 1 - (ValoresDeZSimplex[1] * 0);
                        float CR = 0 - (ValoresDeZSimplex[1] * ValorSujetoARestriccion5);
                        //Tabla
                     System.Console.WriteLine($"Variables Basicas            Z            X1            X2            X3            X4            X5            S1            S2            S3            S4            S5            CR");
            System.Console.WriteLine($"         X1                  0            {ValoresRestriccion1[0]}           {ValoresRestriccion1[1]}           {ValoresRestriccion1[2]}           {ValoresRestriccion1[3]}           {ValoresRestriccion1[4]}           {S1X1}           {S2X1}           {S3X1}           {S4X1}           {S5X1}           {ValorSujetoARestriccion1}");
            System.Console.WriteLine($"         S2                  0            {ValoresRestriccion2[0]}           {ValoresRestriccion2[1]}           {ValoresRestriccion2[2]}           {ValoresRestriccion2[3]}           {ValoresRestriccion2[4]}           {S1X2}           {S2X2}           {S3X2}           {S4X2}           {S5X2}           {ValorSujetoARestriccion2}");
            System.Console.WriteLine($"         S3                  0            {ValoresRestriccion3[0]}           {ValoresRestriccion3[1]}           {ValoresRestriccion3[2]}           {ValoresRestriccion3[3]}           {ValoresRestriccion3[4]}           {S1X3}           {S2X3}           {S3X3}           {S4X3}           {S5X3}           {ValorSujetoARestriccion3}");
            System.Console.WriteLine($"         S4                  0            {ValoresRestriccion4[0]}           {ValoresRestriccion4[1]}           {ValoresRestriccion4[2]}           {ValoresRestriccion4[3]}           {ValoresRestriccion4[4]}           {S1X4}           {S2X4}           {S3X4}           {S4X4}           {S5X4}           {ValorSujetoARestriccion4}");
            System.Console.WriteLine($"         S5                  0            {ValoresRestriccion5[0]}           {ValoresRestriccion5[1]}           {ValoresRestriccion5[2]}           {ValoresRestriccion5[3]}           {ValoresRestriccion5[4]}           {S1X5}           {S2X5}           {S3X5}           {S4X5}           {S5X5}           {ValorSujetoARestriccion5}");
            System.Console.WriteLine($"          Z                  {Z}            {ValoresDeZSimplex[0]}           {ValoresDeZSimplex[1]}           {ValoresDeZSimplex[2]}           {ValoresDeZSimplex[3]}           {ValoresDeZSimplex[4]}           0           0           0           0           0           {CR}");

            //Tercera Tabla Simplex
                 } //Si es el caso de que la columna S5 sea el mas negativo
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
                    //Restriccion 5
                        ValorSujetoARestriccion5 = ValorSujetoARestriccion5 - (ValoresRestriccion5[2]*ValorSujetoARestriccion1);

                     for(int i=0; i<ValoresRestriccion5.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion5[i] = ValoresRestriccion5[i]-(ValoresRestriccion5[2]*ValoresRestriccion1[i]);
                        }
                          //Valores S1,S2,S3,S4,S5 Para Columna X1
                        float S1X5 = 0 - (ValoresRestriccion5[2]*S1X1);
                        float S2X5 = 0 - (ValoresRestriccion5[2]*S2X1);
                        float S3X5 = 0 - (ValoresRestriccion5[2]*S3X1);
                        float S4X5 = 0 - (ValoresRestriccion5[2]*S4X1);
                        float S5X5 = 1 - (ValoresRestriccion5[2]*S5X1);
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
                    //Restriccion 4
                     ValorSujetoARestriccion4 = ValorSujetoARestriccion4 - (ValoresRestriccion4[2]*ValorSujetoARestriccion1);

                     for(int i=0; i<ValoresRestriccion4.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion4[i] = ValoresRestriccion4[i]-(ValoresRestriccion4[2]*ValoresRestriccion1[i]);
                        }
                         //Valores S1,S2,S3,S4,S5 Para Columna X4
                        float S1X4 = 0 - (ValoresRestriccion4[2]*S1X1);
                        float S2X4 = 0 - (ValoresRestriccion4[2]*S2X1);
                        float S3X4 = 0 - (ValoresRestriccion4[2]*S3X1);
                        float S4X4 = 1 - (ValoresRestriccion4[2]*S4X1);
                        float S5X4 = 0 - (ValoresRestriccion4[2]*S5X1);
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
                    //Restriccion 5
                        ValorSujetoARestriccion5 = ValorSujetoARestriccion5 - (ValoresRestriccion5[2]*ValorSujetoARestriccion2);

                     for(int i=0; i<ValoresRestriccion5.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion5[i] = ValoresRestriccion5[i]-(ValoresRestriccion5[2]*ValoresRestriccion2[i]);
                        }
                          //Valores S1,S2,S3,S4,S5 Para Columna X5
                        float S1X5 = 0 - (ValoresRestriccion5[2]*S1X2);
                        float S2X5 = 0 - (ValoresRestriccion5[2]*S2X2);
                        float S3X5 = 0 - (ValoresRestriccion5[2]*S3X2);
                        float S4X5 = 0 - (ValoresRestriccion5[2]*S4X2);
                        float S5X5 = 1 - (ValoresRestriccion5[2]*S5X2);
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
                    //Restriccion 4
                     ValorSujetoARestriccion4 = ValorSujetoARestriccion4 - (ValoresRestriccion4[2]*ValorSujetoARestriccion2);

                     for(int i=0; i<ValoresRestriccion4.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion4[i] = ValoresRestriccion4[i]-(ValoresRestriccion4[2]*ValoresRestriccion2[i]);
                        }
                         //Valores S1,S2,S3,S4,S5 Para Columna X4
                        float S1X4 = 0 - (ValoresRestriccion4[2]*S1X2);
                        float S2X4 = 0 - (ValoresRestriccion4[2]*S2X2);
                        float S3X4 = 0 - (ValoresRestriccion4[2]*S3X2);
                        float S4X4 = 1 - (ValoresRestriccion4[2]*S4X2);
                        float S5X4 = 0 - (ValoresRestriccion4[2]*S5X2);
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
                    //Restriccion 5
                        ValorSujetoARestriccion5 = ValorSujetoARestriccion5 - (ValoresRestriccion5[2]*ValorSujetoARestriccion3);

                     for(int i=0; i<ValoresRestriccion5.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion5[i] = ValoresRestriccion5[i]-(ValoresRestriccion5[2]*ValoresRestriccion3[i]);
                        }
                          //Valores S1,S2,S3,S4,S5 Para Columna X1
                        float S1X5 = 0 - (ValoresRestriccion5[2]*S1X3);
                        float S2X5 = 0 - (ValoresRestriccion5[2]*S2X3);
                        float S3X5 = 0 - (ValoresRestriccion5[2]*S3X3);
                        float S4X5 = 0 - (ValoresRestriccion5[2]*S4X3);
                        float S5X5 = 1 - (ValoresRestriccion5[2]*S5X3);
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
                    //Restriccion 4
                     ValorSujetoARestriccion4 = ValorSujetoARestriccion4 - (ValoresRestriccion4[2]*ValorSujetoARestriccion3);

                     for(int i=0; i<ValoresRestriccion4.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion4[i] = ValoresRestriccion4[i]-(ValoresRestriccion4[2]*ValoresRestriccion3[i]);
                        }
                         //Valores S1,S2,S3,S4,S5 Para Columna X4
                        float S1X4 = 0 - (ValoresRestriccion4[2]*S1X3);
                        float S2X4 = 0 - (ValoresRestriccion4[2]*S2X3);
                        float S3X4 = 0 - (ValoresRestriccion4[2]*S3X3);
                        float S4X4 = 1 - (ValoresRestriccion4[2]*S4X3);
                        float S5X4 = 0 - (ValoresRestriccion4[2]*S5X3);
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

                   else if((ValorSujetoARestriccion4/ValoresRestriccion4[2])<(ValorSujetoARestriccion1/ValoresRestriccion1[2])&&(ValorSujetoARestriccion4/ValoresRestriccion4[2])<(ValorSujetoARestriccion2/ValoresRestriccion2[2])&&(ValorSujetoARestriccion4/ValoresRestriccion4[2])<(ValorSujetoARestriccion3/ValoresRestriccion3[2])&&(ValorSujetoARestriccion4/ValoresRestriccion4[2])<(ValorSujetoARestriccion5/ValoresRestriccion5[2]))
                 {
                      System.Console.WriteLine("Segunda Tabla Simplex\n\n"); 
                    //Nuevos Valores Tabla Simplex 2
                    //Restriccion 4
                     ValorSujetoARestriccion4 = ValorSujetoARestriccion4/ValoresRestriccion4[2];
                    for(int i=0; i<ValoresRestriccion4.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion4[i] = ValoresRestriccion4[i]/ValoresRestriccion4[2];
                        }
                        //Valores S1,S2,S3,S4,S5 Para Columna X4
                        float S1X4 = 0/ValoresRestriccion4[2];
                        float S2X4 = 0/ValoresRestriccion4[2];
                        float S3X4 = 0/ValoresRestriccion4[2];
                        float S4X4 = 1/ValoresRestriccion4[2];
                        float S5X4 = 0/ValoresRestriccion4[2];
                    //Restriccion 5
                        ValorSujetoARestriccion5 = ValorSujetoARestriccion5 - (ValoresRestriccion5[2]*ValorSujetoARestriccion4);

                     for(int i=0; i<ValoresRestriccion5.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion5[i] = ValoresRestriccion5[i]-(ValoresRestriccion5[2]*ValoresRestriccion4[i]);
                        }
                          //Valores S1,S2,S3,S4,S5 Para Columna X1
                        float S1X5 = 0 - (ValoresRestriccion5[2]*S1X4);
                        float S2X5 = 0 - (ValoresRestriccion5[2]*S2X4);
                        float S3X5 = 0 - (ValoresRestriccion5[2]*S3X4);
                        float S4X5 = 0 - (ValoresRestriccion5[2]*S4X4);
                        float S5X5 = 1 - (ValoresRestriccion5[2]*S5X4);
                    //Restriccion 3
                         ValorSujetoARestriccion3 = ValorSujetoARestriccion3 - (ValoresRestriccion3[2]*ValorSujetoARestriccion4);

                     for(int i=0; i<ValoresRestriccion3.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion3[i] = ValoresRestriccion3[i]-(ValoresRestriccion3[2]*ValoresRestriccion4[i]);
                        }
                         //Valores S1,S2,S3,S4,S5 Para Columna X3
                        float S1X3 = 0 - (ValoresRestriccion3[2]*S1X4);
                        float S2X3 = 0 - (ValoresRestriccion3[2]*S2X4);
                        float S3X3 = 1 - (ValoresRestriccion3[2]*S3X4);
                        float S4X3 = 0 - (ValoresRestriccion3[2]*S4X4);
                        float S5X3 = 0 - (ValoresRestriccion3[2]*S5X4);
                    //Restriccion 4
                     ValorSujetoARestriccion1 = ValorSujetoARestriccion1 - (ValoresRestriccion1[2]*ValorSujetoARestriccion4);

                     for(int i=0; i<ValoresRestriccion1.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion1[i] = ValoresRestriccion1[i]-(ValoresRestriccion1[2]*ValoresRestriccion4[i]);
                        }
                         //Valores S1,S2,S3,S4,S5 Para Columna X4
                        float S1X1 = 1 - (ValoresRestriccion1[2]*S1X4);
                        float S2X1 = 0 - (ValoresRestriccion1[2]*S2X4);
                        float S3X1 = 0 - (ValoresRestriccion1[2]*S3X4);
                        float S4X1 = 0 - (ValoresRestriccion1[2]*S4X4);
                        float S5X1 = 0 - (ValoresRestriccion1[2]*S5X4);
                    //Restriccion 2
                     ValorSujetoARestriccion2 = ValorSujetoARestriccion2 - (ValoresRestriccion2[2]*ValorSujetoARestriccion4);

                     for(int i=0; i<ValoresRestriccion2.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion2[i] = ValoresRestriccion2[i]-(ValoresRestriccion2[2]*ValoresRestriccion4[i]);
                        }
                    //Valores S1,S2,S3,S4,S5 Para Columna X2
                        float S1X2 = 0 - (ValoresRestriccion2[2]*S1X4);
                        float S2X2 = 1 - (ValoresRestriccion2[2]*S2X4);
                        float S3X2 = 0 - (ValoresRestriccion2[2]*S3X4);
                        float S4X2 = 0 - (ValoresRestriccion2[2]*S4X4);
                        float S5X2 = 0 - (ValoresRestriccion2[2]*S5X4);
                        //Valor de Z
                         for(int i=0; i<ValoresDeZSimplex.Length; i++)                                   
                        {                                                                 
                            ValoresDeZSimplex[i] = ValoresDeZSimplex[i]-(ValoresDeZSimplex[2]*ValoresRestriccion4[i]);
                        }
                        //Valores Z y CR Para Columna Z
                        float Z = 1 - (ValoresDeZSimplex[2] * 0);
                        float CR = 0 - (ValoresDeZSimplex[2] * ValorSujetoARestriccion4);
                        //Tabla
                     System.Console.WriteLine($"Variables Basicas            Z            X1            X2            X3            X4            X5            S1            S2            S3            S4            S5            CR");
            System.Console.WriteLine($"         X1                  0            {ValoresRestriccion1[0]}           {ValoresRestriccion1[1]}           {ValoresRestriccion1[2]}           {ValoresRestriccion1[3]}           {ValoresRestriccion1[4]}           {S1X1}           {S2X1}           {S3X1}           {S4X1}           {S5X1}           {ValorSujetoARestriccion1}");
            System.Console.WriteLine($"         S2                  0            {ValoresRestriccion2[0]}           {ValoresRestriccion2[1]}           {ValoresRestriccion2[2]}           {ValoresRestriccion2[3]}           {ValoresRestriccion2[4]}           {S1X2}           {S2X2}           {S3X2}           {S4X2}           {S5X2}           {ValorSujetoARestriccion2}");
            System.Console.WriteLine($"         S3                  0            {ValoresRestriccion3[0]}           {ValoresRestriccion3[1]}           {ValoresRestriccion3[2]}           {ValoresRestriccion3[3]}           {ValoresRestriccion3[4]}           {S1X3}           {S2X3}           {S3X3}           {S4X3}           {S5X3}           {ValorSujetoARestriccion3}");
            System.Console.WriteLine($"         S4                  0            {ValoresRestriccion4[0]}           {ValoresRestriccion4[1]}           {ValoresRestriccion4[2]}           {ValoresRestriccion4[3]}           {ValoresRestriccion4[4]}           {S1X4}           {S2X4}           {S3X4}           {S4X4}           {S5X4}           {ValorSujetoARestriccion4}");
            System.Console.WriteLine($"         S5                  0            {ValoresRestriccion5[0]}           {ValoresRestriccion5[1]}           {ValoresRestriccion5[2]}           {ValoresRestriccion5[3]}           {ValoresRestriccion5[4]}           {S1X5}           {S2X5}           {S3X5}           {S4X5}           {S5X5}           {ValorSujetoARestriccion5}");
            System.Console.WriteLine($"          Z                  {Z}            {ValoresDeZSimplex[0]}           {ValoresDeZSimplex[1]}           {ValoresDeZSimplex[2]}           {ValoresDeZSimplex[3]}           {ValoresDeZSimplex[4]}           0           0           0           0           0           {CR}");

            //Tercera Tabla Simplex
                 } //Si es el caso de que la columna S4 sea el mas negativo

                   else if((ValorSujetoARestriccion5/ValoresRestriccion5[2])<(ValorSujetoARestriccion1/ValoresRestriccion1[2])&&(ValorSujetoARestriccion5/ValoresRestriccion5[2])<(ValorSujetoARestriccion2/ValoresRestriccion2[2])&&(ValorSujetoARestriccion5/ValoresRestriccion5[2])<(ValorSujetoARestriccion4/ValoresRestriccion4[2])&&(ValorSujetoARestriccion5/ValoresRestriccion5[2])<(ValorSujetoARestriccion3/ValoresRestriccion3[2]))
                 {
                     System.Console.WriteLine("Segunda Tabla Simplex\n\n"); 
                    //Nuevos Valores Tabla Simplex 2
                    //Restriccion 5
                     ValorSujetoARestriccion5 = ValorSujetoARestriccion5/ValoresRestriccion5[2];
                    for(int i=0; i<ValoresRestriccion5.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion5[i] = ValoresRestriccion5[i]/ValoresRestriccion5[2];
                        }
                        //Valores S1,S2,S3,S4,S5 Para Columna X4
                        float S1X5 = 0/ValoresRestriccion5[2];
                        float S2X5 = 0/ValoresRestriccion5[2];
                        float S3X5 = 0/ValoresRestriccion5[2];
                        float S4X5 = 0/ValoresRestriccion5[2];
                        float S5X5 = 1/ValoresRestriccion5[2];
                    //Restriccion 4
                        ValorSujetoARestriccion4 = ValorSujetoARestriccion4 - (ValoresRestriccion4[2]*ValorSujetoARestriccion5);

                     for(int i=0; i<ValoresRestriccion4.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion4[i] = ValoresRestriccion4[i]-(ValoresRestriccion4[2]*ValoresRestriccion5[i]);
                        }
                          //Valores S1,S2,S3,S4,S5 Para Columna X1
                        float S1X4 = 0 - (ValoresRestriccion4[2]*S1X5);
                        float S2X4 = 0 - (ValoresRestriccion4[2]*S2X5);
                        float S3X4 = 0 - (ValoresRestriccion4[2]*S3X5);
                        float S4X4 = 1 - (ValoresRestriccion4[2]*S4X5);
                        float S5X4 = 0 - (ValoresRestriccion4[2]*S5X5);
                    //Restriccion 3
                         ValorSujetoARestriccion3 = ValorSujetoARestriccion3 - (ValoresRestriccion3[2]*ValorSujetoARestriccion5);

                     for(int i=0; i<ValoresRestriccion3.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion3[i] = ValoresRestriccion3[i]-(ValoresRestriccion3[2]*ValoresRestriccion5[i]);
                        }
                         //Valores S1,S2,S3,S4,S5 Para Columna X3
                        float S1X3 = 0 - (ValoresRestriccion3[2]*S1X5);
                        float S2X3 = 0 - (ValoresRestriccion3[2]*S2X5);
                        float S3X3 = 1 - (ValoresRestriccion3[2]*S3X5);
                        float S4X3 = 0 - (ValoresRestriccion3[2]*S4X5);
                        float S5X3 = 0 - (ValoresRestriccion3[2]*S5X5);
                    //Restriccion 4
                     ValorSujetoARestriccion1 = ValorSujetoARestriccion1 - (ValoresRestriccion1[2]*ValorSujetoARestriccion5);

                     for(int i=0; i<ValoresRestriccion1.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion1[i] = ValoresRestriccion1[i]-(ValoresRestriccion1[2]*ValoresRestriccion5[i]);
                        }
                         //Valores S1,S2,S3,S4,S5 Para Columna X4
                        float S1X1 = 1 - (ValoresRestriccion1[2]*S1X5);
                        float S2X1 = 0 - (ValoresRestriccion1[2]*S2X5);
                        float S3X1 = 0 - (ValoresRestriccion1[2]*S3X5);
                        float S4X1 = 0 - (ValoresRestriccion1[2]*S4X5);
                        float S5X1 = 0 - (ValoresRestriccion1[2]*S5X5);
                    //Restriccion 2
                     ValorSujetoARestriccion2 = ValorSujetoARestriccion2 - (ValoresRestriccion2[2]*ValorSujetoARestriccion5);

                     for(int i=0; i<ValoresRestriccion2.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion2[i] = ValoresRestriccion2[i]-(ValoresRestriccion2[2]*ValoresRestriccion5[i]);
                        }
                    //Valores S1,S2,S3,S4,S5 Para Columna X2
                        float S1X2 = 0 - (ValoresRestriccion2[2]*S1X5);
                        float S2X2 = 1 - (ValoresRestriccion2[2]*S2X5);
                        float S3X2 = 0 - (ValoresRestriccion2[2]*S3X5);
                        float S4X2 = 0 - (ValoresRestriccion2[2]*S4X5);
                        float S5X2 = 0 - (ValoresRestriccion2[2]*S5X5);
                        //Valor de Z
                         for(int i=0; i<ValoresDeZSimplex.Length; i++)                                   
                        {                                                                 
                            ValoresDeZSimplex[i] = ValoresDeZSimplex[i]-(ValoresDeZSimplex[2]*ValoresRestriccion5[i]);
                        }
                        //Valores Z y CR Para Columna Z
                        float Z = 1 - (ValoresDeZSimplex[2] * 0);
                        float CR = 0 - (ValoresDeZSimplex[2] * ValorSujetoARestriccion5);
                        //Tabla
                     System.Console.WriteLine($"Variables Basicas            Z            X1            X2            X3            X4            X5            S1            S2            S3            S4            S5            CR");
            System.Console.WriteLine($"         X1                  0            {ValoresRestriccion1[0]}           {ValoresRestriccion1[1]}           {ValoresRestriccion1[2]}           {ValoresRestriccion1[3]}           {ValoresRestriccion1[4]}           {S1X1}           {S2X1}           {S3X1}           {S4X1}           {S5X1}           {ValorSujetoARestriccion1}");
            System.Console.WriteLine($"         S2                  0            {ValoresRestriccion2[0]}           {ValoresRestriccion2[1]}           {ValoresRestriccion2[2]}           {ValoresRestriccion2[3]}           {ValoresRestriccion2[4]}           {S1X2}           {S2X2}           {S3X2}           {S4X2}           {S5X2}           {ValorSujetoARestriccion2}");
            System.Console.WriteLine($"         S3                  0            {ValoresRestriccion3[0]}           {ValoresRestriccion3[1]}           {ValoresRestriccion3[2]}           {ValoresRestriccion3[3]}           {ValoresRestriccion3[4]}           {S1X3}           {S2X3}           {S3X3}           {S4X3}           {S5X3}           {ValorSujetoARestriccion3}");
            System.Console.WriteLine($"         S4                  0            {ValoresRestriccion4[0]}           {ValoresRestriccion4[1]}           {ValoresRestriccion4[2]}           {ValoresRestriccion4[3]}           {ValoresRestriccion4[4]}           {S1X4}           {S2X4}           {S3X4}           {S4X4}           {S5X4}           {ValorSujetoARestriccion4}");
            System.Console.WriteLine($"         S5                  0            {ValoresRestriccion5[0]}           {ValoresRestriccion5[1]}           {ValoresRestriccion5[2]}           {ValoresRestriccion5[3]}           {ValoresRestriccion5[4]}           {S1X5}           {S2X5}           {S3X5}           {S4X5}           {S5X5}           {ValorSujetoARestriccion5}");
            System.Console.WriteLine($"          Z                  {Z}            {ValoresDeZSimplex[0]}           {ValoresDeZSimplex[1]}           {ValoresDeZSimplex[2]}           {ValoresDeZSimplex[3]}           {ValoresDeZSimplex[4]}           0           0           0           0           0           {CR}");

            //Tercera Tabla Simplex
                 } //Si es el caso de que la columna S5 sea el mas negativo
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
                    //Restriccion 5
                        ValorSujetoARestriccion5 = ValorSujetoARestriccion5 - (ValoresRestriccion5[3]*ValorSujetoARestriccion1);

                     for(int i=0; i<ValoresRestriccion5.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion5[i] = ValoresRestriccion5[i]-(ValoresRestriccion5[3]*ValoresRestriccion1[i]);
                        }
                          //Valores S1,S2,S3,S4,S5 Para Columna X1
                        float S1X5 = 0 - (ValoresRestriccion5[3]*S1X1);
                        float S2X5 = 0 - (ValoresRestriccion5[3]*S2X1);
                        float S3X5 = 0 - (ValoresRestriccion5[3]*S3X1);
                        float S4X5 = 0 - (ValoresRestriccion5[3]*S4X1);
                        float S5X5 = 1 - (ValoresRestriccion5[3]*S5X1);
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
                    //Restriccion 4
                     ValorSujetoARestriccion4 = ValorSujetoARestriccion4 - (ValoresRestriccion4[3]*ValorSujetoARestriccion1);

                     for(int i=0; i<ValoresRestriccion1.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion4[i] = ValoresRestriccion4[i]-(ValoresRestriccion4[3]*ValoresRestriccion1[i]);
                        }
                         //Valores S1,S2,S3,S4,S5 Para Columna X4
                        float S1X4 = 0 - (ValoresRestriccion4[3]*S1X1);
                        float S2X4 = 0 - (ValoresRestriccion4[3]*S2X1);
                        float S3X4 = 0 - (ValoresRestriccion4[3]*S3X1);
                        float S4X4 = 1 - (ValoresRestriccion4[3]*S4X1);
                        float S5X4 = 0 - (ValoresRestriccion4[3]*S5X1);
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
                    //Restriccion 5
                        ValorSujetoARestriccion5 = ValorSujetoARestriccion5 - (ValoresRestriccion5[3]*ValorSujetoARestriccion2);

                     for(int i=0; i<ValoresRestriccion5.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion5[i] = ValoresRestriccion5[i]-(ValoresRestriccion5[3]*ValoresRestriccion2[i]);
                        }
                          //Valores S1,S2,S3,S4,S5 Para Columna X1
                        float S1X5 = 0 - (ValoresRestriccion5[3]*S1X2);
                        float S2X5 = 0 - (ValoresRestriccion5[3]*S2X2);
                        float S3X5 = 0 - (ValoresRestriccion5[3]*S3X2);
                        float S4X5 = 0 - (ValoresRestriccion5[3]*S4X2);
                        float S5X5 = 1 - (ValoresRestriccion5[3]*S5X2);
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
                    //Restriccion 4
                     ValorSujetoARestriccion4 = ValorSujetoARestriccion4 - (ValoresRestriccion4[3]*ValorSujetoARestriccion2);

                     for(int i=0; i<ValoresRestriccion1.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion4[i] = ValoresRestriccion4[i]-(ValoresRestriccion4[3]*ValoresRestriccion2[i]);
                        }
                         //Valores S1,S2,S3,S4,S5 Para Columna X4
                        float S1X4 = 0 - (ValoresRestriccion4[3]*S1X2);
                        float S2X4 = 0 - (ValoresRestriccion4[3]*S2X2);
                        float S3X4 = 0 - (ValoresRestriccion4[3]*S3X2);
                        float S4X4 = 1 - (ValoresRestriccion4[3]*S4X2);
                        float S5X4 = 0 - (ValoresRestriccion4[3]*S5X2);
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
                    //Restriccion 5
                        ValorSujetoARestriccion5 = ValorSujetoARestriccion5 - (ValoresRestriccion5[3]*ValorSujetoARestriccion3);

                     for(int i=0; i<ValoresRestriccion5.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion5[i] = ValoresRestriccion5[i]-(ValoresRestriccion5[3]*ValoresRestriccion3[i]);
                        }
                          //Valores S1,S2,S3,S4,S5 Para Columna X1
                        float S1X5 = 0 - (ValoresRestriccion5[3]*S1X3);
                        float S2X5 = 0 - (ValoresRestriccion5[3]*S2X3);
                        float S3X5 = 0 - (ValoresRestriccion5[3]*S3X3);
                        float S4X5 = 0 - (ValoresRestriccion5[3]*S4X3);
                        float S5X5 = 1 - (ValoresRestriccion5[3]*S5X3);
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
                    //Restriccion 4
                     ValorSujetoARestriccion4 = ValorSujetoARestriccion4 - (ValoresRestriccion4[3]*ValorSujetoARestriccion3);

                     for(int i=0; i<ValoresRestriccion4.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion4[i] = ValoresRestriccion4[i]-(ValoresRestriccion4[3]*ValoresRestriccion3[i]);
                        }
                         //Valores S1,S2,S3,S4,S5 Para Columna X4
                        float S1X4 = 0 - (ValoresRestriccion4[3]*S1X3);
                        float S2X4 = 0 - (ValoresRestriccion4[3]*S2X3);
                        float S3X4 = 0 - (ValoresRestriccion4[3]*S3X3);
                        float S4X4 = 1 - (ValoresRestriccion4[3]*S4X3);
                        float S5X4 = 0 - (ValoresRestriccion4[3]*S5X3);
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

                   else if((ValorSujetoARestriccion4/ValoresRestriccion4[3])<(ValorSujetoARestriccion1/ValoresRestriccion1[3])&&(ValorSujetoARestriccion4/ValoresRestriccion4[3])<(ValorSujetoARestriccion2/ValoresRestriccion2[3])&&(ValorSujetoARestriccion4/ValoresRestriccion4[3])<(ValorSujetoARestriccion3/ValoresRestriccion3[3])&&(ValorSujetoARestriccion4/ValoresRestriccion4[3])<(ValorSujetoARestriccion5/ValoresRestriccion5[3]))
                 {
                     System.Console.WriteLine("Segunda Tabla Simplex\n\n"); 
                    //Nuevos Valores Tabla Simplex 2
                    //Restriccion 4
                     ValorSujetoARestriccion4 = ValorSujetoARestriccion4/ValoresRestriccion4[3];
                    for(int i=0; i<ValoresRestriccion4.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion4[i] = ValoresRestriccion4[i]/ValoresRestriccion4[3];
                        }
                        //Valores S1,S2,S3,S4,S5 Para Columna X4
                        float S1X4 = 0/ValoresRestriccion4[3];
                        float S2X4 = 0/ValoresRestriccion4[3];
                        float S3X4 = 0/ValoresRestriccion4[3];
                        float S4X4 = 1/ValoresRestriccion4[3];
                        float S5X4 = 0/ValoresRestriccion4[3];
                    //Restriccion 5
                        ValorSujetoARestriccion5 = ValorSujetoARestriccion5 - (ValoresRestriccion5[3]*ValorSujetoARestriccion4);

                     for(int i=0; i<ValoresRestriccion5.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion5[i] = ValoresRestriccion5[i]-(ValoresRestriccion5[3]*ValoresRestriccion4[i]);
                        }
                          //Valores S1,S2,S3,S4,S5 Para Columna X1
                        float S1X5 = 0 - (ValoresRestriccion5[3]*S1X4);
                        float S2X5 = 0 - (ValoresRestriccion5[3]*S2X4);
                        float S3X5 = 0 - (ValoresRestriccion5[3]*S3X4);
                        float S4X5 = 0 - (ValoresRestriccion5[3]*S4X4);
                        float S5X5 = 1 - (ValoresRestriccion5[3]*S5X4);
                    //Restriccion 3
                         ValorSujetoARestriccion3 = ValorSujetoARestriccion3 - (ValoresRestriccion3[3]*ValorSujetoARestriccion4);

                     for(int i=0; i<ValoresRestriccion3.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion3[i] = ValoresRestriccion3[i]-(ValoresRestriccion3[3]*ValoresRestriccion4[i]);
                        }
                         //Valores S1,S2,S3,S4,S5 Para Columna X3
                        float S1X3 = 0 - (ValoresRestriccion3[3]*S1X4);
                        float S2X3 = 0 - (ValoresRestriccion3[3]*S2X4);
                        float S3X3 = 1 - (ValoresRestriccion3[3]*S3X4);
                        float S4X3 = 0 - (ValoresRestriccion3[3]*S4X4);
                        float S5X3 = 0 - (ValoresRestriccion3[3]*S5X4);
                    //Restriccion 4
                     ValorSujetoARestriccion1 = ValorSujetoARestriccion1 - (ValoresRestriccion1[3]*ValorSujetoARestriccion4);

                     for(int i=0; i<ValoresRestriccion1.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion1[i] = ValoresRestriccion1[i]-(ValoresRestriccion1[3]*ValoresRestriccion4[i]);
                        }
                         //Valores S1,S2,S3,S4,S5 Para Columna X4
                        float S1X1 = 1 - (ValoresRestriccion1[3]*S1X4);
                        float S2X1 = 0 - (ValoresRestriccion1[3]*S2X4);
                        float S3X1 = 0 - (ValoresRestriccion1[3]*S3X4);
                        float S4X1 = 0 - (ValoresRestriccion1[3]*S4X4);
                        float S5X1 = 0 - (ValoresRestriccion1[3]*S5X4);
                    //Restriccion 2
                     ValorSujetoARestriccion2 = ValorSujetoARestriccion2 - (ValoresRestriccion2[3]*ValorSujetoARestriccion4);

                     for(int i=0; i<ValoresRestriccion2.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion2[i] = ValoresRestriccion2[i]-(ValoresRestriccion2[3]*ValoresRestriccion4[i]);
                        }
                    //Valores S1,S2,S3,S4,S5 Para Columna X2
                        float S1X2 = 0 - (ValoresRestriccion2[3]*S1X4);
                        float S2X2 = 1 - (ValoresRestriccion2[3]*S2X4);
                        float S3X2 = 0 - (ValoresRestriccion2[3]*S3X4);
                        float S4X2 = 0 - (ValoresRestriccion2[3]*S4X4);
                        float S5X2 = 0 - (ValoresRestriccion2[3]*S5X4);
                        //Valor de Z
                         for(int i=0; i<ValoresDeZSimplex.Length; i++)                                   
                        {                                                                 
                            ValoresDeZSimplex[i] = ValoresDeZSimplex[i]-(ValoresDeZSimplex[3]*ValoresRestriccion4[i]);
                        }
                        //Valores Z y CR Para Columna Z
                        float Z = 1 - (ValoresDeZSimplex[3] * 0);
                        float CR = 0 - (ValoresDeZSimplex[3] * ValorSujetoARestriccion4);
                        //Tabla
                     System.Console.WriteLine($"Variables Basicas            Z            X1            X2            X3            X4            X5            S1            S2            S3            S4            S5            CR");
            System.Console.WriteLine($"         X1                  0            {ValoresRestriccion1[0]}           {ValoresRestriccion1[1]}           {ValoresRestriccion1[2]}           {ValoresRestriccion1[3]}           {ValoresRestriccion1[4]}           {S1X1}           {S2X1}           {S3X1}           {S4X1}           {S5X1}           {ValorSujetoARestriccion1}");
            System.Console.WriteLine($"         S2                  0            {ValoresRestriccion2[0]}           {ValoresRestriccion2[1]}           {ValoresRestriccion2[2]}           {ValoresRestriccion2[3]}           {ValoresRestriccion2[4]}           {S1X2}           {S2X2}           {S3X2}           {S4X2}           {S5X2}           {ValorSujetoARestriccion2}");
            System.Console.WriteLine($"         S3                  0            {ValoresRestriccion3[0]}           {ValoresRestriccion3[1]}           {ValoresRestriccion3[2]}           {ValoresRestriccion3[3]}           {ValoresRestriccion3[4]}           {S1X3}           {S2X3}           {S3X3}           {S4X3}           {S5X3}           {ValorSujetoARestriccion3}");
            System.Console.WriteLine($"         S4                  0            {ValoresRestriccion4[0]}           {ValoresRestriccion4[1]}           {ValoresRestriccion4[2]}           {ValoresRestriccion4[3]}           {ValoresRestriccion4[4]}           {S1X4}           {S2X4}           {S3X4}           {S4X4}           {S5X4}           {ValorSujetoARestriccion4}");
            System.Console.WriteLine($"         S5                  0            {ValoresRestriccion5[0]}           {ValoresRestriccion5[1]}           {ValoresRestriccion5[2]}           {ValoresRestriccion5[3]}           {ValoresRestriccion5[4]}           {S1X5}           {S2X5}           {S3X5}           {S4X5}           {S5X5}           {ValorSujetoARestriccion5}");
            System.Console.WriteLine($"          Z                  {Z}            {ValoresDeZSimplex[0]}           {ValoresDeZSimplex[1]}           {ValoresDeZSimplex[2]}           {ValoresDeZSimplex[3]}           {ValoresDeZSimplex[4]}           0           0           0           0           0           {CR}");

            //Tercera Tabla Simplex
                 } //Si es el caso de que la columna S4 sea el mas negativo

                   else if((ValorSujetoARestriccion5/ValoresRestriccion5[3])<(ValorSujetoARestriccion1/ValoresRestriccion1[3])&&(ValorSujetoARestriccion5/ValoresRestriccion5[3])<(ValorSujetoARestriccion2/ValoresRestriccion2[3])&&(ValorSujetoARestriccion5/ValoresRestriccion5[3])<(ValorSujetoARestriccion4/ValoresRestriccion4[3])&&(ValorSujetoARestriccion5/ValoresRestriccion5[3])<(ValorSujetoARestriccion3/ValoresRestriccion3[3]))
                 {
                     System.Console.WriteLine("Segunda Tabla Simplex\n\n"); 
                    //Nuevos Valores Tabla Simplex 2
                    //Restriccion 5
                     ValorSujetoARestriccion5 = ValorSujetoARestriccion5/ValoresRestriccion5[3];
                    for(int i=0; i<ValoresRestriccion5.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion5[i] = ValoresRestriccion5[i]/ValoresRestriccion5[3];
                        }
                        //Valores S1,S2,S3,S4,S5 Para Columna X4
                        float S1X5 = 0/ValoresRestriccion5[3];
                        float S2X5 = 0/ValoresRestriccion5[3];
                        float S3X5 = 0/ValoresRestriccion5[3];
                        float S4X5 = 0/ValoresRestriccion5[3];
                        float S5X5 = 1/ValoresRestriccion5[3];
                    //Restriccion 5
                        ValorSujetoARestriccion1 = ValorSujetoARestriccion1 - (ValoresRestriccion1[3]*ValorSujetoARestriccion5);

                     for(int i=0; i<ValoresRestriccion1.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion1[i] = ValoresRestriccion1[i]-(ValoresRestriccion1[3]*ValoresRestriccion5[i]);
                        }
                          //Valores S1,S2,S3,S4,S5 Para Columna X1
                        float S1X1 = 1 - (ValoresRestriccion1[3]*S1X5);
                        float S2X1 = 0 - (ValoresRestriccion1[3]*S2X5);
                        float S3X1 = 0 - (ValoresRestriccion1[3]*S3X5);
                        float S4X1 = 0 - (ValoresRestriccion1[3]*S4X5);
                        float S5X1 = 0 - (ValoresRestriccion1[3]*S5X5);
                    //Restriccion 3
                         ValorSujetoARestriccion3 = ValorSujetoARestriccion3 - (ValoresRestriccion3[3]*ValorSujetoARestriccion5);

                     for(int i=0; i<ValoresRestriccion3.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion3[i] = ValoresRestriccion3[i]-(ValoresRestriccion3[3]*ValoresRestriccion5[i]);
                        }
                         //Valores S1,S2,S3,S4,S5 Para Columna X3
                        float S1X3 = 0 - (ValoresRestriccion3[3]*S1X5);
                        float S2X3 = 0 - (ValoresRestriccion3[3]*S2X5);
                        float S3X3 = 1 - (ValoresRestriccion3[3]*S3X5);
                        float S4X3 = 0 - (ValoresRestriccion3[3]*S4X5);
                        float S5X3 = 0 - (ValoresRestriccion3[3]*S5X5);
                    //Restriccion 4
                     ValorSujetoARestriccion4 = ValorSujetoARestriccion4 - (ValoresRestriccion4[3]*ValorSujetoARestriccion5);

                     for(int i=0; i<ValoresRestriccion1.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion4[i] = ValoresRestriccion4[i]-(ValoresRestriccion4[3]*ValoresRestriccion5[i]);
                        }
                         //Valores S1,S2,S3,S4,S5 Para Columna X4
                        float S1X4 = 0 - (ValoresRestriccion4[3]*S1X5);
                        float S2X4 = 0 - (ValoresRestriccion4[3]*S2X5);
                        float S3X4 = 0 - (ValoresRestriccion4[3]*S3X5);
                        float S4X4 = 1 - (ValoresRestriccion4[3]*S4X5);
                        float S5X4 = 0 - (ValoresRestriccion4[3]*S5X5);
                    //Restriccion 2
                     ValorSujetoARestriccion2 = ValorSujetoARestriccion2 - (ValoresRestriccion2[3]*ValorSujetoARestriccion5);

                     for(int i=0; i<ValoresRestriccion2.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion2[i] = ValoresRestriccion2[i]-(ValoresRestriccion2[3]*ValoresRestriccion5[i]);
                        }
                    //Valores S1,S2,S3,S4,S5 Para Columna X2
                        float S1X2 = 0 - (ValoresRestriccion2[3]*S1X5);
                        float S2X2 = 1 - (ValoresRestriccion2[3]*S2X5);
                        float S3X2 = 0 - (ValoresRestriccion2[3]*S3X5);
                        float S4X2 = 0 - (ValoresRestriccion2[3]*S4X5);
                        float S5X2 = 0 - (ValoresRestriccion2[3]*S5X5);
                        //Valor de Z
                         for(int i=0; i<ValoresDeZSimplex.Length; i++)                                   
                        {                                                                 
                            ValoresDeZSimplex[i] = ValoresDeZSimplex[i]-(ValoresDeZSimplex[3]*ValoresRestriccion5[i]);
                        }
                        //Valores Z y CR Para Columna Z
                        float Z = 1 - (ValoresDeZSimplex[3] * 0);
                        float CR = 0 - (ValoresDeZSimplex[3] * ValorSujetoARestriccion5);
                        //Tabla
                     System.Console.WriteLine($"Variables Basicas            Z            X1            X2            X3            X4            X5            S1            S2            S3            S4            S5            CR");
            System.Console.WriteLine($"         X1                  0            {ValoresRestriccion1[0]}           {ValoresRestriccion1[1]}           {ValoresRestriccion1[2]}           {ValoresRestriccion1[3]}           {ValoresRestriccion1[4]}           {S1X1}           {S2X1}           {S3X1}           {S4X1}           {S5X1}           {ValorSujetoARestriccion1}");
            System.Console.WriteLine($"         S2                  0            {ValoresRestriccion2[0]}           {ValoresRestriccion2[1]}           {ValoresRestriccion2[2]}           {ValoresRestriccion2[3]}           {ValoresRestriccion2[4]}           {S1X2}           {S2X2}           {S3X2}           {S4X2}           {S5X2}           {ValorSujetoARestriccion2}");
            System.Console.WriteLine($"         S3                  0            {ValoresRestriccion3[0]}           {ValoresRestriccion3[1]}           {ValoresRestriccion3[2]}           {ValoresRestriccion3[3]}           {ValoresRestriccion3[4]}           {S1X3}           {S2X3}           {S3X3}           {S4X3}           {S5X3}           {ValorSujetoARestriccion3}");
            System.Console.WriteLine($"         S4                  0            {ValoresRestriccion4[0]}           {ValoresRestriccion4[1]}           {ValoresRestriccion4[2]}           {ValoresRestriccion4[3]}           {ValoresRestriccion4[4]}           {S1X4}           {S2X4}           {S3X4}           {S4X4}           {S5X4}           {ValorSujetoARestriccion4}");
            System.Console.WriteLine($"         S5                  0            {ValoresRestriccion5[0]}           {ValoresRestriccion5[1]}           {ValoresRestriccion5[2]}           {ValoresRestriccion5[3]}           {ValoresRestriccion5[4]}           {S1X5}           {S2X5}           {S3X5}           {S4X5}           {S5X5}           {ValorSujetoARestriccion5}");
            System.Console.WriteLine($"          Z                  {Z}            {ValoresDeZSimplex[0]}           {ValoresDeZSimplex[1]}           {ValoresDeZSimplex[2]}           {ValoresDeZSimplex[3]}           {ValoresDeZSimplex[4]}           0           0           0           0           0           {CR}");

            //Tercera Tabla Simplex
                 } //Si es el caso de que la columna S5 sea el mas negativo

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
                    //Restriccion 5
                        ValorSujetoARestriccion5 = ValorSujetoARestriccion5 - (ValoresRestriccion5[4]*ValorSujetoARestriccion1);

                     for(int i=0; i<ValoresRestriccion5.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion5[i] = ValoresRestriccion5[i]-(ValoresRestriccion5[4]*ValoresRestriccion1[i]);
                        }
                          //Valores S1,S2,S3,S4,S5 Para Columna X1
                        float S1X5 = 0 - (ValoresRestriccion5[4]*S1X1);
                        float S2X5 = 0 - (ValoresRestriccion5[4]*S2X1);
                        float S3X5 = 0 - (ValoresRestriccion5[4]*S3X1);
                        float S4X5 = 0 - (ValoresRestriccion5[4]*S4X1);
                        float S5X5 = 1 - (ValoresRestriccion5[4]*S5X1);
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
                    //Restriccion 4
                     ValorSujetoARestriccion4 = ValorSujetoARestriccion4 - (ValoresRestriccion4[4]*ValorSujetoARestriccion1);

                     for(int i=0; i<ValoresRestriccion1.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion4[i] = ValoresRestriccion4[i]-(ValoresRestriccion4[4]*ValoresRestriccion1[i]);
                        }
                         //Valores S1,S2,S3,S4,S5 Para Columna X4
                        float S1X4 = 0 - (ValoresRestriccion4[4]*S1X1);
                        float S2X4 = 0 - (ValoresRestriccion4[4]*S2X1);
                        float S3X4 = 0 - (ValoresRestriccion4[4]*S3X1);
                        float S4X4 = 1 - (ValoresRestriccion4[4]*S4X1);
                        float S5X4 = 0 - (ValoresRestriccion4[4]*S5X1);
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
                    //Restriccion 5
                        ValorSujetoARestriccion5 = ValorSujetoARestriccion5 - (ValoresRestriccion5[4]*ValorSujetoARestriccion2);

                     for(int i=0; i<ValoresRestriccion5.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion5[i] = ValoresRestriccion5[i]-(ValoresRestriccion5[4]*ValoresRestriccion2[i]);
                        }
                          //Valores S1,S2,S3,S4,S5 Para Columna X1
                        float S1X5 = 0 - (ValoresRestriccion5[4]*S1X2);
                        float S2X5 = 0 - (ValoresRestriccion5[4]*S2X2);
                        float S3X5 = 0 - (ValoresRestriccion5[4]*S3X2);
                        float S4X5 = 0 - (ValoresRestriccion5[4]*S4X2);
                        float S5X5 = 1 - (ValoresRestriccion5[4]*S5X2);
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
                    //Restriccion 4
                     ValorSujetoARestriccion4 = ValorSujetoARestriccion4 - (ValoresRestriccion4[4]*ValorSujetoARestriccion2);

                     for(int i=0; i<ValoresRestriccion1.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion4[i] = ValoresRestriccion4[i]-(ValoresRestriccion4[4]*ValoresRestriccion2[i]);
                        }
                         //Valores S1,S2,S3,S4,S5 Para Columna X4
                        float S1X4 = 0 - (ValoresRestriccion4[4]*S1X2);
                        float S2X4 = 0 - (ValoresRestriccion4[4]*S2X2);
                        float S3X4 = 0 - (ValoresRestriccion4[4]*S3X2);
                        float S4X4 = 1 - (ValoresRestriccion4[4]*S4X2);
                        float S5X4 = 0 - (ValoresRestriccion4[4]*S5X2);
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
                    //Restriccion 5
                        ValorSujetoARestriccion5 = ValorSujetoARestriccion5 - (ValoresRestriccion5[4]*ValorSujetoARestriccion3);

                     for(int i=0; i<ValoresRestriccion5.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion5[i] = ValoresRestriccion5[i]-(ValoresRestriccion5[4]*ValoresRestriccion3[i]);
                        }
                          //Valores S1,S2,S3,S4,S5 Para Columna X1
                        float S1X5 = 0 - (ValoresRestriccion5[4]*S1X3);
                        float S2X5 = 0 - (ValoresRestriccion5[4]*S2X3);
                        float S3X5 = 0 - (ValoresRestriccion5[4]*S3X3);
                        float S4X5 = 0 - (ValoresRestriccion5[4]*S4X3);
                        float S5X5 = 1 - (ValoresRestriccion5[4]*S5X3);
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
                    //Restriccion 4
                     ValorSujetoARestriccion4 = ValorSujetoARestriccion4 - (ValoresRestriccion4[4]*ValorSujetoARestriccion3);

                     for(int i=0; i<ValoresRestriccion1.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion4[i] = ValoresRestriccion4[i]-(ValoresRestriccion4[4]*ValoresRestriccion3[i]);
                        }
                         //Valores S1,S2,S3,S4,S5 Para Columna X4
                        float S1X4 = 0 - (ValoresRestriccion4[4]*S1X3);
                        float S2X4 = 0 - (ValoresRestriccion4[4]*S2X3);
                        float S3X4 = 0 - (ValoresRestriccion4[4]*S3X3);
                        float S4X4 = 1 - (ValoresRestriccion4[4]*S4X3);
                        float S5X4 = 0 - (ValoresRestriccion4[4]*S5X3);
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

                   else if((ValorSujetoARestriccion4/ValoresRestriccion4[4])<(ValorSujetoARestriccion1/ValoresRestriccion1[4])&&(ValorSujetoARestriccion4/ValoresRestriccion4[4])<(ValorSujetoARestriccion2/ValoresRestriccion2[4])&&(ValorSujetoARestriccion4/ValoresRestriccion4[4])<(ValorSujetoARestriccion3/ValoresRestriccion3[4])&&(ValorSujetoARestriccion4/ValoresRestriccion4[4])<(ValorSujetoARestriccion5/ValoresRestriccion5[4]))
                 {
                     System.Console.WriteLine("Segunda Tabla Simplex\n\n"); 
                    //Nuevos Valores Tabla Simplex 2
                    //Restriccion 4
                     ValorSujetoARestriccion4 = ValorSujetoARestriccion4/ValoresRestriccion4[4];
                    for(int i=0; i<ValoresRestriccion4.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion4[i] = ValoresRestriccion4[i]/ValoresRestriccion4[4];
                        }
                        //Valores S1,S2,S3,S4,S5 Para Columna X4
                        float S1X4 = 0/ValoresRestriccion4[4];
                        float S2X4 = 0/ValoresRestriccion4[4];
                        float S3X4 = 0/ValoresRestriccion4[4];
                        float S4X4 = 1/ValoresRestriccion4[4];
                        float S5X4 = 0/ValoresRestriccion4[4];
                    //Restriccion 5
                        ValorSujetoARestriccion5 = ValorSujetoARestriccion5 - (ValoresRestriccion5[4]*ValorSujetoARestriccion4);

                     for(int i=0; i<ValoresRestriccion5.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion5[i] = ValoresRestriccion5[i]-(ValoresRestriccion5[4]*ValoresRestriccion4[i]);
                        }
                          //Valores S1,S2,S3,S4,S5 Para Columna X1
                        float S1X5 = 0 - (ValoresRestriccion5[4]*S1X4);
                        float S2X5 = 0 - (ValoresRestriccion5[4]*S2X4);
                        float S3X5 = 0 - (ValoresRestriccion5[4]*S3X4);
                        float S4X5 = 0 - (ValoresRestriccion5[4]*S4X4);
                        float S5X5 = 1 - (ValoresRestriccion5[4]*S5X4);
                    //Restriccion 3
                         ValorSujetoARestriccion3 = ValorSujetoARestriccion3 - (ValoresRestriccion3[4]*ValorSujetoARestriccion4);

                     for(int i=0; i<ValoresRestriccion3.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion3[i] = ValoresRestriccion3[i]-(ValoresRestriccion3[4]*ValoresRestriccion4[i]);
                        }
                         //Valores S1,S2,S3,S4,S5 Para Columna X3
                        float S1X3 = 0 - (ValoresRestriccion3[4]*S1X4);
                        float S2X3 = 0 - (ValoresRestriccion3[4]*S2X4);
                        float S3X3 = 1 - (ValoresRestriccion3[4]*S3X4);
                        float S4X3 = 0 - (ValoresRestriccion3[4]*S4X4);
                        float S5X3 = 0 - (ValoresRestriccion3[4]*S5X4);
                    //Restriccion 4
                     ValorSujetoARestriccion1 = ValorSujetoARestriccion1 - (ValoresRestriccion1[4]*ValorSujetoARestriccion4);

                     for(int i=0; i<ValoresRestriccion1.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion1[i] = ValoresRestriccion1[i]-(ValoresRestriccion1[4]*ValoresRestriccion4[i]);
                        }
                         //Valores S1,S2,S3,S4,S5 Para Columna X4
                        float S1X1 = 1 - (ValoresRestriccion1[4]*S1X4);
                        float S2X1 = 0 - (ValoresRestriccion1[4]*S2X4);
                        float S3X1 = 0 - (ValoresRestriccion1[4]*S3X4);
                        float S4X1 = 0 - (ValoresRestriccion1[4]*S4X4);
                        float S5X1 = 0 - (ValoresRestriccion1[4]*S5X4);
                    //Restriccion 2
                     ValorSujetoARestriccion2 = ValorSujetoARestriccion2 - (ValoresRestriccion2[4]*ValorSujetoARestriccion4);

                     for(int i=0; i<ValoresRestriccion2.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion2[i] = ValoresRestriccion2[i]-(ValoresRestriccion2[4]*ValoresRestriccion4[i]);
                        }
                    //Valores S1,S2,S3,S4,S5 Para Columna X2
                        float S1X2 = 0 - (ValoresRestriccion2[4]*S1X4);
                        float S2X2 = 1 - (ValoresRestriccion2[4]*S2X4);
                        float S3X2 = 0 - (ValoresRestriccion2[4]*S3X4);
                        float S4X2 = 0 - (ValoresRestriccion2[4]*S4X4);
                        float S5X2 = 0 - (ValoresRestriccion2[4]*S5X4);
                        //Valor de Z
                         for(int i=0; i<ValoresDeZSimplex.Length; i++)                                   
                        {                                                                 
                            ValoresDeZSimplex[i] = ValoresDeZSimplex[i]-(ValoresDeZSimplex[4]*ValoresRestriccion4[i]);
                        }
                        //Valores Z y CR Para Columna Z
                        float Z = 1 - (ValoresDeZSimplex[4] * 0);
                        float CR = 0 - (ValoresDeZSimplex[4] * ValorSujetoARestriccion4);
                        //Tabla
                     System.Console.WriteLine($"Variables Basicas            Z            X1            X2            X3            X4            X5            S1            S2            S3            S4            S5            CR");
            System.Console.WriteLine($"         X1                  0            {ValoresRestriccion1[0]}           {ValoresRestriccion1[1]}           {ValoresRestriccion1[2]}           {ValoresRestriccion1[3]}           {ValoresRestriccion1[4]}           {S1X1}           {S2X1}           {S3X1}           {S4X1}           {S5X1}           {ValorSujetoARestriccion1}");
            System.Console.WriteLine($"         S2                  0            {ValoresRestriccion2[0]}           {ValoresRestriccion2[1]}           {ValoresRestriccion2[2]}           {ValoresRestriccion2[3]}           {ValoresRestriccion2[4]}           {S1X2}           {S2X2}           {S3X2}           {S4X2}           {S5X2}           {ValorSujetoARestriccion2}");
            System.Console.WriteLine($"         S3                  0            {ValoresRestriccion3[0]}           {ValoresRestriccion3[1]}           {ValoresRestriccion3[2]}           {ValoresRestriccion3[3]}           {ValoresRestriccion3[4]}           {S1X3}           {S2X3}           {S3X3}           {S4X3}           {S5X3}           {ValorSujetoARestriccion3}");
            System.Console.WriteLine($"         S4                  0            {ValoresRestriccion4[0]}           {ValoresRestriccion4[1]}           {ValoresRestriccion4[2]}           {ValoresRestriccion4[3]}           {ValoresRestriccion4[4]}           {S1X4}           {S2X4}           {S3X4}           {S4X4}           {S5X4}           {ValorSujetoARestriccion4}");
            System.Console.WriteLine($"         S5                  0            {ValoresRestriccion5[0]}           {ValoresRestriccion5[1]}           {ValoresRestriccion5[2]}           {ValoresRestriccion5[3]}           {ValoresRestriccion5[4]}           {S1X5}           {S2X5}           {S3X5}           {S4X5}           {S5X5}           {ValorSujetoARestriccion5}");
            System.Console.WriteLine($"          Z                  {Z}            {ValoresDeZSimplex[0]}           {ValoresDeZSimplex[1]}           {ValoresDeZSimplex[2]}           {ValoresDeZSimplex[3]}           {ValoresDeZSimplex[4]}           0           0           0           0           0           {CR}");

            //Tercera Tabla Simplex
                 } //Si es el caso de que la columna S4 sea el mas negativo

                   else if((ValorSujetoARestriccion5/ValoresRestriccion5[4])<(ValorSujetoARestriccion1/ValoresRestriccion1[4])&&(ValorSujetoARestriccion5/ValoresRestriccion5[4])<(ValorSujetoARestriccion2/ValoresRestriccion2[4])&&(ValorSujetoARestriccion5/ValoresRestriccion5[4])<(ValorSujetoARestriccion4/ValoresRestriccion4[4])&&(ValorSujetoARestriccion5/ValoresRestriccion5[4])<(ValorSujetoARestriccion3/ValoresRestriccion3[4]))
                 {
                     System.Console.WriteLine("Segunda Tabla Simplex\n\n"); 
                    //Nuevos Valores Tabla Simplex 2
                    //Restriccion 5
                     ValorSujetoARestriccion5 = ValorSujetoARestriccion5/ValoresRestriccion5[4];
                    for(int i=0; i<ValoresRestriccion5.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion5[i] = ValoresRestriccion5[i]/ValoresRestriccion5[4];
                        }
                        //Valores S1,S2,S3,S4,S5 Para Columna X4
                        float S1X5 = 0/ValoresRestriccion5[4];
                        float S2X5 = 0/ValoresRestriccion5[4];
                        float S3X5 = 0/ValoresRestriccion5[4];
                        float S4X5 = 0/ValoresRestriccion5[4];
                        float S5X5 = 1/ValoresRestriccion5[4];
                    //Restriccion 5
                        ValorSujetoARestriccion1 = ValorSujetoARestriccion1 - (ValoresRestriccion1[4]*ValorSujetoARestriccion5);

                     for(int i=0; i<ValoresRestriccion1.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion1[i] = ValoresRestriccion1[i]-(ValoresRestriccion1[4]*ValoresRestriccion5[i]);
                        }
                          //Valores S1,S2,S3,S4,S5 Para Columna X1
                        float S1X1 = 1 - (ValoresRestriccion1[4]*S1X5);
                        float S2X1 = 0 - (ValoresRestriccion1[4]*S2X5);
                        float S3X1 = 0 - (ValoresRestriccion1[4]*S3X5);
                        float S4X1 = 0 - (ValoresRestriccion1[4]*S4X5);
                        float S5X1 = 0 - (ValoresRestriccion1[4]*S5X5);
                    //Restriccion 3
                         ValorSujetoARestriccion3 = ValorSujetoARestriccion3 - (ValoresRestriccion3[4]*ValorSujetoARestriccion5);

                     for(int i=0; i<ValoresRestriccion3.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion3[i] = ValoresRestriccion3[i]-(ValoresRestriccion3[4]*ValoresRestriccion5[i]);
                        }
                         //Valores S1,S2,S3,S4,S5 Para Columna X3
                        float S1X3 = 0 - (ValoresRestriccion3[4]*S1X5);
                        float S2X3 = 0 - (ValoresRestriccion3[4]*S2X5);
                        float S3X3 = 1 - (ValoresRestriccion3[4]*S3X5);
                        float S4X3 = 0 - (ValoresRestriccion3[4]*S4X5);
                        float S5X3 = 0 - (ValoresRestriccion3[4]*S5X5);
                    //Restriccion 4
                     ValorSujetoARestriccion4 = ValorSujetoARestriccion4 - (ValoresRestriccion4[4]*ValorSujetoARestriccion5);

                     for(int i=0; i<ValoresRestriccion1.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion4[i] = ValoresRestriccion4[i]-(ValoresRestriccion4[4]*ValoresRestriccion5[i]);
                        }
                         //Valores S1,S2,S3,S4,S5 Para Columna X4
                        float S1X4 = 0 - (ValoresRestriccion4[4]*S1X5);
                        float S2X4 = 0 - (ValoresRestriccion4[4]*S2X5);
                        float S3X4 = 0 - (ValoresRestriccion4[4]*S3X5);
                        float S4X4 = 1 - (ValoresRestriccion4[4]*S4X5);
                        float S5X4 = 0 - (ValoresRestriccion4[4]*S5X5);
                    //Restriccion 2
                     ValorSujetoARestriccion2 = ValorSujetoARestriccion2 - (ValoresRestriccion2[4]*ValorSujetoARestriccion5);

                     for(int i=0; i<ValoresRestriccion2.Length; i++)                                   
                        {                                                                 
                            ValoresRestriccion2[i] = ValoresRestriccion2[i]-(ValoresRestriccion2[4]*ValoresRestriccion5[i]);
                        }
                    //Valores S1,S2,S3,S4,S5 Para Columna X2
                        float S1X2 = 0 - (ValoresRestriccion2[4]*S1X5);
                        float S2X2 = 1 - (ValoresRestriccion2[4]*S2X5);
                        float S3X2 = 0 - (ValoresRestriccion2[4]*S3X5);
                        float S4X2 = 0 - (ValoresRestriccion2[4]*S4X5);
                        float S5X2 = 0 - (ValoresRestriccion2[4]*S5X5);
                        //Valor de Z
                         for(int i=0; i<ValoresDeZSimplex.Length; i++)                                   
                        {                                                                 
                            ValoresDeZSimplex[i] = ValoresDeZSimplex[i]-(ValoresDeZSimplex[4]*ValoresRestriccion5[i]);
                        }
                        //Valores Z y CR Para Columna Z
                        float Z = 1 - (ValoresDeZSimplex[4] * 0);
                        float CR = 0 - (ValoresDeZSimplex[4] * ValorSujetoARestriccion5);
                        //Tabla
                     System.Console.WriteLine($"Variables Basicas            Z            X1            X2            X3            X4            X5            S1            S2            S3            S4            S5            CR");
            System.Console.WriteLine($"         X1                  0            {ValoresRestriccion1[0]}           {ValoresRestriccion1[1]}           {ValoresRestriccion1[2]}           {ValoresRestriccion1[3]}           {ValoresRestriccion1[4]}           {S1X1}           {S2X1}           {S3X1}           {S4X1}           {S5X1}           {ValorSujetoARestriccion1}");
            System.Console.WriteLine($"         S2                  0            {ValoresRestriccion2[0]}           {ValoresRestriccion2[1]}           {ValoresRestriccion2[2]}           {ValoresRestriccion2[3]}           {ValoresRestriccion2[4]}           {S1X2}           {S2X2}           {S3X2}           {S4X2}           {S5X2}           {ValorSujetoARestriccion2}");
            System.Console.WriteLine($"         S3                  0            {ValoresRestriccion3[0]}           {ValoresRestriccion3[1]}           {ValoresRestriccion3[2]}           {ValoresRestriccion3[3]}           {ValoresRestriccion3[4]}           {S1X3}           {S2X3}           {S3X3}           {S4X3}           {S5X3}           {ValorSujetoARestriccion3}");
            System.Console.WriteLine($"         S4                  0            {ValoresRestriccion4[0]}           {ValoresRestriccion4[1]}           {ValoresRestriccion4[2]}           {ValoresRestriccion4[3]}           {ValoresRestriccion4[4]}           {S1X4}           {S2X4}           {S3X4}           {S4X4}           {S5X4}           {ValorSujetoARestriccion4}");
            System.Console.WriteLine($"         S5                  0            {ValoresRestriccion5[0]}           {ValoresRestriccion5[1]}           {ValoresRestriccion5[2]}           {ValoresRestriccion5[3]}           {ValoresRestriccion5[4]}           {S1X5}           {S2X5}           {S3X5}           {S4X5}           {S5X5}           {ValorSujetoARestriccion5}");
            System.Console.WriteLine($"          Z                  {Z}            {ValoresDeZSimplex[0]}           {ValoresDeZSimplex[1]}           {ValoresDeZSimplex[2]}           {ValoresDeZSimplex[3]}           {ValoresDeZSimplex[4]}           0           0           0           0           0           {CR}");

            //Tercera Tabla Simplex
                 } //Si es el caso de que la columna S5 sea el mas negativo


            }//Final localizar valor mas negativo de Z para la X5
            
    }//Acaba Metodo Simplex con 5 Restricciones

    //Metodo para obtener los valores de cada X para un arreglo                                                              
 public static float[]ValoresX()
{   
int cantidadX;
float [] ValoresDeX = {0,0,0,0,0};
    do
    {                                                              
System.Console.WriteLine("Digame Cuantas X Contiene\nMaximo 5");            
cantidadX =Int32.Parse(System.Console.ReadLine());
if(cantidadX <6)
{
for(int i=0; i<cantidadX; i++)                                   
 {                                                                 
System.Console.WriteLine("Digame el valor de X"+(i+1));
ValoresDeX[i]=float.Parse(System.Console.ReadLine());
}

}
else
{
    System.Console.WriteLine("Ingrese un valor valido");
}
}while(cantidadX >5);
return ValoresDeX;
 } 

 public static float[] ValoresXParaZEnSimplex(float[]ValoresDeZ)
 {
     float[]ValoresDeZNueva = new float[5];
     float valorNegativo;
for(int i=0; i<ValoresDeZ.Length; i++)                                   
 {                        
valorNegativo = ValoresDeZ[i] - (ValoresDeZ[i]*2);
ValoresDeZNueva[i] = valorNegativo;
}
return ValoresDeZNueva;
 }

 }
}