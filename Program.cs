namespace OOP2
{
    struct Person
    { 
            public string name;
            public int age;
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            //Part 02

            #region 2.1

            ////Define a struct "Person" with properties "Name" and "Age".
            ////Create an array of three "Person" objects and populate it with data.Then,
            ////  write a C# program to display the details of all the persons in the array.
            //// Populate the array with data

            //Person[] p = new Person[3];
            //p[0] = new Person { name = "Mohamed", age = 8 };
            //p[1] = new Person { name = "Saaied", age = 18 };
            //p[2] = new Person { name = "Elokr", age = 28 };
            //for(int i=0;i<p.Length; i++)
            //{
            //    Console.WriteLine(" Name: "+p[i].name+" Age: " + p[i].age);
            //}

            #endregion

            #region 2.2

            //2 Create a struct called "Person" with properties "Name" and "Age".
            //Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.

            //Person[] p = new Person[3];
            //for (int i = 0; i < p.Length; i++)
            //{
            //    p[i] = new Person();
            //    Console.WriteLine(" Enter name of person number " + ( i + 1 ));
            //    p[i].name = Console.ReadLine();
            //    Console.WriteLine(" Enter age of person number " + (i + 1 ));
            //    p[i].age = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < p.Length; i++)
            //{
            //    Console.WriteLine(" Name: " + p[i].name + " Age: " + p[i].age);
            //}

            #endregion

            //Part 03

            //from 3.1 ->3.5 the answers are in employees class
            #region 3.1

            //Design and implement a Class for the employees in a company:
            //Employee is identified by an ID, Name, security level, salary, hire date and Gender.

            #endregion

            #region 3.2
            //Develop a Class to represent the Hiring Date Data:
            //consisting of fields to hold the day, month and Years.
            #endregion

            #region 3.3

            //We need to restrict the Gender field to be only M or F[Male or Female]

            #endregion

            #region 3.4

            //Assign the following security privileges to the employee (guest, Developer, secretary and DBA) in a form of Enum

            #endregion

            #region 3.5

            //We want to provide the Employee Class to represent Employee data in a string Form(override ToString()),
            //display employee salary in a currency format. [use String.Format Function]

            #endregion
            //from 3.1 ->3.5 the answers are in employees class


            #region 3.6

            ////Create an array of Employees with size three a DBA, Guest and the third one is security officer who have full permissions. (Employee[] EmpArr;)

            ////Notes:
            ////Implement All the Necessary Member Functions on the Class(Getters, Setters)
            ////Define all the Necessary Constructors for the Class
            ////Allow NO RUNTIME errors if the user inputs any data
            ////Write down all the necessary Properties(Instead of setters and getters)


            employees[] arr = new employees[3];
            arr[0] = new employees(1, "mohamed",SL.DBA, 20000, new HD(  18,  5, 2020 ),G.M);
            arr[1] = new employees(2, "mona", SL.guest, 18000, new HD(25, 7, 2023), G.F);
            arr[2] = new employees(3, "ahmed",SL.secretary, 12000, new HD(6, 9, 2023), G.M);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i].ToString());
            }

            #endregion

            #region 3.7

            //Sort the employees based on their hire date then Print the sorted array.
            //While sorting(how many times Boxing and Unboxing process has occurred)
            Array.Sort(arr, (a1, a2) => a1.hireDate.year.CompareTo(a2.hireDate.year));

            // Print sorted array
            foreach (var s in arr)
            {
                Console.WriteLine(s);
            }
            #endregion

        }
    }
        }
