using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OneForm.CommonLogic.Countries;
using OneForm.SharedApi.Controllers;

namespace OneForm.CommonApi.Controllers
{
    public class CountryController : BaseController<ICountryLogic>
    {
        public CountryController(ICountryLogic logic) : base(logic)
        {
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            try
            {
                var result = await Logic.GetList();
                return Json(result);
            }
            catch (Exception ex)
            {
                return ExceptionResult(ex);
            }
        }
    }
}