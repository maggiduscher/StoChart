namespace StoChart
{
    partial class StoChart
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 10D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2D, 5D);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();

            this.label15 = new System.Windows.Forms.Label();

            this.label8 = new System.Windows.Forms.Label();
            this.Preis = new System.Windows.Forms.TextBox();
            this.dtp_Aktien = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.b_aktien = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_Depot_Stock = new System.Windows.Forms.ComboBox();
            this.tb_ISIN = new System.Windows.Forms.TextBox();
            this.tb_WKN = new System.Windows.Forms.TextBox();
            this.tb_Menge = new System.Windows.Forms.TextBox();
            this.tb_Kuerzel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.b_Depot = new System.Windows.Forms.Button();
            this.tb_Depot = new System.Windows.Forms.TextBox();
            this.cb_Depot = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.clb_stock = new System.Windows.Forms.CheckedListBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.Delete_Sparplan = new System.Windows.Forms.Button();
            this.Sparplan_List = new System.Windows.Forms.CheckedListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.Ausfuerung = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Depot = new System.Windows.Forms.ComboBox();
            this.Summe = new System.Windows.Forms.TextBox();
            this.Kuerzel = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.konfigurationspfadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

            this.label16 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();

            this.Kürzel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kaufkurs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anzahl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(26, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(831, 438);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.tabPage1.Controls.Add(this.label15);

            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.Preis);
            this.tabPage1.Controls.Add(this.dtp_Aktien);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.b_aktien);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.cb_Depot_Stock);
            this.tabPage1.Controls.Add(this.tb_ISIN);
            this.tabPage1.Controls.Add(this.tb_WKN);
            this.tabPage1.Controls.Add(this.tb_Menge);
            this.tabPage1.Controls.Add(this.tb_Kuerzel);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(823, 412);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Manager";
            // 

            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(667, 171);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(15, 16);
            this.label15.TabIndex = 23;
            this.label15.Text = "€";
            // 

            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(558, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Preis pro Aktie";
            // 
            // Preis
            // 
            this.Preis.Location = new System.Drawing.Point(561, 167);
            this.Preis.Name = "Preis";
            this.Preis.Size = new System.Drawing.Size(100, 20);
            this.Preis.TabIndex = 16;
            // 
            // dtp_Aktien
            // 
            this.dtp_Aktien.AutoSize = true;
            this.dtp_Aktien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Aktien.Location = new System.Drawing.Point(408, 274);
            this.dtp_Aktien.Name = "dtp_Aktien";
            this.dtp_Aktien.Size = new System.Drawing.Size(71, 16);
            this.dtp_Aktien.TabIndex = 13;
            this.dtp_Aktien.Text = "Kaufdatum";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(408, 304);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(97, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // b_aktien
            // 
            this.b_aktien.Location = new System.Drawing.Point(408, 366);
            this.b_aktien.Name = "b_aktien";
            this.b_aktien.Size = new System.Drawing.Size(97, 23);
            this.b_aktien.TabIndex = 11;
            this.b_aktien.Text = "Bestätigen";
            this.b_aktien.UseVisualStyleBackColor = true;
            this.b_aktien.Click += new System.EventHandler(this.b_aktien_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(111, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Depot";
            // 
            // cb_Depot_Stock
            // 
            this.cb_Depot_Stock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Depot_Stock.FormattingEnabled = true;
            this.cb_Depot_Stock.Location = new System.Drawing.Point(111, 304);
            this.cb_Depot_Stock.Name = "cb_Depot_Stock";
            this.cb_Depot_Stock.Size = new System.Drawing.Size(100, 21);
            this.cb_Depot_Stock.TabIndex = 9;
            // 
            // tb_ISIN
            // 
            this.tb_ISIN.Location = new System.Drawing.Point(405, 237);
            this.tb_ISIN.Name = "tb_ISIN";
            this.tb_ISIN.Size = new System.Drawing.Size(100, 20);
            this.tb_ISIN.TabIndex = 8;
            // 
            // tb_WKN
            // 
            this.tb_WKN.Location = new System.Drawing.Point(405, 167);
            this.tb_WKN.Name = "tb_WKN";
            this.tb_WKN.Size = new System.Drawing.Size(100, 20);
            this.tb_WKN.TabIndex = 7;
            // 
            // tb_Menge
            // 
            this.tb_Menge.Location = new System.Drawing.Point(111, 237);
            this.tb_Menge.Name = "tb_Menge";
            this.tb_Menge.Size = new System.Drawing.Size(100, 20);
            this.tb_Menge.TabIndex = 6;
            // 
            // tb_Kuerzel
            // 
            this.tb_Kuerzel.Location = new System.Drawing.Point(111, 167);
            this.tb_Kuerzel.Name = "tb_Kuerzel";
            this.tb_Kuerzel.Size = new System.Drawing.Size(100, 20);
            this.tb_Kuerzel.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(402, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "ISIN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(402, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "WKN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Menge";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kürzel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aktien-Manager";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.b_Depot);
            this.tabPage2.Controls.Add(this.tb_Depot);
            this.tabPage2.Controls.Add(this.cb_Depot);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(823, 412);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Depot";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Kürzel,
            this.Kaufkurs,
            this.Anzahl,
            this.Datum});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(36, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.RowHeadersWidth = 4;
            this.dataGridView1.Size = new System.Drawing.Size(747, 236);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Name";
            // 
            // b_Depot
            // 
            this.b_Depot.Location = new System.Drawing.Point(209, 38);
            this.b_Depot.Name = "b_Depot";
            this.b_Depot.Size = new System.Drawing.Size(75, 23);
            this.b_Depot.TabIndex = 3;
            this.b_Depot.Text = "Hinzufügen";
            this.b_Depot.UseVisualStyleBackColor = true;
            this.b_Depot.Click += new System.EventHandler(this.b_Depot_Click);
            // 
            // tb_Depot
            // 
            this.tb_Depot.Location = new System.Drawing.Point(88, 40);
            this.tb_Depot.Name = "tb_Depot";
            this.tb_Depot.Size = new System.Drawing.Size(100, 20);
            this.tb_Depot.TabIndex = 2;
            // 
            // cb_Depot
            // 
            this.cb_Depot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Depot.FormattingEnabled = true;
            this.cb_Depot.Location = new System.Drawing.Point(662, 118);
            this.cb_Depot.Name = "cb_Depot";
            this.cb_Depot.Size = new System.Drawing.Size(121, 21);
            this.cb_Depot.TabIndex = 0;
            this.cb_Depot.SelectedIndexChanged += new System.EventHandler(this.cb_Depot_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(823, 412);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Aktien";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tabPage4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage4.Controls.Add(this.clb_stock);
            this.tabPage4.Controls.Add(this.chart1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(823, 412);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Kurse";
            // 
            // clb_stock
            // 
            this.clb_stock.CheckOnClick = true;
            this.clb_stock.FormattingEnabled = true;
            this.clb_stock.Location = new System.Drawing.Point(63, 317);
            this.clb_stock.Name = "clb_stock";
            this.clb_stock.ScrollAlwaysVisible = true;
            this.clb_stock.Size = new System.Drawing.Size(591, 94);
            this.clb_stock.TabIndex = 1;
            this.clb_stock.SelectedIndexChanged += new System.EventHandler(this.clb_stock_SelectedIndexChanged);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.chart1.BorderlineColor = System.Drawing.SystemColors.ActiveBorder;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(-4, 3);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(831, 321);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tabPage5.Controls.Add(this.label14);
            this.tabPage5.Controls.Add(this.Delete_Sparplan);
            this.tabPage5.Controls.Add(this.Sparplan_List);
            this.tabPage5.Controls.Add(this.label13);
            this.tabPage5.Controls.Add(this.StartDate);
            this.tabPage5.Controls.Add(this.Ausfuerung);
            this.tabPage5.Controls.Add(this.label12);
            this.tabPage5.Controls.Add(this.label11);
            this.tabPage5.Controls.Add(this.label10);
            this.tabPage5.Controls.Add(this.label9);
            this.tabPage5.Controls.Add(this.Depot);
            this.tabPage5.Controls.Add(this.Summe);
            this.tabPage5.Controls.Add(this.Kuerzel);
            this.tabPage5.Controls.Add(this.Add);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(823, 412);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Sparpläne";
            this.tabPage5.Click += new System.EventHandler(this.tabPage5_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(281, 63);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(15, 16);
            this.label14.TabIndex = 22;
            this.label14.Text = "€";
            // 
            // Delete_Sparplan
            // 
            this.Delete_Sparplan.Location = new System.Drawing.Point(434, 180);
            this.Delete_Sparplan.Name = "Delete_Sparplan";
            this.Delete_Sparplan.Size = new System.Drawing.Size(75, 23);
            this.Delete_Sparplan.TabIndex = 21;
            this.Delete_Sparplan.Text = "Löschen";
            this.Delete_Sparplan.UseVisualStyleBackColor = true;
            this.Delete_Sparplan.Click += new System.EventHandler(this.Delete_Sparplan_Click);
            // 
            // Sparplan_List
            // 
            this.Sparplan_List.FormattingEnabled = true;
            this.Sparplan_List.Location = new System.Drawing.Point(51, 180);
            this.Sparplan_List.Name = "Sparplan_List";
            this.Sparplan_List.Size = new System.Drawing.Size(355, 184);
            this.Sparplan_List.TabIndex = 20;
            this.Sparplan_List.SelectedIndexChanged += new System.EventHandler(this.Sparplan_List_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(550, 34);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 16);
            this.label13.TabIndex = 19;
            this.label13.Text = "Start Datum";
            // 
            // StartDate
            // 
            this.StartDate.Location = new System.Drawing.Point(553, 67);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(97, 20);
            this.StartDate.TabIndex = 18;
            // 
            // Ausfuerung
            // 
            this.Ausfuerung.FormattingEnabled = true;
            this.Ausfuerung.Items.AddRange(new object[] {
            "pro Monat",
            "pro Quartal",
            "pro Halbjahr "});
            this.Ausfuerung.Location = new System.Drawing.Point(306, 62);
            this.Ausfuerung.Name = "Ausfuerung";
            this.Ausfuerung.Size = new System.Drawing.Size(100, 21);
            this.Ausfuerung.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(303, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 16);
            this.label12.TabIndex = 16;
            this.label12.Text = "Ausführung";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(177, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 16);
            this.label11.TabIndex = 14;
            this.label11.Text = "Summe";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(48, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 16);
            this.label10.TabIndex = 13;
            this.label10.Text = "Kürzel";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(434, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Depot";
            // 
            // Depot
            // 
            this.Depot.FormattingEnabled = true;
            this.Depot.Location = new System.Drawing.Point(434, 64);
            this.Depot.Name = "Depot";
            this.Depot.Size = new System.Drawing.Size(100, 21);
            this.Depot.TabIndex = 11;
            // 
            // Summe
            // 
            this.Summe.Location = new System.Drawing.Point(175, 63);
            this.Summe.Name = "Summe";
            this.Summe.Size = new System.Drawing.Size(100, 20);
            this.Summe.TabIndex = 2;
            // 
            // Kuerzel
            // 
            this.Kuerzel.Location = new System.Drawing.Point(51, 63);
            this.Kuerzel.Name = "Kuerzel";
            this.Kuerzel.Size = new System.Drawing.Size(100, 20);
            this.Kuerzel.TabIndex = 1;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(674, 64);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 0;
            this.Add.Text = "Hinzufügen";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tabPage6.Controls.Add(this.tabControl2);
            this.tabPage6.Controls.Add(this.label16);
            this.tabPage6.Controls.Add(this.comboBox1);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(823, 412);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Depot";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(879, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.konfigurationspfadToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(69, 20);
            this.toolStripMenuItem1.Text = "Optionen";
            // 
            // konfigurationspfadToolStripMenuItem
            // 
            this.konfigurationspfadToolStripMenuItem.Name = "konfigurationspfadToolStripMenuItem";
            this.konfigurationspfadToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.konfigurationspfadToolStripMenuItem.Text = "Konfigurationspfad";
            // 

            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(14, 12);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 16);
            this.label16.TabIndex = 12;
            this.label16.Text = "Depot";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(14, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage7);
            this.tabControl2.Controls.Add(this.tabPage8);
            this.tabControl2.Location = new System.Drawing.Point(3, 69);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(817, 340);
            this.tabControl2.TabIndex = 13;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(809, 314);
            this.tabPage7.TabIndex = 0;
            this.tabPage7.Text = "tabPage7";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(809, 314);
            this.tabPage8.TabIndex = 1;
            this.tabPage8.Text = "tabPage8";
            this.tabPage8.UseVisualStyleBackColor = true;

            // Kürzel
            // 
            this.Kürzel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Kürzel.HeaderText = "Kürzel";
            this.Kürzel.Name = "Kürzel";
            this.Kürzel.ReadOnly = true;
            // 
            // Kaufkurs
            // 
            this.Kaufkurs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Kaufkurs.HeaderText = "Kaufkurs";
            this.Kaufkurs.Name = "Kaufkurs";
            this.Kaufkurs.ReadOnly = true;
            // 
            // Anzahl
            // 
            this.Anzahl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Anzahl.HeaderText = "Anzahl";
            this.Anzahl.Name = "Anzahl";
            this.Anzahl.ReadOnly = true;
            // 
            // Datum
            // 
            this.Datum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;

            // 
            // StoChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 489);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StoChart";
            this.Text = "StoChart";
            this.Load += new System.EventHandler(this.StoChart_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button b_aktien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_Depot_Stock;
        private System.Windows.Forms.TextBox tb_ISIN;
        private System.Windows.Forms.TextBox tb_WKN;
        private System.Windows.Forms.TextBox tb_Menge;
        private System.Windows.Forms.TextBox tb_Kuerzel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cb_Depot;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem konfigurationspfadToolStripMenuItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button b_Depot;
        private System.Windows.Forms.TextBox tb_Depot;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label dtp_Aktien;
        private System.Windows.Forms.CheckedListBox clb_stock;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Preis;

        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.ComboBox Ausfuerung;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox Depot;
        private System.Windows.Forms.TextBox Summe;
        private System.Windows.Forms.TextBox Kuerzel;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker StartDate;
        private System.Windows.Forms.CheckedListBox Sparplan_List;
        private System.Windows.Forms.Button Delete_Sparplan;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox comboBox1;

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kürzel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kaufkurs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anzahl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;

    }
}

