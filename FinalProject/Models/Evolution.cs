using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject.Models
{
    public class Evolution
    {
        public int EvolStageId { get; set; }

        public Pokemon EvolFrom { get; set; }
        public Pokemon EvolTo { get; set; }
    }
}