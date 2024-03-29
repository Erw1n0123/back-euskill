﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Vezetéknév_Keresztnév_backend.Models
{
    public partial class Orszag
    {
        public Orszag()
        {
            Versenyzos = new HashSet<Versenyzo>();
        }

        public string Id { get; set; }
        public string OrszagNev { get; set; }

        public virtual ICollection<Versenyzo> Versenyzos { get; set; }
    }
}
