using System.Threading.Tasks;
using Abp.Application.Services;
using CellopointAddin.Sessions.Dto;

namespace CellopointAddin.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
