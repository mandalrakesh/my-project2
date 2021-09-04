using my_project2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace my_project2.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            employeeModel employeeModel = new employeeModel();
            employeeModel.employeemodel = 145;
            TempData["tempData"] = "Hi is am temp data";
            ViewBag.employeeView = "hi i'm view data";
 
            return View(employeeModel);

        }
        public ActionResult employee()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}