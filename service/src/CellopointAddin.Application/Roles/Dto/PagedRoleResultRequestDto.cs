using Abp.Application.Services.Dto;

namespace CellopointAddin.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

