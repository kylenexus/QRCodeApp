using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

using QRCodeApp.Models;

namespace QRCodeApp.Controllers
{
    public class GuestController : Controller
    {
        // GET: Guest
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Guest guest)
        {
            
            return RedirectToAction("GetQRCode",guest);
        }

        [HttpGet]
        public ActionResult GetQRCode()
        {
            return View("Index");
        }

        [HttpPost]
        public ActionResult GetQRCode(Guest guest)
        {
            string googleApi = "https://chart.googleapis.com/chart?cht=qr&chs=300x300&chl=";
            ViewBag.JsonGuest = JsonConvert.SerializeObject(guest);
            ViewBag.ImgUrl = googleApi + ViewBag.JsonGuest;
            

            return View(guest);
        }
    }
}