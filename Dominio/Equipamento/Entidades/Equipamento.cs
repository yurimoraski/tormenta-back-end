using Dominio.Equipamento.Enumeradores;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Equipamento.Entidade
{
    public class Equipamento
    {
        public long Id { get; set; }
        public TipoEquipamentoEnum Tipo { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Peso { get; set; }
        public decimal Preco { get; set; }
        public AlcanceEquipamentoEnum Alcance { get; set; }
        public TamanhoEquipamentoEnum Tamanho { get; set; }
        public string Dano { get; set; }
        public TipodanoEquipamentoEnum TipoDano { get; set; }
        public string Critico { get; set; }
        public long ClasseArmadura { get; set; }
        public long PenalidadeArmadura { get; set; }
    }
}
