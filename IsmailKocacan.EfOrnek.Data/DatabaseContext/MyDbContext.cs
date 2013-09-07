using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace IsmailKocacan.EfOrnek.Data.DatabaseContext
{
    public class MyDbContext : DbContext
    {

        public MyDbContext()
        {
            this.Database.CreateIfNotExists();
            this.Configuration.LazyLoadingEnabled = true;
        }


        // factory method
        public static MyDbContext create()
        {
            var context = new MyDbContext();
            return context;
        }
    }
}
