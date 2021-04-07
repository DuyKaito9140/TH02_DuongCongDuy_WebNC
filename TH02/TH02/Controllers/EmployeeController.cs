using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TH02.Models;

namespace TH02.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult GetView()
        {
            
            List<Employee> listEmp = new List<Employee>();
            Employee emp1 = new Employee();
            emp1.FirstName = "Duy";
            emp1.LastName = "Kaito";
            emp1.Salary = 5000;

            Employee emp2 = new Employee();
            emp2.FirstName = "Quỳnh";
            emp2.LastName = "Giao";
            emp2.Salary = 1000;

            Employee emp3 = new Employee();
            emp3.FirstName = "Silver";
            emp3.LastName = "Rayleigh";
            emp3.Salary = 8000;

            listEmp.Add(emp1);
            listEmp.Add(emp2);
            listEmp.Add(emp3);

            foreach (var item in listEmp)
            {
                if (item.Salary >= 1500)
                {
                    item.SalaryColor = "Yellow";
                }
                else
                {
                    item.SalaryColor = "aqua";
                }
            }
            return View(listEmp);
        }
    }
}