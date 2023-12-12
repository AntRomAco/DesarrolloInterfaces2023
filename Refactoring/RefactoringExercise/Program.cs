using System;
namespace RefactoringExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            Utils utils = new Utils();
            menu.MenuIngredientes();
            while (!utils.getCheck())
            {
                utils.SeleccionarIngredientes(utils.Opcion());
            }
            utils.resetCheck();
            menu.MenuTamano();
            while (!utils.getCheck())
            {
                utils.SeleccionarTamano(utils.Opcion());
            }
            utils.resetCheck();
            menu.MenuDomicilio();
            while (!utils.getCheck())
            {
                utils.SeleccionarDomicilio(utils.Opcion());
            }
            Console.WriteLine($"El precio de tu pizza es {utils.getPrecio()} euros");
        }
    }
}