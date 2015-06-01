using NUnit.Framework;
using StudyTdd.CarrinhoDeCompra;

namespace StudyTddTest.CarrinhoDeCompra
{
    [TestFixture]
    public class TestMaiorPreco
    {
        private CarrinhoDeCompras carrinho;

        [SetUp]
        public void Inicialize()
        {
            this.carrinho = new CarrinhoDeCompras();
        }

        [Test]
        public void DeveRetornaVazioSeCarrinhoVazio()
        {
            Assert.AreEqual(0.0, carrinho.MaiorValor(), 0.00001);
        }

        [Test]
        public void DeveRetornarValorDoItemSeCarrinhoCom1Elemento()
        {
            carrinho.Adiciona(new Item("Fogão", 1, 500.0));

            Assert.AreEqual(500.0, carrinho.MaiorValor(), 0.00001);
        }

        [Test]
        public void DeveRetornarMaiorValorSeCarrinhoContemMuitosElementos()
        {
            carrinho.Adiciona(new Item("Fogão", 1, 500.0));
            carrinho.Adiciona(new Item("Geladeira", 1, 1500.0));
            carrinho.Adiciona(new Item("Tv Led", 1, 750.0));

            Assert.AreEqual(1500.0, carrinho.MaiorValor(), 0.00001);
        }
    }
}
