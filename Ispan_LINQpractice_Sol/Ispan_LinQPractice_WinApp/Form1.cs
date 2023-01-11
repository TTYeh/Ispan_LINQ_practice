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
            EmployeesTableAdapter taEmp =  new EmployeesTableAdapter();
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
            IEnumerable<string> qCity = from city in arrCitys
                                        where arrChar.Contains(city[0])
                                        select city;

            foreach (string a in qCity)
            {
                textBoxResult.Text += a +" \r\n";
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
    }
}
