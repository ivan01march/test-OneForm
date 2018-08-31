using System;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using OneForm.SharedLogic;
using Serilog;

namespace OneForm.SharedApi.Controllers
{
    [Route("[controller]")]
    public class BaseController<TLogic> : Controller where TLogic : IBaseLogic
    {
        protected readonly TLogic Logic;

        public BaseController(TLogic logic)
        {
            Logic = logic;
        }


        protected IActionResult ExceptionResult(Exception ex, params object[] args)
        {
            var controllerName = ControllerContext.ActionDescriptor.ControllerName;
            var actionName = ControllerContext.ActionDescriptor.ActionName;
            var msg = $"{controllerName} {actionName} {ex.Message}";

            if (ex is ArgumentException)
            {
                Log.Warning(ex, msg, args);
#if DEBUG
                return BadRequest(ex);
#else
            return BadRequest(msg);
#endif
            }

            Log.Error(ex, msg, args);
            Response.StatusCode = (int) HttpStatusCode.InternalServerError;
#if DEBUG
            return Json(ex);
#else
            return Json(msg);
#endif
        }
    }
}