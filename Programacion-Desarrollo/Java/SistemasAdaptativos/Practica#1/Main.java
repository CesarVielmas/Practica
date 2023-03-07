import javax.swing.*;
//Metodo main principal para el programa con su interfaz grafica

public class Main extends JFrame {

	public Main() {
 		add(new Grafica());
 		setDefaultCloseOperation(JFrame.HEIGHT);
 		setSize(400,300);
 		setLocationRelativeTo(null);
 		setTitle("Practica #1");
 		setResizable(false);
 		setVisible(true);
 	}

 	public static void main(String[] args) {
 		new Main();
		Carros LisCarr = new Carros();
		LisCarr.start();
 	}
}