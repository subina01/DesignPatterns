using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDemo
{
    public class ChargerAdapter : ITypeCPhone
    {
        private oldCharger oldCharger;
        public ChargerAdapter(oldCharger oldCharger)
        {
            this.oldCharger = oldCharger;
        }

        public void ConnectTypeC()
        {
            Console.WriteLine("Using Adapter to Connect");
            oldCharger.ConnectUSBA();
        }
    }
}
