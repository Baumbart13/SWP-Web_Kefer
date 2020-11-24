using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModDB_Rebuild.Models;

namespace ModDB_Rebuild.Controllers
{
    public class MemberController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

		public IActionResult Register() {
			return View(new User());
		}
    }
}