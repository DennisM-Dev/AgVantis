using System.Threading.Tasks;
using Abp.Application.Services;
using AgVantis.Sessions.Dto;

namespace AgVantis.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
