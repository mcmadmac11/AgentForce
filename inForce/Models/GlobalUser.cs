using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using inForce.Models.Salesforce;
using System.ComponentModel.DataAnnotations;

namespace inForce.Models
{
    public class GlobalUser
    {
        [Key]
        public int GlobalUserId { get; set; }
        public Client GlobalClientId { get; set; }
        public Agent GlobalAgentId { get; set; }

    }
}