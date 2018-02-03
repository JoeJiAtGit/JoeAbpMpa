namespace JoeAbpMpa.Assets.Dto
{
    public class UpdateAssetInput
    {
        public int AssetId { get; internal set; }
        public int? AssetCategoryId { get; internal set; }
        public int? DeviceId { get; internal set; }
    }
}