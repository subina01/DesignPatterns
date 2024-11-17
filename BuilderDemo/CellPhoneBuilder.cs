using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDemo
{
    public class SamsungPhoneBuilder : ICellPhoneBuilder// this is concrete builder
    {
        private string brand = "Samsung";
        private string Processor;
        private double ScreenSize;
        private int Battery;
        private int Camera;


        public CellPhone GetPhone()
        {
            return new CellPhone(Processor, ScreenSize, Battery, Camera, brand);
        }

        public ICellPhoneBuilder SetOs(string processor)
        {
            this.Processor = processor;
            return this;
        }

        public ICellPhoneBuilder SetScreenSize(double screenSize)
        {
            this.ScreenSize = screenSize;
            return this;

        }

        public ICellPhoneBuilder SetBattery(int battery)
        {
            this.Battery = battery;
            return this;
        }


        public ICellPhoneBuilder SetCamera(int camera)
        {
            this.Camera = camera;
            return this;
        }
    }
}
