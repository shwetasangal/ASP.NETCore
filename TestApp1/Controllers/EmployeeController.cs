using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TestApp1.Controllers
{
    [Route("Employee")]
    public class EmployeeController:Controller
    {
        [Route("Name")]
        public ContentResult Name()
        {
            return Content("Jonas");
        }

        [Route("Country")]
        public string Country()
        {
            return "Indias";
        }

        [Route("")]
        public string Index()
        {
            return "Index of Employee Class";
        }
    }
}
