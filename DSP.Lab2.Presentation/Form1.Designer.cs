namespace DSP.Lab2.Presentation
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.SignalGroupBox = new System.Windows.Forms.GroupBox();
            this.FrequencyLabel = new System.Windows.Forms.Label();
            this.FrequencyTrackBar = new System.Windows.Forms.TrackBar();
            this.SignalComboBox = new System.Windows.Forms.ComboBox();
            this.FilterComboBox = new System.Windows.Forms.ComboBox();
            this.FilterGroupBox = new System.Windows.Forms.GroupBox();
            this.HighFrequenciesLabel = new System.Windows.Forms.Label();
            this.LowFrequenciesLabel = new System.Windows.Forms.Label();
            this.HighFrequenciesTrackBar = new System.Windows.Forms.TrackBar();
            this.LowFrequenciesTrackBar = new System.Windows.Forms.TrackBar();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TabPage = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.SignalGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FrequencyTrackBar)).BeginInit();
            this.FilterGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HighFrequenciesTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LowFrequenciesTrackBar)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.TabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SignalGroupBox
            // 
            this.SignalGroupBox.Controls.Add(this.FrequencyLabel);
            this.SignalGroupBox.Controls.Add(this.FrequencyTrackBar);
            this.SignalGroupBox.Controls.Add(this.SignalComboBox);
            this.SignalGroupBox.Location = new System.Drawing.Point(20, 490);
            this.SignalGroupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SignalGroupBox.Name = "SignalGroupBox";
            this.SignalGroupBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SignalGroupBox.Size = new System.Drawing.Size(429, 189);
            this.SignalGroupBox.TabIndex = 1;
            this.SignalGroupBox.TabStop = false;
            this.SignalGroupBox.Text = "Тип сигнала:";
            // 
            // FrequencyLabel
            // 
            this.FrequencyLabel.AutoSize = true;
            this.FrequencyLabel.Location = new System.Drawing.Point(8, 89);
            this.FrequencyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FrequencyLabel.Name = "FrequencyLabel";
            this.FrequencyLabel.Size = new System.Drawing.Size(226, 25);
            this.FrequencyLabel.TabIndex = 2;
            this.FrequencyLabel.Text = "Сгенерировать данные";
            // 
            // FrequencyTrackBar
            // 
            this.FrequencyTrackBar.Location = new System.Drawing.Point(8, 117);
            this.FrequencyTrackBar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FrequencyTrackBar.Maximum = 30;
            this.FrequencyTrackBar.Minimum = 1;
            this.FrequencyTrackBar.Name = "FrequencyTrackBar";
            this.FrequencyTrackBar.Size = new System.Drawing.Size(384, 56);
            this.FrequencyTrackBar.TabIndex = 1;
            this.FrequencyTrackBar.Value = 1;
            this.FrequencyTrackBar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // SignalComboBox
            // 
            this.SignalComboBox.FormattingEnabled = true;
            this.SignalComboBox.Items.AddRange(new object[] {
            "Гармонический",
            "Полигармонический"});
            this.SignalComboBox.Location = new System.Drawing.Point(8, 33);
            this.SignalComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SignalComboBox.Name = "SignalComboBox";
            this.SignalComboBox.Size = new System.Drawing.Size(384, 33);
            this.SignalComboBox.TabIndex = 0;
            this.SignalComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // FilterComboBox
            // 
            this.FilterComboBox.FormattingEnabled = true;
            this.FilterComboBox.Items.AddRange(new object[] {
            "НЧ-фильтр",
            "ВЧ-фильтр",
            "Полосовой фильтр",
            "NONE"});
            this.FilterComboBox.Location = new System.Drawing.Point(8, 33);
            this.FilterComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FilterComboBox.Name = "FilterComboBox";
            this.FilterComboBox.Size = new System.Drawing.Size(339, 33);
            this.FilterComboBox.TabIndex = 2;
            this.FilterComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // FilterGroupBox
            // 
            this.FilterGroupBox.Controls.Add(this.HighFrequenciesLabel);
            this.FilterGroupBox.Controls.Add(this.LowFrequenciesLabel);
            this.FilterGroupBox.Controls.Add(this.HighFrequenciesTrackBar);
            this.FilterGroupBox.Controls.Add(this.LowFrequenciesTrackBar);
            this.FilterGroupBox.Controls.Add(this.FilterComboBox);
            this.FilterGroupBox.Location = new System.Drawing.Point(453, 490);
            this.FilterGroupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FilterGroupBox.Name = "FilterGroupBox";
            this.FilterGroupBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FilterGroupBox.Size = new System.Drawing.Size(386, 243);
            this.FilterGroupBox.TabIndex = 5;
            this.FilterGroupBox.TabStop = false;
            this.FilterGroupBox.Text = "Фильтрация:";
            // 
            // HighFrequenciesLabel
            // 
            this.HighFrequenciesLabel.AutoSize = true;
            this.HighFrequenciesLabel.Location = new System.Drawing.Point(9, 148);
            this.HighFrequenciesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HighFrequenciesLabel.Name = "HighFrequenciesLabel";
            this.HighFrequenciesLabel.Size = new System.Drawing.Size(43, 25);
            this.HighFrequenciesLabel.TabIndex = 6;
            this.HighFrequenciesLabel.Text = "ВЧ:";
            // 
            // LowFrequenciesLabel
            // 
            this.LowFrequenciesLabel.AutoSize = true;
            this.LowFrequenciesLabel.Location = new System.Drawing.Point(8, 89);
            this.LowFrequenciesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LowFrequenciesLabel.Name = "LowFrequenciesLabel";
            this.LowFrequenciesLabel.Size = new System.Drawing.Size(44, 25);
            this.LowFrequenciesLabel.TabIndex = 5;
            this.LowFrequenciesLabel.Text = "НЧ:";
            // 
            // HighFrequenciesTrackBar
            // 
            this.HighFrequenciesTrackBar.Location = new System.Drawing.Point(8, 177);
            this.HighFrequenciesTrackBar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.HighFrequenciesTrackBar.Maximum = 30;
            this.HighFrequenciesTrackBar.Minimum = 1;
            this.HighFrequenciesTrackBar.Name = "HighFrequenciesTrackBar";
            this.HighFrequenciesTrackBar.Size = new System.Drawing.Size(296, 56);
            this.HighFrequenciesTrackBar.TabIndex = 4;
            this.HighFrequenciesTrackBar.Value = 11;
            this.HighFrequenciesTrackBar.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // LowFrequenciesTrackBar
            // 
            this.LowFrequenciesTrackBar.Location = new System.Drawing.Point(8, 117);
            this.LowFrequenciesTrackBar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LowFrequenciesTrackBar.Maximum = 30;
            this.LowFrequenciesTrackBar.Name = "LowFrequenciesTrackBar";
            this.LowFrequenciesTrackBar.Size = new System.Drawing.Size(296, 56);
            this.LowFrequenciesTrackBar.TabIndex = 3;
            this.LowFrequenciesTrackBar.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.chart4);
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage4.Size = new System.Drawing.Size(1146, 430);
            this.tabPage4.TabIndex = 2;
            this.tabPage4.Text = "БПФ";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // chart4
            // 
            chartArea1.Name = "ChartArea1";
            this.chart4.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart4.Legends.Add(legend1);
            this.chart4.Location = new System.Drawing.Point(24, 27);
            this.chart4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chart4.Name = "chart4";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
            series1.Color = System.Drawing.Color.Blue;
            series1.Legend = "Legend1";
            series1.Name = "БПФ для полигармоники";
            series1.YValuesPerPoint = 4;
            this.chart4.Series.Add(series1);
            this.chart4.Size = new System.Drawing.Size(1234, 428);
            this.chart4.TabIndex = 0;
            this.chart4.Text = "chart4";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.chart3);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1146, 430);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Амплитудный спектр";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // chart3
            // 
            chartArea2.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart3.Legends.Add(legend2);
            this.chart3.Location = new System.Drawing.Point(24, 27);
            this.chart3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chart3.Name = "chart3";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
            series2.Color = System.Drawing.Color.Red;
            series2.Legend = "Legend1";
            series2.Name = "Амплитудный спектр";
            series2.YValuesPerPoint = 4;
            this.chart3.Series.Add(series2);
            this.chart3.Size = new System.Drawing.Size(1234, 428);
            this.chart3.TabIndex = 0;
            this.chart3.Text = "chart3";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chart2);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Size = new System.Drawing.Size(1146, 430);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Фазовый спектр";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chart2
            // 
            chartArea3.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart2.Legends.Add(legend3);
            this.chart2.Location = new System.Drawing.Point(24, 27);
            this.chart2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chart2.Name = "chart2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
            series3.Color = System.Drawing.Color.Red;
            series3.Legend = "Legend1";
            series3.Name = "Фазовый спектр";
            series3.YValuesPerPoint = 4;
            this.chart2.Series.Add(series3);
            this.chart2.Size = new System.Drawing.Size(1234, 428);
            this.chart2.TabIndex = 0;
            this.chart2.Text = "chart2";
            // 
            // TabPage
            // 
            this.TabPage.Controls.Add(this.chart1);
            this.TabPage.Location = new System.Drawing.Point(4, 34);
            this.TabPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TabPage.Name = "TabPage";
            this.TabPage.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TabPage.Size = new System.Drawing.Size(1146, 430);
            this.TabPage.TabIndex = 0;
            this.TabPage.Text = "Сигналы";
            this.TabPage.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(4, 27);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Color = System.Drawing.Color.Red;
            series4.Legend = "Legend1";
            series4.Name = "Исходный сигнал";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Color = System.Drawing.Color.Blue;
            series5.Legend = "Legend1";
            series5.Name = "Восстановленный сигнал";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Color = System.Drawing.Color.Yellow;
            series6.Legend = "Legend1";
            series6.Name = "Восстановленный сигнал без учета фазы";
            this.chart1.Series.Add(series4);
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(1121, 401);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "Chart";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabPage);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(16, 16);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1154, 468);
            this.tabControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1183, 741);
            this.Controls.Add(this.FilterGroupBox);
            this.Controls.Add(this.SignalGroupBox);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "DSP.Lab2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SignalGroupBox.ResumeLayout(false);
            this.SignalGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FrequencyTrackBar)).EndInit();
            this.FilterGroupBox.ResumeLayout(false);
            this.FilterGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HighFrequenciesTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LowFrequenciesTrackBar)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.TabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox SignalGroupBox;
        private System.Windows.Forms.TrackBar FrequencyTrackBar;
        private System.Windows.Forms.ComboBox SignalComboBox;
        private System.Windows.Forms.Label FrequencyLabel;
        private System.Windows.Forms.ComboBox FilterComboBox;
        private System.Windows.Forms.GroupBox FilterGroupBox;
        private System.Windows.Forms.TrackBar LowFrequenciesTrackBar;
        private System.Windows.Forms.Label HighFrequenciesLabel;
        private System.Windows.Forms.Label LowFrequenciesLabel;
        private System.Windows.Forms.TrackBar HighFrequenciesTrackBar;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.TabPage TabPage;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

