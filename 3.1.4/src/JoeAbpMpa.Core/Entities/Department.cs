﻿using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoeAbpMpa.Entities
{
    public class Department : Entity
    {
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
