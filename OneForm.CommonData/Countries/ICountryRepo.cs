using System.Collections.Generic;
using System.Threading.Tasks;
using OneForm.CommonData.Dtos;
using OneForm.SharedData.Entities;
using OneForm.SharedData.Repos;

namespace OneForm.CommonData.Countries
{
    public interface ICountryRepo : IBaseRepo<Country>
    {
        Task<IEnumerable<CountryListDto>> GetList();
    }
}