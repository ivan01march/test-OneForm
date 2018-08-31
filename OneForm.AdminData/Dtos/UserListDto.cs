using OneForm.SharedData.Entities;
using OneForm.SharedData.Primitives;

namespace OneForm.AdminData.Dtos
{
    public class UserListDto
    {
        /// <summary>
        /// Полное имя
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Пол
        /// </summary>
        public Sex Sex { get; set; }

        /// <summary>
        /// Имеется ли собственная машина
        /// </summary>
        public bool HasVehicle { get; set; }

        /// <summary>
        /// Страна
        /// </summary>
        public string CountryName { get; set; }

        public UserListDto()
        {
        }

        public UserListDto(User entity)
        {
            FullName = entity.FullName;
            Sex = entity.Sex;
            HasVehicle = entity.HasVehicle;
            CountryName = entity.Country.Name;
        }
    }
}