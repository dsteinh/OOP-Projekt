﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Dal
{
    public interface IParsable
    {
         T Parse<T>(string path);
    }
}
