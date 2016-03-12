using Newtonsoft.Json;
using Salesforce.Common.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using inForce.Models.Salesforce;
namespace inForce.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PolicyNumber { get; set; }
        public List<Contact> ClientContact { get; set; }

    }
}