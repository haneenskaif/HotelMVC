using System.Collections.Generic;
using HotelMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace HotelMVC.Controllers
{
    public class BookingController : Controller
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

            return RedirectToAction("Receipt", new { bookingId = booking.BookingId });

        }

        public ActionResult Receipt(int bookingId)
        {
            var booking = bookings.FirstOrDefault(b => b.BookingId == bookingId);
            return View(booking);
        }

    }

}

