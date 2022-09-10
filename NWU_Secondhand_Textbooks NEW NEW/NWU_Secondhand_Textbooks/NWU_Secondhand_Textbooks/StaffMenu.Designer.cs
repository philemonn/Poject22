namespace NWU_Secondhand_Textbooks
{
    partial class StaffMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffMenu));
            this.pnlTextbook = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSTaffMaintain = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClient = new System.Windows.Forms.Button();
            this.btnAuthor = new System.Windows.Forms.Button();
            this.btnTextbooks = new System.Windows.Forms.Button();
            this.btnConditions = new System.Windows.Forms.Button();
            this.btnGetReports = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlTextbook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTextbook
            // 
            this.pnlTextbook.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pnlTextbook.Controls.Add(this.pictureBox2);
            this.pnlTextbook.Controls.Add(this.pictureBox1);
            this.pnlTextbook.Controls.Add(this.lblSTaffMaintain);
            this.pnlTextbook.Location = new System.Drawing.Point(1, 0);
            this.pnlTextbook.Name = "pnlTextbook";
            this.pnlTextbook.Size = new System.Drawing.Size(989, 111);
            this.pnlTextbook.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(765, 0);
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
            // lblSTaffMaintain
            // 
            this.lblSTaffMaintain.AutoSize = true;
            this.lblSTaffMaintain.Font = new System.Drawing.Font("Baskerville Old Face", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSTaffMaintain.Location = new System.Drawing.Point(274, 32);
            this.lblSTaffMaintain.Name = "lblSTaffMaintain";
            this.lblSTaffMaintain.Size = new System.Drawing.Size(419, 43);
            this.lblSTaffMaintain.TabIndex = 4;
            this.lblSTaffMaintain.Text = "Welcome to the Staff Page:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "What would you like to do?";
            // 
            // btnClient
            // 
            this.btnClient.Location = new System.Drawing.Point(75, 206);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(117, 39);
            this.btnClient.TabIndex = 7;
            this.btnClient.Text = "Maintain Clients";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAuthor
            // 
            this.btnAuthor.Location = new System.Drawing.Point(74, 273);
            this.btnAuthor.Name = "btnAuthor";
            this.btnAuthor.Size = new System.Drawing.Size(118, 40);
            this.btnAuthor.TabIndex = 8;
            this.btnAuthor.Text = "Maintain Author";
            this.btnAuthor.UseVisualStyleBackColor = true;
            this.btnAuthor.Click += new System.EventHandler(this.btnAuthor_Click);
            // 
            // btnTextbooks
            // 
            this.btnTextbooks.Location = new System.Drawing.Point(74, 333);
            this.btnTextbooks.Name = "btnTextbooks";
            this.btnTextbooks.Size = new System.Drawing.Size(118, 42);
            this.btnTextbooks.TabIndex = 9;
            this.btnTextbooks.Text = "Maintain Textbooks";
            this.btnTextbooks.UseVisualStyleBackColor = true;
            this.btnTextbooks.Click += new System.EventHandler(this.btnTextbooks_Click);
            // 
            // btnConditions
            // 
            this.btnConditions.Location = new System.Drawing.Point(75, 394);
            this.btnConditions.Name = "btnConditions";
            this.btnConditions.Size = new System.Drawing.Size(121, 43);
            this.btnConditions.TabIndex = 10;
            this.btnConditions.Text = "Maintain Condition";
            this.btnConditions.UseVisualStyleBackColor = true;
            this.btnConditions.Click += new System.EventHandler(this.btnConditions_Click);
            // 
            // btnGetReports
            // 
            this.btnGetReports.Location = new System.Drawing.Point(367, 273);
            this.btnGetReports.Name = "btnGetReports";
            this.btnGetReports.Size = new System.Drawing.Size(106, 42);
            this.btnGetReports.TabIndex = 11;
            this.btnGetReports.Text = "Get Report";
            this.btnGetReports.UseVisualStyleBackColor = true;
            this.btnGetReports.Click += new System.EventHandler(this.btnGetReports_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(827, 431);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(106, 46);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Back to Main Form";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // StaffMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 489);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnGetReports);
            this.Controls.Add(this.btnConditions);
            this.Controls.Add(this.btnTextbooks);
            this.Controls.Add(this.btnAuthor);
            this.Controls.Add(this.btnClient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlTextbook);
            this.Name = "StaffMenu";
            this.Text = "StaffMenu";
            this.pnlTextbook.ResumeLayout(false);
            this.pnlTextbook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTextbook;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSTaffMaintain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnAuthor;
        private System.Windows.Forms.Button btnTextbooks;
        private System.Windows.Forms.Button btnConditions;
        private System.Windows.Forms.Button btnGetReports;
        private System.Windows.Forms.Button btnBack;
    }
}