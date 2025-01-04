public class SmartWatchDisplay : IWeatherInfoObserver, IDisplayData
{
    private WeatherDataDTO SmartWatchWeatherData;
    private IWeatherInfo smartWatchWeatherSubscriptionHandler;

    public SmartWatchDisplay(IWeatherInfo weatherInfoSubject){
        smartWatchWeatherSubscriptionHandler = weatherInfoSubject;
        smartWatchWeatherSubscriptionHandler.AddObserver(this);
        SmartWatchWeatherData = new WeatherDataDTO();
    }

    public void Display()
    {
        Console.WriteLine("******Smart Watch Display*****");
        Console.WriteLine("Temperature: " + SmartWatchWeatherData.Temperature);
        Console.WriteLine("Pressure: " + SmartWatchWeatherData.Pressure);
        Console.WriteLine("Humidity: " + SmartWatchWeatherData.Humidity);
    }

    public void UpdateWeatherData(WeatherDataDTO weatherdata)
    {
        SmartWatchWeatherData.Temperature = weatherdata.Temperature;
        SmartWatchWeatherData.Pressure = weatherdata.Pressure;
        SmartWatchWeatherData.Humidity = weatherdata.Humidity;

        Display();

    }
}