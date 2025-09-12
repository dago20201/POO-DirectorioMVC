namespace DirectorioMVC.Models
{
    using System;
    using System.Collections.Generic;

    namespace proyecto_DirectorioEmp
    {
        public class Persona
        {
            // Variables privadas
            private string numeroID;
            private string nombres;
            private string apellidos;
            private DateTime fechaNacimiento;
            private string telefono;
            private string celular;
            private string pais;
            private string ciudad;
            private string direccion;
            private string profesion;




            // Constructor vacío
            public Persona()
            {
                numeroID = "";
                nombres = "";
                apellidos = "";
                fechaNacimiento = DateTime.Now;
                telefono = "";
                celular = "";
                pais = "";
                ciudad = "";
                direccion = "";
                profesion = "";

            }

            // Constructor con parámetros
            public Persona(string numeroID, string nombres, string apellidos,
                           DateTime fechaNacimiento, string telefono, string celular,
                           string pais, string ciudad, string direccion, string profesion)
            {
                this.numeroID = numeroID;
                this.nombres = nombres;
                this.apellidos = apellidos;
                this.fechaNacimiento = fechaNacimiento;
                this.telefono = telefono;
                this.celular = celular;
                this.pais = pais;
                this.ciudad = ciudad;
                this.direccion = direccion;
                this.profesion = profesion;

            }

            // Métodos Get y Set
            public string GetNumeroID()
            {
                return numeroID;
            }

            public void SetNumeroID(string numeroID)
            {
                this.numeroID = numeroID;
            }

            public string GetNombres()
            {
                return nombres;
            }

            public void SetNombres(string nombres)
            {
                this.nombres = nombres;
            }

            public string GetApellidos()
            {
                return apellidos;
            }

            public void SetApellidos(string apellidos)
            {
                this.apellidos = apellidos;
            }

            public DateTime GetFechaNacimiento()
            {
                return fechaNacimiento;
            }

            public void SetFechaNacimiento(DateTime fechaNacimiento)
            {
                this.fechaNacimiento = fechaNacimiento;
            }

            public string GetTelefono()
            {
                return telefono;
            }

            public void SetTelefono(string telefono)
            {
                this.telefono = telefono;
            }

            public string GetCelular()
            {
                return celular;
            }

            public void SetCelular(string celular)
            {
                this.celular = celular;
            }

            public string GetPais()
            {
                return pais;
            }

            public void SetPais(string pais)
            {
                this.pais = pais;
            }

            public string GetCiudad()
            {
                return ciudad;
            }

            public void SetCiudad(string ciudad)
            {
                this.ciudad = ciudad;
            }

            public string GetDireccion()
            {
                return direccion;
            }

            public void SetDireccion(string direccion)
            {
                this.direccion = direccion;
            }

            public string GetProfesion()
            {
                return profesion;
            }

            public void SetProfesion(string profesion)
            {
                this.profesion = profesion;
            }





            // Método para mostrar información completa
            public void MostrarInformacion()
            {
                Console.WriteLine($"\n=== INFORMACIÓN DE PERSONA ===");
                Console.WriteLine($"ID: {numeroID}");
                Console.WriteLine($"Nombre: {nombres} {apellidos}");
                Console.WriteLine($"Fecha de Nacimiento: {fechaNacimiento.ToShortDateString()}");
                Console.WriteLine($"Teléfono: {telefono}");
                Console.WriteLine($"Celular: {celular}");
                Console.WriteLine($"Ubicación: {ciudad}, {pais}");
                Console.WriteLine($"Dirección: {direccion}");
                Console.WriteLine($"Profesión: {profesion}");




            }
        }

    }
}