using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace VuonSenDa.AdminApp.Controllers
{
    [Authorize]// đã là trang admin nên bắt buộc phải đăng nhập mới  dc vào
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var user = User.Identity.Name;
            return View();
        }
    }
}