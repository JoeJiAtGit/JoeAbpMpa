using Abp.Domain.Entities;

namespace JoeAbpMpa.Entities
{
    public class AssetStatus : Entity
    {
        public virtual string Status { get; set; }

        public virtual string Description { get; set; }
    }
}