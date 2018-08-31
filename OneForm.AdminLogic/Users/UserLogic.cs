using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OneForm.AdminData.Dtos;
using OneForm.AdminData.Users;
using OneForm.SharedData.Entities;
using OneForm.SharedLogic;

namespace OneForm.AdminLogic.Users
{
    public class UserLogic : BaseLogic<IUserRepo, User>, IUserLogic
    {
        public UserLogic(IUserRepo repo) : base(repo)
        {
        }

        public async Task<IEnumerable<UserListDto>> GetList()
        {
            return await Repo.GetList();
        }

        public async Task<UserDto> GetById(int id)
        {
            return await Repo.GetUser(id);
        }

        public async Task Add(UserDto entity)
        {
            var newEntity = new User
            {
                Id = entity.Id,
                CountryId = entity.CountryId,
                Sex = entity.Sex,
                BirthDate = entity.BirthDate,
                CreatedDate = DateTime.Now,
                FirstName = entity.FirstName,
                HasVehicle = entity.HasVehicle,
                LastName = entity.LastName,
                UpdatedDate = DateTime.Now
            };
            await Repo.Add(newEntity);
        }

        public async Task Update(UserDto entity)
        {
            var oldEntity = await Repo.GetById(entity.Id);
            await Repo.Update(oldEntity);
        }

        public async Task Remove(int id)
        {
            var entity = await Repo.GetById(id);
            entity.Id = entity.Id;
            entity.CountryId = entity.CountryId;
            entity.Sex = entity.Sex;
            entity.BirthDate = entity.BirthDate;
            entity.CreatedDate = DateTime.Now;
            entity.FirstName = entity.FirstName;
            entity.HasVehicle = entity.HasVehicle;
            entity.LastName = entity.LastName;
            entity.UpdatedDate = DateTime.Now;
            await Repo.Remove(entity);
        }
    }
}