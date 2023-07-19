namespace PartiSecimIstatistik
{
    partial class FrmGrafikler
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbIlce = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar5 = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.LblA = new System.Windows.Forms.Label();
            this.LblB = new System.Windows.Forms.Label();
            this.LblC = new System.Windows.Forms.Label();
            this.LblD = new System.Windows.Forms.Label();
            this.LblE = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chart1);
            this.groupBox1.Location = new System.Drawing.Point(13, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1106, 337);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grafikler";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 26);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1100, 308);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LblE);
            this.groupBox2.Controls.Add(this.LblD);
            this.groupBox2.Controls.Add(this.LblC);
            this.groupBox2.Controls.Add(this.LblB);
            this.groupBox2.Controls.Add(this.LblA);
            this.groupBox2.Controls.Add(this.progressBar5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.progressBar4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.progressBar3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.progressBar2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.CmbIlce);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(16, 351);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1103, 319);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İlçe Değerleri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "İlçe Seçin:";
            // 
            // CmbIlce
            // 
            this.CmbIlce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbIlce.FormattingEnabled = true;
            this.CmbIlce.Location = new System.Drawing.Point(141, 45);
            this.CmbIlce.Name = "CmbIlce";
            this.CmbIlce.Size = new System.Drawing.Size(188, 32);
            this.CmbIlce.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "A PARTİ:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(141, 95);
            this.progressBar1.Maximum = 200;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(505, 35);
            this.progressBar1.TabIndex = 3;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(141, 134);
            this.progressBar2.Maximum = 200;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(505, 35);
            this.progressBar2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "B PARTİ:";
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(141, 173);
            this.progressBar3.Maximum = 200;
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(505, 35);
            this.progressBar3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "C PARTİ:";
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(141, 211);
            this.progressBar4.Maximum = 200;
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(505, 35);
            this.progressBar4.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "D PARTİ:";
            // 
            // progressBar5
            // 
            this.progressBar5.Location = new System.Drawing.Point(141, 250);
            this.progressBar5.Maximum = 200;
            this.progressBar5.Name = "progressBar5";
            this.progressBar5.Size = new System.Drawing.Size(505, 35);
            this.progressBar5.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "E PARTİ:";
            // 
            // LblA
            // 
            this.LblA.AutoSize = true;
            this.LblA.Location = new System.Drawing.Point(674, 106);
            this.LblA.Name = "LblA";
            this.LblA.Size = new System.Drawing.Size(22, 24);
            this.LblA.TabIndex = 12;
            this.LblA.Text = "0";
            // 
            // LblB
            // 
            this.LblB.AutoSize = true;
            this.LblB.Location = new System.Drawing.Point(674, 145);
            this.LblB.Name = "LblB";
            this.LblB.Size = new System.Drawing.Size(22, 24);
            this.LblB.TabIndex = 13;
            this.LblB.Text = "0";
            // 
            // LblC
            // 
            this.LblC.AutoSize = true;
            this.LblC.Location = new System.Drawing.Point(674, 184);
            this.LblC.Name = "LblC";
            this.LblC.Size = new System.Drawing.Size(22, 24);
            this.LblC.TabIndex = 14;
            this.LblC.Text = "0";
            // 
            // LblD
            // 
            this.LblD.AutoSize = true;
            this.LblD.Location = new System.Drawing.Point(674, 223);
            this.LblD.Name = "LblD";
            this.LblD.Size = new System.Drawing.Size(22, 24);
            this.LblD.TabIndex = 15;
            this.LblD.Text = "0";
            // 
            // LblE
            // 
            this.LblE.AutoSize = true;
            this.LblE.Location = new System.Drawing.Point(674, 261);
            this.LblE.Name = "LblE";
            this.LblE.Size = new System.Drawing.Size(22, 24);
            this.LblE.TabIndex = 16;
            this.LblE.Text = "0";
            // 
            // FrmGrafikler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(175)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1132, 683);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmGrafikler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VTGS";
            this.Load += new System.EventHandler(this.FrmGrafikler_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox CmbIlce;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblE;
        private System.Windows.Forms.Label LblD;
        private System.Windows.Forms.Label LblC;
        private System.Windows.Forms.Label LblB;
        private System.Windows.Forms.Label LblA;
        private System.Windows.Forms.ProgressBar progressBar5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2;
    }
}