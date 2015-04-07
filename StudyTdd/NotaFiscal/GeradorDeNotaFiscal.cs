using System;

namespace StudyTdd.NotaFiscal
{
    class GeradorDeNotaFiscal
    {
        private NfDao Dao;
        private Sap Sap;

        public GeradorDeNotaFiscal(NfDao dao)
        {
            Dao = dao;
        }

        public GeradorDeNotaFiscal()
        {

        }

        public GeradorDeNotaFiscal(NfDao dao, Sap sap)
        {
            this.Dao = dao;
            this.Sap = sap;
        }

        public NotaFiscal Gera(Pedido pedido)
        {
            var notaFiscal = new NotaFiscal(
                pedido.Cliente,
                pedido.ValorTotal * 0.94,
                DateTime.Now);

            new NfDao().Persiste(notaFiscal);

            return notaFiscal;
        }
    }
}
