using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OneForm.AdminData.Dtos;
using OneForm.SharedData;
using OneForm.SharedData.Entities;
using OneForm.SharedData.Repos;

namespace OneForm.AdminData.Users
{
    public class UserRepo : BaseRepo<User>, IUserRepo
    {
        public UserRepo(OneFormContext context) : base(context)
        {
        }

        public async Task<IEnumerable<UserListDto>> GetList()
        {
            return await Repo
                .Select(x => new UserListDto
                {
                    FullName = x.FullName,
                    Sex = x.Sex,
                    HasVehicle = x.HasVehicle,
                    CountryName = x.Country.Name
                })
                .ToListAsync();
        }

        public async Task<UserDto> GetUser(int id)
        {
            return await Repo
                .Where(x => x.Id == id)
                .Select(x => new UserDto(x))
                .FirstOrDefaultAsync();
        }
    }
}