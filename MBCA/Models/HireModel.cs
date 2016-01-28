﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace chevron.Models
{
    public class HireModel
    {
        public Int32 id { get; set; }
        public string tgl_start { get; set; }
        public string tgl_end { get; set; }
        public string vessel { get; set; }
        public Decimal cost_usd { get; set; }
        public Decimal mob_cost { get; set; }
        public Int16 curency_cat { get; set; }

    }
}