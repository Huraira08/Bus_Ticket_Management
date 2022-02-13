using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Employee : Person
    {
        protected string employeeID;
        protected string title;
        protected int salary;
        //protected static int idCount = 0;
        public Employee(string name, string employeeID, string title, int salary)
            : base(name)
        {
            //this.name = name;
            this.employeeID = employeeID;
            this.title = title;
            this.salary = salary;
        }
        public Employee()
        {

        }
        public string EmployeeID 
        { 
            get
            {
                return employeeID;
            }
            set
            {
                employeeID = value;
            }
        }
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        public int Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }
        }
    }
}