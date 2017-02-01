using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace App1.ViewModel
{
    class DalManager
    {
        //singleton
        private static DalManager _instance = null;

        private DalManager()
        { }

        public static DalManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DalManager();
                }
                return _instance;
            }
        }

        //retive data and send it to the requester
        public string GetName()
        {
            throw new NotImplementedException();
            return null;
        }

        public IPAddress GetIP()
        {
            throw new NotImplementedException();
            return null;
        }

        public string GetMAC()
        {
            throw new NotImplementedException();
            return null;
        }

        public string GetStatus()
        {
            throw new NotImplementedException();
            return null;
        }
    }
}
