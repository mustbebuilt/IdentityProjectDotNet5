using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CRUDFilmDbProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using System.IO;
using Microsoft.AspNetCore.Hosting;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CRUDFilmDbProject.Controllers
{
    public class CMSController : Controller
    {
        private readonly ILogger<CMSController> _logger;

        private readonly ApplicationDbContext _context;

        public CMSController(ILogger<CMSController> logger, ApplicationDbContext context)
        {
            _context = context;
            _logger = logger;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            List<Film> model = _context.Films.ToList();
            return View(model);
        }

        [HttpGet]
        public IActionResult AddFilm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddFilm(FilmForm model)
        {
            
            if (ModelState.IsValid)
            {

                Film newFilm = new Film
                {
                    FilmTitle = model.FilmTitle,
                    FilmCertificate = model.FilmCertificate,
                    FilmDescription = model.FilmDescription,
                    FilmImage = model.FilmImage,
                    FilmPrice = model.FilmPrice,
                    Stars = model.Stars,
                    ReleaseDate = DateTime.Now,
                };
                _context.Add(newFilm);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View();

        }

          

    


        // note uses id because of routing in startup.cs
        [HttpGet]
        public IActionResult UpdateFilm(int id)
        {
            //List<Film> model = _context.Films.Find(Id);
            Film model = _context.Films.Find(id);
            FilmForm formModel = new FilmForm
            {
                FilmID = model.FilmID,
                FilmTitle = model.FilmTitle,
                FilmCertificate = model.FilmCertificate,
                FilmDescription = model.FilmDescription,
                FilmImage = model.FilmImage,
                FilmPrice = model.FilmPrice,
                Stars = model.Stars,
                ReleaseDate = model.ReleaseDate,
            };
            ViewBag.ImageName = model.FilmImage;
            return View(formModel);
        }

        [HttpPost]
        public IActionResult UpdateFilm(FilmForm model)
        {
            // Only run if image is changed

                Film editFilm = new Film
                {
                    FilmID = model.FilmID,
                    FilmTitle = model.FilmTitle,
                    FilmCertificate = model.FilmCertificate,
                    FilmDescription = model.FilmDescription,
                    FilmImage = model.FilmImage,
                    FilmPrice = model.FilmPrice,
                    Stars = model.Stars,
                    ReleaseDate = model.ReleaseDate
                };
                _context.Films.Update(editFilm);

            _context.SaveChanges();
            return RedirectToAction("Index");

            //_context.Films.Update(model);
            //_context.SaveChanges();
            //return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DeleteFilm(int Id)
        {
            Film model = _context.Films.Find(Id);
            return View(model);
        }

        [HttpPost]
        public IActionResult DeleteFilm(Film model)
        {
            _context.Films.Remove(model);
            _context.SaveChanges();
            //return View(model);
            return RedirectToAction("Index");
        }

    }
}
