using EFMVC05.Models;
using System.Data.Entity;

namespace EFMVC05.Infrastructure
{
    public abstract class RepositoryBase<T> where T : class
    {
        private EFMVCContext dataContext;
        private readonly IDbSet<T> dbset;
        protected RepositoryBase(IDatabaseFactory databaseFactory)
        {

        }
    }
}