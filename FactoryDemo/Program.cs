


namespace FactoryDemo
{
    class Program
    {
        public static void Main(string[] args) {
            Factory factory = new SubFactory();//creating object without exposing creation logic to clients
            ProductionFactory product = factory.ProductionProcess("Product3");

            product.ProducedGood();
        
        
        }
    }
}