using System.Reflection;

namespace WeatherForecastWithFavorites
{
  public partial class Favorites : UserControl
  {
    string settingsFilePath = string.Empty;

    public Favorites()
    {
      InitializeComponent();
      columnHeaderWhere.Width = -2; // auto-size last column

      // file for storing favorites list

      string folder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
      string? appName = Assembly.GetEntryAssembly()?.GetName().Name;
      folder = Path.Combine(folder, appName!);
      Directory.CreateDirectory(folder);
      settingsFilePath = Path.Combine(folder, "settings.txt");
    }

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

    public bool ContainsCity(City city)
    {
      foreach (ListViewItem lvi in listView.Items)
      {
        if (lvi.Tag is not City c) continue;
        if (c.Name != city.Name) continue;
        if (c.Admin != city.Admin) continue;
        if (c.Country != city.Country) continue;
        return true;
      }
      return false;
    }

    void ListView_SizeChanged(object sender, EventArgs e)
    {
      columnHeaderWhere.Width = -2; // auto-size last column
    }

    void ListView_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Delete) return;

      DeleteSelectedItems();
      e.SuppressKeyPress = true;  // to suppress the default ding sound
    }

    void ListView_MouseUp(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Right) return;

      ListViewItem? item = listView.HitTest(e.Location).Item;
      if (item == null) return;

      contextMenuStrip.Show(listView, e.Location);
    }

    void ToolStripMenuItemDeleteItem_Click(object sender, EventArgs e)
    {
      DeleteSelectedItems();
    }

    void DeleteSelectedItems()
    {
      if (listView.SelectedItems.Count == 0) return;

      var result = MessageBox.Show("Delete the selected item?", "Please Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (result != DialogResult.Yes) return;

      for (int i = listView.SelectedItems.Count - 1; i >= 0; i--)
        listView.SelectedItems[i].Remove();
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

