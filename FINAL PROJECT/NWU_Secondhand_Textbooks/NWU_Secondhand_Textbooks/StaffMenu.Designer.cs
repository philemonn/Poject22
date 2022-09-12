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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffMenu));
            this.pnlTextbook = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSTaffMaintain = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClient = new System.Windows.Forms.Button();
            this.btnAuthor = new System.Windows.Forms.Button();
            this.btnTextbooks = new System.Windows.Forms.Button();
            this.btnGetReports = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlTextbook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTextbook
            // 
            this.pnlTextbook.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pnlTextbook.Controls.Add(this.pictureBox2);
            this.pnlTextbook.Controls.Add(this.pictureBox1);
            this.pnlTextbook.Controls.Add(this.lblSTaffMaintain);
            this.pnlTextbook.Location = new System.Drawing.Point(1, 0);
            this.pnlTextbook.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTextbook.Name = "pnlTextbook";
            this.pnlTextbook.Size = new System.Drawing.Size(742, 90);
            this.pnlTextbook.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(574, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(133, 88);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lblSTaffMaintain
            // 
            this.lblSTaffMaintain.AutoSize = true;
            this.lblSTaffMaintain.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSTaffMaintain.Location = new System.Drawing.Point(206, 26);
            this.lblSTaffMaintain.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSTaffMaintain.Name = "lblSTaffMaintain";
            this.lblSTaffMaintain.Size = new System.Drawing.Size(373, 36);
            this.lblSTaffMaintain.TabIndex = 4;
            this.lblSTaffMaintain.Text = "Welcome to the Staff Page:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "What would you like to do?";
            // 
            // btnClient
            // 
            this.btnClient.Location = new System.Drawing.Point(56, 18);
            this.btnClient.Margin = new System.Windows.Forms.Padding(2);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(91, 32);
            this.btnClient.TabIndex = 7;
            this.btnClient.Text = "Maintain Clients";
            this.toolTip1.SetToolTip(this.btnClient, "Go To Maintain Clients Form");
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAuthor
            // 
            this.btnAuthor.Location = new System.Drawing.Point(56, 66);
            this.btnAuthor.Margin = new System.Windows.Forms.Padding(2);
            this.btnAuthor.Name = "btnAuthor";
            this.btnAuthor.Size = new System.Drawing.Size(91, 32);
            this.btnAuthor.TabIndex = 8;
            this.btnAuthor.Text = "Maintain Author";
            this.toolTip1.SetToolTip(this.btnAuthor, "Go To Maintain Author Form");
            this.btnAuthor.UseVisualStyleBackColor = true;
            this.btnAuthor.Click += new System.EventHandler(this.btnAuthor_Click);
            // 
            // btnTextbooks
            // 
            this.btnTextbooks.Location = new System.Drawing.Point(56, 115);
            this.btnTextbooks.Margin = new System.Windows.Forms.Padding(2);
            this.btnTextbooks.Name = "btnTextbooks";
            this.btnTextbooks.Size = new System.Drawing.Size(91, 34);
            this.btnTextbooks.TabIndex = 9;
            this.btnTextbooks.Text = "Maintain Textbooks";
            this.toolTip1.SetToolTip(this.btnTextbooks, "Go To Maintain Textbooks Form");
            this.btnTextbooks.UseVisualStyleBackColor = true;
            this.btnTextbooks.Click += new System.EventHandler(this.btnTextbooks_Click);
            // 
            // btnGetReports
            // 
            this.btnGetReports.Location = new System.Drawing.Point(14, 336);
            this.btnGetReports.Margin = new System.Windows.Forms.Padding(2);
            this.btnGetReports.Name = "btnGetReports";
            this.btnGetReports.Size = new System.Drawing.Size(199, 34);
            this.btnGetReports.TabIndex = 11;
            this.btnGetReports.Text = "Get Report";
            this.toolTip1.SetToolTip(this.btnGetReports, "Go To Get Reports Form");
            this.btnGetReports.UseVisualStyleBackColor = true;
            this.btnGetReports.Click += new System.EventHandler(this.btnGetReports_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(537, 348);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 37);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "back";
            this.toolTip1.SetToolTip(this.btnBack, "Go Back To The Main Menu");
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(622, 348);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 37);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.toolTip1.SetToolTip(this.btnClose, "Close The Program");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClient);
            this.groupBox1.Controls.Add(this.btnAuthor);
            this.groupBox1.Controls.Add(this.btnTextbooks);
            this.groupBox1.Location = new System.Drawing.Point(14, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 179);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Maintian";
            // 
            // StaffMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 397);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnGetReports);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlTextbook);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StaffMenu";
            this.Text = "StaffMenu";
            this.pnlTextbook.ResumeLayout(false);
            this.pnlTextbook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnGetReports;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}