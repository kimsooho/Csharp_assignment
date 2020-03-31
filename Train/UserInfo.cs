using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{   
    class UserInfo
    {
        //완료
        static private string _name = string.Empty;
        static private string _id = string.Empty;
        static private string _lastConnectionTime = string.Empty;
        static private string _phone = string.Empty;
        static private string _email = string.Empty;


        public string NAME
        {
            get { return _name; }
            set { _name = value; }
        }

        public string ID
        {
            get { return _id; }
            set { _id = value; }

        }

        public string LASTCONNECTIONTIME
        {
            get { return _lastConnectionTime; }
            set { _lastConnectionTime = value; }
        }

        public string PHONE
        {
            get { return _phone; }
            set { _phone = value; }
        }

        public string EMAIL
        {
            get { return _email; }
            set { _email = value; }
        }
    }
}
