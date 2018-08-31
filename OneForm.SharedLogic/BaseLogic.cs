using OneForm.SharedData.Entities;
using OneForm.SharedData.Repos;

namespace OneForm.SharedLogic
{
    public class BaseLogic<TRepo, TEntity> : IBaseLogic where TRepo : IBaseRepo<TEntity> where TEntity : BaseEntity
    {
        protected readonly TRepo Repo;

        public BaseLogic(TRepo repo)
        {
            Repo = repo;
        }
    }
}