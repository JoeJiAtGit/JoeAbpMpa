using Abp.Application.Services;
using JoeAbpMpa.Assets.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JoeAbpMpa.Assets
{
    public interface IAssetAppService : IApplicationService
    {
        GetAssetOutput GetAssets(GetAssetInput input);

        void UpdateAsset(UpdateAssetInput input);

        void CreateAsset(CreateAssetInput input);

        AssetDto GetAssetById(int assetId);

        Task<AssetDto> GetAssetByIdAsync(int assetId);

        void DeleteAsset(int assetId);

        IList<AssetDto> GetAllAssets();
    }
}
