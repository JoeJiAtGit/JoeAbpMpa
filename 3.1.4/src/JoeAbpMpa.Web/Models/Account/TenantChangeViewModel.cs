using Abp.AutoMapper;
using JoeAbpMpa.Sessions.Dto;

namespace JoeAbpMpa.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}