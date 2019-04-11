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
            List<Dish> AllDishes = dbContext.Dishes.ToList();

            List<Dish> dishesWithCreators = dbContext.Dishes
            .Include(dish => dish.Creator)
            .ToList();

            return View(AllDishes);
        }

        [Route("/chefs")]
        [HttpGet]
        public IActionResult Chefs()
        {
            List<Chef> AllChefs = dbContext.Chefs.ToList();
            List<Dish> dishesWithCreators = dbContext.Dishes
            .Include(dish => dish.Creator)
            .ToList();

            return View(AllChefs);
        }

        [Route("/new")]
        [HttpGet]
        public IActionResult New()
        {
            List<Chef> AllChefs = dbContext.Chefs.ToList();
            ViewBag.Chefs = AllChefs;
            return View();
        }
        
        [Route("/new/chef")]
        [HttpGet]
        public IActionResult NewChef()
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

        [Route("/create/chef")]
        [HttpPost]
        public IActionResult CreateChef(Chef newChef)
        {
            if (ModelState.IsValid)
            {
                dbContext.Add(newChef);
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
            Dish oneDish = dbContext.Dishes.FirstOrDefault(dish =>
            dish.DishId == id);

            List<Dish> dishesWithCreators = dbContext.Dishes
            .Include(dish => dish.Creator)
            .ToList();
            return View(oneDish);
        }

        [Route("/delete/{id}")]
        [HttpGet]
        public IActionResult DeleteDish(int id)
        {
            Dish DishToDelete = dbContext.Dishes.FirstOrDefault(dish =>
            dish.DishId == id);
            dbContext.Dishes.Remove(DishToDelete);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [Route("/edit/{id}")]
        [HttpGet]
        public IActionResult ViewEdit(int id)
        {
            Dish oneDish = dbContext.Dishes.FirstOrDefault(dish =>
            dish.DishId == id);
            return View(oneDish);
        }

        [Route("/update/{id}")]
        [HttpPost]
        public IActionResult Update(Dish updatedDish, int id)
        {
            Dish oneDish = dbContext.Dishes.FirstOrDefault(dish =>
            dish.DishId == id);
            if (ModelState.IsValid)
            {
                oneDish.Name = updatedDish.Name;
                oneDish.Creator = updatedDish.Creator;
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
