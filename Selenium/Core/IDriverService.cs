﻿using System;
using System.Net;

namespace Selenium.Core {

    interface IDriverService {

        IPEndPoint IPEndPoint { get; }

        string Uri { get; }

        void Quit();

        void Dispose();

    }

}
