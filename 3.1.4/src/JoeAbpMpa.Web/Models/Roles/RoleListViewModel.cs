using System.Collections.Generic;
using JoeAbpMpa.Roles.Dto;

namespace JoeAbpMpa.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}