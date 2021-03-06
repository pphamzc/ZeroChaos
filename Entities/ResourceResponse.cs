﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZeroChaos.Business.Entities
{
    public class ResourceResponse
    {
        public string CareerGoal { get; set; }
        public string AspiringQuote { get; set; }
        public string Website { get; set; }
        public string MonthAndDayOfBirth { get; set; }
        public int UniqueResourceID { get; set; }
        public string NationalID { get; set; }
        public string CitizenCountryCode { get; set; }
        public bool AllowProfileSearch { get; set; }
        public bool WillingToRelocate { get; set; }

    }
}
