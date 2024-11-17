using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDemo
{
    public interface ProductionFactory //This is the abstract product interface, which defines the common interface that all products must implement.the client will
                                       // interact with this interface, not the concrete classes.
    {
        void ProducedGood();
    }

    public class Product1 : ProductionFactory//Concrete Product Which implements the interface
    {
        public void ProducedGood() {
            Console.WriteLine("Vehicle ");
        }
    }

    public class Product2 : ProductionFactory
    {
        public void ProducedGood()
        {
            Console.WriteLine("Food");
        }
    }

    public class Product3 : ProductionFactory
    {
        public void ProducedGood()
        {
            Console.WriteLine("Clothes ");
        }
    }

    public abstract class Factory
    {
        
        public abstract ProductionFactory ProductionProcess(string type);
    }

    
    public class SubFactory : Factory
    {
        
        public override ProductionFactory ProductionProcess(string type)
        {
            switch (type.ToLower())
            {
                case "product1":
                    return new Product1();//here the object creation is happening  but this logic is hidden from the client program
                case "product2":
                    return new Product2();
                case "product3":
                    return new Product3();
                default:
                    Console.WriteLine("Product Not Available");
                    return null;
            }
        }
    }
}


