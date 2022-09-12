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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Availible_Textbooks));
            this.dgvAvailable = new System.Windows.Forms.DataGridView();
            this.lblModule = new System.Windows.Forms.Label();
            this.cbModule = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlAvailable = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlAvailable.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAvailable
            // 
            this.dgvAvailable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvailable.Location = new System.Drawing.Point(26, 105);
            this.dgvAvailable.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAvailable.Name = "dgvAvailable";
            this.dgvAvailable.RowHeadersWidth = 51;
            this.dgvAvailable.RowTemplate.Height = 24;
            this.dgvAvailable.Size = new System.Drawing.Size(517, 349);
            this.dgvAvailable.TabIndex = 1;
            // 
            // lblModule
            // 
            this.lblModule.AutoSize = true;
            this.lblModule.Location = new System.Drawing.Point(547, 148);
            this.lblModule.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModule.Name = "lblModule";
            this.lblModule.Size = new System.Drawing.Size(45, 13);
            this.lblModule.TabIndex = 3;
            this.lblModule.Text = "Module:";
            // 
            // cbModule
            // 
            this.cbModule.FormattingEnabled = true;
            this.cbModule.Location = new System.Drawing.Point(612, 141);
            this.cbModule.Margin = new System.Windows.Forms.Padding(2);
            this.cbModule.Name = "cbModule";
            this.cbModule.Size = new System.Drawing.Size(92, 21);
            this.cbModule.TabIndex = 4;
            this.toolTip1.SetToolTip(this.cbModule, "Select The Module To View Textbooks In");
            this.cbModule.SelectedIndexChanged += new System.EventHandler(this.cbModule_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(555, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Please select the module code:";
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailable.Location = new System.Drawing.Point(255, 25);
            this.lblAvailable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(291, 36);
            this.lblAvailable.TabIndex = 4;
            this.lblAvailable.Text = "Available Textbooks:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
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
            // pnlAvailable
            // 
            this.pnlAvailable.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pnlAvailable.Controls.Add(this.pictureBox2);
            this.pnlAvailable.Controls.Add(this.pictureBox1);
            this.pnlAvailable.Controls.Add(this.lblAvailable);
            this.pnlAvailable.Location = new System.Drawing.Point(17, 10);
            this.pnlAvailable.Margin = new System.Windows.Forms.Padding(2);
            this.pnlAvailable.Name = "pnlAvailable";
            this.pnlAvailable.Size = new System.Drawing.Size(742, 90);
            this.pnlAvailable.TabIndex = 0;
            // 
            // Availible_Textbooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 477);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbModule);
            this.Controls.Add(this.lblModule);
            this.Controls.Add(this.dgvAvailable);
            this.Controls.Add(this.pnlAvailable);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Label lblModule;
        private System.Windows.Forms.ComboBox cbModule;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pnlAvailable;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}