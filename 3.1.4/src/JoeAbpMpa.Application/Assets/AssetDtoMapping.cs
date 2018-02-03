using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using JoeAbpMpa.Assets.Dto;
using JoeAbpMpa.Entities;

namespace JoeAbpMpa.Assets
{
    public class AssetDtoMapping : IDtoMapping
    {
        public void CreateMapping(IMapperConfigurationExpression mapperConfig)
        {
            //mapperConfig.CreateMap<GetAssetOutput, Asset>();
            //I specified mapping for AssignedPersonId since NHibernate does not fill Task.AssignedPersonId
            //If you will just use EF, then you can remove ForMember definition.
            mapperConfig.CreateMap<Asset, AssetDto>().ForMember(s => s.AssetCategoryId, opts => opts.MapFrom(d => d.AssetCategory.Id));
            mapperConfig.CreateMap<Asset, AssetDto>().ForMember(s => s.DeviceId, opts => opts.MapFrom(d => d.Device.Id));
        }
    }
}
