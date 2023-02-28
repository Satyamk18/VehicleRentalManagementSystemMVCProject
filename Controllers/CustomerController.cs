using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VehicleRentalManagementProject.Models;

namespace VehicleRentalManagementProject.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ACE42023Context db;
        public CustomerController(ACE42023Context _db){
            db = _db;
        }

        public IActionResult About()
        {
            return View();
        }
        // //get customer profile page
        // public IActionResult GetTransactions()
        // {
        //     List<Transactions
        //     return View();
        // }

        // // get return page 
        // public IActionResult Return(int id){
        //     return View(id);
        // }
        

        // public IActionResult ReturnConfirm(){

        // }
        

    }
}