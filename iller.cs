﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
   
    public class il
    {
        public string Il { get; set; }
        public List<ilce> Ilce { get; set; }
    }
    public class ilce
    {
        public string Ilce { get; set; }
        public List<semt> Semt { get; set; }
    }
    public class semt
    {
        public string Semt { get; set; }
        public string PostaKodu { get; set; }
        public List<mahalle> Mahalle { get; set; }
    }
    public class mahalle
    {
        public string Mahalle { get; set; }
    }

}
