using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Model
{
    class Harddisk
    {
        string driveLetter;
        string mbSize;
        public string DriveLetter
        {
            get {return driveLetter;}
            set{driveLetter = value;}
        }
        public string MbSize
        {
            get{return mbSize;}
            set{mbSize = value;}
        }
    }
}
