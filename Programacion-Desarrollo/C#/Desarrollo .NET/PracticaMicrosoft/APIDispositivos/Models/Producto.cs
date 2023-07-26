namespace APIDispositivos.Models
{
    //Se asigna el modelo de los datos que va a contener la API , en este caso serian empleados
    //Y para cada empleado que vaya a recibir necesitan tener ciertas propiedades cada uno y por ello el modelo
    //Empleado para reusarlo y crearlo y mandarlo a la api directamente 
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public float Precio { get; set; }
        public string Tipo { get; set; }
        public int Cantidad { get; set; }
        public string fecha { get; set; }
    }
}