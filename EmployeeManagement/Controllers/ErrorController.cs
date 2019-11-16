﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeeManagement.Controllers
{
    public class ErrorController : Controller
    {

        [Route("Error/{statusCode}")]
        public IActionResult HttpStatusCodeHandler(int statusCode)
        {
            
            //getting the OrignalPath & OriginalQueryString
            var statusCodeResult = HttpContext.Features.Get<IStatusCodeReExecuteFeature>();
            // statusCodeResult.OriginalQueryString
            // statusCodeResult.OriginalPath

            switch (statusCode)
            {
                case 404:
                    ViewBag.ErrorMessage = "Sorry the resource you requested could not be found";
                    break;
            }

            return View("NotFound");
        }
    }
}
