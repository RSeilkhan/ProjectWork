﻿using Lunch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lunch.Interfaces
{
    public interface IAllLinks
    {
        IEnumerable<Link> Links { get; }
        Link getObjectLink(int linkId);
    }
}
