using AutoMapper;
using DataTransfer.Teste.Request;
using DataTransfer.Teste.Response;
using Dominio.Teste.Entidade;
using Dominio.Teste.Servico.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Teste.Servico
{
    public class TesteServico : ITesteServico
    {
        private readonly IMapper mapper;

        public TesteServico(IMapper mapper)
        {
            this.mapper = mapper;
        }

        public TesteResponse TesteDoServico(TesteRequest testeRequest)
        {
            TesteEntidade testeEntidade = mapper.Map<TesteEntidade>(testeRequest);
            return mapper.Map<TesteResponse>(testeEntidade);
        }
    }
}
