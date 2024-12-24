namespace Tyuiu.AkhmetovRR.Sprint7.V13
{
    partial class Analizform
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
            btnExit_АхметовРР = new Button();
            dGvnew_АхметовРР = new DataGridView();
            statistika_АхметовРР = new GroupBox();
            btnmax_АхметовРР = new Button();
            btnmin_АхметовРР = new Button();
            btnsrednee_АхметовРР = new Button();
            btnsum_АхметовРР = new Button();
            btnkolichestvo_АхметовРР = new Button();
            grafic_АхметовРР = new GroupBox();
            btndiagr_АхметовРР = new Button();
            btnfun_АхметовРР = new Button();
            btngist_АхметовРР = new Button();
            chart_АхметовРР = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)dGvnew_АхметовРР).BeginInit();
            statistika_АхметовРР.SuspendLayout();
            grafic_АхметовРР.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart_АхметовРР).BeginInit();
            SuspendLayout();
            // 
            // btnExit_АхметовРР
            // 
            btnExit_АхметовРР.Location = new Point(319, 722);
            btnExit_АхметовРР.Name = "btnExit_АхметовРР";
            btnExit_АхметовРР.Size = new Size(142, 23);
            btnExit_АхметовРР.TabIndex = 0;
            btnExit_АхметовРР.Text = "Выход";
            btnExit_АхметовРР.UseVisualStyleBackColor = true;
            btnExit_АхметовРР.Click += btnExit_Click;
            // 
            // dGvnew_АхметовРР
            // 
            dGvnew_АхметовРР.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGvnew_АхметовРР.Location = new Point(480, 59);
            dGvnew_АхметовРР.Name = "dGvnew_АхметовРР";
            dGvnew_АхметовРР.Size = new Size(240, 272);
            dGvnew_АхметовРР.TabIndex = 1;
            // 
            // statistika_АхметовРР
            // 
            statistika_АхметовРР.Controls.Add(btnmax_АхметовРР);
            statistika_АхметовРР.Controls.Add(btnmin_АхметовРР);
            statistika_АхметовРР.Controls.Add(btnsrednee_АхметовРР);
            statistika_АхметовРР.Controls.Add(btnsum_АхметовРР);
            statistika_АхметовРР.Controls.Add(btnkolichestvo_АхметовРР);
            statistika_АхметовРР.Location = new Point(34, 41);
            statistika_АхметовРР.Name = "statistika_АхметовРР";
            statistika_АхметовРР.Size = new Size(255, 311);
            statistika_АхметовРР.TabIndex = 2;
            statistika_АхметовРР.TabStop = false;
            statistika_АхметовРР.Text = "Статистика ";
            // 
            // btnmax_АхметовРР
            // 
            btnmax_АхметовРР.Location = new Point(6, 253);
            btnmax_АхметовРР.Name = "btnmax_АхметовРР";
            btnmax_АхметовРР.Size = new Size(127, 23);
            btnmax_АхметовРР.TabIndex = 3;
            btnmax_АхметовРР.Text = "Максимальное";
            btnmax_АхметовРР.UseVisualStyleBackColor = true;
            btnmax_АхметовРР.Click += btnmax_АхметовРР_Click_1;
            // 
            // btnmin_АхметовРР
            // 
            btnmin_АхметовРР.Location = new Point(6, 203);
            btnmin_АхметовРР.Name = "btnmin_АхметовРР";
            btnmin_АхметовРР.Size = new Size(127, 23);
            btnmin_АхметовРР.TabIndex = 3;
            btnmin_АхметовРР.Text = "Минимальное";
            btnmin_АхметовРР.UseVisualStyleBackColor = true;
            btnmin_АхметовРР.Click += btnmin_АхметовРР_Click;
            // 
            // btnsrednee_АхметовРР
            // 
            btnsrednee_АхметовРР.Location = new Point(6, 159);
            btnsrednee_АхметовРР.Name = "btnsrednee_АхметовРР";
            btnsrednee_АхметовРР.Size = new Size(127, 23);
            btnsrednee_АхметовРР.TabIndex = 3;
            btnsrednee_АхметовРР.Text = "Среднее";
            btnsrednee_АхметовРР.UseVisualStyleBackColor = true;
            btnsrednee_АхметовРР.Click += btnsrednee_АхметовРР_Click;
            // 
            // btnsum_АхметовРР
            // 
            btnsum_АхметовРР.Location = new Point(6, 112);
            btnsum_АхметовРР.Name = "btnsum_АхметовРР";
            btnsum_АхметовРР.Size = new Size(127, 23);
            btnsum_АхметовРР.TabIndex = 1;
            btnsum_АхметовРР.Text = "Сумма";
            btnsum_АхметовРР.UseVisualStyleBackColor = true;
            btnsum_АхметовРР.Click += btnsum_АхметовРР_Click;
            // 
            // btnkolichestvo_АхметовРР
            // 
            btnkolichestvo_АхметовРР.Location = new Point(6, 70);
            btnkolichestvo_АхметовРР.Name = "btnkolichestvo_АхметовРР";
            btnkolichestvo_АхметовРР.Size = new Size(127, 23);
            btnkolichestvo_АхметовРР.TabIndex = 0;
            btnkolichestvo_АхметовРР.Text = "Количество";
            btnkolichestvo_АхметовРР.UseVisualStyleBackColor = true;
            btnkolichestvo_АхметовРР.Click += btnkolichestvo_АхметовРР_Click;
            // 
            // grafic_АхметовРР
            // 
            grafic_АхметовРР.Controls.Add(btndiagr_АхметовРР);
            grafic_АхметовРР.Controls.Add(btnfun_АхметовРР);
            grafic_АхметовРР.Controls.Add(btngist_АхметовРР);
            grafic_АхметовРР.Location = new Point(34, 376);
            grafic_АхметовРР.Name = "grafic_АхметовРР";
            grafic_АхметовРР.Size = new Size(255, 311);
            grafic_АхметовРР.TabIndex = 4;
            grafic_АхметовРР.TabStop = false;
            grafic_АхметовРР.Text = "График";
            grafic_АхметовРР.Enter += grafic_АхметовРР_Enter;
            // 
            // btndiagr_АхметовРР
            // 
            btndiagr_АхметовРР.Location = new Point(6, 192);
            btndiagr_АхметовРР.Name = "btndiagr_АхметовРР";
            btndiagr_АхметовРР.Size = new Size(127, 23);
            btndiagr_АхметовРР.TabIndex = 3;
            btndiagr_АхметовРР.Text = "Диаграмма";
            btndiagr_АхметовРР.UseVisualStyleBackColor = true;
            btndiagr_АхметовРР.Click += btndiagr_АхметовРР_Click;
            // 
            // btnfun_АхметовРР
            // 
            btnfun_АхметовРР.Location = new Point(6, 136);
            btnfun_АхметовРР.Name = "btnfun_АхметовРР";
            btnfun_АхметовРР.Size = new Size(127, 23);
            btnfun_АхметовРР.TabIndex = 1;
            btnfun_АхметовРР.Text = "Функция";
            btnfun_АхметовРР.UseVisualStyleBackColor = true;
            btnfun_АхметовРР.Click += btnfun_АхметовРР_Click;
            // 
            // btngist_АхметовРР
            // 
            btngist_АхметовРР.Location = new Point(6, 80);
            btngist_АхметовРР.Name = "btngist_АхметовРР";
            btngist_АхметовРР.Size = new Size(127, 23);
            btngist_АхметовРР.TabIndex = 0;
            btngist_АхметовРР.Text = "Гистограмма";
            btngist_АхметовРР.UseVisualStyleBackColor = true;
            btngist_АхметовРР.Click += btngist_АхметовРР_Click;
            // 
            // chart_АхметовРР
            // 
            chartArea1.Name = "ChartArea1";
            chart_АхметовРР.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart_АхметовРР.Legends.Add(legend1);
            chart_АхметовРР.Location = new Point(364, 337);
            chart_АхметовРР.Name = "chart_АхметовРР";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart_АхметовРР.Series.Add(series1);
            chart_АхметовРР.Size = new Size(384, 350);
            chart_АхметовРР.TabIndex = 5;
            chart_АхметовРР.Text = "Диаграмма";
            // 
            // Analizform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 788);
            Controls.Add(chart_АхметовРР);
            Controls.Add(grafic_АхметовРР);
            Controls.Add(statistika_АхметовРР);
            Controls.Add(dGvnew_АхметовРР);
            Controls.Add(btnExit_АхметовРР);
            Name = "Analizform";
            Text = "Analizform";
            Load += Analizform_Load;
            ((System.ComponentModel.ISupportInitialize)dGvnew_АхметовРР).EndInit();
            statistika_АхметовРР.ResumeLayout(false);
            grafic_АхметовРР.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart_АхметовРР).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnExit_АхметовРР;
        private DataGridView dGvnew_АхметовРР;
        private GroupBox statistika_АхметовРР;
        private Button btnmax_АхметовРР;
        private Button btnmin_АхметовРР;
        private Button btnsrednee_АхметовРР;
        private Button btnsum_АхметовРР;
        private Button btnkolichestvo_АхметовРР;
        private GroupBox grafic_АхметовРР;
        private Button btndiagr_АхметовРР;
        private Button btnfun_АхметовРР;
        private Button btngist_АхметовРР;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_АхметовРР;
    }
}