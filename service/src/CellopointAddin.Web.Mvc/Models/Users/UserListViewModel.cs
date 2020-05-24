using System.Collections.Generic;
using CellopointAddin.Roles.Dto;

namespace CellopointAddin.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
