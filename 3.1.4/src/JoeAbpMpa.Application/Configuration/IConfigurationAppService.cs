using System.Threading.Tasks;
using Abp.Application.Services;
using JoeAbpMpa.Configuration.Dto;

namespace JoeAbpMpa.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}