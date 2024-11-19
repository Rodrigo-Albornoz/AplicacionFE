namespace AplicacionBE.Entities
{
    public class Datos
    {
        public string Nombre;
        public int Edad;

        public string Verificar(int Edad)
        {
            if (Edad >= 18)
            {
                return "Acceso concedido";
            }
            else
            {
                return "Acceso no concedido";
            }
        }
    }
}
