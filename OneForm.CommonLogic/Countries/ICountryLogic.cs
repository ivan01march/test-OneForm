using System.Collections.Generic;
using System.Threading.Tasks;
using OneForm.CommonData.Dtos;
using OneForm.SharedLogic;

namespace OneForm.CommonLogic.Countries
{
    public interface ICountryLogic : IBaseLogic
    {
        Task<IEnumerable<CountryListDto>> GetList();
    }
}