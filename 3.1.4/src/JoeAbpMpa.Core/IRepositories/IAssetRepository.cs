using Abp.Domain.Repositories;
using JoeAbpMpa.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoeAbpMpa.IRepositories
{
    /// <summary>
    /// Defines a repository to perform database operations for <see cref="Asset"/> Entities.
    /// 
    /// Extends <see cref="IRepository{TEntity, TPrimaryKey}"/> to inherit base repository functionality. 
    /// </summary>
    public interface IAssetRepository : IRepository<Asset>
    {

    }
}
