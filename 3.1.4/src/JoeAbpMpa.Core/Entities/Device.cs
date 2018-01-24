using Abp.Domain.Entities;

namespace JoeAbpMpa.Entities
{
    public class Device : Entity<string>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string Manufacturer { get; set; }
    }
}
