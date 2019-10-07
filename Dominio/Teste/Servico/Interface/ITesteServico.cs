using DataTransfer.Teste.Request;
using DataTransfer.Teste.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Teste.Servico.Interface
{
    public interface ITesteServico
    {
        TesteResponse TesteDoServico(TesteRequest testeRequest);
    }
}
