using System.Threading.Tasks;
using Abp.Application.Services;
using JoeAbpMpa.Authorization.Accounts.Dto;

namespace JoeAbpMpa.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
