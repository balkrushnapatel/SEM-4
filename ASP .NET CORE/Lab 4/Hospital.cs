﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class Hospital
    {
        public virtual string HospitalDetails()
        {
            string name = Console.ReadLine();
            return name;
        }
    }

    class Apollo : Hospital
    {
        public virtual string HospitalDetails()
        {
            string name = Console.ReadLine();
            return name;
        }
    }

    class Wockhardt : Hospital
    {
        public virtual string HospitalDetails()
        {
            string name = Console.ReadLine();
            return name;
        }
    }

    class Gokul_Superspecialist : Hospital
    {
        public virtual string HospitalDetails()
        {
            string name = Console.ReadLine();
            return name;
        }
    }
}
