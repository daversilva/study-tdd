using System;

namespace StudyTdd.NotaFiscal
{
    public class RelogioDoSistema : IRelogio
    {
        public DateTime Hoje()
        {
            return DateTime.Now;
        }
    }
}
