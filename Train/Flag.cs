using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    class Flag
    {
        static private bool loginFlag = false;
        static private bool adminFlag = false;

        public bool LOGIN
        {
            get { return loginFlag; }
            set { loginFlag = value; }
        }
        public bool ADMIN
        {
            get { return adminFlag; }
            set { adminFlag = value; }
        }
    }
}
