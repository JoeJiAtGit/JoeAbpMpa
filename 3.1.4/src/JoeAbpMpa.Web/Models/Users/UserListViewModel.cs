using System.Collections.Generic;
using JoeAbpMpa.Roles.Dto;
using JoeAbpMpa.Users.Dto;

namespace JoeAbpMpa.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}