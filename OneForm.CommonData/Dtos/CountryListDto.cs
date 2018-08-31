using OneForm.SharedData.Entities;
using OneForm.SharedData.Repos;

namespace OneForm.CommonData.Dtos
{
    public class CountryListDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static int Count;

        public CountryListDto(Country entity)
        {
            Id = entity.Id;
            Name = entity.Name;
        }
    }
}