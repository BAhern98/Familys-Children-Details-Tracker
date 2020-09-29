namespace Dave_Menu
{
    partial class Infographic
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
            this.chartMultiBirths = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnBack = new System.Windows.Forms.Button();
            this.chartAges = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartPlanner = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblPlanner = new System.Windows.Forms.Label();
            this.lbMultiBirths = new System.Windows.Forms.Label();
            this.lblAges = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartMultiBirths)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAges)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPlanner)).BeginInit();
            this.SuspendLayout();
            // 
            // chartMultiBirths
            // 
            this.chartMultiBirths.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(220)))));
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea1.Area3DStyle.PointDepth = 120;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(220)))));
            chartArea1.Name = "ChartArea1";
            this.chartMultiBirths.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(220)))));
            legend1.Name = "Legend1";
            this.chartMultiBirths.Legends.Add(legend1);
            this.chartMultiBirths.Location = new System.Drawing.Point(453, -3);
            this.chartMultiBirths.Name = "chartMultiBirths";
            this.chartMultiBirths.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "MultiBirths";
            this.chartMultiBirths.Series.Add(series1);
            this.chartMultiBirths.Size = new System.Drawing.Size(358, 342);
            this.chartMultiBirths.TabIndex = 0;
            this.chartMultiBirths.Text = "chart1";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            this.btnBack.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnBack.Location = new System.Drawing.Point(317, 610);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(163, 44);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // chartAges
            // 
            this.chartAges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(220)))));
            chartArea2.Area3DStyle.Enable3D = true;
            chartArea2.Name = "ChartArea1";
            this.chartAges.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(220)))));
            legend2.Name = "Legend1";
            this.chartAges.Legends.Add(legend2);
            this.chartAges.Location = new System.Drawing.Point(-22, 12);
            this.chartAges.Name = "chartAges";
            this.chartAges.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
            series2.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.Legend = "Legend1";
            series2.Name = "Age";
            this.chartAges.Series.Add(series2);
            this.chartAges.Size = new System.Drawing.Size(454, 539);
            this.chartAges.TabIndex = 4;
            this.chartAges.Text = "chart1";
            // 
            // chartPlanner
            // 
            this.chartPlanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(220)))));
            chartArea3.Area3DStyle.Enable3D = true;
            chartArea3.Area3DStyle.PointDepth = 120;
            chartArea3.Area3DStyle.Rotation = 45;
            chartArea3.Area3DStyle.WallWidth = 0;
            chartArea3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(220)))));
            chartArea3.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(220)))));
            chartArea3.Name = "ChartArea1";
            this.chartPlanner.ChartAreas.Add(chartArea3);
            legend3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(220)))));
            legend3.Name = "Legend1";
            this.chartPlanner.Legends.Add(legend3);
            this.chartPlanner.Location = new System.Drawing.Point(465, 387);
            this.chartPlanner.Name = "chartPlanner";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series3.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.Legend = "Legend1";
            series3.Name = "School Planner";
            series3.YValuesPerPoint = 4;
            this.chartPlanner.Series.Add(series3);
            this.chartPlanner.Size = new System.Drawing.Size(346, 217);
            this.chartPlanner.TabIndex = 5;
            this.chartPlanner.Text = "chart1";
            // 
            // lblPlanner
            // 
            this.lblPlanner.AutoSize = true;
            this.lblPlanner.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanner.Location = new System.Drawing.Point(461, 387);
            this.lblPlanner.Name = "lblPlanner";
            this.lblPlanner.Size = new System.Drawing.Size(173, 21);
            this.lblPlanner.TabIndex = 6;
            this.lblPlanner.Text = "School Planner for 2018";
            // 
            // lbMultiBirths
            // 
            this.lbMultiBirths.AutoSize = true;
            this.lbMultiBirths.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMultiBirths.Location = new System.Drawing.Point(524, 26);
            this.lbMultiBirths.Name = "lbMultiBirths";
            this.lbMultiBirths.Size = new System.Drawing.Size(110, 21);
            this.lbMultiBirths.TabIndex = 7;
            this.lbMultiBirths.Text = "Multiple Births";
            // 
            // lblAges
            // 
            this.lblAges.AutoSize = true;
            this.lblAges.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAges.Location = new System.Drawing.Point(181, 9);
            this.lblAges.Name = "lblAges";
            this.lblAges.Size = new System.Drawing.Size(42, 21);
            this.lblAges.TabIndex = 8;
            this.lblAges.Text = "Ages";
            // 
            // Infographic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(802, 666);
            this.Controls.Add(this.lblAges);
            this.Controls.Add(this.lbMultiBirths);
            this.Controls.Add(this.lblPlanner);
            this.Controls.Add(this.chartPlanner);
            this.Controls.Add(this.chartAges);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.chartMultiBirths);
            this.Name = "Infographic";
            this.Text = "Infographic";
            this.Load += new System.EventHandler(this.Infographic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartMultiBirths)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAges)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPlanner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartMultiBirths;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAges;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPlanner;
        private System.Windows.Forms.Label lblPlanner;
        private System.Windows.Forms.Label lbMultiBirths;
        private System.Windows.Forms.Label lblAges;
    }
}