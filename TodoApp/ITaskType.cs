namespace TodoApp
{
    public interface ITaskType
    {
        string GetTaskType();
        string Name { get; }
    }

    public class PersonalTask : ITaskType
    {
        public string Name { get; }

        public PersonalTask(string name)
        {
            Name = name;
        }

        public string GetTaskType()
        {
            return "Personal Task";
        }
    }

    public class WorkTask : ITaskType
    {
        public string Name { get; }

        public WorkTask(string name)
        {
            Name = name;
        }

        public string GetTaskType()
        {
            return "Work Task";
        }
    }
    public class DefaultTask : ITaskType
    {
        public string Name { get; } = "Unknown Task";
        public string GetTaskType() => "Invalid Task Type";
    }
    public class TaskFactory
    {
        public ITaskType CreateTask(string type, string name)
        {
            switch (type.ToLower())
            {
                case "personal":
                    return new PersonalTask(name);
                case "work":
                    return new WorkTask(name);
                default:
                    return new DefaultTask();
            }
        }
    }

}