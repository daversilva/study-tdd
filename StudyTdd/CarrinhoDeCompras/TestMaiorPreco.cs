using NUnit.Framework;

namespace StudyTdd.CarrinhoDeCompras
{
    [TestFixture]
    public class TestMaiorPreco
    {
        [Test]
        public void DeveRetornaVazioSeCarrinhoVazio()
        {
            CarrinhoDeCompras carrinho = new CarrinhoDeCompras();

            Assert.AreEqual(0.0, carrinho.MaiorValor(), 0.00001);
        }

        [Test]
        public void DeveRetornarValorDoItemSeCarrinhoCom1Elemento()
        {
            CarrinhoDeCompras carrinho = new CarrinhoDeCompras();
            carrinho.Adiciona(new Item("Fogão", 1, 500.0));

            Assert.AreEqual(500.0, carrinho.MaiorValor(), 0.00001);
        }

        [Test]
        public void DeveRetornarMaiorValorSeCarrinhoContemMuitosElementos()
        {
            CarrinhoDeCompras carrinho = new CarrinhoDeCompras();
            carrinho.Adiciona(new Item("Fogão", 1, 500.0));
            carrinho.Adiciona(new Item("Geladeira", 1, 1500.0));
            carrinho.Adiciona(new Item("Tv Led", 1, 750.0));

            Assert.AreEqual(1500.0, carrinho.MaiorValor(), 0.00001);
        }
    }
}
