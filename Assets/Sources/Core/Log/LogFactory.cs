﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Sources.Core.Log
{
    public class LogFactory
    {
        public static LogStrategy CreateLog()
        {
            return new NullLogStrategy();
        }
    }
}
