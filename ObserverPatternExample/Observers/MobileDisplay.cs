public class MobileDisplay : IWeatherInfoObserver, IDisplayData
{
    private WeatherDataDTO MobileWeatherData;
    private IWeatherInfo mobileWeatherSubscriptionHandler;

    public MobileDisplay(IWeatherInfo weatherInfoSubject){
        mobileWeatherSubscriptionHandler = weatherInfoSubject;
        mobileWeatherSubscriptionHandler.AddObserver(this);
        MobileWeatherData = new WeatherDataDTO();
    }

    public void Display()
    {
        Console.WriteLine("~~~~~Mobile Display~~~~~");
        Console.WriteLine("Temperature: " + MobileWeatherData.Temperature);
        Console.WriteLine("Pressure: " + MobileWeatherData.Pressure);
        Console.WriteLine("Humidity: " + MobileWeatherData.Humidity);
    }

    public void UpdateWeatherData(WeatherDataDTO weatherdata)
    {
        MobileWeatherData.Temperature = weatherdata.Temperature;
        MobileWeatherData.Pressure = weatherdata.Pressure;
        MobileWeatherData.Humidity = weatherdata.Humidity;

        Display();

    }
}