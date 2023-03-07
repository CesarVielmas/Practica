import java.util.*;

public class Sistema extends Thread {

	public boolean SemAB,SemCD;
	public boolean CA,CB,CC,CD; 
	public int CarrilA,CarrilB,CarrilC,CarrilD; 
	public String EstadoAB = "";
	public String EstadoCD = "";

    public void run() {

        //Modelo usado en el semaforo para evitar choques y controlar el flujo
	try { 

            Carros LisCarr = new Carros();

		while(true) {
			//Modelo matematica obtenido mediante la tabla de karnaugh
		    if (CarrilA > 10) { CA = true; }

		    if (CarrilB > 10) { CB = true; }

		    if (CarrilC > 5 ) { CC = true; }

		    if (CarrilD > 5 ) { CD = true; }
						
		    SemAB = (CA | CB | !CD ) & (CA | !CC | !CD ) & (CA | CB | !CC) & (CB | !CC | !CD);
		    SemCD = !SemAB;
				
		LisCarr.setEstado(SemAB,SemCD);
				
		if (SemAB == true) {
			EstadoAB = "Verde";
			EstadoCD = "Rojo";

		} else {
			EstadoAB = "Rojo";
			EstadoCD = "Verde";
		}	
				
		for(int r=0;r<20;r++){System.out.println("\n");}
        //Pequeña descripcion en la terminal o consola para el algoritmo
        System.out.println("Integrantes \nKevin Alexander Garza Medina 1945821\nCesar Alejandro Vielmas Salais 2035665\nSofía Mayela Peña García 1906377\nItzel Gabriela Chávez Herrera 1858503\nNestor Fernandez Ponce 2077422");
		System.out.println("\nControl de Semaforos");				
		System.out.println("El congestionamiento dentro de los carros");
		System.out.println(CarrilA+" carros en A");
		System.out.println(CarrilB+" carros en B");
		System.out.println(CarrilC+" carros en C");
		System.out.println(CarrilD+" carros en D");
			
		System.out.println("\n\n\t\tEstado de los semaforos para el control");
		System.out.println("\nA y B estan en "+EstadoAB );
		System.out.println("\nC y D estan en "+EstadoCD );
	
	Thread.sleep(500);
	} //Fin del while

        } catch(InterruptedException e) {
		System.out.println("Excepcion: " + e.getMessage());
	}
		
} //Termina el run()

public void setCarros(int CaA, int CaB, int CaC, int CaD) {
	CarrilA = CaA;
	CarrilB = CaB;
	CarrilC = CaC;
	CarrilD = CaD;
}

}//Termina la clase Sistema