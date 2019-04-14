using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Soft2.Models
{
    public class Soft2Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Soft2Context() : base("name=Soft2Context")
        {
        }

        public System.Data.Entity.DbSet<Soft2.Models.Cliente> Clientes { get; set; }
    }
}
