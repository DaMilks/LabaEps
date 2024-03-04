namespace LabaEps
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartE1F = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartE2F = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartE2E1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonPlot = new System.Windows.Forms.Button();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelT = new System.Windows.Forms.Label();
            this.labelE8 = new System.Windows.Forms.Label();
            this.labelEs = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxT = new System.Windows.Forms.TextBox();
            this.textBoxE8 = new System.Windows.Forms.TextBox();
            this.textBoxEs = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartE1F)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartE2F)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartE2E1)).BeginInit();
            this.SuspendLayout();
            // 
            // chartE1F
            // 
            chartArea10.Name = "ChartArea1";
            this.chartE1F.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            this.chartE1F.Legends.Add(legend10);
            this.chartE1F.Location = new System.Drawing.Point(12, 12);
            this.chartE1F.Name = "chartE1F";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series10.Legend = "Legend1";
            series10.Name = "Series1";
            this.chartE1F.Series.Add(series10);
            this.chartE1F.Size = new System.Drawing.Size(471, 289);
            this.chartE1F.TabIndex = 0;
            this.chartE1F.Text = "chartE1F";
            // 
            // chartE2F
            // 
            chartArea11.Name = "ChartArea1";
            this.chartE2F.ChartAreas.Add(chartArea11);
            legend11.Name = "Legend1";
            this.chartE2F.Legends.Add(legend11);
            this.chartE2F.Location = new System.Drawing.Point(12, 323);
            this.chartE2F.Name = "chartE2F";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series11.Legend = "Legend1";
            series11.Name = "Series1";
            this.chartE2F.Series.Add(series11);
            this.chartE2F.Size = new System.Drawing.Size(471, 322);
            this.chartE2F.TabIndex = 1;
            this.chartE2F.Text = "chartE2F";
            // 
            // chartE2E1
            // 
            chartArea12.Name = "ChartArea1";
            this.chartE2E1.ChartAreas.Add(chartArea12);
            legend12.Name = "Legend1";
            this.chartE2E1.Legends.Add(legend12);
            this.chartE2E1.Location = new System.Drawing.Point(516, 12);
            this.chartE2E1.Name = "chartE2E1";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series12.Legend = "Legend1";
            series12.Name = "Series1";
            this.chartE2E1.Series.Add(series12);
            this.chartE2E1.Size = new System.Drawing.Size(466, 289);
            this.chartE2E1.TabIndex = 2;
            this.chartE2E1.Text = "chartE1E2";
            // 
            // buttonPlot
            // 
            this.buttonPlot.Location = new System.Drawing.Point(892, 588);
            this.buttonPlot.Name = "buttonPlot";
            this.buttonPlot.Size = new System.Drawing.Size(75, 23);
            this.buttonPlot.TabIndex = 3;
            this.buttonPlot.Text = "Plot";
            this.buttonPlot.UseVisualStyleBackColor = true;
            this.buttonPlot.Click += new System.EventHandler(this.buttonPlot_Click);
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(861, 448);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(15, 16);
            this.labelA.TabIndex = 4;
            this.labelA.Text = "a";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(861, 476);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(15, 16);
            this.labelB.TabIndex = 5;
            this.labelB.Text = "b";
            // 
            // labelT
            // 
            this.labelT.AutoSize = true;
            this.labelT.Location = new System.Drawing.Point(866, 504);
            this.labelT.Name = "labelT";
            this.labelT.Size = new System.Drawing.Size(10, 16);
            this.labelT.TabIndex = 6;
            this.labelT.Text = "t";
            // 
            // labelE8
            // 
            this.labelE8.AutoSize = true;
            this.labelE8.Location = new System.Drawing.Point(854, 532);
            this.labelE8.Name = "labelE8";
            this.labelE8.Size = new System.Drawing.Size(22, 16);
            this.labelE8.TabIndex = 7;
            this.labelE8.Text = "e8";
            // 
            // labelEs
            // 
            this.labelEs.AutoSize = true;
            this.labelEs.Location = new System.Drawing.Point(854, 560);
            this.labelEs.Name = "labelEs";
            this.labelEs.Size = new System.Drawing.Size(22, 16);
            this.labelEs.TabIndex = 8;
            this.labelEs.Text = "es";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(882, 448);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(100, 22);
            this.textBoxA.TabIndex = 9;
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(882, 476);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(100, 22);
            this.textBoxB.TabIndex = 10;
            // 
            // textBoxT
            // 
            this.textBoxT.Location = new System.Drawing.Point(882, 504);
            this.textBoxT.Name = "textBoxT";
            this.textBoxT.Size = new System.Drawing.Size(100, 22);
            this.textBoxT.TabIndex = 11;
            // 
            // textBoxE8
            // 
            this.textBoxE8.Location = new System.Drawing.Point(882, 532);
            this.textBoxE8.Name = "textBoxE8";
            this.textBoxE8.Size = new System.Drawing.Size(100, 22);
            this.textBoxE8.TabIndex = 12;
            // 
            // textBoxEs
            // 
            this.textBoxEs.Location = new System.Drawing.Point(882, 560);
            this.textBoxEs.Name = "textBoxEs";
            this.textBoxEs.Size = new System.Drawing.Size(100, 22);
            this.textBoxEs.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(508, 341);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(273, 317);
            this.textBox1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 748);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxEs);
            this.Controls.Add(this.textBoxE8);
            this.Controls.Add(this.textBoxT);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.labelEs);
            this.Controls.Add(this.labelE8);
            this.Controls.Add(this.labelT);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.buttonPlot);
            this.Controls.Add(this.chartE2E1);
            this.Controls.Add(this.chartE2F);
            this.Controls.Add(this.chartE1F);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chartE1F)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartE2F)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartE2E1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartE1F;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartE2F;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartE2E1;
        private System.Windows.Forms.Button buttonPlot;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelT;
        private System.Windows.Forms.Label labelE8;
        private System.Windows.Forms.Label labelEs;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxT;
        private System.Windows.Forms.TextBox textBoxE8;
        private System.Windows.Forms.TextBox textBoxEs;
        private System.Windows.Forms.TextBox textBox1;
    }
}

