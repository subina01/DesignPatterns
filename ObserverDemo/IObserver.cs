namespace ObserverDemo
{
    public interface IObserver
    {//Observer
        void Update(float temperature);
    }

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