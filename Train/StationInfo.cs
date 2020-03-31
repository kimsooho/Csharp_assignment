using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    class StationInfo
    {
        static public string startStation = "";
        static public string endStation = "";

        static public string START
        {
            get { return startStation; }
            set { startStation = value; }
        }

        static public string END
        {
            get { return endStation; }
            set { endStation = value; }
        }
    }
}
