namespace WeatherForecastWithFavorites
{
  partial class WeeklyConditions
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      panelTop = new Panel();
      labelWeatherForCity = new Label();
      dailyConditions7 = new DailyConditions();
      dailyConditions6 = new DailyConditions();
      dailyConditions5 = new DailyConditions();
      dailyConditions4 = new DailyConditions();
      dailyConditions3 = new DailyConditions();
      dailyConditions2 = new DailyConditions();
      dailyConditions1 = new DailyConditions();
      panelTop.SuspendLayout();
      SuspendLayout();
      // 
      // panelTop
      // 
      panelTop.Controls.Add(labelWeatherForCity);
      panelTop.Dock = DockStyle.Top;
      panelTop.Location = new Point(0, 0);
      panelTop.Name = "panelTop";
      panelTop.Size = new Size(803, 32);
      panelTop.TabIndex = 8;
      // 
      // labelWeatherForCity
      // 
      labelWeatherForCity.BackColor = Color.Blue;
      labelWeatherForCity.Dock = DockStyle.Fill;
      labelWeatherForCity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
      labelWeatherForCity.ForeColor = Color.White;
      labelWeatherForCity.Location = new Point(0, 0);
      labelWeatherForCity.Name = "labelWeatherForCity";
      labelWeatherForCity.Size = new Size(803, 32);
      labelWeatherForCity.TabIndex = 0;
      labelWeatherForCity.Text = "Weather for <city>";
      labelWeatherForCity.TextAlign = ContentAlignment.MiddleLeft;
      // 
      // dailyConditions7
      // 
      dailyConditions7.BackColor = Color.White;
      dailyConditions7.Location = new Point(692, 38);
      dailyConditions7.Name = "dailyConditions7";
      dailyConditions7.Size = new Size(100, 377);
      dailyConditions7.TabIndex = 20;
      // 
      // dailyConditions6
      // 
      dailyConditions6.BackColor = Color.White;
      dailyConditions6.Location = new Point(578, 38);
      dailyConditions6.Name = "dailyConditions6";
      dailyConditions6.Size = new Size(100, 377);
      dailyConditions6.TabIndex = 19;
      // 
      // dailyConditions5
      // 
      dailyConditions5.BackColor = Color.White;
      dailyConditions5.Location = new Point(464, 38);
      dailyConditions5.Name = "dailyConditions5";
      dailyConditions5.Size = new Size(100, 377);
      dailyConditions5.TabIndex = 18;
      // 
      // dailyConditions4
      // 
      dailyConditions4.BackColor = Color.White;
      dailyConditions4.Location = new Point(350, 38);
      dailyConditions4.Name = "dailyConditions4";
      dailyConditions4.Size = new Size(100, 377);
      dailyConditions4.TabIndex = 17;
      // 
      // dailyConditions3
      // 
      dailyConditions3.BackColor = Color.White;
      dailyConditions3.Location = new Point(236, 38);
      dailyConditions3.Name = "dailyConditions3";
      dailyConditions3.Size = new Size(100, 377);
      dailyConditions3.TabIndex = 16;
      // 
      // dailyConditions2
      // 
      dailyConditions2.BackColor = Color.White;
      dailyConditions2.Location = new Point(122, 38);
      dailyConditions2.Name = "dailyConditions2";
      dailyConditions2.Size = new Size(100, 377);
      dailyConditions2.TabIndex = 15;
      // 
      // dailyConditions1
      // 
      dailyConditions1.BackColor = Color.White;
      dailyConditions1.Location = new Point(8, 38);
      dailyConditions1.Name = "dailyConditions1";
      dailyConditions1.Size = new Size(100, 377);
      dailyConditions1.TabIndex = 14;
      // 
      // WeeklyConditions
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      Controls.Add(dailyConditions7);
      Controls.Add(dailyConditions6);
      Controls.Add(dailyConditions5);
      Controls.Add(dailyConditions4);
      Controls.Add(dailyConditions3);
      Controls.Add(dailyConditions2);
      Controls.Add(dailyConditions1);
      Controls.Add(panelTop);
      Name = "WeeklyConditions";
      Size = new Size(803, 425);
      panelTop.ResumeLayout(false);
      ResumeLayout(false);
    }

    #endregion

    private Panel panelTop;
    private Label labelWeatherForCity;
    private DailyConditions dailyConditions7;
    private DailyConditions dailyConditions6;
    private DailyConditions dailyConditions5;
    private DailyConditions dailyConditions4;
    private DailyConditions dailyConditions3;
    private DailyConditions dailyConditions2;
    private DailyConditions dailyConditions1;
  }
}
