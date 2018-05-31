using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace Pruebas
{
    [TestClass]
    public class TestNuevoJuego
    {
        [TestMethod]
        public void TestIniciarNuevoJuego()
        {
            //Arrange
            Juego juego = new Juego();

            //Act
            string inicio = juego.IniciarJuego();

            //Assert
            Assert.AreEqual("Juego Iniciado", inicio);
        }

        [TestMethod]
        public void TestDefinirPalabraAAdivinar()
        {
            //Arrange
            Juego juego = new Juego();
            juego.IniciarJuego();
            juego.IngresarPalabraAAdivinar("vaso");

            //Act
            string palabraAAdivinar = juego.PalabraAAdivinar;

            //Assert
            Assert.AreEqual("vaso", palabraAAdivinar);
        }

        [TestMethod]
        public void TestIngresarLetraCorrecta()
        {
            //Arrange
            Juego juego = new Juego();
            juego.IniciarJuego();
            juego.IngresarPalabraAAdivinar("vaso");

            //Act
            bool esCorrecta = juego.IngresarLetra('a');

            //Assert
            Assert.AreEqual(true, esCorrecta);
        }

        [TestMethod]
        public void TestIngresarLetraIncorrecta()
        {
            //Arrange
            Juego juego = new Juego();
            juego.IniciarJuego();
            juego.IngresarPalabraAAdivinar("vaso");

            //Act
            bool esCorrecta = juego.IngresarLetra('b');

            //Assert
            Assert.AreEqual(false, esCorrecta);
        }

        [TestMethod]
        public void TestAdivinoPalabra()
        {
            //Arrange
            Juego juego = new Juego();
            juego.IniciarJuego();
            juego.IngresarPalabraAAdivinar("vaso");
            juego.IngresarLetra('v');
            juego.IngresarLetra('a');
            juego.IngresarLetra('s');
            juego.IngresarLetra('o');

            //Act
            bool adivino = juego.AdivinoPalabra();

            //Assert
            Assert.AreEqual(true, adivino);
        }

        [TestMethod]
        public void TestNoAdivinoPalabra()
        {
            //Arrange
            Juego juego = new Juego();
            juego.IniciarJuego();
            juego.IngresarPalabraAAdivinar("vaso");
            juego.IngresarLetra('v');
            juego.IngresarLetra('a');
            juego.IngresarLetra('s');

            //Act
            bool adivino = juego.AdivinoPalabra();

            //Assert
            Assert.AreEqual(false, adivino);
        }

        [TestMethod]
        public void VerProgresoPalabraSinAciertos()
        {
            //Arrange
            Juego juego = new Juego();
            juego.IniciarJuego();
            juego.IngresarPalabraAAdivinar("vaso");
            juego.IngresarLetra('x');

            //Act
            string palabra = juego.DevolverPalabraParcial();

            //Assert
            Assert.AreEqual("----", palabra);
        }

        [TestMethod]
        public void VerProgresoPalabraConAciertos()
        {
            //Arrange
            Juego juego = new Juego();
            juego.IniciarJuego();
            juego.IngresarPalabraAAdivinar("vaso");
            juego.IngresarLetra('v');

            //Act
            string palabra = juego.DevolverPalabraParcial();

            //Assert
            Assert.AreEqual("v---", palabra);
        }

    }
}
