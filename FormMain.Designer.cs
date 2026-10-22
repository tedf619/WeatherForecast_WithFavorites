namespace WeatherForecastWithFavorites
{
  partial class FormMain
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
      panelTop = new Panel();
      buttonAddToFavorites = new Button();
      radioButtonFahrenheit = new RadioButton();
      radioButtonCelsius = new RadioButton();
      comboBoxCity = new ComboBox();
      buttonSearch = new Button();
      label3 = new Label();
      panelBottom = new Panel();
      labelStatusMessage = new Label();
      label1 = new Label();
      panelMiddle = new Panel();
      weeklyConditions = new WeeklyConditions();
      label4 = new Label();
      toolTip = new ToolTip(components);
      favorites = new Favorites();
      panelLeft = new Panel();
      splitter1 = new Splitter();
      panelTop.SuspendLayout();
      panelBottom.SuspendLayout();
      panelMiddle.SuspendLayout();
      panelLeft.SuspendLayout();
      SuspendLayout();
      // 
      // panelTop
      // 
      panelTop.BorderStyle = BorderStyle.FixedSingle;
      panelTop.Controls.Add(buttonAddToFavorites);
      panelTop.Controls.Add(radioButtonFahrenheit);
      panelTop.Controls.Add(radioButtonCelsius);
      panelTop.Controls.Add(comboBoxCity);
      panelTop.Controls.Add(buttonSearch);
      panelTop.Controls.Add(label3);
      panelTop.Dock = DockStyle.Top;
      panelTop.Location = new Point(0, 0);
      panelTop.Name = "panelTop";
      panelTop.Size = new Size(1066, 69);
      panelTop.TabIndex = 0;
      // 
      // buttonAddToFavorites
      // 
      buttonAddToFavorites.BackgroundImage = (Image)resources.GetObject("buttonAddToFavorites.BackgroundImage");
      buttonAddToFavorites.BackgroundImageLayout = ImageLayout.Center;
      buttonAddToFavorites.Location = new Point(368, 15);
      buttonAddToFavorites.Name = "buttonAddToFavorites";
      buttonAddToFavorites.Size = new Size(40, 34);
      buttonAddToFavorites.TabIndex = 6;
      toolTip.SetToolTip(buttonAddToFavorites, "Add to favorites");
      buttonAddToFavorites.UseVisualStyleBackColor = true;
      buttonAddToFavorites.Visible = false;
      buttonAddToFavorites.Click += ButtonAddToFavorites_Click;
      // 
      // radioButtonFahrenheit
      // 
      radioButtonFahrenheit.AutoSize = true;
      radioButtonFahrenheit.Location = new Point(603, 36);
      radioButtonFahrenheit.Name = "radioButtonFahrenheit";
      radioButtonFahrenheit.Size = new Size(36, 19);
      radioButtonFahrenheit.TabIndex = 5;
      radioButtonFahrenheit.Text = "°F";
      toolTip.SetToolTip(radioButtonFahrenheit, "Show Temperatures in Fahrenheit");
      radioButtonFahrenheit.UseVisualStyleBackColor = true;
      // 
      // radioButtonCelsius
      // 
      radioButtonCelsius.AutoSize = true;
      radioButtonCelsius.Checked = true;
      radioButtonCelsius.Location = new Point(603, 11);
      radioButtonCelsius.Name = "radioButtonCelsius";
      radioButtonCelsius.Size = new Size(38, 19);
      radioButtonCelsius.TabIndex = 4;
      radioButtonCelsius.TabStop = true;
      radioButtonCelsius.Text = "°C";
      toolTip.SetToolTip(radioButtonCelsius, "Show temperatures in Celsius");
      radioButtonCelsius.UseVisualStyleBackColor = true;
      radioButtonCelsius.CheckedChanged += RadioButtonCelsius_CheckedChanged;
      // 
      // comboBoxCity
      // 
      comboBoxCity.DisplayMember = "DisplayName";
      comboBoxCity.FormattingEnabled = true;
      comboBoxCity.Location = new Point(46, 21);
      comboBoxCity.Name = "comboBoxCity";
      comboBoxCity.Size = new Size(316, 23);
      comboBoxCity.TabIndex = 3;
      comboBoxCity.Text = "<city to search>";
      toolTip.SetToolTip(comboBoxCity, "Enter a city name. If you omit the region or country, you'll be presented with a list of matching cities worldwide");
      comboBoxCity.SelectionChangeCommitted += ComboBoxCity_SelectionChangeCommitted;
      // 
      // buttonSearch
      // 
      buttonSearch.Location = new Point(413, 18);
      buttonSearch.Name = "buttonSearch";
      buttonSearch.Size = new Size(97, 31);
      buttonSearch.TabIndex = 2;
      buttonSearch.Text = "Search";
      buttonSearch.UseVisualStyleBackColor = true;
      buttonSearch.Click += ButtonSearch_Click;
      // 
      // label3
      // 
      label3.AutoSize = true;
      label3.Location = new Point(12, 24);
      label3.Name = "label3";
      label3.Size = new Size(28, 15);
      label3.TabIndex = 0;
      label3.Text = "City";
      // 
      // panelBottom
      // 
      panelBottom.BorderStyle = BorderStyle.FixedSingle;
      panelBottom.Controls.Add(labelStatusMessage);
      panelBottom.Controls.Add(label1);
      panelBottom.Dock = DockStyle.Bottom;
      panelBottom.Location = new Point(0, 494);
      panelBottom.Name = "panelBottom";
      panelBottom.Size = new Size(1066, 23);
      panelBottom.TabIndex = 1;
      // 
      // labelStatusMessage
      // 
      labelStatusMessage.Dock = DockStyle.Fill;
      labelStatusMessage.Location = new Point(0, 0);
      labelStatusMessage.Name = "labelStatusMessage";
      labelStatusMessage.Size = new Size(859, 21);
      labelStatusMessage.TabIndex = 1;
      labelStatusMessage.TextAlign = ContentAlignment.MiddleLeft;
      // 
      // label1
      // 
      label1.Dock = DockStyle.Right;
      label1.ForeColor = Color.Gray;
      label1.Location = new Point(859, 0);
      label1.Name = "label1";
      label1.Size = new Size(205, 21);
      label1.TabIndex = 0;
      label1.Text = "Data provided by Open-Meteo.com";
      label1.TextAlign = ContentAlignment.MiddleCenter;
      // 
      // panelMiddle
      // 
      panelMiddle.BackColor = Color.WhiteSmoke;
      panelMiddle.Controls.Add(weeklyConditions);
      panelMiddle.Controls.Add(label4);
      panelMiddle.Dock = DockStyle.Fill;
      panelMiddle.Location = new Point(241, 69);
      panelMiddle.Name = "panelMiddle";
      panelMiddle.Size = new Size(825, 425);
      panelMiddle.TabIndex = 2;
      panelMiddle.Visible = false;
      // 
      // weeklyConditions
      // 
      weeklyConditions.Dock = DockStyle.Fill;
      weeklyConditions.Location = new Point(0, 0);
      weeklyConditions.Name = "weeklyConditions";
      weeklyConditions.Size = new Size(825, 425);
      weeklyConditions.TabIndex = 4;
      // 
      // label4
      // 
      label4.AutoSize = true;
      label4.ForeColor = Color.Teal;
      label4.Location = new Point(185, 182);
      label4.Name = "label4";
      label4.Size = new Size(296, 15);
      label4.TabIndex = 3;
      label4.Text = "The 7-day forecast for the selected city will appear here";
      // 
      // favorites
      // 
      favorites.Dock = DockStyle.Fill;
      favorites.Location = new Point(0, 0);
      favorites.Name = "favorites";
      favorites.Size = new Size(236, 425);
      favorites.TabIndex = 4;
      favorites.CitySelected += Favorites_CitySelected;
      // 
      // panelLeft
      // 
      panelLeft.Controls.Add(favorites);
      panelLeft.Dock = DockStyle.Left;
      panelLeft.Location = new Point(0, 69);
      panelLeft.Name = "panelLeft";
      panelLeft.Size = new Size(236, 425);
      panelLeft.TabIndex = 5;
      // 
      // splitter1
      // 
      splitter1.Location = new Point(236, 69);
      splitter1.Name = "splitter1";
      splitter1.Size = new Size(5, 425);
      splitter1.TabIndex = 6;
      splitter1.TabStop = false;
      // 
      // FormMain
      // 
      AcceptButton = buttonSearch;
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(1066, 517);
      Controls.Add(panelMiddle);
      Controls.Add(splitter1);
      Controls.Add(panelLeft);
      Controls.Add(panelBottom);
      Controls.Add(panelTop);
      Name = "FormMain";
      StartPosition = FormStartPosition.CenterScreen;
      Text = "7 Day Weather Forecast";
      FormClosing += FormMain_FormClosing;
      panelTop.ResumeLayout(false);
      panelTop.PerformLayout();
      panelBottom.ResumeLayout(false);
      panelMiddle.ResumeLayout(false);
      panelMiddle.PerformLayout();
      panelLeft.ResumeLayout(false);
      ResumeLayout(false);
    }

    #endregion

    private Panel panelTop;
    private Panel panelBottom;
    private Panel panelMiddle;
    private Label labelStatusMessage;
    private Label label1;
    private Button buttonSearch;
    private Label label3;
    private ToolTip toolTip;
    private Label label4;
    private ComboBox comboBoxCity;
    private RadioButton radioButtonFahrenheit;
    private RadioButton radioButtonCelsius;
    private Favorites favorites;
    private Panel panelLeft;
    private Splitter splitter1;
    private WeeklyConditions weeklyConditions;
    private Button buttonAddToFavorites;
  }
}