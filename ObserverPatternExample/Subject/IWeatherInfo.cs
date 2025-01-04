public interface IWeatherInfo
{
    List<IWeatherInfoObserver> Observers { get; set; }

    void AddObserver(IWeatherInfoObserver observer);
    void RemoveObserver(IWeatherInfoObserver observer);
    void NotifyDataChange();
}