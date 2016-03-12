using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace inForce.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string LineOfInsurance { get; set; }
        public List<Agent> CaptiveAgents { get; set; }

    }
}