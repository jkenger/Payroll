using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_System
{
    public abstract class PersonalDetails
    {
        protected int employeeId;
        protected string employeeName;
        protected int ratePerHour;
        protected int hourPerDay;
        protected int noOfDays;
        protected int grossSalary;
        protected int netSalary;
        public abstract void setGrossSalary(int rateHour, int hourDay, int numDays);
        public abstract int getGrossSalary();
        public abstract void setNetSalary();
        public abstract int getNetSalary();
        public abstract void setTotalDeduction(double tax, double sss, double philHealth);
        public abstract int getTotalDeduction();

        public PersonalDetails(int id, string name, int rateHour, int hourDay, int numDays)
        {
            //Get Personal Details
            this.employeeId = id;
            this.employeeName = name;
            this.ratePerHour = rateHour;
            this.hourPerDay = hourDay;
            this.noOfDays = numDays;
        }
        
    }

    class salaryDeduction : PersonalDetails
    {
        private int totalDeduction;
        private int totalGrossSalary;
        private int totalNetSalary;
        private int totalTax;
        private int totalSSS;
        private int totalPhilHealth;
        public salaryDeduction(int id, string name, int rateHour, int hourDay, int numDays) : base(id, name, rateHour, hourDay, numDays)
        {
            double tax = .15;
            double sss = .02;
            double philHealth = .05;

            setGrossSalary(rateHour, hourDay, numDays);
            setTotalDeduction(tax, sss, philHealth);
            setNetSalary();
            
        }

        //Setter;
        public override void setGrossSalary(int rateHour, int hourDay, int numDays)
        {
            totalGrossSalary = (rateHour * hourDay) * numDays;
        }

        public override void setTotalDeduction(double tax, double sss, double philHealth)
        {
            // Compute The Totals From Total Gross Salary
            this.totalTax = (int)(totalGrossSalary * tax);
            this.totalSSS = (int)(totalGrossSalary * sss);
            this.totalPhilHealth = (int)(totalGrossSalary * philHealth);

            this.totalDeduction = totalTax + totalSSS + totalPhilHealth; // Set The Total Deduction From Tax Sss And Philhealth

        }

        public override void setNetSalary()
        {
            this.totalNetSalary = this.totalGrossSalary - this.totalDeduction;
        }

        //Getter;
        public override int getGrossSalary()
        {
            return this.totalGrossSalary;
        }

        public override int getTotalDeduction()
        {
            return this.totalDeduction;
        }

        public override int getNetSalary()
        {
            return this.totalNetSalary;
        }

        public int getTotalTax()
        {
            return this.totalTax;
        }
        public int getTotalSSS()
        {
            return this.totalSSS;
        }
        public int getTotalPhilHealth()
        {
            return this.totalPhilHealth;
        }
    }

}
