using System.Threading.Tasks;
using Abp.Application.Services;
using AgVantis.Authorization.Accounts.Dto;

namespace AgVantis.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
