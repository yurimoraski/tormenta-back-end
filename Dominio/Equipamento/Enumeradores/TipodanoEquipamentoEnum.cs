using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Dominio.Equipamento.Enumeradores
{
    public enum TipodanoEquipamentoEnum
    {
        [Description("Corte")]
        Corte,
        Perfuracao,
        Esmagamento,
        Fogo,
        Trovao,
        Luz,
        Acido,
        Outro
    }
}
