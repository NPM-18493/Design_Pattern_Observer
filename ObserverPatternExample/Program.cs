// See https://aka.ms/new-console-template for more information

IWeatherInfo weatherInfo = new WeatherInfo();

//Passing subject to observer so that observer can have power to unsubscribe itself
IWeatherInfoObserver smartWatchDisplayObserver = new SmartWatchDisplay(weatherInfo);
IWeatherInfoObserver mobileDisplayObserver = new MobileDisplay(weatherInfo);

//This will show data for both devices
weatherInfo.NotifyDataChange();

//Unsubscribing Smart watch device
weatherInfo.RemoveObserver(smartWatchDisplayObserver);

weatherInfo.NotifyDataChange();
