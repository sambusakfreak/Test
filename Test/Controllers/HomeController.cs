using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Design;
using Test.Models;

namespace Test.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(Inputs inputs)
        {

            ViewData["Dup"] = "<div class=\"panel-body\"> <fieldset> <div class=\"row\"> <div class=\"col-sm-12 col-md-10 col-md-offset-1 \"> <div class=\"form-group\"> <label><strong>New Input</strong></label> <div class=\"input-group\"> <span class=\"input-group-addon\"> <i class=\"glyphicon glyphicon-user\"></i> </span> <input asp-for=\"@Model.Data\" placeholder=\"Data\" autofocus=\"\" class=\"form-control\" value=\"\"/> </div> </div> <div class=\"form-group\"> <div class=\"input-group\"> <span class=\"input-group-addon\"> <i class=\"glyphicon glyphicon-lock\"></i> </span> <select class=\"form-control\" asp-for=\"@Model.Datatype\" asp-items=\"@Model.Types\"> <option disabled=\"\">Select</option> </select> </div> </div> </div> </div> </fieldset> </div>";

            return View(inputs);
            
        }

        public IActionResult About(Inputs inputs)
        {


            return View(inputs);
        }

        public IActionResult Contact(Inputs inputs)
        {
            ViewData["Dup"] = "<div class=\"panel-body\"> <fieldset> <div class=\"row\"> <div class=\"col-sm-12 col-md-10 col-md-offset-1 \"> <div class=\"form-group\"> <label><strong>New Input</strong></label> <div class=\"input-group\"> <span class=\"input-group-addon\"> <i class=\"glyphicon glyphicon-user\"></i> </span> <input asp-for=\"@Model.Data\" placeholder=\"Data\" autofocus=\"\" class=\"form-control\" value=\"\"/> </div> </div> <div class=\"form-group\"> <div class=\"input-group\"> <span class=\"input-group-addon\"> <i class=\"glyphicon glyphicon-lock\"></i> </span> <select class=\"form-control\" asp-for=\"@Model.Datatype\" asp-items=\"@Model.Types\"> <option disabled=\"\">Select</option> </select> </div> </div> </div> </div> </fieldset> </div>";

            return View(inputs);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

