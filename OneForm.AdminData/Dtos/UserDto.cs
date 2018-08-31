using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OneForm.SharedData.Entities;
using OneForm.SharedData.Primitives;

namespace OneForm.AdminData.Dtos
{
    public class UserDto
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        [Required]
        public Sex Sex { get; set; }

        [Required]
        public bool HasVehicle { get; set; }

        [Required]
        public int CountryId { get; set; }

        public UserDto()
        {
        }

        public UserDto(User entity)
        {
            Id = entity.Id;
            FirstName = entity.FirstName;
            LastName = entity.LastName;
            BirthDate = entity.BirthDate;
            Sex = entity.Sex;
            HasVehicle = entity.HasVehicle;
            CountryId = entity.CountryId;
        }
    }
}