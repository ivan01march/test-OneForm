using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OneForm.SharedData.Context;
using OneForm.SharedData.Entities;
using OneForm.SharedData.RepoInterfaces;

namespace EntityFrameworkProvider.Repos
{
    public class BaseRepo<TEntity> : IRepo<TEntity>
        where TEntity : BaseEntity
    {
        private readonly OneFormContext _context;
        protected readonly DbSet<TEntity> _repo;

        public BaseRepo(OneFormContext context)
        {
            _context = context;
            _repo = context.Set<TEntity>();
        }

        public async Task<IEnumerable<TEntity>> GetList<TKey>(
            Expression<Func<TEntity, bool>> filter,
            Expression<Func<TEntity, TKey>> sort, bool isDescending,
            int page, int limit)
        {
            var query = _repo
                .Where(filter);
            query = isDescending ? query.OrderByDescending(sort) : query.OrderBy(sort);
            return await query.ToListAsync();
        }

        public async Task<IEnumerable<TDto>> GetList<TDto, TKey>(
            Expression<Func<TEntity, bool>> filter,
            Expression<Func<TEntity, TKey>> sort, bool isDescending,
            int page, int limit) where TDto : IDto<TEntity>, new()
        {
            var query = _repo
                .Where(filter);
            query = isDescending ? query.OrderByDescending(sort) : query.OrderBy(sort);
            return await query
                .Select(x => (TDto) new TDto().FromEntity(x))
                .ToListAsync();
        }

        public async Task Add(TEntity entity)
        {
            await _repo.AddAsync(entity);
        }

        public async Task Update(TEntity entity)
        {
            _repo.Update(entity);
        }
    }
}