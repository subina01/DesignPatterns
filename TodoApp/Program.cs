﻿namespace TodoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SingletonImplementation Todo = SingletonImplementation.Instance;

            while (true)
            {
                Console.WriteLine("TO DO APP");
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. View Task");
                Console.WriteLine("3. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();

                switch (choice) {

                    case "1":
                        Console.Write("Enter task description: ");
                        string task = Console.ReadLine();
                        Todo.AddTask(task);
                        break;


                    case "2":
                        Todo.DisplayTask();
                        break;


                    case "3":
                        Console.WriteLine("Exiting...");
                        return;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}