using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TallerDBaaS.Controllers
{
    public class GradesController : Controller
    {
        // GET: Grades
        public ActionResult Index()
        {
            return View();
        }

        // GET: Grades/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Grades/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Grades/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {

                Models.Communication.ConnectToMongoService();
                Models.Communication.grades_collection =
                    Models.Communication.database.GetCollection<Models.Grades>("Notas");
                //Se crea un carnet al azar
                Object carnet = generateRandomId(2);
                Models.Communication.grades_collection.InsertOneAsync(new Models.Grades
                {

                    _id = carnet,
                    Carnet = collection["Carnet"],
                    Nombre = collection["Nombre"],
                    Apellido = collection["Apellido"],
                    Curso = collection["Curso"],
                    Nota = collection["Nota"]

                });
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        private static Random randomNum = new Random();
        private object generateRandomId(int carnet)
        {
            string strArray = "0123456789";
            return new string(Enumerable.Repeat(strArray, carnet).Select(s=>s[randomNum.Next(s.Length)]).ToArray());
        }

        // GET: Grades/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Grades/Edit/5
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

        // GET: Grades/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Grades/Delete/5
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
