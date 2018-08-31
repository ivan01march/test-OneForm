using System.Collections.Generic;
using System.Threading.Tasks;
using OneForm.AdminData.Dtos;
using OneForm.SharedData.Entities;
using OneForm.SharedData.Repos;

namespace OneForm.AdminData.Users
{
    public interface IUserRepo : IBaseRepo<User>
    {
        Task<IEnumerable<UserListDto>> GetList();
        Task<UserDto> GetUser(int id);
    }
}