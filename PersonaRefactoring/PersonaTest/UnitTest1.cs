using NUnit.Framework;
using System;
using System.IO;

namespace PersonaTest
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void MostrarDatos_Correcto()
        {
            PersonaNamespace.Persona persona = new PersonaNamespace.Persona
            {
                Nombre = "Testing",
                Edad = 25,
                Direccion = "DirecciónTest"
            };

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                persona.MostrarDatos();
                string resultado = sw.ToString().Trim();

                string expectedResult = "Nombre: Testing Edad: 25 Dirección: DirecciónTest";
                Assert.That(expectedResult, Is.EqualTo(resultado));
            }
        }

        public void MostrarDatos_Error()
        {
            PersonaNamespace.Persona persona = new PersonaNamespace.Persona
            {
                Nombre = "",
                Edad = 0,
                Direccion = ""
            };

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                persona.MostrarDatos();
                string resultado = sw.ToString().Trim();

                string expectedResult = "Nombre: Testing Edad: 25 Dirección: DirecciónTest";
                Assert.That(expectedResult, !Is.EqualTo(resultado));
            }
        }

        [Test]
        public void CalcularIMC_Correcto()
        {
            PersonaNamespace.Persona persona = new PersonaNamespace.Persona();

            float imc = persona.CalcularIMC(70, 1);

            float expectedResult = 70f;
            Assert.That(expectedResult, Is.EqualTo(imc));
        }

        [Test]
        public void CalcularIMC_Error()
        {
            PersonaNamespace.Persona persona = new PersonaNamespace.Persona();

            float imc = persona.CalcularIMC(70, 0);

            float expectedResult = 70f;
            Assert.That(expectedResult, !Is.EqualTo(imc));
        }

        [Test]
        public void ActualizarDatos_Correcto()
        {
            PersonaNamespace.Persona persona = new PersonaNamespace.Persona();

            persona.ActualizarDatos("NuevoNombre", 30, "NuevaDirección");

            Assert.That("NuevoNombre", Is.EqualTo(persona.Nombre));
            Assert.That(30, Is.EqualTo(persona.Edad));
            Assert.That("NuevaDirección", Is.EqualTo(persona.Direccion));
        }

        [Test]
        public void ActualizarDatos_Error()
        {
            PersonaNamespace.Persona persona = new PersonaNamespace.Persona();

            persona.ActualizarDatos("", 0, "");

            Assert.That("NuevoNombre", !Is.EqualTo(persona.Nombre));
            Assert.That(30, !Is.EqualTo(persona.Edad));
            Assert.That("NuevaDirección", !Is.EqualTo(persona.Direccion));
        }
    }
}
