using Abp.Domain.Entities;

namespace JoeAbpMpa.Entities
{
    public class AssetCategory : Entity
    {
        public string Category { get; set; }

        public string Description { get; set; }
    }
}
