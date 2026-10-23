# Weather Forecast with Favorites List

A .Net 10 WinForms desktop app that gives a 7-day weather forecast for any city in the world. 


## Features

* Great project for getting started with online weather services.
* No dependencies on GitHub packages or third-party components.
* Uses free web service APIs from Open-Meteo.com.
* No API keys required.
* Allows you to save your favorite cities for quick access.

The following figure shows the app in action with a list of favorite cities.

<img width="1068" height="549" alt="image" src="https://github.com/user-attachments/assets/43c08bdd-0d2d-4dac-acfe-b7c068de0a77" />

*Figure 1* - The app showing a weekly forecast, along with a list of favorite cities.
<br>

The app is derived from my other [WeatherForecast](https://github.com/tedf619/WeatherForecast) app, which handles the retrieval and display of graphical daily forecasts.
See that repo for details. What's new here is the management of the Favorites list.

## The UI Layout

The main user interface uses docked panels for the layout, as shown in red in the following figure.

<img width="645" height="390" alt="image" src="https://github.com/user-attachments/assets/08195154-4384-4357-9a08-c87d1d74ac99" />

*Figure 2* - The docked panels for the main user interface.

The red panels divide the screen vertically, with the middle area occupied by two additional panels (left and right).
To achieve the required layout, the panels must be added in the proper back-to-front order, like this:

  1. PanelTop.
  2. PanelBottom.
  3. PanelLeft
  4. PanelRight.

PanelRight is added last, since it has Dock=Fill. As a general rule, components with Dock=Fill must always be added last to their parent container.

## The Favorites Control

The Favorites control is implemented as a WinForms UserControl that has its own internal docked panels, as shown in the following figure.

<img width="231" height="330" alt="image" src="https://github.com/user-attachments/assets/db7c3270-ce96-416a-9a24-864ba895b50e" />

*Figure 3* - The docked panels for the Favorites control.

The red layer divides the screen vertically, with the middle area filling available space.
As always, the panels must be added in the proper back-to-front order, with the panel having Dock=Fill added last:

  1. PanelTop.
  2. PanelMiddle.

At design time the Favorites look like this in the Visual Studio Forms Designer:

<img width="237" height="334" alt="image" src="https://github.com/user-attachments/assets/456e64d3-de58-41c0-b064-27855d46d38c" />

*Figure 4* - The Favorites control at design time.

## How it Works

As stated earlier, the weather retrieval and display is handled as described in the [WeatherForecast](https://github.com/tedf619/WeatherForecast) app.
The Favorites UserControl is the new part. It uses a WinForms ListView to display a list of favorite cities. 
When you click on a city, the UserControl fires an event, which FormMain handles by showing the weather for that city. The following figure shows the sequence diagram.

<img width="507" height="331" alt="image" src="https://github.com/user-attachments/assets/3c9e0f77-f07f-4b34-a9d2-5b5e3aa17f0f" />

*Figure 5* - The Sequence Diagram showing how the Favorites control interacts with the rest of the system.

The following listing shows the essential code for Favorites.

```csharp
  public partial class Favorites : UserControl
  {
    string settingsFilePath = <filePath...>

    public void LoadFavorites()
    {
      if (!File.Exists(settingsFilePath)) return;

      string[] lines = File.ReadAllLines(settingsFilePath);

      foreach (string line in lines)
      {
        string[] words = line.Split('|');

        City city = new City
        {
          Name = words[0].Trim(),
          Admin = words[1].Trim(),
          Country = words[2].Trim(),
          Latitude = double.TryParse(words[3], out var lat) ? lat : 0,
          Longitude = double.TryParse(words[4], out var lon) ? lon : 0,
        };

        AddCity(city);
      }
    }

    public void SaveFavorites()
    {
      using var writer = new StreamWriter(settingsFilePath);

      foreach (ListViewItem lvi in listView.Items)
      {
        if (lvi.Tag is not City city) continue;

        writer.Write($"{city.Name} | ");
        writer.Write($"{city.Admin} | ");
        writer.Write($"{city.Country} | ");
        writer.Write($"{city.Latitude} | ");
        writer.Write($"{city.Longitude}\n");
      }
    }

    public void AddCity(City city)
    {
      string admin = $"{city.Admin} ({city.Country})";

      ListViewItem lvi = new ListViewItem(city.Name);
      lvi.SubItems.Add(admin);
      lvi.Tag = city;

      listView.Items.Add(lvi);
    }

    void ListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
    {
      if (listView.SelectedItems.Count == 0) return;
      if (listView.SelectedItems[0].Tag is not City city) return;

      FireCitySelected(city);
    }

    #region Events
    public delegate void CityHandler(City city);
    public event CityHandler? CitySelected;
    void FireCitySelected(City city)
    {
      CitySelected?.Invoke(city);
    }
    #endregion
  }
}
```
*Listing 1* - The code that manages the Favorites list.

FormMain tells Favorites to load its settings in the constructor:

```csharp
 public partial class FormMain : Form
 {
   //...

   public FormMain()
   {
     //...
     favorites.LoadFavorites();
   }
}
```
*Listing 2* - Loading Favorites at startup time.

When the app closes, FormMain tells Favorites to saves its list:

```csharp
 public partial class FormMain : Form
 {
    //...

    void FormMain_FormClosing(object sender, FormClosingEventArgs e)
    {
      favorites.SaveFavorites();
    }
}
```
*Listing 3* - Saving Favorites when the app closes.

When the user clicks the **Heart** button, FormMain adds the current city to the Favorites list:

```csharp
 public partial class FormMain : Form
 {
    //...

   void ButtonAddToFavorites_Click(object sender, EventArgs e)
   {
     if (comboBoxCity.SelectedItem is not City city) return;
     favorites.AddCity(city);
   }
}
```
*Listing 4* - Adding a city to the Favorites list.

There are two ways to delete a city from Favorites:

1. Select it and hit the ```Delete``` key.
2. Right click a city and choose the ```Delete Item``` command from the popup menu.

To focus on the essentials, I omitted the deletion logic in Listing 1. If you're interested, you can find the code in all its glory in ```Favorites.cs has```.
## Closing Notes

Managing favorites essentially breaks down into the following:

1. Managing the UI presentation.
2. Adding and removing items.
3. Loading and saving items for persistence.
4. Notifying the host application when an item is selected.

That's it folks! I hope this was useful.
