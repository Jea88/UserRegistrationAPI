using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserRegistrationAPI.Models;
using System.Net.Http;

namespace UserRegistrationAPI.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Register rg) 
        {
            if (ModelState.IsValid)
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("https://localhost:44354/api/Accounts");

                var insertrecords = client.PostAsJsonAsync<Register>("Accounts", rg);
                var saveRecord = insertrecords.Result;

                if (saveRecord.IsSuccessStatusCode)
                {
                    ViewBag.message = "The User " + rg.FirstName + " is inserted successfully";
                }
            }
           
            return View();
        }
    }
}