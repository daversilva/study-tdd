using System.Collections.Generic;
using Moq;
using NUnit.Framework;
using StudyTdd.NotaFiscal;

namespace StudyTddTest.NotaFiscal
{
    public class TesteNotaFiscal
    {
        [Test]
        public void DeveGerarNfComValorDeImpostoDescontado()
        {
            var acao1 = new Mock<IAcaoAposGerarNota>();
            var acao2 = new Mock<IAcaoAposGerarNota>();
            var acoes = new List<IAcaoAposGerarNota>() { acao1.Object, acao2.Object };

            var gerador = new GeradorDeNotaFiscal(acoes);
            var pedido = new Pedido("Mauricio", 1000, 1);
            var nf = gerador.Gera(pedido);

            Assert.AreEqual(1000 * 0.94, nf.Valor, 0.0001);
        }

        [Test]
        public void DevePersistirNfGerada()
        {
            var acao1 = new Mock<IAcaoAposGerarNota>();
            var acao2 = new Mock<IAcaoAposGerarNota>();
            var acoes = new List<IAcaoAposGerarNota>() {acao1.Object, acao2.Object};

            var dao = new Mock<NfDao>();
            var gerador = new GeradorDeNotaFiscal(acoes);
            var pedido = new Pedido("Mauricio", 1000, 1);

            gerador.Gera(pedido);

            dao.VerifyAll();
        }

        [Test]
        public void DeveInvocarAcoesPosteriores()
        {
            var acao1 = new Mock<IAcaoAposGerarNota>();
            var acao2 = new Mock<IAcaoAposGerarNota>();

            var acoes = new List<IAcaoAposGerarNota>() 
                            {   acao1.Object, 
                                acao2.Object 
                            };

            var gerador = new GeradorDeNotaFiscal(acoes);
            var pedido = new Pedido("Mauricio", 1000, 1);
            var nf = gerador.Gera(pedido);

            acao1.Verify(a => a.Executa(nf));
            acao2.Verify(a => a.Executa(nf));
        }
    }
}
