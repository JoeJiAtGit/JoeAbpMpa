using Abp.Application.Services.Dto;

namespace JoeAbpMpa.Assets.Dto
{
    public class AssetDto : EntityDto
    {
        public string AssetNo { get;  set; }

        public string Description { get;  set; }
               
        public string DeviceId { get; set; }

        public int AssetCategoryId { get; set; }
    }
}