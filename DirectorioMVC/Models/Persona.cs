namespace POO_DirectorioMVC.Models
{
    public class Persona
    {
        private string numeroid { set; get; }

        private string nombres { set; get; }

        public string apellidos { set; get; }
        public string direccion { set; get; }
        public int edad { set; get; }
        public DateTime fechaNacimiento { set; get; }
        public string telefono { set; get; }
        public string celular { set; get; }
        public string email { set; get; }
        public Persona()
        {
            this.nombres = "Jose";
        }

        public Persona(string p_nombre)
        {
            this.nombres = p_nombre;
        }
        public string getNombre()
        {
            return this.nombres;
        }
        public void setNombre(string p_nombres)
        {
            this.nombres = p_nombres;
        }

        public void setApellidos(string p_apellidos)
        {
            this.apellidos = p_apellidos;
        }
        public string getNombreCompleto()
        {
            return this.nombres + "" + this.apellidos;
        }

        public string getNombreCompleto(string p_nombre, string p_apellido)
        {
            this.nombres = p_nombre;
            this.apellidos = p_apellido;

            return this.nombres + "" + this.apellidos;

        }

    }
}
