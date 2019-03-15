using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class TaskController : ApiController
    {
        [HttpGet]
        public JsonResult Get()
        {
            return Json(new { status = "ok", message = "success" });
        }

        [HttpPost]
        public JsonResult List()
        {
            return Json(new { status = "ok", message = "success" });
        }
    }
}
