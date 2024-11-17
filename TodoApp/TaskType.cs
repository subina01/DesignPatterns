using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp
{
    public abstract class TaskType

    {
        
        public abstract string GetTaskType();

    }


    public class PersonalTask:TaskType
    {
        public override string GetTaskType()
        {
            return "Personal Task";
        }
    }

    public class WorkTask : TaskType
    {
        public override string GetTaskType()
        {
            return "Personal Task";
        }
    }


    public class TaskFactory
    {
        public TaskType CreateTask(string type)
        {
            switch (type.ToLower())
            {
                case "personal":
                    return new PersonalTask();
                case "work":
                    return new WorkTask();
                default:
                    return null;
            }
        }



    }
}

