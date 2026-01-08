using HotelMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace HotelMVC.Controllers
{
    public class BookingController1 : Controller
    {
        static List<Booking> bookings = new List<Booking>();

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Booking booking)
        {
            booking.BookingId = bookings.Count + 1;

         
            booking.TotalAmount = 500;

            bookings.Add(booking);

            return RedirectToAction("Receipt", booking);
        }

        public ActionResult Receipt(Booking booking)
        {
            return View(booking);
        }
    }

}

