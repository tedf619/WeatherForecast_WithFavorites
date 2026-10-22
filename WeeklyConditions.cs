namespace WeatherForecastWithFavorites;

public partial class WeeklyConditions : UserControl
{
  List<DailyConditions> dailyConditions = [];

  public WeeklyConditions()
  {
    InitializeComponent();

    // the UserControls for each day in the 7-day forecast
    dailyConditions.AddRange(
      [
        dailyConditions1, dailyConditions2, dailyConditions3, dailyConditions4,
        dailyConditions5, dailyConditions6, dailyConditions7
      ]);
  }

  public void ShowWeatherData(City city, List<WeatherData> weatherData, bool useCelsius)
  {
    labelWeatherForCity.Text = $"Weather for {city.Name}, {city.Admin} ({city.Country})";

    for (int i = 0; i < weatherData.Count; i++)
      dailyConditions[i].SetWeatherData(weatherData[i], useCelsius);
  }
}
