﻿using System.Linq;
using System.Web.Mvc;
using DataModul.BaseRepository;
using DataModul.DomainModel;
using DataModul.IRepository;

namespace Store.Areas.User.Controllers
{
    [Authorize(Roles = "user")]
    public class HomeController : Controller
    {
        public HomeController(IRepository<Category> repository)
        {
            Repository = repository;
        }

        IRepository<Category> Repository { get; set; } 
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = Repository.GetAll().First().Name;
            //ViewBag.Message = Repository.GetById(2).Name;
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = Repository.GetAll().First().Name; 

            return View();
        }
    }
}