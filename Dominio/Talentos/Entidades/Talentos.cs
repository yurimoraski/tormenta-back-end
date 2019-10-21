using Dominio.Talentos.Enumeradores;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Talentos.Entidades
{
    public class Talentos
    {
        public int Id { get; set; }
        public TipoTalentoEnum Tipo { get; set; }
        public string Nome { get; set; }
        public string PreRequisito { get; set; }
        public string Descricao { get; set; }
    }
}
