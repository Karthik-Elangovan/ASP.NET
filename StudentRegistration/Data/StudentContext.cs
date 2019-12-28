using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace StudentRegistration.Data
{
    public class StudentContext : DbContext
    {

        public StudentContext() : base("name=StudentRegistrationContext")
        {
        }

        public System.Data.Entity.DbSet<StudentRegistration.Models.Students> Students { get; set; }

    }

}