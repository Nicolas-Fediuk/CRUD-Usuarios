namespace Entidad
{
    public class Usuario
    {
        private string nombre;
        private string apellido;
        private string contraseña;
        private string dni;
        private string correo;
        private string celular;

        public Usuario()
        {

        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Celular { get => celular; set => celular = value; }
    }
}