using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using JoeAbpMpa.Authorization.Users;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JoeAbpMpa.Entities
{
    /// <summary>
    /// Represents an Asset entity.
    /// </summary>
    public class Asset : Entity
    {
        //64kb
        public const int MaxDescriptionLength = 64 * 1024;

        [Required]
        public string AssetNo { get; set; }

        /// <summary>
        /// Describes the asset.
        /// </summary>
        [MaxLength(MaxDescriptionLength)]
        public virtual string Description { get; set; }

        /// <summary>
        /// Database field for Device reference.
        /// Needed for EntityFramework, no need for NHibernate.
        /// </summary>
        [Required]
        public virtual int DeviceId { get; set; }

        /// <summary>
        /// Database field for AssetCategory reference.
        /// Needed for EntityFramework, no need for NHibernate.
        /// </summary>
        public virtual int AssetCategoryId { get; set; }

        /// <summary>
        /// Database field for AssetStatus reference.
        /// Needed for EntityFramework, no need for NHibernate.
        /// </summary>
        public virtual int AssetStatusId { get; set; }

        /// <summary>
        /// The time when this asset is acquired.
        /// </summary>
        public virtual DateTime DateAcquired { get; set; }

        /// <summary>
        /// The time when this asset is used.
        /// </summary>
        public virtual DateTime DateUsed { get; set; }

        /// <summary>
        /// Database field for department reference.
        /// Needed for EntityFramework, no need for NHibernate.
        /// </summary>
        public virtual int DepartmentId { get; set; }

        /// <summary>
        /// Database field for AssignedPerson reference.
        /// Needed for EntityFramework, no need for NHibernate.
        /// </summary>
        public virtual int UserId { get; set; }

        /// <summary>
        /// Remark
        /// </summary>
        public virtual string Remark { get; set; }

        /// <summary>
        /// A reference (navigation property) to device <see cref="Device"/> for this asset.
        /// We declare <see cref="ForeignKeyAttribute"/> for EntityFramework here. No need for NHibernate.
        /// </summary>
        public virtual Device Device { get; set; }

        public virtual AssetCategory AssetCategory { get; set; }

        public virtual AssetStatus AssetStatus { get; set; }

        public virtual Department Department { get; set; }

        public virtual User User { get; set; }
    }
}
