using Aplicacao.Teste.Interface;
using AutoMapper;
using DataTransfer.Teste.Request;
using DataTransfer.Teste.Response;
using Dominio.Teste.Servico.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicacao.Servico.Teste
{
    public class TesteAppServico : ITesteAppServico
    {
        private readonly ITesteServico testeServico;

        public TesteAppServico(ITesteServico testeServico)
        {
            this.testeServico = testeServico;
        }

        public TesteResponse TesteDoAppServico(TesteRequest testeRequest)
        {
            return testeServico.TesteDoServico(testeRequest);
        }
    }
}
