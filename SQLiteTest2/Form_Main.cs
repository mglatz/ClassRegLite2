using ClassRegLite.Tests;
using SQLiteTest2.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLiteTest2
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button_test_Click(object sender, EventArgs e)
        {


            MyTest.mytest();
            MyTest.testfile();


            MyTest.manCon();
           //MyTest.insert();s
            

        }

        private void RefreshStudentGrid()
        {
            MyDb dbc = new MyDb();

            //var res = from s in dbc.Studenti
            //          select s;
            //var res2 = res.ToList();
            //dataGridView_Student.DataSource = res2;

            var x = dbc.Studenti.Count();

            //SQLiteDataAdapter a = new SQLiteDataAdapter();            
            //DataTable t = new DataTable();
            //dbc.Studenti.ToList().fill
            
            //dataGridView_Student.DataSource = dbc.Studenti;
            
            dataGridView_Student.DataSource = dbc.Studenti.ToList();
            dataGridView_Student.Refresh();

        }

        private void button_refreshStudent_Click(object sender, EventArgs e)
        {
            RefreshStudentGrid();
        }


    }
}
