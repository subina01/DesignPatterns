using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp
{
    public sealed class SingletonImplementation
    {
        private static readonly SingletonImplementation instance = new SingletonImplementation();

        private readonly List<string> tasks = new List<string>();

        private SingletonImplementation() {
        
            tasks = new List<string>();
        
        }

        public static SingletonImplementation Instance { get { return instance; } }

        public void AddTask(string task) {
        tasks.Add(task);
            Console.WriteLine("Task Added!");
        
        }


        public void DisplayTask()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("No task available");
            }
            else {
                Console.WriteLine("To do List");
                for (int i = 0; i < tasks.Count; i++) {
                Console.WriteLine($"{i +1}. {tasks[i]}");
                
                }
            
            }
        }
    }
}
