using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class AnimalController : Controller
    {

        public AnimalController()
        {
            lista = new List<Animal>();
            lista.Add(new Animal() { Especie = "Cachorro", Cor = "Branco", Genero = true, Idade = 4, Raca = "Border Collie" });
            lista.Add(new Animal() { Especie = "Rato", Cor = "Marrom", Genero = true, Idade = 1, Raca = "Twister" });
            lista.Add(new Animal() { Especie = "Peixe", Cor = "Listrado", Genero = false, Idade = 1, Raca = "Pacu" });
            lista.Add(new Animal() { Especie = "Ornitorrinco", Cor = "Preto", Genero = false, Idade = 4, Raca = "Mamífero" });
        }
        List<Animal> lista;
        // GET: Animal
        public ActionResult Index()
        {
            return View("Index", lista);
        }

        // GET: Animal/Details/5
        public ActionResult Details(int id)
        {
            return View("Details", lista.[id]);
        }

        // GET: Animal/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Animal/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Animal/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Animal/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Animal/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Animal/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
