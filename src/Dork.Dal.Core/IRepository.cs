using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Dork.Models;

namespace Dork.Dal.Core
{
    public interface IRepository<T> : IQueryable<T>, IRepository where T : IEntity<string>
    {
        
        Task<EntityResponse<IEnumerable<T>>> GetAllAsync();
        Task<EntityResponse<IEnumerable<T>>> GetAllAsync(Expression<Func<T, bool>> condition);

        Task<EntityResponse<T>> GetByIdAsync(string id);

        Task<EntityResponse<T>> SaveAsync(T entity);
        Task<EntityResponse<T>> SaveAsync(IEnumerable<T> entities);

        Task<EntityResponse<T>> DeleteAsync(string id);
        Task<EntityResponse<T>> DeleteAsync(T entity);
        Task<EntityResponse<T>> DeleteAllAsync();

        Task<EntityResponse<T>> CountAsync();
    }

    public interface IRepository { }
}
