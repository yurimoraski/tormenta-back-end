using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Deuses.Entidades
{
    public class Deuses
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string PreRequisito { get; set; } //Classes e Raças permitidas
        public string Simbolo { get; set; }
        public string Arma { get; set; }
        public string ObrigacoesEretricoes { get; set; }
        public string Poderes { get; set; }
    }
}
