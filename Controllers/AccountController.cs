using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VehicleRentalManagementProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Authorization;

namespace VehicleRentalManagementProject.Controllers
{
    public class AccountController : Controller
    {
        private readonly ISession session;
        private readonly ACE42023Context db;
        public AccountController(ACE42023Context _db, IHttpContextAccessor httpContextAccessor){
            db = _db;
            session = httpContextAccessor.HttpContext.Session;
            
        }
        
        //login
        public IActionResult Login(){
            return View();
        }

        [HttpPost]
        public IActionResult Login(Customer customer){
            var result = (from i in db.Customers
                          where i.Username == customer.Username && i.Password == customer.Password
                          select i).SingleOrDefault();
            if(result != null){
                HttpContext.Session.SetString("Username",result.Username);
                HttpContext.Session.SetString("Userid",result.Userid.ToString());

                session.SetString("Username",result.Username);

                return RedirectToAction("Home", "Account");

            }else{
                return View();
            }              
            
        }
        //register
        public IActionResult Register(){
            return View();
        }

        public IActionResult Transactions(){
            ViewBag.username = HttpContext.Session.GetString("Username");
            if(ViewBag.username == null){
                return RedirectToAction("Login","Account");
            }
            //TransactionVrm transaction = db.TransactionVrms.FirstOrDefault(x => x.TransactionId == id);
            int userid = Convert.ToInt32(HttpContext.Session.GetString("Userid"));

            Customer customer = db.Customers.FirstOrDefault(x => x.Userid == userid);
            List<TransactionVrm> list = new List<TransactionVrm>();
            foreach(TransactionVrm t in db.TransactionVrms){
                  if(t.Userid == customer.Userid){
                     list.Add(t);
                  }
            }
            return View(list);
        }
        [HttpPost]
        public IActionResult Register(Customer customer){
           db.Customers.Add(customer);
           db.SaveChanges();
           return RedirectToAction("Login", "Account");
        }
        public IActionResult Home(){
                        ViewBag.username = HttpContext.Session.GetString("Username");
            if(ViewBag.username == null){
                return RedirectToAction("Login","Account");
            }
            ViewBag.Username = HttpContext.Session.GetString("Username");
            return View();
        }
        //logout 
        public IActionResult Logout(){
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "Account");
        }
        

    }
}