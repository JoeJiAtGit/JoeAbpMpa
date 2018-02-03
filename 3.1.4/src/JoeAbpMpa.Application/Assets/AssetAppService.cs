using JoeAbpMpa.Assets.Dto;
using JoeAbpMpa.IRepositories;
using System.Collections.Generic;
using System.Threading.Tasks;
using JoeAbpMpa.Entities;
using Abp.Domain.Repositories;
using System;
using AutoMapper;
using System.Linq;

namespace JoeAbpMpa.Assets
{
    public class AssetAppService : JoeAbpMpaAppServiceBase, IAssetAppService
    {
        private IAssetRepository _assetRepository;
        private IRepository<AssetCategory> _categoryRepository;
        private IRepository<Device> _deviceRepository;

        public AssetAppService(IAssetRepository assetRepository, IRepository<AssetCategory> categoryRepository, IRepository<Device> deviceRepository)
        {
            _assetRepository = assetRepository;
            _categoryRepository = categoryRepository;
            _deviceRepository = deviceRepository;
        }

        public void CreateAsset(CreateAssetInput input)
        {
            //We can use Logger, it's defined in ApplicationService class.
            Logger.Info("Creating a Asset for input: " + input);

            //Creating a new Asset entity with given input's properties
            var asset = new Asset()
            {
                AssetNo = input.AssetNo,
                Description = input.Description,
                Device = _deviceRepository.Load(input.DeviceId.Value),
            };

            if (input.AssetCategoryId.HasValue)
            {
                asset.AssetCategory = _categoryRepository.Load(input.AssetCategoryId.Value);
            }

            _assetRepository.Insert(asset);
        }

        public void DeleteAsset(int assetId)
        {
            _assetRepository.Delete(assetId);
        }

        public IList<AssetDto> GetAllAssets()
        {
            var assets = _assetRepository.GetAll();
            return Mapper.Map<List<AssetDto>>(assets);
        }

        public AssetDto GetAssetById(int assetId)
        {
            var asset = _assetRepository.Get(assetId);
            return Mapper.Map<AssetDto>(asset);
        }

        public async Task<AssetDto> GetAssetByIdAsync(int assetId)
        {
            var asset = await _assetRepository.GetAsync(assetId);
            return Mapper.Map<AssetDto>(asset);
        }

        public GetAssetOutput GetAssets(GetAssetInput input)
        {
            var query = _assetRepository.GetAll();

            if (!string.IsNullOrEmpty(input.AssetNo))
            {
                query = query.Where(q => string.Equals(q.AssetNo, input.AssetNo));
            }

            return new GetAssetOutput
            {
                Assets = Mapper.Map<List<AssetDto>>(query)
            };
        }

        public void UpdateAsset(UpdateAssetInput input)
        {
            var asset = _assetRepository.Get(input.AssetId);

            if (input.AssetCategoryId.HasValue)
            {
                asset.AssetCategory = _categoryRepository.Load(input.AssetCategoryId.Value);
            }

            if (input.DeviceId.HasValue)
            {
                asset.Device = _deviceRepository.Load(input.DeviceId.Value);
            }
        }
    }
}
