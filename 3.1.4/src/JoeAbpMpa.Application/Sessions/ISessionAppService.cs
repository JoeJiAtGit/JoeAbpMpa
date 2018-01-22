using System.Threading.Tasks;
using Abp.Application.Services;
using JoeAbpMpa.Sessions.Dto;

namespace JoeAbpMpa.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
