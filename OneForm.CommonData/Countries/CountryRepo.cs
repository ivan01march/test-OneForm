using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OneForm.CommonData.Dtos;
using OneForm.SharedData;
using OneForm.SharedData.Entities;
using OneForm.SharedData.Repos;

namespace OneForm.CommonData.Countries
{
    public class CountryBaseRepo : BaseRepo<Country>, ICountryRepo
    {
        public CountryBaseRepo(OneFormContext context) : base(context)
        {
        }

        public async Task<IEnumerable<CountryListDto>> GetList()
        {
            return await Repo.Select(x => new CountryListDto(x)).ToListAsync();
        }
    }
}