using Auren.Api.Dto;
using Auren.Api.Model;
using AutoMapper;

namespace Auren.Api.Business
{
    public class ApiProfile : Profile
    {
        public ApiProfile()
        {
            CreateMap<BankAccountInput, BankAccountDao>();
            CreateMap<BankAccountDao, BankAccountReponse>();
        }
    }
}