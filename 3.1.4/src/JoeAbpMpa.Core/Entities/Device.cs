using Abp.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace JoeAbpMpa.Entities
{
    public class Device : Entity
    {
        [Required]
        public string DeviceNo { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Manufacturer { get; set; }
    }
}
