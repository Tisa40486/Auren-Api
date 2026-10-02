using Auren.Api.Db.UnitOfWork;
using Auren.Api.Dto;
using AutoMapper;
using MediatR;

namespace Auren.Api.Business.Finance.BankAccount.Query
{
    public class GetAllBankAccountQuery : IRequest<List<BankAccountReponse?>>
    {
    }
    public class GetAllBankAccountQueryHandler : IRequestHandler<GetAllBankAccountQuery, List<BankAccountReponse?>>
    {
        readonly IAurenApiUnitOfWork _unitOfWork;
        readonly IMapper _mapper;
        public GetAllBankAccountQueryHandler(
            IAurenApiUnitOfWork unitOfWork, 
            IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<List<BankAccountReponse?>> Handle(GetAllBankAccountQuery request, CancellationToken cancellationToken)
        {
            var data = await _unitOfWork.BankAccountRepository.GetAllAsync();
            
           var result = _mapper.Map<List<BankAccountReponse?>>(data);

            return result;
        }
    }   
}
