﻿namespace StoChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 10D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2D, 5D);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.konfigurationspfadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
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
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(-4, 3);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series3.Points.Add(dataPoint5);
            series3.Points.Add(dataPoint6);
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(831, 321);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
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
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kürzel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kaufkurs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anzahl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
    }
}

