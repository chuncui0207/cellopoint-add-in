using System.Collections.Generic;
using CellopointAddin.Roles.Dto;

namespace CellopointAddin.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}