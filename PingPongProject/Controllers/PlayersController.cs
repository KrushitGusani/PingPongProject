using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PingPongProject.DAL;
using PingPongProject.Models;

namespace PingPongProject.Controllers
{
    public class PlayersController : Controller
    {
        //DatabseContext object to retrive and insert data into database
        private PlayerDBContext db = new PlayerDBContext();

        // GET: Gets the list of players from the database and display on page load
        public ActionResult Index()
        {
            return View(db.Players.ToList());
        }

        // GET: To get the players details and if ID is not provided or is incorrect than will display messages accordingly
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return View("Error", new ErrorViewModel { Description = "Cannot Display becuase no ID provided." });
            }
            Player player = db.Players.Find(id);
            if (player == null)
            {
                return View("Error", new ErrorViewModel { Description = "Requested Player not found." });
            }

            ViewBag.PlayerName = player.FirstName + " " + player.LastName;
            return View(player);
        }


        public ActionResult Create()
        {
            return View();
        }

        // POST: Creates player record into databse and will save the changes if the model state is valid.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PlayerID,FirstName,LastName,Age,SkillLevel,EmailAddress")] Player player)
        {
            if (ModelState.IsValid)
            {
                db.Players.Add(player);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(player);
        }

        // GET: If provided ID is found then will allow to edit or else will show the error message accordingly
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return View("Error", new ErrorViewModel { Description = "Cannot Edit becuase no ID provided." });
            }
            Player player = db.Players.Find(id);
            if (player == null)
            {
                return View("Error", new ErrorViewModel { Description = "Cannot Edit becuase requested Player not found." });
            }
            ViewBag.PlayerName = player.FirstName + " " + player.LastName;
            return View(player);
        }

        // POST: This will allow to edit or else will show the error message accordingly if the request is post and data is submited on button click
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PlayerID,FirstName,LastName,Age,SkillLevel,EmailAddress")] Player player)
        {
            if (ModelState.IsValid)
            {
                db.Entry(player).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(player);
        }

        // GET: This will allow to delete the player data by showing confirmation page if correct ID is provided or else will show the error message
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Player player = db.Players.Find(id);
            if (player == null)
            {
                return View("Error", new ErrorViewModel { Description = "Cannot Delete becuase requested Player not found." });
            }
            ViewBag.PlayerName = player.FirstName + " " + player.LastName;
            return View(player);
        }

        // POST: This will allow to delete the player data by showing confirmation page if correct ID is provided or else will show the error message
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Player player = db.Players.Find(id);
            db.Players.Remove(player);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        //This is Dispose method created to release the memory
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
