﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1
{
    public interface Talkable
    {
        String Talk();

        String Name { get; }
    }
}
