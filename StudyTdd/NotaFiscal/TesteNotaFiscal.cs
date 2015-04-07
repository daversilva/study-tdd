
using Moq;
using NUnit.Framework;

namespace StudyTdd.NotaFiscal
{
    public class TesteNotaFiscal
    {
        [Test]
        public void DeveGerarNFComValorDeImpostoDescontado()
        {
            GeradorDeNotaFiscal gerador = new GeradorDeNotaFiscal();

            Pedido pedido = new Pedido("Mauricio", 1000, 1);

            NotaFiscal nf = gerador.Gera(pedido);

            Assert.AreEqual(1000 * 0.94, nf.Valor, 0.0001);
        }

        [Test]
        public void DevePersistirNFGerada()
        {
            var dao = new Mock<NfDao>();

            GeradorDeNotaFiscal gerador = new GeradorDeNotaFiscal(dao.Object);

            Pedido pedido = new Pedido("Mauricio", 1000, 1);

            NotaFiscal nf = gerador.Gera(pedido);

            //dao.Verify(t => t.Persiste(nf));

            dao.VerifyAll();

        }

        [Test]
        public void DeveEnviarNFGeradaParaSAP()
        {
            var dao = new Mock<NfDao>();

            var sap = new Mock<Sap>();

            GeradorDeNotaFiscal gerador = new GeradorDeNotaFiscal(dao.Object, sap.Object);

            Pedido pedido = new Pedido("Mauricio", 1000, 1);

            NotaFiscal nf = gerador.Gera(pedido);

            //sap.Verify(t => t.Envia(nf));

            dao.VerifyAll();

        }
    }
}
