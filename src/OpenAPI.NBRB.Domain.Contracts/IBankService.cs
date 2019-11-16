using System.Collections.Generic;
using System.Threading.Tasks;
using OpenAPI.NBRB.Domain.Contracts.ViewModels;

namespace OpenAPI.NBRB.Domain.Contracts
{
    public interface IBankService
    {
        Task<IEnumerable<BankViewModel>> GetBanksAsync();
    }
}
