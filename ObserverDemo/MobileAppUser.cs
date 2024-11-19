using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDemo
{
    public class MobileAppUser : IObserver
    {
        private string name;

        public MobileAppUser(string name)
        {
            this.name = name;
        }

        public void Update(float temperature)
        {
            Console.WriteLine($"{name} Here's your Weather Update: Temperature is {temperature} degrees Celsius");
        }
    }
}
