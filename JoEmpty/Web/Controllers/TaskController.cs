using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

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
        public JsonResult Post(TaskModel model)
        {
            UserTask userTask = new UserTask
            {
                CreatedDate = DateTime.Now,
            };

            //check

            return Json(new { status = "ok", message = "success" });
        }
    }
}
