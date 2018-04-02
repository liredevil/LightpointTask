using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LightpointTask.BLL.Interfaces;
using LightpointTask.BLL.DTO;
using LightpointTask.Models;
using LightpointTask.BLL.Infrastructure;

namespace LightpointTask.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }


    }
}