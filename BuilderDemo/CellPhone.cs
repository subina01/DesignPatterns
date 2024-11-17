using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BuilderDemo
{
    public class CellPhone// this is product
    {
        private string brand;
        private string Processor;
        private double screenSize;
        private int battery;
        private int camera;

        public CellPhone(string processor, double screenSize, int battery, int camera, string brand)
        {
            Processor = processor;
            this.screenSize = screenSize;
            this.battery = battery;
            this.camera = camera;
            this.brand = brand;
        }


        public override string ToString()
        {
            return $"Processor: {Processor}, ScreenSize: {screenSize}, battery: {battery}, camera:{camera}";
        }
    }
}
