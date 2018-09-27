using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatasetPractice.DataSet1TableAdapters;

namespace DatasetPractice
{
    public partial class Form1 : Form
    {
        DataSet1.EmployeesDataTable emptable = new DataSet1.EmployeesDataTable();
        EmployeesTableAdapter empadapter = new EmployeesTableAdapter();

        public Form1()

        {
            InitializeComponent();
       
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            empadapter.Fill(emptable);
            DataTable dtable = emptable;
            Datagridview.DataSource = emptable;           
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            DataSet1.EmployeesRow employeerow = emptable.NewEmployeesRow();
            employeerow.emp_firstname = textBox1.Text;
            employeerow.emp_lastname = textBox2.Text;
            employeerow.emp_address = Addresstextbox.Text;
            employeerow.emp_hiredate = Hiredatetextbox.Text;
            employeerow.emp_jobtitle = Jobtitletextbox.Text;
            emptable.AddEmployeesRow(employeerow);
            Datagridview.Refresh();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            empadapter.Update(emptable);
        }
    }
}
