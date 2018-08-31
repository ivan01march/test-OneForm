using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OneForm.AdminData.Dtos;
using OneForm.AdminLogic.Users;
using OneForm.SharedApi.Controllers;

namespace OneForm.AdminApi.Controllers
{
    public class UserController : BaseController<IUserLogic>
    {
        public UserController(IUserLogic logic) : base(logic)
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

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            try
            {
                var result = await Logic.GetById(id);
                return Json(result);
            }
            catch (Exception ex)
            {
                return ExceptionResult(ex, id);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] UserDto entity)
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest(ModelState);
                await Logic.Add(entity);
                return Json(new {ok = "ok"});
            }
            catch (Exception ex)
            {
                return ExceptionResult(ex, entity);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UserDto entity)
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest(ModelState);
                await Logic.Update(entity);
                return Json(new {ok = "ok"});
            }
            catch (Exception ex)
            {
                return ExceptionResult(ex, entity);
            }
        }

        [HttpDelete]
        [Route("id")]
        public async Task<IActionResult> Remove([FromRoute] int id)
        {
            try
            {
                await Logic.Remove(id);
                return Json(new {ok = "ok"});
            }
            catch (Exception ex)
            {
                return ExceptionResult(ex, id);
            }
        }
    }
}