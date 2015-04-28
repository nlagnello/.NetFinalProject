using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject.Models
{
    public class Type
    {

        public string TypeName { get; set; }
        public int TypeId { get; set;}
        public Type strength {get;set;}
        public Type weakness { get; set; }
    }
}