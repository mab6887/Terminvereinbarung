﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TerminvereinbarungLib;
using TerminvereinbarungWebApp.Models;

namespace TerminvereinbarungWebApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly TerminvereinbarungModelContainer _context;

        public AccountController()
        {
            _context = new TerminvereinbarungModelContainer();
        }

        // GET: Account
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Login model)
        {
            if (ModelState.IsValid)
            {
                var user = _context.UserSet
                    .FirstOrDefault(u => u.EMail == model.EMail && u.Passwort == model.Passwort);
                if (user != null)
                {
                    // Authentication logic
                    Session["UserId"] = user.Id;
                    Session["UserName"] = user.Nachname;
                    // Hier if um verschiedene rollen zuzuweisen und basierend auf rolle unterschiedliche views
                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError("", "Invalid email or password.");
            }
            
            return View(model);
        }

        // GET: Account/Register
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(Register model)
        {
            if (ModelState.IsValid)
            {
                var existingUser = _context.UserSet.FirstOrDefault(u => u.EMail == model.EMail);
                if (existingUser == null)
                {
                    var user = new User
                    {
                        Vorname = model.Vorname,
                        Nachname = model.Nachname,
                        Geburtsdatum = model.Geburtsdatum,
                        Telefon = model.Telefon,
                        EMail = model.EMail,
                        Krankenkasse = model.Krankenkasse,
                        Arzt = model.Arzt,
                        Admin = model.Admin,
                        Passwort = model.Passwort,
                        
                    };

                    _context.UserSet.Add(user);
                    _context.SaveChanges();

                    return RedirectToAction("Login");
                }

                ModelState.AddModelError("", "Email already exists.");
            }
            return View(model);
        }

        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Login");
        }
        
    }
}
 