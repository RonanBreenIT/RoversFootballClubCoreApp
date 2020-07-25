﻿using Microsoft.AspNetCore.Mvc;
using Rovers4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rovers4.Components
{
    public class FixtureMenu : ViewComponent
    {
        private readonly ITeamRepository _teamRepository;

        public FixtureMenu(ITeamRepository teamRepository)
        {
            _teamRepository = teamRepository;
        }

        public IViewComponentResult Invoke()
        {
            var teams = _teamRepository.Teams.OrderBy(c => c.TeamID);
            return View(teams);
        }
    }
}
