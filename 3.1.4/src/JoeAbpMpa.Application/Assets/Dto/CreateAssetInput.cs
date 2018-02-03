namespace JoeAbpMpa.Assets.Dto
{
    public class CreateAssetInput
    {
        public string AssetNo { get; internal set; }

        public string Description { get; internal set; }

        public int? AssetCategoryId { get; internal set; }

        public int? DeviceId { get; internal set; }
    }
}