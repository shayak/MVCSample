﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC4Sample1.Controllers
{
    public class StoresController : Controller
    {
        //
        // GET: /Stores/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Stores/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Stores/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Stores/Create

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

        //
        // GET: /Stores/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Stores/Edit/5

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

        //
        // GET: /Stores/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Stores/Delete/5

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
