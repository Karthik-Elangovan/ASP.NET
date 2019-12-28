using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentRegistration.Models
{
 
    public class Students
    {
        public int ID { get; set; }
        public string name { get; set; }
        public int Std { get; set; }
        public string section { get; set; }
    }

}