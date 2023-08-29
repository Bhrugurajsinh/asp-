 using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Computer_Model.Models
{
    public class Database : DbContext
    {
        public Database() : base("MyDB")
        { 
            
        }
        public DbSet<ComputerModel> Computers { get; set; }
    }
}