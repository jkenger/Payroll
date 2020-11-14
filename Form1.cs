using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_System
{
    public partial class Form1 : Form
    {
        salaryDeduction sd;
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int empId = Convert.ToInt32(tbEmpId.Text);
            string empName = tbEmpName.Text.ToString();
            int ratePerHour = Convert.ToInt32(tbRph.Text);
            int hourPerDay = Convert.ToInt32(tbHpd.Text);
            int numOfDays = Convert.ToInt32(tbNod.Text);

            sd = new salaryDeduction(empId, empName, ratePerHour, hourPerDay, numOfDays); //Instatiate Personal Detail Class
            //Console.WriteLine(sd.getGrossSalary());

            //Set Value In Their Perspective Textbox
            tbGrossSalary.Text = sd.getGrossSalary().ToString();
            tbGrossSalary2.Text = sd.getGrossSalary().ToString();

            tbTax.Text = sd.getTotalTax().ToString();
            tbSSS.Text = sd.getTotalSSS().ToString();
            tbPH.Text = sd.getTotalPhilHealth().ToString();

            tbTotalDed.Text = sd.getTotalDeduction().ToString();
            tbTotalDed2.Text = sd.getTotalDeduction().ToString();

            tbNetSalary.Text = sd.getNetSalary().ToString();
        }

        private void tbClear_Click(object sender, EventArgs e)
        {
            tbEmpId.Text = "";
            tbEmpName.Text = "";
            tbRph.Text = "";
            tbHpd.Text = "";
            tbNod.Text = "";
        }
    }
}
