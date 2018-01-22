using Abp.Authorization;
using JoeAbpMpa.Authorization.Roles;
using JoeAbpMpa.Authorization.Users;

namespace JoeAbpMpa.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
