
using ObserverDemo;

public class Client
{
    public static void Main(string[] args)
    {
        WeatherStation weatherStation = new WeatherStation();

        
        MobileAppUser u1 = new MobileAppUser("User 1");
        MobileAppUser u2 = new MobileAppUser("User 2");

        weatherStation.AddObserver(u1);
        weatherStation.AddObserver(u2);

        weatherStation.SetTemperature(25.5f);
        weatherStation.RemoveObserver(u1);

        weatherStation.SetTemperature(30.0f);
    }
}