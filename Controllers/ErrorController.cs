using System.Linq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace EmlpoyeeMgt.Controllers
{
   
    public class ErrorController : Controller
    {
        [Route("Error/{statusCode}")]
        public IActionResult HttpStatusCodeHandler(int statusCode)
        {
            switch (statusCode){
                case 404:
                    ViewBag.ErrorMessage="Page could not be found";
                    break;
            }
            return View("NotFound");  
        } 
        [AllowAnonymous]
        [Route("Error")]
        public IActionResult Error()
        {
            return View("Error");
        }
         
    }
}