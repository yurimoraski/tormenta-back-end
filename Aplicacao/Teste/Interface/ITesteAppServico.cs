using DataTransfer.Teste.Request;
using DataTransfer.Teste.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicacao.Teste.Interface
{
    public interface ITesteAppServico
    {
        TesteResponse TesteDoAppServico(TesteRequest testeRequest);
    }
}
