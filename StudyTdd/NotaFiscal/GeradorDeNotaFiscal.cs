using System;
using System.Collections.Generic;

namespace StudyTdd.NotaFiscal
{
    class GeradorDeNotaFiscal
    {
        private NfDao _dao;

        private Sap _sap;

        private readonly IList<IAcaoAposGerarNota> _acoes;

        private IRelogio _relogio;

        // construtor sem Relogio para não
        // quebrar o resto do sistema
        public GeradorDeNotaFiscal(IList<IAcaoAposGerarNota> acoes) :
            this(acoes, new RelogioDoSistema())
        { }

        public GeradorDeNotaFiscal(IList<IAcaoAposGerarNota> acoes, IRelogio relogio)
        {
            this._acoes = acoes;
            this._relogio = relogio;
        }

        public GeradorDeNotaFiscal(NfDao dao)
        {
            _dao = dao;
        }

        public GeradorDeNotaFiscal()
        {

        }

        public GeradorDeNotaFiscal(NfDao dao, Sap sap)
        {
            this._dao = dao;
            this._sap = sap;
        }

        public NotaFiscal Gera(Pedido pedido)
        {
            var notaFiscal = new NotaFiscal(
                pedido.Cliente,
                pedido.ValorTotal * 0.94,
                DateTime.Now);

            foreach (var acao in _acoes)
            {
                acao.Executa(notaFiscal);
            }

            return notaFiscal;
        }
    }
}
