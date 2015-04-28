using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject.Models
{
    public class Pokemon
    {

        public int Number { get; set; }
        public string Name { get; set; }


        public Evolution Evolution {get;set;}
        public Type Type { get; set; }

    }
}