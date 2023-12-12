using NUnit.Framework;
using RefactoringExercise;

namespace RefactoringExerciseTesting
{
    public class Tests
    {
        [Test]
        public void Opcion_Valido_Opcion()
        {
            Utils utils = new Utils();
            int input = 2;
            int expectedOpcion = 2;

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                Console.SetIn(new StringReader(input.ToString()));
                int actualOpcion = utils.Opcion();

                Assert.That(actualOpcion, Is.EqualTo(expectedOpcion));
            }
        }

        [Test]
        public void Opcion_Invalido_MenosUno()
        {
            Utils utils = new Utils();
            string input = "texto_invalido";
            int expectedOpcion = -1;

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                Console.SetIn(new StringReader(input));
                int actualOpcion = utils.Opcion();

                Assert.That(actualOpcion, Is.EqualTo(expectedOpcion));
            }
        }

        [Test]
        public void SeleccionarIngredientes_Valida_Correcto()
        {
            Utils utils = new Utils();
            int input = 2;
            double expectedPrecio = 6;

            utils.SeleccionarIngredientes(input);
            double actualPrecio = utils.getPrecio();

            Assert.That(actualPrecio, Is.EqualTo(expectedPrecio));
        }

        [Test]
        public void SeleccionarIngredientes_Invalida_Mensaje()
        {
            Utils utils = new Utils();
            int input = -1;
            double expectedPrecio = 0;

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                utils.SeleccionarIngredientes(input);
                double actualPrecio = utils.getPrecio();

                Assert.That(actualPrecio, Is.EqualTo(expectedPrecio));
            }
        }


        [Test]
        public void SeleccionarTamano_Pequena_Correcto()
        {
            Utils utils = new Utils();
            utils.SeleccionarIngredientes(2);

            int input = 1;
            double expectedPrecio = 6 * 0.8;

            utils.SeleccionarTamano(input);
            double actualPrecio = utils.getPrecio();

            Assert.That(actualPrecio, Is.EqualTo(expectedPrecio));
        }

        [Test]
        public void SeleccionarTamano_Mediana_Correcto()
        {
            Utils utils = new Utils();
            utils.SeleccionarIngredientes(2);

            int input = 2;
            double expectedPrecio = 6;

            utils.SeleccionarTamano(input);
            double actualPrecio = utils.getPrecio();

            Assert.That(actualPrecio, Is.EqualTo(expectedPrecio));
        }

        [Test]
        public void SeleccionarTamano_Grande_Correcto()
        {
            Utils utils = new Utils();
            utils.SeleccionarIngredientes(2);

            int input = 3;
            double expectedPrecio = 6 * 1.2;

            utils.SeleccionarTamano(input);
            double actualPrecio = utils.getPrecio();

            Assert.That(actualPrecio, Is.EqualTo(expectedPrecio));
        }

        [Test]
        public void SeleccionarTamano_Invalida_SinCambios()
        {
            Utils utils = new Utils();
            utils.SeleccionarIngredientes(2);

            int input = 4;
            double expectedPrecio = 6;

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                utils.SeleccionarTamano(input);
                double actualPrecio = utils.getPrecio();

                Assert.That(actualPrecio, Is.EqualTo(expectedPrecio));
            }
        }

        [Test]
        public void SeleccionarDomicilio_Domicilio_Correcto()
        {
            Utils utils = new Utils();
            utils.SeleccionarIngredientes(2);

            int input = 1;
            double expectedPrecio = 6 + 2;

            utils.SeleccionarDomicilio(input);
            double actualPrecio = utils.getPrecio();

            Assert.That(actualPrecio, Is.EqualTo(expectedPrecio));
        }

        [Test]
        public void SeleccionarDomicilio_Local_Correcto()
        {
            Utils utils = new Utils();
            utils.SeleccionarIngredientes(2);

            int input = 2;
            double expectedPrecio = 6;

            utils.SeleccionarDomicilio(input);
            double actualPrecio = utils.getPrecio();

            Assert.That(actualPrecio, Is.EqualTo(expectedPrecio));
        }

        [Test]
        public void SeleccionarDomicilio_Invalida_SinCambios()
        {
            Utils utils = new Utils();
            utils.SeleccionarIngredientes(2);

            int input = 3;
            double expectedPrecio = 6;

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                utils.SeleccionarDomicilio(input);
                double actualPrecio = utils.getPrecio();

                Assert.That(actualPrecio, Is.EqualTo(expectedPrecio));
            }
        }
    }
}
