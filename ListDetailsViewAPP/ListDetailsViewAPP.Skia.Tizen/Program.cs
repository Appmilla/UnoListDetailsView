﻿using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace ListDetailsViewAPP.Skia.Tizen
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new ListDetailsViewAPP.App(), args);
            host.Run();
        }
    }
}
