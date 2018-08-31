using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using OneForm.SharedData.Entities;

namespace OneForm.SharedData.Repos
{
    public interface IBaseRepo<TEntity> where TEntity : BaseEntity
    {
        Task<TEntity> GetById(int id);

        Task Update(TEntity entity);

        Task Add(TEntity entity);

        Task Remove(TEntity entity);
    }
}