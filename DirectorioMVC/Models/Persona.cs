using System.Security.Cryptography.X509Certificates;

namespace POO_DirectorioMVC.Models
{
    public class Persona
    {

        private string numeroID { get; set; }
        private string nombres { get; set; }
        private string apellidos{ get; set; }
        private DateTime fechaNacimiento { get; set; }
        private string telefono { get; set; }
        private string celular { get; set; }
         private string email { get; set; }
         private string  ciudad{ get; set; }
         private string direccion{ get; set; }
         private string profesion { get; set; }

        public Persona ()
        {
           
        }
        public Persona (string numeroID, string nombres, string apellidos, DateTime Fechanacimiento, string telefono, string celular, string email, string ciudad, string direccion, string profesion)
        {
            this.numeroID = numeroID;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.fechaNacimiento = fechaNacimiento;
            this.telefono = telefono;
            this.celular = celular;
            this.email = email;
            this.ciudad = ciudad;
            this.direccion = direccion;
            this.profesion = profesion;
        }
        public Persona(string nombres, string apellido)
        { this.nombres = nombres;
            this.apellidos = apellidos;
        }
        public void setNombres(string p_nombres)
        {
            this.nombres = p_nombres;
        }
        public string getNombres()
        { return this.nombres; }
        public void setApellidos(string p_apellidos)
        { this.apellidos = p_apellidos; }
        public string getNombreCompleto()
        { return this.nombres + "" + this.apellidos; }
        }
}
