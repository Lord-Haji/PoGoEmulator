﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PoGoPrivate
{
    public static class Global
    {
        public static int port = 3000;
        public static IPAddress ip = IPAddress.Any;
        public static int maxRequestContentLength = (1024 * 1024) * (1); //1MB
#if DEBUG

        public static TimeSpan requestTimeout = new TimeSpan(0, 10, 0);
#else
        public static TimeSpan requestTimeout = new TimeSpan(0, 0, 15);
#endif
        public static TimeSpan garbageTime = new TimeSpan(0, 0, 10);
    }
}