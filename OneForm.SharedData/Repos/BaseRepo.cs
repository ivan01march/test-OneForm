using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OneForm.SharedData.Entities;

namespace OneForm.SharedData.Repos
{
    public class BaseRepo<TEntity> : IBaseRepo<TEntity>
        where TEntity : BaseEntity
    {
        protected readonly OneFormContext Context;
        protected readonly DbSet<TEntity> Repo;

        public BaseRepo(OneFormContext context)
        {
            Context = context;
            Repo = context.Set<TEntity>();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await Repo.FindAsync(id);
        }

        public async Task Add(TEntity entity)
        {
            entity.CreatedDate = DateTime.Now;
            entity.UpdatedDate = DateTime.Now;
            await Repo.AddAsync(entity);
            await Context.SaveChangesAsync();
        }

        public async Task Update(TEntity entity)
        {
            entity.UpdatedDate = DateTime.Now;
            Repo.Update(entity);
            await Context.SaveChangesAsync();
        }

        public async Task Remove(TEntity entity)
        {
            Repo.Remove(entity);
            await Context.SaveChangesAsync();
        }
    }
}