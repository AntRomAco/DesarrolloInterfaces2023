using System;

namespace RefactoringExercise
{
    public class Menu
    {
        public void MenuIngredientes()
        {
            Console.WriteLine("Bienvenido a la pizzería\n\n" +
                "¿Qué ingredientes quieres en tu pizza?\n\n1. Queso\n" +
                "2. Jamón\n3. Champiñones\n4. Salami\n5. Piña\n6. Aceitunas" +
                "\n7. Todos\n");
        }

        public void MenuTamano()
        {
            Console.Clear();
            Console.WriteLine("¿Qué tamaño quieres?\n1. Pequeña\n2. Mediana\n" +
                "3. Grande\n");
        }

        public void MenuDomicilio()
        {
            Console.Clear();
            Console.WriteLine("¿Quieres que te la entreguen a domicilio?\n\n" +
                "1. Sí\n2. No\n");
        }
    }
}
