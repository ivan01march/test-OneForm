using OneForm.SharedData.Context;

namespace OneForm.SharedData.RepoInterfaces
{
    public interface ITDto<TEntity> where TEntity : BaseEntity
    {
        ITDto<TEntity> FromEntity(TEntity entity);
    }
}