using AutoMapper;
using DataTransfer.Teste.Request;
using DataTransfer.Teste.Response;
using Dominio.Teste.Entidade;

public class TesteProfile : Profile
{
    public TesteProfile()
    {
        CreateMap<TesteRequest, TesteEntidade>().ReverseMap();
        CreateMap<TesteEntidade, TesteResponse>().ReverseMap();

    }
}