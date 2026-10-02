using Auren.Api.Db.UnitOfWork;
using Auren.Api.Dto;
using Auren.Api.Model;
using AutoMapper;
using MediatR;

namespace Auren.Api.Business.Finance.BankAccount.Command
{
    public class CreateBankAccountCommand : BankAccountInput, IRequest
    {
    }

    public class CreateBankAccountCommandHandler : IRequestHandler<CreateBankAccountCommand>
    {
        readonly IMapper _mapper;
        readonly IAurenApiUnitOfWork _unitOfWork;
        public CreateBankAccountCommandHandler(
            IAurenApiUnitOfWork unitOfWork,
            IMapper mapper)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }
        public async Task Handle(CreateBankAccountCommand request, CancellationToken cancellationToken)
        {
            var data = _mapper.Map<BankAccountDao>(request);
            await _unitOfWork.BankAccountRepository.AddAndSaveAsync(data);
        }
    }
}