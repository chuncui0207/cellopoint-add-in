using Abp.Authorization;
using CellopointAddin.Authorization.Roles;
using CellopointAddin.Authorization.Users;

namespace CellopointAddin.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
