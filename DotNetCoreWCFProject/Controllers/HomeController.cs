using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCoreWCFProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreWCFProject.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            DataService.DataServiceClient service = new DataService.DataServiceClient();
            Data d = new Data();
            d.DataValue = await service.GetDataAsync(5);
            ViewData["DataModel"] = d;
            return View(); 
        }

       
    }
}