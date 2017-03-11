using Dork.Dal.Core;
using Dork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dork.Services.Core.Queries
{
    public class EntityQueries<T> : IEntityQueries<T> where T : IEntity
    {
        public readonly IRepository<T> Repo;
        
        public EntityQueries(IRepository<T> repo)
        {
            Repo = repo;
        }
        
        public async Task<EntityResponse<IEnumerable<T>>> GetAllAsync()
        {
            return await Repo.GetAllAsync();
        }

        public async Task<EntityResponse<T>> GetByIdAsync(string id)
        {
            return await Repo.GetByIdAsync(id);
        }

        public async Task<EntityResponse<T>> SaveElementAsync(T entity)
        {
            return await Repo.SaveAsync(entity);
        }

        public async Task<EntityResponse<T>> DeleteElementAsync(string id)
        {
            return await Repo.DeleteAsync(id);
        }
    }
}
