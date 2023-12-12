using System;

namespace RefactoringExercise
{
    public class Utils
    {
        private double precio;
        private bool check;
        public double getPrecio() { return precio; }
        public bool getCheck() { return check; }
        public void resetCheck() { check = false; }
        public int Opcion()
        {
            int opcion;
            try
            {
                Console.Write("Opción: ");
                return opcion = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }
        }
        public void SeleccionarIngredientes(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    precio = 5; check = true; break;
                case 2:
                case 3:
                    precio = 6; check = true; break;
                case 4:
                case 5:
                case 6:
                    precio = 7; check = true; break;
                case 7:
                    precio = 10; check = true; break;
                default:
                    Console.WriteLine("Opción inválida"); return;
            }
        }

        public void SeleccionarTamano(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    precio *= 0.8; check = true; break;
                case 2:
                    precio *= 1; check = true; break;
                case 3:
                    precio *= 1.2; check = true; break;
                default:
                    Console.WriteLine("Opción inválida"); return;
            }
        }

        public void SeleccionarDomicilio(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    precio += 2; check = true; break;
                case 2:
                    precio += 0; check = true; break;
                default:
                    Console.WriteLine("Opción inválida"); return;
            }
        }
    }
}
