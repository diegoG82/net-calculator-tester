using net_calculator_tester;
using NUnit.Framework.Internal;

namespace CalcolatriceTester
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Test eseguito!");
        }

        [Test]
        public void Test_somma_con_risultato()
        {
            double risultato = Calcolatrice.Somma(5, 5);
            Assert.AreEqual(10, risultato);
        }

        [Test]
        public void Test_sottrazione_con_risultato()
        {
            double risultato = Calcolatrice.Sottrazione(5, 5);
            Assert.AreEqual(0, risultato);
        }

        [Test]
        public void Test_moltiplicazione_con_risultato()
        {
            double risultato = Calcolatrice.Moltiplicazione(5, 5);
            Assert.AreEqual(25, risultato);
        }

        [Test]
        public void Test_divisione_con_risultato()
        {
            double risultato = Calcolatrice.Divisione(5, 5);
            Assert.AreEqual(1, risultato);
        }


    }
}
