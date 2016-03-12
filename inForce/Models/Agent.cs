using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace inForce.Models
{
    public class Agent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProducerNumber { get; set; }
        public List<Company> CompanyAffiliations { get; set; }
        
    }
}