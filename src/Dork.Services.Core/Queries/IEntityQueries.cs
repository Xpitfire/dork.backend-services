using Dork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dork.Services.Core.Queries
{
    public interface IEntityQueries<T> where T : IEntity
    {
        Task<EntityResponse<IEnumerable<T>>> GetAllAsync();
        Task<EntityResponse<T>> GetByIdAsync(string id);

        Task<EntityResponse<T>> SaveElementAsync(T entity);

        Task<EntityResponse<T>> DeleteElementAsync(string id);
    }
}
