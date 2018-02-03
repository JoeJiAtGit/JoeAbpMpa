using Abp.EntityFramework;
using JoeAbpMpa.Entities;
using JoeAbpMpa.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoeAbpMpa.EntityFramework.Repositories
{
    public class AssetRepository : JoeAbpMpaRepositoryBase<Asset>, IAssetRepository
    {
        public AssetRepository(IDbContextProvider<JoeAbpMpaDbContext> dbContextProvider) : base(dbContextProvider)
        {

        }
        //TODO: Implement interface
    }
}
