using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLitwareLib
{
    public class Employee
    {
        private int EmpNo;
        private string EmpName;
        private double Salary;
        private double HRA;
        private double TA;
        private double DA;
        private double PF;
        private double TDS;
        private double NetSalary;
        private double GrossSalary;

        public int empNumber
        {
            get { return this.EmpNo; }
            set { this.EmpNo = value; }
        }

        public string empName
        {
            get { return this.EmpName; }
            set { this.EmpName = value; }
        }

        public double salary
        {
            get { return this.Salary; } 
            set { this.Salary = value; }
        }

        public double calculate_HRA(double salary)
        {
            if(salary < 5000)
            {
                this.HRA = 0.1 * salary;
                //return this.HRA;
            }
            else if(salary < 10000)
            {
                this.HRA = 0.15 * salary;
            }
            else if(salary < 15000)
            {
                this.HRA = 0.2 * salary;
            }
            else if(salary < 20000)
            {
                this.HRA = 0.25 * salary;   
            }
            else if(salary >= 20000)
            {
                this.HRA = 0.3 * salary;
            }
            return this.HRA;
        }
        public double calculate_TA(double salary)
        {
            if (salary < 5000)
            {
                this.TA = 0.05 * salary;
                //return this.HRA;
            }
            else if (salary < 10000)
            {
                this.TA = 0.1 * salary;
            }
            else if (salary < 15000)
            {
                this.TA = 0.15 * salary;
            }
            else if (salary < 20000)
            {
                this.TA = 0.2 * salary;
            }
            else if (salary >= 20000)
            {
                this.TA = 0.25 * salary;
            }
            return this.TA;
        }

        public double calculate_DA(double salary)
        {
            if (salary < 5000)
            {
                this.DA = 0.15 * salary;
                //return this.HRA;
            }
            else if (salary < 10000)
            {
                this.DA = 0.2 * salary;
            }
            else if (salary < 15000)
            {
                this.DA = 0.25 * salary;
            }
            else if (salary < 20000)
            {
                this.DA = 0.3 * salary;
            }
            else if (salary >= 20000)
            {
                this.DA = 0.35 * salary;
            }
            return this.DA;
        }
        public double grossSalary( double salary)
        {
            this.GrossSalary = salary + this.HRA + this.DA + this.TA;
            return this.GrossSalary;
        }

        public void CalculateSalary()
        {
            this.PF = 0.1 * GrossSalary;
            this.TDS = 0.18 * GrossSalary;
            this.NetSalary = GrossSalary - this.PF - this.TDS;
        }

    }
}
