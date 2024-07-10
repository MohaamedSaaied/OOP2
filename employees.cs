using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP2
{

    #region 3.2


    //Develop a Class to represent the Hiring Date Data:
    //consisting of fields to hold the day, month and Years.

    public class HD
    {
        public int day { get; set; }
        public int month { get; set; }
        public int year { get; set; }
        public HD(int day, int month, int year)
        {
            if (day < 1 || day > 31 || month < 1 || month > 12 || year < 0)
            {
                throw new ArgumentException("Invalid date values.");
            }
            this.day = day;
            this.month = month;
            this.year = year;
        }
        public override string ToString()
        {
            return $"{month}/{day}/{year}";
        }
    }

    #endregion

    #region 3.4

    //Assign the following security privileges to the employee (guest, Developer, secretary and DBA) in a form of Enum


    public enum SL
    {
        guest = 1, Developer = 2, secretary = 3, DBA = 4
    }

    #endregion

    #region 3.3

    //We need to restrict the Gender field to be only M or F[Male or Female]


    public enum G
    {
        M = 1, F = 2
    }

    #endregion

    class employees
    {
        #region 3.1

        //Design and implement a Class for the employees in a company:
        //Employee is identified by an ID, Name, security level, salary, hire date and Gender.


        public int id { get; set; }
        public string name { get; set; }
        public SL secL { get; set; }
        public double salary { get; set; }
        public HD hireDate { get; set; }
        public G gender { get; set; }


        #endregion

        #region 3.5

        //We want to provide the Employee Class to represent Employee data in a string Form(override ToString()),
        //display employee salary in a currency format. [use String.Format Function]


        public override string ToString()
        {
            return $"ID: {id}," +
                $" Name: {name}," +
                $" Security Level: {secL}," +
                $" Salary: {salary:C}," +
                $" Hire Date: {hireDate}," +
                $" Gender: {gender}";
        }

        #endregion

        public employees(int id, string name, SL secL, double salary, HD hireDate, G gender)
        {
            this.id = id;
            this.name = name;
            this.secL = secL;
            this.salary = salary;
            this.hireDate = hireDate;
            this.gender = gender;

        }

    }
}

