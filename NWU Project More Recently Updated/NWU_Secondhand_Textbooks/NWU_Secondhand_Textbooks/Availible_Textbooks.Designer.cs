namespace NWU_Secondhand_Textbooks
{
    partial class Availible_Textbooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Availible_Textbooks));
            this.dgvAvailable = new System.Windows.Forms.DataGridView();
            this.btn = new System.Windows.Forms.Button();
            this.lblModule = new System.Windows.Forms.Label();
            this.cbModule = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlAvailable = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlAvailable.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAvailable
            // 
            this.dgvAvailable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvailable.Location = new System.Drawing.Point(34, 129);
            this.dgvAvailable.Name = "dgvAvailable";
            this.dgvAvailable.RowHeadersWidth = 51;
            this.dgvAvailable.RowTemplate.Height = 24;
            this.dgvAvailable.Size = new System.Drawing.Size(689, 429);
            this.dgvAvailable.TabIndex = 1;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(835, 231);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(102, 43);
            this.btn.TabIndex = 2;
            this.btn.Text = "Search For Module Textbook";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // lblModule
            // 
            this.lblModule.AutoSize = true;
            this.lblModule.Location = new System.Drawing.Point(729, 182);
            this.lblModule.Name = "lblModule";
            this.lblModule.Size = new System.Drawing.Size(55, 16);
            this.lblModule.TabIndex = 3;
            this.lblModule.Text = "Module:";
            // 
            // cbModule
            // 
            this.cbModule.FormattingEnabled = true;
            this.cbModule.Location = new System.Drawing.Point(816, 174);
            this.cbModule.Name = "cbModule";
            this.cbModule.Size = new System.Drawing.Size(121, 24);
            this.cbModule.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(740, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Please select the module code:";
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Font = new System.Drawing.Font("Baskerville Old Face", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailable.Location = new System.Drawing.Point(340, 31);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(329, 43);
            this.lblAvailable.TabIndex = 4;
            this.lblAvailable.Text = "Available Textbooks:";
            this.lblAvailable.Click += new System.EventHandler(this.lblAvailable_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(52, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
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
            // pnlAvailable
            // 
            this.pnlAvailable.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pnlAvailable.Controls.Add(this.pictureBox2);
            this.pnlAvailable.Controls.Add(this.pictureBox1);
            this.pnlAvailable.Controls.Add(this.lblAvailable);
            this.pnlAvailable.Location = new System.Drawing.Point(23, 12);
            this.pnlAvailable.Name = "pnlAvailable";
            this.pnlAvailable.Size = new System.Drawing.Size(989, 111);
            this.pnlAvailable.TabIndex = 0;
            // 
            // Availible_Textbooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 587);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbModule);
            this.Controls.Add(this.lblModule);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.dgvAvailable);
            this.Controls.Add(this.pnlAvailable);
            this.Name = "Availible_Textbooks";
            this.Text = "Availible_Textbooks";
            this.Load += new System.EventHandler(this.Availible_Textbooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlAvailable.ResumeLayout(false);
            this.pnlAvailable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvAvailable;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label lblModule;
        private System.Windows.Forms.ComboBox cbModule;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pnlAvailable;
    }
}