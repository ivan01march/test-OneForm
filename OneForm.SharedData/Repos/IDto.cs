using OneForm.SharedData.Context;

namespace OneForm.SharedData.RepoInterfaces
{
    /// <summary>
    /// Data Translate Object
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IDto<TEntity> where TEntity : BaseEntity
    {
        IDto<TEntity> FromEntity(TEntity entity);
    }
}