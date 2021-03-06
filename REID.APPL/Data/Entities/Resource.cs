﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REID.APPL.Data.Entities
{
    public class Resource
    {
        public int Id { get; set; }
        public string Name { get; set;}
        public int Cell { get; set; }
        public string Email { get; set; }
        public string Note { get; set; }
        public Task Task { get; set; }
    }
}
