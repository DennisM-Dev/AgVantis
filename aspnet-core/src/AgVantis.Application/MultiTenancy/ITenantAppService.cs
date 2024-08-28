using Abp.Application.Services;
using AgVantis.MultiTenancy.Dto;

namespace AgVantis.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

