using System.Collections.Generic;
using CellopointAddin.Roles.Dto;

namespace CellopointAddin.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
