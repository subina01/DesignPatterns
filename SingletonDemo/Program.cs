using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
             
            PrintEmpDetails();
            PrintStuDetails();

        }

        private static void PrintStuDetails()
        {
            Singleton FromStudent = Singleton.GetInstance;
            FromStudent.PrintDetails("From Student");
        }

        private static void PrintEmpDetails()
        {
            Singleton FormEmployee = Singleton.GetInstance;
            FormEmployee.PrintDetails("From Employee");
        }
    }
}