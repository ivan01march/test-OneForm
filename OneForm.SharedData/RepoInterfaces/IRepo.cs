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
        Task<IEnumerable<Country>> GetList(Expression<Func<Country, bool>> filter, int page, int limit);

        Task<IEnumerable<Country>> GetList<TDto>(
            Expression<Func<Country, bool>> filter, TDto dto, int page, int limit) where TDto : ITDto<TEntity>, new();

        Task Add(Country country);
    }
}