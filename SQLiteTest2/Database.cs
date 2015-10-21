using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
using System.Data.SQLite;
using System.Data.SQLite.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace SQLiteTest2.Database
{

    /// <summary>
    /// definice databaze:, dedi od DbContecxt
    /// musí obsahovat connectionsring 
    /// </summary>
    class MyDb : DbContext
    {
        //public const string connectionString = "Data Source=mydatabase.sqlite";
        public const string connectionString = "Data Source=|DataDirectory|mydatabase.sqlite";
        public DbSet<Student> Studenti { get; set; }

        public Table<Student> dbStudenti;

        public MyDb() : base("name=MyDbContext") { }

      
        
    }


    [Table(Name = "Studenti")]
    class Student
    {
        [Column(Name = "Id")]
        public int Id { get; set; }

        [Column(Name = "Jmeno")]
        public string Jmeno { get; set; }

        [Column(Name = "Prijmeni")]
        public string Prijmeni { get; set; }

        [Column(Name = "Vek")]
        public int Vek { get; set; }
    }
}
