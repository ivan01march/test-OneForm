using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using OneForm.SharedData.Context;
using OneForm.SharedData.Entities;

namespace OneForm.SharedData.RepoInterfaces
{
    public interface IRepo<TEntity> where TEntity : BaseEntity
    {
        Task<IEnumerable<TEntity>> GetList<TKey>(
            Expression<Func<TEntity, bool>> filter,
            Expression<Func<TEntity, TKey>> sort, bool isDescending,
            int page, int limit);

        Task<IEnumerable<TDto>> GetList<TDto, TKey>(
            Expression<Func<TEntity, bool>> filter,
            Expression<Func<TEntity, TKey>> sort, bool isDescending,
            int page, int limit) where TDto : IDto<TEntity>, new();

        Task Update(TEntity entity);

        Task Add(TEntity entity);
    }
}