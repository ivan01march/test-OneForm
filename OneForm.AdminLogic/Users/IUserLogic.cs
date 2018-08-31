using System.Collections.Generic;
using System.Threading.Tasks;
using OneForm.AdminData.Dtos;
using OneForm.SharedLogic;

namespace OneForm.AdminLogic.Users
{
    public interface IUserLogic : IBaseLogic
    {
        Task<IEnumerable<UserListDto>> GetList();
        Task<UserDto> GetById(int id);
        Task Add(UserDto entity);
        Task Update(UserDto entity);
        Task Remove(int id);
    }
}