﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VicMarket.Domain.Models
{
    public class AppSettings
    {
        public string? ApiUrl { get; set; }
        public string[]? ClientUrls  { get; set; }
        public string? FileStoreFolder { get; set; }
        public string? VicMarketEmailPath { get; set; }
    }
}
