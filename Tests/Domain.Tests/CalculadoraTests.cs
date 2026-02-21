using Loja.Domain;
using NUnit.Framework;

namespace Domain.Tests
{
   
        [TestFixture]
        public class CalculadoraTests
        {
            private Calculadora _calculadora;

            [SetUp]
            public void Setup()
            {
                _calculadora = new Calculadora();
            }

            #region Soma

            [Test]
            public void Somar_Deve_Retornar_Resultado_Correto()
            {
                var resultado = _calculadora.Somar(10, 5);

                Assert.That(resultado, Is.EqualTo(15));
            }

            #endregion

            #region Subtração

            [Test]
            public void Subtrair_Deve_Retornar_Resultado_Correto()
            {
                var resultado = _calculadora.Subtrair(10, 5);

                Assert.That(resultado, Is.EqualTo(5));
            }

            #endregion

            #region Multiplicação

            [Test]
            public void Multiplicar_Deve_Retornar_Resultado_Correto()
            {
                var resultado = _calculadora.Multiplicar(10, 5);

                Assert.That(resultado, Is.EqualTo(50));
            }

            #endregion

            #region Divisão

            [Test]
            public void Dividir_Deve_Retornar_Resultado_Correto()
            {
                var resultado = _calculadora.Dividir(10, 2);

                Assert.That(resultado, Is.EqualTo(5));
            }

            [Test]
            public void Dividir_Deve_Lancar_Excecao_Quando_Dividir_Por_Zero()
            {
                Assert.Throws<DivideByZeroException>(() =>
                    _calculadora.Dividir(10, 0));
            }

            #endregion
        }
    }

