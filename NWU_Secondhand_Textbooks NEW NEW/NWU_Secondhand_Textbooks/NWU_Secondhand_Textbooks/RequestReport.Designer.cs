namespace NWU_Secondhand_Textbooks
{
    partial class RequestReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestReport));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnlTextbook = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbltextbook = new System.Windows.Forms.Label();
            this.tbcReporting = new System.Windows.Forms.TabControl();
            this.tpReports = new System.Windows.Forms.TabPage();
            this.tbGraphs = new System.Windows.Forms.TabPage();
            this.gpbReport = new System.Windows.Forms.GroupBox();
            this.rdProfit = new System.Windows.Forms.RadioButton();
            this.rbAllSales = new System.Windows.Forms.RadioButton();
            this.rbAllPurchases = new System.Windows.Forms.RadioButton();
            this.rbInventory = new System.Windows.Forms.RadioButton();
            this.lblOutput = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1lblDateBetween = new System.Windows.Forms.Label();
            this.lblAnd = new System.Windows.Forms.Label();
            this.lblModule = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.pnlTextbook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tbcReporting.SuspendLayout();
            this.tpReports.SuspendLayout();
            this.tbGraphs.SuspendLayout();
            this.gpbReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTextbook
            // 
            this.pnlTextbook.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pnlTextbook.Controls.Add(this.pictureBox2);
            this.pnlTextbook.Controls.Add(this.pictureBox1);
            this.pnlTextbook.Controls.Add(this.lbltextbook);
            this.pnlTextbook.Location = new System.Drawing.Point(2, 2);
            this.pnlTextbook.Name = "pnlTextbook";
            this.pnlTextbook.Size = new System.Drawing.Size(1135, 111);
            this.pnlTextbook.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(954, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(177, 108);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lbltextbook
            // 
            this.lbltextbook.AutoSize = true;
            this.lbltextbook.Font = new System.Drawing.Font("Baskerville Old Face", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltextbook.Location = new System.Drawing.Point(481, 29);
            this.lbltextbook.Name = "lbltextbook";
            this.lbltextbook.Size = new System.Drawing.Size(143, 43);
            this.lbltextbook.TabIndex = 4;
            this.lbltextbook.Text = "Reports:";
            // 
            // tbcReporting
            // 
            this.tbcReporting.Controls.Add(this.tpReports);
            this.tbcReporting.Controls.Add(this.tbGraphs);
            this.tbcReporting.Location = new System.Drawing.Point(2, 116);
            this.tbcReporting.Name = "tbcReporting";
            this.tbcReporting.SelectedIndex = 0;
            this.tbcReporting.Size = new System.Drawing.Size(1135, 510);
            this.tbcReporting.TabIndex = 6;
            // 
            // tpReports
            // 
            this.tpReports.Controls.Add(this.comboBox1);
            this.tpReports.Controls.Add(this.lblModule);
            this.tpReports.Controls.Add(this.lblAnd);
            this.tpReports.Controls.Add(this.label1lblDateBetween);
            this.tpReports.Controls.Add(this.dateTimePicker2);
            this.tpReports.Controls.Add(this.dateTimePicker1);
            this.tpReports.Controls.Add(this.lblOutput);
            this.tpReports.Controls.Add(this.gpbReport);
            this.tpReports.Location = new System.Drawing.Point(4, 25);
            this.tpReports.Name = "tpReports";
            this.tpReports.Padding = new System.Windows.Forms.Padding(3);
            this.tpReports.Size = new System.Drawing.Size(1127, 481);
            this.tpReports.TabIndex = 0;
            this.tpReports.Text = "Reports";
            this.tpReports.UseVisualStyleBackColor = true;
            // 
            // tbGraphs
            // 
            this.tbGraphs.Controls.Add(this.groupBox1);
            this.tbGraphs.Controls.Add(this.chart1);
            this.tbGraphs.Location = new System.Drawing.Point(4, 25);
            this.tbGraphs.Name = "tbGraphs";
            this.tbGraphs.Padding = new System.Windows.Forms.Padding(3);
            this.tbGraphs.Size = new System.Drawing.Size(1127, 481);
            this.tbGraphs.TabIndex = 1;
            this.tbGraphs.Text = "Graphs";
            this.tbGraphs.UseVisualStyleBackColor = true;
            // 
            // gpbReport
            // 
            this.gpbReport.Controls.Add(this.rbInventory);
            this.gpbReport.Controls.Add(this.rbAllPurchases);
            this.gpbReport.Controls.Add(this.rbAllSales);
            this.gpbReport.Controls.Add(this.rdProfit);
            this.gpbReport.Location = new System.Drawing.Point(44, 24);
            this.gpbReport.Name = "gpbReport";
            this.gpbReport.Size = new System.Drawing.Size(220, 186);
            this.gpbReport.TabIndex = 0;
            this.gpbReport.TabStop = false;
            this.gpbReport.Text = "Reports on:";
            // 
            // rdProfit
            // 
            this.rdProfit.AutoSize = true;
            this.rdProfit.Location = new System.Drawing.Point(6, 31);
            this.rdProfit.Name = "rdProfit";
            this.rdProfit.Size = new System.Drawing.Size(58, 20);
            this.rdProfit.TabIndex = 0;
            this.rdProfit.TabStop = true;
            this.rdProfit.Text = "Profit";
            this.rdProfit.UseVisualStyleBackColor = true;
            // 
            // rbAllSales
            // 
            this.rbAllSales.AutoSize = true;
            this.rbAllSales.Location = new System.Drawing.Point(6, 72);
            this.rbAllSales.Name = "rbAllSales";
            this.rbAllSales.Size = new System.Drawing.Size(81, 20);
            this.rbAllSales.TabIndex = 1;
            this.rbAllSales.TabStop = true;
            this.rbAllSales.Text = "All Sales";
            this.rbAllSales.UseVisualStyleBackColor = true;
            // 
            // rbAllPurchases
            // 
            this.rbAllPurchases.AutoSize = true;
            this.rbAllPurchases.Location = new System.Drawing.Point(6, 107);
            this.rbAllPurchases.Name = "rbAllPurchases";
            this.rbAllPurchases.Size = new System.Drawing.Size(110, 20);
            this.rbAllPurchases.TabIndex = 2;
            this.rbAllPurchases.TabStop = true;
            this.rbAllPurchases.Text = "All Purchases";
            this.rbAllPurchases.UseVisualStyleBackColor = true;
            this.rbAllPurchases.CheckedChanged += new System.EventHandler(this.rbAllPurchases_CheckedChanged);
            // 
            // rbInventory
            // 
            this.rbInventory.AutoSize = true;
            this.rbInventory.Location = new System.Drawing.Point(6, 142);
            this.rbInventory.Name = "rbInventory";
            this.rbInventory.Size = new System.Drawing.Size(82, 20);
            this.rbInventory.TabIndex = 3;
            this.rbInventory.TabStop = true;
            this.rbInventory.Text = "Inventory";
            this.rbInventory.UseVisualStyleBackColor = true;
            // 
            // lblOutput
            // 
            this.lblOutput.FormattingEnabled = true;
            this.lblOutput.ItemHeight = 16;
            this.lblOutput.Location = new System.Drawing.Point(3, 233);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(1112, 244);
            this.lblOutput.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(291, 102);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(597, 102);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // label1lblDateBetween
            // 
            this.label1lblDateBetween.AutoSize = true;
            this.label1lblDateBetween.Location = new System.Drawing.Point(320, 57);
            this.label1lblDateBetween.Name = "label1lblDateBetween";
            this.label1lblDateBetween.Size = new System.Drawing.Size(120, 16);
            this.label1lblDateBetween.TabIndex = 9;
            this.label1lblDateBetween.Text = "Between the dates:";
            // 
            // lblAnd
            // 
            this.lblAnd.AutoSize = true;
            this.lblAnd.Location = new System.Drawing.Point(532, 108);
            this.lblAnd.Name = "lblAnd";
            this.lblAnd.Size = new System.Drawing.Size(30, 16);
            this.lblAnd.TabIndex = 10;
            this.lblAnd.Text = "and";
            // 
            // lblModule
            // 
            this.lblModule.AutoSize = true;
            this.lblModule.Location = new System.Drawing.Point(913, 69);
            this.lblModule.Name = "lblModule";
            this.lblModule.Size = new System.Drawing.Size(99, 16);
            this.lblModule.TabIndex = 11;
            this.lblModule.Text = "For the Module:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(916, 102);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 12;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(375, 66);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Location = new System.Drawing.Point(30, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 186);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reports on:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 142);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(82, 20);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Inventory";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 107);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(110, 20);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "All Purchases";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 72);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(81, 20);
            this.radioButton3.TabIndex = 1;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "All Sales";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 31);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(58, 20);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Profit";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // RequestReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 626);
            this.Controls.Add(this.tbcReporting);
            this.Controls.Add(this.pnlTextbook);
            this.Name = "RequestReport";
            this.Text = "RequestReport";
            this.Load += new System.EventHandler(this.RequestReport_Load);
            this.pnlTextbook.ResumeLayout(false);
            this.pnlTextbook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tbcReporting.ResumeLayout(false);
            this.tpReports.ResumeLayout(false);
            this.tpReports.PerformLayout();
            this.tbGraphs.ResumeLayout(false);
            this.gpbReport.ResumeLayout(false);
            this.gpbReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTextbook;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbltextbook;
        private System.Windows.Forms.TabControl tbcReporting;
        private System.Windows.Forms.TabPage tpReports;
        private System.Windows.Forms.GroupBox gpbReport;
        private System.Windows.Forms.RadioButton rbAllPurchases;
        private System.Windows.Forms.RadioButton rbAllSales;
        private System.Windows.Forms.RadioButton rdProfit;
        private System.Windows.Forms.TabPage tbGraphs;
        private System.Windows.Forms.Label lblAnd;
        private System.Windows.Forms.Label label1lblDateBetween;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListBox lblOutput;
        private System.Windows.Forms.RadioButton rbInventory;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblModule;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}