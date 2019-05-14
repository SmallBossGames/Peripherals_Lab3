namespace Peripherals_Lab3
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.SourceDecTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SourceBinTextBox = new System.Windows.Forms.TextBox();
            this.AnalogTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.E0TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.С1TextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.С2TextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            this.SuspendLayout();
            // 
            // Chart
            // 
            chartArea1.Name = "ChartArea1";
            this.Chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Chart.Legends.Add(legend1);
            this.Chart.Location = new System.Drawing.Point(198, 12);
            this.Chart.Name = "Chart";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series1.Legend = "Legend1";
            series1.Name = "ЦАП";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Исходное значение";
            this.Chart.Series.Add(series1);
            this.Chart.Series.Add(series2);
            this.Chart.Size = new System.Drawing.Size(590, 426);
            this.Chart.TabIndex = 0;
            this.Chart.Text = "chart1";
            // 
            // SourceDecTextBox
            // 
            this.SourceDecTextBox.Location = new System.Drawing.Point(15, 25);
            this.SourceDecTextBox.Name = "SourceDecTextBox";
            this.SourceDecTextBox.Size = new System.Drawing.Size(160, 20);
            this.SourceDecTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Исходное значение";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Исходное значение (бинарное)";
            // 
            // SourceBinTextBox
            // 
            this.SourceBinTextBox.Location = new System.Drawing.Point(15, 64);
            this.SourceBinTextBox.Name = "SourceBinTextBox";
            this.SourceBinTextBox.ReadOnly = true;
            this.SourceBinTextBox.Size = new System.Drawing.Size(160, 20);
            this.SourceBinTextBox.TabIndex = 3;
            // 
            // AnalogTextBox
            // 
            this.AnalogTextBox.Location = new System.Drawing.Point(15, 414);
            this.AnalogTextBox.Name = "AnalogTextBox";
            this.AnalogTextBox.ReadOnly = true;
            this.AnalogTextBox.Size = new System.Drawing.Size(160, 20);
            this.AnalogTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Аналоговое значение";
            // 
            // ConvertButton
            // 
            this.ConvertButton.Location = new System.Drawing.Point(15, 207);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(160, 23);
            this.ConvertButton.TabIndex = 5;
            this.ConvertButton.Text = "Преобразовать";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // E0TextBox
            // 
            this.E0TextBox.Location = new System.Drawing.Point(15, 103);
            this.E0TextBox.Name = "E0TextBox";
            this.E0TextBox.Size = new System.Drawing.Size(160, 20);
            this.E0TextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Исходное напряжение";
            // 
            // С1TextBox
            // 
            this.С1TextBox.Location = new System.Drawing.Point(15, 142);
            this.С1TextBox.Name = "С1TextBox";
            this.С1TextBox.Size = new System.Drawing.Size(160, 20);
            this.С1TextBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ёмкость конденсатора 1";
            // 
            // С2TextBox
            // 
            this.С2TextBox.Location = new System.Drawing.Point(15, 181);
            this.С2TextBox.Name = "С2TextBox";
            this.С2TextBox.Size = new System.Drawing.Size(160, 20);
            this.С2TextBox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ёмкость конденсатора 2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Преобразовать2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AnalogTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SourceBinTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.С2TextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.С1TextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.E0TextBox);
            this.Controls.Add(this.SourceDecTextBox);
            this.Controls.Add(this.Chart);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
        private System.Windows.Forms.TextBox SourceDecTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SourceBinTextBox;
        private System.Windows.Forms.TextBox AnalogTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.TextBox E0TextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox С1TextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox С2TextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}

