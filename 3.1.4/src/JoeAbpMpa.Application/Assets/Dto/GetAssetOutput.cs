using System.Collections.Generic;

namespace JoeAbpMpa.Assets.Dto
{
    public class GetAssetOutput
    {
        public List<AssetDto> Assets { get; internal set; }
    }
}