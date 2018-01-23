using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JoeAbpMpa.Entities
{
    class Asset : Entity<string>
    {
        //64kb
        public const int MaxDescriptionLength = 64 * 1024;

        [Column("AssetNo")]
        public override string Id { get => base.Id; set => base.Id = value; }

        [MaxLength(MaxDescriptionLength)]
        public virtual string AssetDescription { get; set; }

        [Required]
        public string DeviceId { get; set; }

        public int AssetCategoryId { get; set; }

        public int AssetStatusId { get; set; }

        public DateTime DateAcquired { get; set; }

        public DateTime DateUsed { get; set; }

        public int DeptId { get; set; }

        public int TennatUserId { get; set; }

        public string Remark { get; set; }
    }
}
