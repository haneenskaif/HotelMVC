using System.Collections.Generic;
using HotelMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace HotelMVC.Controllers
{
    public class RoomController : Controller
    {
        static List<Room> rooms = new List<Room>();

        public ActionResult Index()
        {
            return View(rooms);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Room room)
        {
            room.RoomId = rooms.Count + 1;
            room.Status = "Available";
            rooms.Add(room);
            TempData["msg"] = "Room added successfully!";
            return RedirectToAction("Index");


        }

    }
}

