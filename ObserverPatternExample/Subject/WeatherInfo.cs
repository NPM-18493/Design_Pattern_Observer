
public class WeatherInfo : IWeatherInfo
{
    public List<IWeatherInfoObserver> Observers { get; set; }

    public WeatherInfo(){
        Observers = new List<IWeatherInfoObserver>();
    }

    public void AddObserver(IWeatherInfoObserver observer)
    {
        Observers.Add(observer);
    }

    public void NotifyDataChange()
    {     
        WeatherDataDTO weatherdata = GetData();
        foreach (var observer in Observers)
        {
            observer.UpdateWeatherData(weatherdata);
        }
    }

    private WeatherDataDTO GetData(){
        Random random = new Random();

        return new WeatherDataDTO(){
            Temperature = random.Next(100),
            Pressure = random.Next(100),
            Humidity = random.Next(100)
        };
    }

    public void RemoveObserver(IWeatherInfoObserver observer)
    {
        Observers.Remove(observer);
    }
}