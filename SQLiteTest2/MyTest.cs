using SQLiteTest2.Database;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassRegLite.Tests
{
    class MyTest
    {


        public static void testfile()
        {
            FileStream f = new FileStream("mydatabase.sqlite", FileMode.Open);
            f.Close();

        }

        public static void mytest()
        {

            //SQLiteConnection dbCon = new SQLiteConnection("Data Source=mydatabase.sqlite;Version=3;");
            //dbCon.Open();

            MyDb dbc = new MyDb();

            var s = from a in dbc.Studenti
                    orderby a.Vek
                    select a;

            foreach (var x in s)
            {
                MessageBox.Show(string.Format("{0} {1}", x.Jmeno,x.Prijmeni));
           
            }


        }


        
        public static void manCon()
        {

            
            var connection = new SQLiteConnection("Data Source=mydatabase.sqlite");
            var context = new DataContext(connection);

            var stud = context.GetTable<Student>();
            foreach(var j in stud)
            {
                MessageBox.Show(string.Format("Company: {0} {1}", 
                    j.Jmeno, j.Prijmeni));
            }
            
            //Console.ReadKey();
            

        }


        public static void insert()
        {
            MyDb dbc = new MyDb();

            Student s = new Student()
            {
                Jmeno = "Radek",
                Prijmeni = "Novak",
                Vek = 30
            };

            
            //dbc.dbStudenti.InsertOnSubmit(s);
            dbc.Studenti.Add(s);

            // Submit the change to the database. 
            try
            {
                dbc.SaveChanges();
                //dbc.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                // Make some adjustments. 
                // ... 
                // Try again.
                //dbc.SubmitChanges();
            }
        }

    }


}
