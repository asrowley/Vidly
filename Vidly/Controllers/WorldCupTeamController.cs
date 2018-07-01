using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class WorldCupTeamController : Controller
    {


        // GET: WorldCupTeam
        public ActionResult Index()
        {
            var teams = new List<WorldCupTeam>();

            var teamA = new WorldCupTeam() { Id = 1, Name = "England", StarPlayer = "Harry Kane" };
            var teamB = new WorldCupTeam() { Id = 2, Name = "Colombia", StarPlayer = "Radamel Falcao" };

            teams.Add(teamA);
            teams.Add(teamB);

            return View(teams.ToList());
        }
    }
}