using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

        public async Task<IEnumerable<TEntity>> GetList(Expression<Func<TEntity, bool>> filter, int page, int limit)
        {
            return await _repo
                .Where(filter)
                .ToListAsync();
        }

        public async Task<IEnumerable<TDto>> GetList<TDto>(
            Expression<Func<TEntity, bool>> filter,
            TDto dto, int page, int limit) where TDto : ITDto<TEntity>, new()
        {
            return await _repo
                .Where(filter)
                .Select(x => new TDto().FromEntity(x))
                .ToListAsync();
        }

        public Task Add(Country country)
        {
            throw new NotImplementedException();
        }
    }
}