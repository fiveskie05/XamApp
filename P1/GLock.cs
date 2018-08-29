using System;
using System.Collections.Generic;
using System.Text;

namespace P1
{
    class GLock
    {

        private static bool _lock = true;

        public static bool Unlock
        {
            get { return _lock; }
            set { _lock = value; }
        }

    }
}
