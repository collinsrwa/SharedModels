﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels.Models
{
    public class TokenResponse
    {
        public string token { get; set; }
        public string expiration { get; set; }
    }
}
