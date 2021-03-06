﻿using Rovers4.Models;
using System.Collections.Generic;

namespace Rovers4.ViewModels
{
    public class PlayerStatsViewModel
    {
        public Person Person { get; set; }

        public IEnumerable<Person> Staff { get; set; }
        public IEnumerable<PlayerStat> Stats { get; set; }

        public string CurrentPlayer { get; set; }

        public int CurrentPlayerID { get; set; }

        public bool HasStats { get; set; }
    }
}
