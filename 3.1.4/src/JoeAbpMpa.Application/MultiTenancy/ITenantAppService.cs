using Abp.Application.Services;
using Abp.Application.Services.Dto;
using JoeAbpMpa.MultiTenancy.Dto;

namespace JoeAbpMpa.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
