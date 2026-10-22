namespace WeatherForecastWithFavorites
{
  public partial class FormMain : Form
  {
    List<WeatherData> lastWeatherData = [];
    City? lastCity;
    readonly WebApi webApi = new();

    public FormMain()
    {
      InitializeComponent();

      favorites.LoadFavorites();
    }

    async void ButtonSearch_Click(object sender, EventArgs e)
    {
      if (comboBoxCity.SelectedItem is City) return;  // the result of a previous search

      buttonAddToFavorites.Visible = false;

      await PerformCityLookupAsync();
    }

    async void ComboBoxCity_SelectionChangeCommitted(object sender, EventArgs e)
    {
      if (comboBoxCity.SelectedItem is not City city) return;

      buttonAddToFavorites.Visible = true;

      await LoadWeatherDataAsync(city);
    }

    void RadioButtonCelsius_CheckedChanged(object sender, EventArgs e)
    {
      if (lastWeatherData == null) return;

      ShowWeatherData(lastCity, lastWeatherData);
    }

    async Task PerformCityLookupAsync()
    {
      if (comboBoxCity.SelectedItem is City selectedCity)
      {
        // lookup already performed. Show weather for selected city
        await LoadWeatherDataAsync(selectedCity);
        return;
      }

      string query = comboBoxCity.Text.Trim();
      if (string.IsNullOrEmpty(query))
      {
        MessageBox.Show("Enter a city name.", "No City Entered", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      labelStatusMessage.Text = $"Finding matching cities...";
      comboBoxCity.Items.Clear();

      try
      {
        buttonSearch.Enabled = false;
        UseWaitCursor = true;

        List<City> cities = await webApi.LookupCities(query);

        UseWaitCursor = false;
        buttonSearch.Enabled = true;

        if (cities.Count == 0)
        {
          labelStatusMessage.Text = "No matching cities found";
          return;
        }

        // add matching cities to dropdown
        foreach (var city in cities)
          comboBoxCity.Items.Add(city);

        SelectFirstCityFound();


        labelStatusMessage.Text = $"Matching cities found: {cities.Count}";
      }
      catch (Exception ex)
      {
        labelStatusMessage.Text = $"City lookup failed ({ex.Message}).";
      }
      finally
      {
        UseWaitCursor = false;
        buttonSearch.Enabled = true;
      }
    }

    // updates the combobox after a brief delay, to allow pending message-loop operations to complete
    void SelectFirstCityFound()
    {
      System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
      timer.Interval = 5; // 5 ms

      timer.Tick += (s, e) =>
      {
        timer.Stop();
        timer.Dispose();

        // select the first match and open dropdown
        comboBoxCity.SelectedIndex = 0;
        comboBoxCity.DroppedDown = true;
      };

      timer.Start();
    }

    async Task LoadWeatherDataAsync(City city)
    {
      lastCity = city;
      UseWaitCursor = true;
      buttonSearch.Enabled = false;

      labelStatusMessage.Text = $"Fetching weather data for {city.Name}, {city.Admin} ({city.Country})..";

      try
      {
        // get the weather data and display it
        lastWeatherData = await webApi.GetWeatherData(city);
        ShowWeatherData(city, lastWeatherData);

        labelStatusMessage.Text = $"Forecast updated at {DateTime.Now:T}";
      }
      catch (Exception ex)
      {
        labelStatusMessage.Text = $"Failed to load weather data ({ex.Message})";
      }
      finally
      {
        UseWaitCursor = false;
        buttonSearch.Enabled = true;
      }
    }

    void ShowWeatherData(City? city, List<WeatherData> weatherData)
    {
      if (city == null) return;
      weeklyConditions.ShowWeatherData(city, weatherData, radioButtonCelsius.Checked);
      panelMiddle.Visible = true;
    }

    void ButtonAddToFavorites_Click(object sender, EventArgs e)
    {
      if (comboBoxCity.SelectedItem is not City city) return;

      if (favorites.ContainsCity(city))
      {
        MessageBox.Show("City is already in Favorites.", "Can't Add City", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      favorites.AddCity(city);
      buttonAddToFavorites.Visible = false;
    }

    async void Favorites_CitySelected(City city)
    {
      await LoadWeatherDataAsync(city);
    }

    void FormMain_FormClosing(object sender, FormClosingEventArgs e)
    {
      favorites.SaveFavorites();
    }

    new bool UseWaitCursor
    {
      get { return base.UseWaitCursor; }
      set
      {
        base.UseWaitCursor = value;
        Cursor.Position = Cursor.Position;  // to update occasional "stuck" busy cursors
      }
    }
  }
}
