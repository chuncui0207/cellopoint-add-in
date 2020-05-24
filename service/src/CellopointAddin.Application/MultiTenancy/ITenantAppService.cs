using Abp.Application.Services;
using CellopointAddin.MultiTenancy.Dto;

namespace CellopointAddin.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

