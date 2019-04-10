using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CrudDelicious.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudDelicious.Controllers
{
    public class HomeController : Controller
    {
        private CrudDeliciousContext dbContext;

        public HomeController(CrudDeliciousContext context)
        {
            dbContext = context;
        }

        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            // Get all Users
            List<Dish> AllDishes = dbContext.Dishes.ToList();

            // List<User> Jeffersons = dbContext.Users.Where(u => u.LastName == "Jefferson");
            // // Get the 5 most recently added Users
            // List<User> MostRecent = dbContext.Users
            //     .OrderByDescending(u => u.CreatedAt)
            //     .Take(5)
            //     .ToList();
            return View(AllDishes);
        }

        [Route("/new")]
        [HttpGet]
        public IActionResult New()
        {
            return View();
        }

        [Route("/create")]
        [HttpPost]
        public IActionResult Create(Dish newDish)
        {
            if (ModelState.IsValid)
            {
                dbContext.Add(newDish);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
                return View("New");
        }

        [Route("/{id}")]
        [HttpGet]
        public IActionResult ViewDish(int id)
        {
            Dish oneDish = dbContext.Dishes.FirstOrDefault(dish=>
            dish.id == id);
            return View(oneDish);
        }

        [Route("/delete/{id}")]
        [HttpGet]
        public IActionResult DeleteDish(int id)
        {
            Dish DishToDelete = dbContext.Dishes.FirstOrDefault(dish=>
            dish.id == id);
            dbContext.Dishes.Remove(DishToDelete);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        [Route("/edit/{id}")]
        [HttpGet]
        public IActionResult ViewEdit(int id)
        {
            Dish oneDish = dbContext.Dishes.FirstOrDefault(dish=>
            dish.id == id);
            return View(oneDish);
        }
        [Route("/update/{id}")]
        [HttpPost]
        public IActionResult Update(Dish updatedDish, int id)
        {

            Dish oneDish = dbContext.Dishes.FirstOrDefault(dish=>
            dish.id == id);
            if (ModelState.IsValid)
            {
                oneDish.Name = updatedDish.Name;
                oneDish.Chef = updatedDish.Chef;
                oneDish.Tastiness = updatedDish.Tastiness;
                oneDish.Calories = updatedDish.Calories;
                oneDish.Description = updatedDish.Description;
                oneDish.UpdatedAt = DateTime.Now;
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
                return RedirectToAction("ViewEdit");
        }

    }
}
