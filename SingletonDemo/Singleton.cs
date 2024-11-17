using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{


    public sealed class Singleton // should be sealed otherwise violates the principle of singleton design pattern incase nested derive class is created
    {
        private  int counter = 0;

        //private static readonly object obj = new object();

        //private static Singleton instance = null; // instance variable should be private static 
        private static readonly Singleton instance = new Singleton(); //in case of eager loading
        public static Singleton GetInstance //leverages on the private property,public property to return instance
        {                                   // also here we are delaying the instance creation till the getinstance property is invoked called lazy loading 
            get
            {
               //if (instance == null)// creates a new instance if the instance hasn't been created yet
               // {
               //     lock (obj)//if there is task running in parallel
               //     {
               //         instance = new Singleton();  
               // }
               //}
                return instance;
            }
        }
        private Singleton() // constructor class should be declared private  as this ensures that object is not instantiated other than with in the class itself.
        {
            counter++;
            Console.WriteLine($"counter = {counter}");
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
