using Abp.Authorization;
using AgVantis.Authorization.Roles;
using AgVantis.Authorization.Users;

namespace AgVantis.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
