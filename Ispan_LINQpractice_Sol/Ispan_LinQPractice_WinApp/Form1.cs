using Ispan_LinQPractice_WinApp.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ispan_LinQPractice_WinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonQuery_Click(object sender, EventArgs e)
        {
            DataSet1 dsNorthWind = new DataSet1();
            EmployeesTableAdapter taEmp = new EmployeesTableAdapter();
            taEmp.Fill(dsNorthWind.Employees);
            dataGridView1.DataSource = taEmp.GetData();
        }

        private void buttonQuery2_Click(object sender, EventArgs e)
        {
            DataSet1 dsNorthWind = new DataSet1();
            EmployeesTableAdapter taEmp = new EmployeesTableAdapter();
            taEmp.Fill(dsNorthWind.Employees);

            var qEmp = from emp in dsNorthWind.Employees
                       where emp.Country == "USA"
                       select emp;
            //dataGridView1.DataSource = qEmp.ToList();
            dataGridView1.DataSource = qEmp.AsDataView();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = string.Empty;
            string[] arrCitys = { "Los Angeles", "Amsterdam", "Vilnius" };
            char[] arrChar = { 'A', 'V', 'P' };
            // 選擇A V P開頭的
            IEnumerable<string> qCity = from city in arrCitys
                                        where arrChar.Contains(city[0])
                                        select city;

            foreach (string a in qCity)
            {
                textBoxResult.Text += a + " \r\n";
            }
        }

        private void buttonLinQObj_Click(object sender, EventArgs e)
        {
            DataSet1 dsNorthWind = new DataSet1();
            EmployeesTableAdapter taEmp = new EmployeesTableAdapter();
            taEmp.Fill(dsNorthWind.Employees);

            //var qEmp0 = from emp in dsNorthWind.Employees
            //            where emp.Country != null
            //            select emp;
            //var data = qEmp0.ToList();
            var qEmp = from emp in dsNorthWind.Employees
                       where emp.Country == "USA"
                       select new
                       {
                           Name = emp.FirstName + " " + emp.LastName,
                           emp.City
                       };
            //dataGridView1.DataSource = qEmp.ToList();
            dataGridView1.DataSource = qEmp.ToList();
        }

        private void buttonQueryCategory_Click(object sender, EventArgs e)
        {
            DataSet1 dsNorthWind = new DataSet1();
            CategoriesTableAdapter taCategory = new CategoriesTableAdapter();
            taCategory.Fill(dsNorthWind.Categories);

            var qC = from c in dsNorthWind.Categories
                     select c.CategoryName into CC
                     from intoC in CC
                     select intoC;

            //var qC = from c in dsNorthWind.Categories
            //         select c.CategoryName ;
            var qC2 = from c in dsNorthWind.Categories
                      select new { CategoryName = c.CategoryName };
            dataGridView1.DataSource = qC2.ToList();
            string result = string.Empty;
            foreach (var c in qC) {
                result += c + "\n";
            }
            MessageBox.Show(result);

        }

        private void buttonGroupByLinQ_Click(object sender, EventArgs e)
        {
            DataSet1 dsNorthWind = new DataSet1();
            EmployeesTableAdapter taEmp = new EmployeesTableAdapter();
            taEmp.Fill(dsNorthWind.Employees);
            var qEmp = from emp in dsNorthWind.Employees
                       group emp by emp.Country into gEmp
                       select new
                       {
                           Country = gEmp.Key,
                           COUNT = gEmp.Count()
                       };
            dataGridView1.DataSource = qEmp.ToList();
        }

        private void buttonCreateDat_Click(object sender, EventArgs e)
        {
            DataSet1 dsNorthWind = new DataSet1();
            TestTable2TableAdapter table2 = new TestTable2TableAdapter();
            table2.Fill(dsNorthWind.TestTable2);
            var qEmp = from emp in dsNorthWind.TestTable2
                       select new
                       {
                           Number = emp.Num
                       };
            dataGridView1.DataSource = qEmp.ToList();
            //DataTable dataTable = new DataTable();
            //dataTable.Columns.Add("id", typeof(int));
            ////dataTable.Columns.Add("name", typeof(string));

            //for (int i = 0; i < 10; i++)
            //{
            //    DataRow row = dataTable.NewRow();
            //    row[0] = i;
            //    //row[1] = "name" + i;
            //    dataTable.Rows.Add(row);
            //}
            //dataGridView1.DataSource = dataTable;

        }
 
        private void button2_Click(object sender, EventArgs e)
        {
            DataSet1 dsNorthWind = new DataSet1();
            TestTable2TableAdapter table2 = new TestTable2TableAdapter();
            table2.Fill(dsNorthWind.TestTable2);


            var myArr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 } ;
            var qEmp = from emp in myArr
                       where emp % 2 == 0
                       select new
                       {
                           Number = emp
                       };


            //var qEmp = from emp in dsNorthWind.TestTable2
            //           where emp.Num % 2 == 0
            //           select new
            //           {
            //               Number =  emp.Num
            //           };
            dataGridView1.DataSource = qEmp.ToList();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataSet1 dsNorthWind = new DataSet1();
            TestTable2TableAdapter table2 = new TestTable2TableAdapter();
            table2.Fill(dsNorthWind.TestTable2);
            var qEmp = from emp in dsNorthWind.TestTable2
                       group emp by (emp.Num % 2 ==0 ) into gEmp
                       select new
                       {
                           Key = gEmp.Key == true ? "偶數" : "奇數",
                           COUNT = gEmp.Count()
                       };



            //group emp by emp.Country into gEmp
            //           select new 
            //           {
            //               Country = gEmp.Key,
            //               COUNT = gEmp.Count()
            //           };
            dataGridView1.DataSource = qEmp.ToList();

        }
    }
}
