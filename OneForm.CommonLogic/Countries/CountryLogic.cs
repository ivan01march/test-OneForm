using System.Collections.Generic;
using System.Threading.Tasks;
using OneForm.CommonData.Countries;
using OneForm.CommonData.Dtos;
using OneForm.SharedData.Entities;
using OneForm.SharedLogic;

namespace OneForm.CommonLogic.Countries
{
    public class CountryLogic : BaseLogic<ICountryRepo, Country>, ICountryLogic
    {
        public CountryLogic(ICountryRepo repo) : base(repo)
        {
        }

        public async Task<IEnumerable<CountryListDto>> GetList()
        {
            return await Repo.GetList();
        }
    }
}