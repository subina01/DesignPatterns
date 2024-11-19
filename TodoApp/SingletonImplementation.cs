using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp
{
    public sealed class SingletonImplementation
    {
        public static int count = 0;
        private static readonly SingletonImplementation instance = new SingletonImplementation();
        private readonly List<ITaskType> tasks = new List<ITaskType>();
       private static readonly object lockObject = new object();

        private SingletonImplementation()
        {
            count++;
            tasks = new List<ITaskType>();
            Console.WriteLine($"count :{count}");
        }
        public static SingletonImplementation Instance { 
            get { lock (lockObject)
                {
                    return instance;
                }
            } 
        }
        public void AddTask(ITaskType task)
        {
            tasks.Add(task);
            Console.WriteLine("Task Added!");
            
        }
        public void DisplayTask()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("No task available");
            }
            else
            {
                Console.WriteLine("To do List");
                for (int i = 0; i < tasks.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. Type is :{tasks[i].GetTaskType()} Name:  {tasks[i].Name} ");


                }

            }
        }
    }
}
