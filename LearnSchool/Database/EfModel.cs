using System;
using System.Data.Entity;
using System.Linq;
using MySql.Data.MySqlClient;
using MySql.Data.EntityFramework;
using LearnSchool.Database.Entities;

namespace LearnSchool.Database
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class EfModel : DbContext
    {
        public static string Login { private get; set; }
        public EfModel(): base(new MySqlConnectionStringBuilder
        {
            Server = "cfif31.ru",
            UserID = Login,
            Password = Login,
            Database = Login + "_SobachePole4"
        }
        .ConnectionString) {}

        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<ClientService> ClientServices { get; set; }

        private static EfModel instance;

        public static EfModel Instance => instance ?? (instance = new EfModel());
    }

    
}