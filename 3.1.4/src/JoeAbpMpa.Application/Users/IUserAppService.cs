using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using JoeAbpMpa.Roles.Dto;
using JoeAbpMpa.Users.Dto;

namespace JoeAbpMpa.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}