using System;

namespace POO_DirectorioMVC.Models
{
    public class Persona
    {
        // Propiedades públicas para que MVC pueda enlazarlas
        private string NumeroID { get; set; }
        private string Nombres { get; set; }
        private string Apellidos { get; set; }
        private DateTime? FechaNacimiento { get; set; }
        private string Telefono { get; set; }
       private string Celular { get; set; }
       private string Email { get; set; }
        private string Ciudad { get; set; }
        private string Direccion { get; set; }
     private string Profesion { get; set; }

        // Constructor vacío (MVC lo usa por defecto)
        public Persona()
        {
            this.NumeroID = string.Empty;
            this.Nombres = string.Empty;
            this.Apellidos = string.Empty;
            this.FechaNacimiento = null;
            this.Telefono = string.Empty;
            this.Celular = string.Empty;
            this.Email = string.Empty;
            this.Ciudad = string.Empty;
            this.Direccion = string.Empty;
            this.Profesion = string.Empty;
        }

        // Constructor completo
        public Persona(
            string numeroID,
            string nombres,
            string apellidos,
            DateTime? fechaNacimiento,
            string telefono,
            string celular,
            string email,
            string ciudad,
            string direccion,
            string profesion)
        {
            this.NumeroID = numeroID;
            this.Nombres = nombres;
            this.Apellidos = apellidos;
            this.FechaNacimiento = fechaNacimiento;
            this.Telefono = telefono;
            this.Celular = celular;
            this.Email = email;
            this.Ciudad = ciudad;
            this.Direccion = direccion;
            this.Profesion = profesion;
        }

        // Constructor simple (solo nombres y apellidos)
        public Persona(string nombres, string apellidos)
        {
            this.Nombres = nombres;
            this.Apellidos = apellidos;
        }

        // Métodos estilo Java (compatibles con tu vista actual)
        public void setNombres(string p_nombres)
        {
            this.Nombres = p_nombres;
        }

        public string getNombres()
        {
            return this.Nombres;
        }

        public void setApellidos(string p_apellidos)
        {
            this.Apellidos = p_apellidos;
        }

        public string getApellidos()
        {
            return this.Apellidos;
        }

        // Propiedad calculada
        public string NombreCompleto
        {
            get { return this.Nombres + " " + this.Apellidos; }
        }
    }
}