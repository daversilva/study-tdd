
using System.Collections.Generic;
using Moq;
using NUnit.Framework;

namespace StudyTdd.NotaFiscal
{
    public class TesteNotaFiscal
    {
        [Test]
        public void DeveGerarNfComValorDeImpostoDescontado()
        {
            GeradorDeNotaFiscal gerador = new GeradorDeNotaFiscal();

            Pedido pedido = new Pedido("Mauricio", 1000, 1);

            NotaFiscal nf = gerador.Gera(pedido);

            Assert.AreEqual(1000 * 0.94, nf.Valor, 0.0001);
        }

        [Test]
        public void DevePersistirNfGerada()
        {
            var dao = new Mock<NfDao>();

            GeradorDeNotaFiscal gerador = new GeradorDeNotaFiscal(dao.Object);

            Pedido pedido = new Pedido("Mauricio", 1000, 1);

            NotaFiscal nf = gerador.Gera(pedido);

            //dao.Verify(t => t.Persiste(nf));

            dao.VerifyAll();
        }

        [Test]
        public void DeveInvocarAcoesPosteriores()
        {
            var acao1 = new Mock<IAcaoAposGerarNota>();
            var acao2 = new Mock<IAcaoAposGerarNota>();

            IList<IAcaoAposGerarNota> acoes = new List<IAcaoAposGerarNota>() 
            {   acao1.Object, 
                acao2.Object };

            GeradorDeNotaFiscal gerador = new GeradorDeNotaFiscal(acoes);

            Pedido pedido = new Pedido("Mauricio", 1000, 1);

            NotaFiscal nf = gerador.Gera(pedido);

            acao1.Verify(a => a.Executa(nf));
            acao2.Verify(a => a.Executa(nf));
        }
    }
}
