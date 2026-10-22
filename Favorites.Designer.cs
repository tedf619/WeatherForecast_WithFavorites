namespace WeatherForecastWithFavorites
{
  partial class Favorites
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
      components = new System.ComponentModel.Container();
      panelTop = new Panel();
      label1 = new Label();
      toolTip = new ToolTip(components);
      panelMiddle = new Panel();
      listView = new ListView();
      columnHeaderCity = new ColumnHeader();
      columnHeaderWhere = new ColumnHeader();
      contextMenuStrip = new ContextMenuStrip(components);
      toolStripMenuItemDeleteItem = new ToolStripMenuItem();
      panelTop.SuspendLayout();
      panelMiddle.SuspendLayout();
      contextMenuStrip.SuspendLayout();
      SuspendLayout();
      // 
      // panelTop
      // 
      panelTop.BackColor = Color.Blue;
      panelTop.Controls.Add(label1);
      panelTop.Dock = DockStyle.Top;
      panelTop.Location = new Point(0, 0);
      panelTop.Name = "panelTop";
      panelTop.Size = new Size(227, 32);
      panelTop.TabIndex = 0;
      // 
      // label1
      // 
      label1.Dock = DockStyle.Fill;
      label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
      label1.ForeColor = Color.White;
      label1.Location = new Point(0, 0);
      label1.Name = "label1";
      label1.Size = new Size(227, 32);
      label1.TabIndex = 0;
      label1.Text = "Favorites";
      label1.TextAlign = ContentAlignment.MiddleLeft;
      // 
      // panelMiddle
      // 
      panelMiddle.Controls.Add(listView);
      panelMiddle.Dock = DockStyle.Fill;
      panelMiddle.Location = new Point(0, 32);
      panelMiddle.Name = "panelMiddle";
      panelMiddle.Size = new Size(227, 293);
      panelMiddle.TabIndex = 3;
      // 
      // listView
      // 
      listView.Columns.AddRange(new ColumnHeader[] { columnHeaderCity, columnHeaderWhere });
      listView.Dock = DockStyle.Fill;
      listView.FullRowSelect = true;
      listView.HeaderStyle = ColumnHeaderStyle.None;
      listView.Location = new Point(0, 0);
      listView.MultiSelect = false;
      listView.Name = "listView";
      listView.Size = new Size(227, 293);
      listView.TabIndex = 0;
      listView.UseCompatibleStateImageBehavior = false;
      listView.View = View.Details;
      listView.ItemSelectionChanged += ListView_ItemSelectionChanged;
      listView.SizeChanged += ListView_SizeChanged;
      listView.KeyDown += ListView_KeyDown;
      listView.MouseUp += ListView_MouseUp;
      // 
      // columnHeaderCity
      // 
      columnHeaderCity.Text = "City";
      // 
      // columnHeaderWhere
      // 
      columnHeaderWhere.Text = "Where";
      // 
      // contextMenuStrip
      // 
      contextMenuStrip.Items.AddRange(new ToolStripItem[] { toolStripMenuItemDeleteItem });
      contextMenuStrip.Name = "contextMenuStrip";
      contextMenuStrip.Size = new Size(144, 26);
      // 
      // toolStripMenuItemDeleteItem
      // 
      toolStripMenuItemDeleteItem.Name = "toolStripMenuItemDeleteItem";
      toolStripMenuItemDeleteItem.Size = new Size(143, 22);
      toolStripMenuItemDeleteItem.Text = "Delete Item...";
      toolStripMenuItemDeleteItem.Click += ToolStripMenuItemDeleteItem_Click;
      // 
      // Favorites
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      Controls.Add(panelMiddle);
      Controls.Add(panelTop);
      Name = "Favorites";
      Size = new Size(227, 325);
      panelTop.ResumeLayout(false);
      panelMiddle.ResumeLayout(false);
      contextMenuStrip.ResumeLayout(false);
      ResumeLayout(false);
    }

    #endregion

    private Panel panelTop;
    private ToolTip toolTip;
    private Label label1;
    private Panel panelMiddle;
    private ListView listView;
    private ColumnHeader columnHeaderCity;
    private ColumnHeader columnHeaderWhere;
    private ContextMenuStrip contextMenuStrip;
    private ToolStripMenuItem toolStripMenuItemDeleteItem;
  }
}
