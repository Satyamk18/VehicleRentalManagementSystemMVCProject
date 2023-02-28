using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using VehicleRentalManagementProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Authorization;
namespace VehicleRentalManagementProject.Controllers
{
    //[Authorize]
    public class VehicleController : Controller
    {
        private readonly ACE42023Context db;
        public VehicleController(ACE42023Context _db){
            db = _db;
        }

        //get allvehicles page
        public IActionResult ShowVehicles()
        {
            ViewBag.username = HttpContext.Session.GetString("Username");
            if(ViewBag.username == null){
                return RedirectToAction("Login","Account");
            }
            List<Vehicle> vehicles = db.Vehicles.ToList();
            return View(vehicles);
        }

        //get addvehicle page
        public IActionResult Create()
        {
            ViewBag.username = HttpContext.Session.GetString("Username");
            if(ViewBag.username == null){
                return RedirectToAction("Login","Account");
            }
            return View();
        } 
 
        //post addvehicle route + redirect to showvehicle page
        [HttpPost]
        public IActionResult AddNewVehicle(Vehicle newVehicle){
            db.Vehicles.Add(newVehicle);
            db.SaveChanges();
            return RedirectToAction("ShowVehicles");
        }
       
        //showvehicle with specific id
        public IActionResult Detail(int id){
                        ViewBag.username = HttpContext.Session.GetString("Username");
            if(ViewBag.username == null){
                return RedirectToAction("Login","Account");
            }
                Vehicle vehicle = db.Vehicles.FirstOrDefault(x => x.VehicleId == id);
                ViewBag.thisvehicle = vehicle;
                return View(vehicle);
        }

        public IActionResult ShowReviews(int id){
                ViewBag.username = HttpContext.Session.GetString("Username");
                if(ViewBag.username == null){
                    return RedirectToAction("Login","Account");
                }
                Vehicle vehicle = db.Vehicles.FirstOrDefault(x => x.VehicleId == id);
                ViewBag.VehicleName = vehicle.ModelName;
                List<Review> reviews = db.Reviews.ToList();
                List<Review> list = new List<Review>();

                foreach (var item in reviews)
                {
                    if(item.VehicleId == id){
                        list.Add(item);
                    }

                }
                return View(list);
        }
        // //rent a vehicle
        public IActionResult ConfirmRentVehicle(int id)
        {
            ViewBag.username = HttpContext.Session.GetString("Username");
            if(ViewBag.username == null){
                return RedirectToAction("Login","Account");
            }
            // TransactionVrm transaction = new TransactionVrm();
            Vehicle vehicle = db.Vehicles.FirstOrDefault(x => x.VehicleId == id);
            // transaction.VehicleId = vehicle.VehicleId;
            // transaction.Userid = Convert.ToInt32(HttpContext.Session.GetString("Userid"));
            // transaction.RentalStartDate = DateTime.Now;
            // vehicle.IsAvailable = false;
            // db.TransactionVrms.Add(transaction);
            // db.SaveChanges();
            ViewBag.thisvehicle = vehicle;
            return View(vehicle);
        }

         [HttpPost]
         public IActionResult RentVehicle(int id){
            ViewBag.username = HttpContext.Session.GetString("Username");
            if(ViewBag.username == null){
                return RedirectToAction("Login","Account");
            }
            TransactionVrm transaction = new TransactionVrm();
            Vehicle vehicle = db.Vehicles.FirstOrDefault(x => x.VehicleId == id);
            transaction.VehicleId = vehicle.VehicleId;
            transaction.Userid = Convert.ToInt32(HttpContext.Session.GetString("Userid"));
            transaction.RentalStartDate = DateTime.Now;
            vehicle.IsAvailable = false;
            db.TransactionVrms.Add(transaction);
            db.SaveChanges();
            return RedirectToAction("ShowVehicles");

         }
        public IActionResult ReturnVehicleConfirmation(int id){
                ViewBag.username = HttpContext.Session.GetString("Username");
                if(ViewBag.username == null){
                    return RedirectToAction("Login","Account");
                }
              TransactionVrm transaction = db.TransactionVrms.FirstOrDefault(x => x.TransactionId == id);
              Vehicle vehicle = db.Vehicles.FirstOrDefault(x => x.VehicleId == transaction.VehicleId);
              transaction.RentalEndDate = DateTime.Now;
              TimeSpan diff= DateTime.Now.Subtract(transaction.RentalStartDate);
              int diffindays = diff.Days;
              if(diffindays == 0){
                 diffindays = 1;
              }
              int rentalrate = diffindays*(vehicle.DailyRent);
              transaction.RentalRate = rentalrate;
              vehicle.IsAvailable = true;
              db.TransactionVrms.Update(transaction);
              ViewBag.transaction = transaction;
              db.Vehicles.Update(vehicle);
              db.SaveChanges();
              return View(transaction);
        }

        // //return vehicle
        // [HttpPost]
        // public IActionResult ReturnVehicle(int id)
        // {
        //     Vehicle vehicle = db.Vehicles.FirstOrDefault(x => x.Id == id);
        //     vehicle.IsAvailable = true;
        //    //UserId = HttpContext.User.Identity.Name;
        //     // TransactionVrm transaction = db.TransactionsVrms.FirstOrDefault();
        //     transaction.RentalEndDate = DateTime.Now;
        //     DateTime startDate = transaction.RentalStartDate;
        //     DateTime endDate = DateTime.Now;
        //     int dailyrent = vehicle.DailyRent;
        //     transaction.RentalRate = (endDate-startDate)*dailyrent;
        //     vehicle.IsAvailable = true;
        //     db.SaveChanges();
        //     return RedirectToAction("ReturnVehicleConfirmation" , new {id = transaction.transactionId});

        // }       

        public IActionResult GetReview(){
            ViewBag.username = HttpContext.Session.GetString("Username");
            if(ViewBag.username == null){
                return RedirectToAction("Login","Account");
            }
            return View();
        }

        [HttpPost]
        public IActionResult ReviewSubmit(Review rev){
            ViewBag.username = HttpContext.Session.GetString("Username");
            if(ViewBag.username == null){
                return RedirectToAction("Login","Account");
            }
             rev.Userid = Convert.ToInt32(HttpContext.Session.GetString("Userid"));
             db.Reviews.Add(rev);
             db.SaveChanges();
             return RedirectToAction("ShowVehicles");
        }
        //delete vehicle route
        public IActionResult Delete(int id){
            ViewBag.username = HttpContext.Session.GetString("Username");
            if(ViewBag.username == null){
                return RedirectToAction("Login","Account");
            }
            Vehicle vehicle = db.Vehicles.FirstOrDefault(x => x.VehicleId == id);
            ViewBag.thisvehicle = vehicle;
            return View(vehicle);
        }

        [HttpPost]
        public IActionResult ConfirmDelete(int id){
             ViewBag.username = HttpContext.Session.GetString("Username");
            if(ViewBag.username == null){
                return RedirectToAction("Login","Account");
            }
            List<Review> reviews = db.Reviews.Where(x => x.VehicleId == id).ToList();
            List<TransactionVrm> transactionlist = db.TransactionVrms.Where(x => x.VehicleId == id).ToList();
            Vehicle vehicle = db.Vehicles.FirstOrDefault(x => x.VehicleId == id);
            foreach(TransactionVrm transaction in transactionlist){
                db.TransactionVrms.Remove(transaction);
            }
            foreach(Review review in reviews){
                db.Reviews.Remove(review);
            }
            db.SaveChanges();
            db.Vehicles.Remove(vehicle);
            db.SaveChanges();
            return RedirectToAction("ShowVehicles");
        }

        public IActionResult Edit(int id){
            ViewBag.username = HttpContext.Session.GetString("Username");
            if(ViewBag.username == null){
                return RedirectToAction("Login","Account");
            }
            Vehicle vehicle = db.Vehicles.FirstOrDefault(x => x.VehicleId == id);
            ViewBag.thisvehicle = vehicle;
            return View(vehicle);
        }
        [HttpPost]
        public IActionResult EditConfirm(Vehicle vehicle){
                db.Vehicles.Update(vehicle);
                db.SaveChanges();
                return RedirectToAction("ShowVehicles");

        }
        
        public IActionResult SearchProducts(IFormCollection f){
            string keyword=f["keyword"].ToString();
            var result = db.Vehicles.Where(x => x.ModelName.Contains(keyword)).Select(x => x).ToList();
            return View(result);
        }

    }
}