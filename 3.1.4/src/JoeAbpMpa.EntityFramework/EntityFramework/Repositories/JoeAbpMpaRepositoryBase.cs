using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace JoeAbpMpa.EntityFramework.Repositories
{
    public abstract class JoeAbpMpaRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<JoeAbpMpaDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected JoeAbpMpaRepositoryBase(IDbContextProvider<JoeAbpMpaDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class JoeAbpMpaRepositoryBase<TEntity> : JoeAbpMpaRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected JoeAbpMpaRepositoryBase(IDbContextProvider<JoeAbpMpaDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
