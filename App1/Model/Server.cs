using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace App1.Model
{
    class Server
    {
        string name;
        IPAddress iP;
        string mac;
        string status;
        int ram;
        List<Harddisk> hdd;
        public string Name
        {
            get{return name;}
            set{name = value;}
        }
        public IPAddress IP
        {
            get { return iP; }
            set { iP = value; }
        }
        public string Mac
        {
            get{return mac;}
            set{mac = value;}
        }
        public string Status
        {
            get{return status;}
            set{status = value;}
        }
        public int Ram
        {
            get{return ram;}
            set{ram = value;}
        }
        internal List<Harddisk> Hdd
        {
            get{return hdd;}
            set{hdd = value;}
        }
    }
}