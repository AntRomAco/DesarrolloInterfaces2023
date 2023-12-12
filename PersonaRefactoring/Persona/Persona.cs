using System;

namespace PersonaNamespace
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Direccion { get; set; }

        static void Main(string[] args)
        {
            Persona persona = new Persona();

            persona.ActualizarDatos("Ejemplo", 30, "Ejemplo_Dirección");

            persona.MostrarDatos();

            Console.WriteLine(persona.CalcularIMC(100, 2));
        }

        public void MostrarDatos()
        {
            Console.WriteLine("Nombre: " + Nombre + " Edad: " + Edad + " Dirección: " + Direccion);
        }

        public float CalcularIMC(int peso, int altura)
        {
            float imc = peso / (altura * altura);
            return imc;
        }

        public void ActualizarDatos(string nombre, int edad, string direccion)
        {
            Nombre = nombre;
            Edad = edad;
            Direccion = direccion;
        }
    }
}