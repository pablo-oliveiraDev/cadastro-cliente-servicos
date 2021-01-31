using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Npgsql;
using NpgsqlTypes;
using Excepitions;
using System.Data.Entity;

namespace Entities
{
    public class DataContext : DbContext
    {
        
        public DataContext() : base("DbManutInfor")
        {

        }
        public DbSet<Cliente> cliente { get; set; }

        public DbSet<Servicos> servicos { get; set; }
        public DbSet<Revisao> revisao { get; set; }

    }

}









