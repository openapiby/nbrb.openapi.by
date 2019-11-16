using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using OpenAPI.NBRB.Data.Contracts;
using OpenAPI.NBRB.Domain.Contracts;
using OpenAPI.NBRB.Domain.Contracts.ViewModels;

namespace OpenAPI.NBRB.Domain.Services
{
    public class BankService : IBankService
    {
        private readonly IBankRepository _bankRepository;
        private readonly IMapper _mapper;
        public BankService(IBankRepository bankRepository, IMapper mapper)
        {
            _bankRepository = bankRepository;
            _mapper = mapper;
        }

        public Task<IEnumerable<BankViewModel>> GetBanksAsync()
        {
            var banks = _bankRepository.GetAll();

            var result = _mapper.Map<IEnumerable<BankViewModel>>(banks);

            return Task.FromResult(result);
        }
    }
}
