using System.Threading.Tasks;

namespace TodoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SingletonImplementation Todo = SingletonImplementation.Instance;
            SingletonImplementation Todo1 = SingletonImplementation.Instance;
            TaskFactory factory = new TaskFactory();
            while (true)
            {
                Console.WriteLine("1. Add Task\n2. View Task\n3. Exit \n Choose an option:");
                string? choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.Write("Enter task type (personal/work): ");
                        string? type = Console.ReadLine();
                        Console.Write("Enter task name: ");
                        string? name = Console.ReadLine();
                        if (type!= null && name != null)
                                {
                            ITaskType task = factory.CreateTask(type, name);
                            if (task != null)
                            {
                                Todo.AddTask(task);
                                Todo1.AddTask(task);
                            }
                            else
                            {
                                Console.WriteLine("Please enter 'personal' or 'work'");
                            }
                        }
                        break;

                    case "2":
                        Todo.DisplayTask();
                        Todo1.DisplayTask();
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
