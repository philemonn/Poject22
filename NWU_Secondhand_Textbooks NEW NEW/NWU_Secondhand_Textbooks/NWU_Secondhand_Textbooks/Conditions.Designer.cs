namespace NWU_Secondhand_Textbooks
{
    partial class Conditions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Conditions));
            this.pnlTextbook = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblconditions = new System.Windows.Forms.Label();
            this.tbNew = new System.Windows.Forms.TabPage();
            this.tbpInsert = new System.Windows.Forms.TabPage();
            this.btnUpdateCOn = new System.Windows.Forms.Button();
            this.lblBook = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCondition = new System.Windows.Forms.Label();
            this.dgMaintainCondition = new System.Windows.Forms.DataGridView();
            this.cbTextbookID = new System.Windows.Forms.ComboBox();
            this.cbQuality = new System.Windows.Forms.ComboBox();
            this.tbCondition = new System.Windows.Forms.TabControl();
            this.pnlTextbook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tbpInsert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMaintainCondition)).BeginInit();
            this.tbCondition.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTextbook
            // 
            this.pnlTextbook.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pnlTextbook.Controls.Add(this.pictureBox2);
            this.pnlTextbook.Controls.Add(this.pictureBox1);
            this.pnlTextbook.Controls.Add(this.lblconditions);
            this.pnlTextbook.Location = new System.Drawing.Point(0, 3);
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
            // lblconditions
            // 
            this.lblconditions.AutoSize = true;
            this.lblconditions.Font = new System.Drawing.Font("Baskerville Old Face", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconditions.Location = new System.Drawing.Point(354, 32);
            this.lblconditions.Name = "lblconditions";
            this.lblconditions.Size = new System.Drawing.Size(316, 43);
            this.lblconditions.TabIndex = 4;
            this.lblconditions.Text = "Maintain Condition:";
            // 
            // tbNew
            // 
            this.tbNew.Font = new System.Drawing.Font("Baskerville Old Face", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNew.Location = new System.Drawing.Point(4, 25);
            this.tbNew.Name = "tbNew";
            this.tbNew.Size = new System.Drawing.Size(914, 389);
            this.tbNew.TabIndex = 2;
            this.tbNew.Text = "Update Condition";
            this.tbNew.UseVisualStyleBackColor = true;
            // 
            // tbpInsert
            // 
            this.tbpInsert.Controls.Add(this.cbQuality);
            this.tbpInsert.Controls.Add(this.cbTextbookID);
            this.tbpInsert.Controls.Add(this.dgMaintainCondition);
            this.tbpInsert.Controls.Add(this.lblCondition);
            this.tbpInsert.Controls.Add(this.label2);
            this.tbpInsert.Controls.Add(this.lblBook);
            this.tbpInsert.Controls.Add(this.btnUpdateCOn);
            this.tbpInsert.Font = new System.Drawing.Font("Baskerville Old Face", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpInsert.Location = new System.Drawing.Point(4, 25);
            this.tbpInsert.Name = "tbpInsert";
            this.tbpInsert.Padding = new System.Windows.Forms.Padding(3);
            this.tbpInsert.Size = new System.Drawing.Size(914, 389);
            this.tbpInsert.TabIndex = 0;
            this.tbpInsert.Tag = "";
            this.tbpInsert.Text = "Insert New Client";
            this.tbpInsert.UseVisualStyleBackColor = true;
            // 
            // btnUpdateCOn
            // 
            this.btnUpdateCOn.Location = new System.Drawing.Point(171, 282);
            this.btnUpdateCOn.Name = "btnUpdateCOn";
            this.btnUpdateCOn.Size = new System.Drawing.Size(134, 47);
            this.btnUpdateCOn.TabIndex = 0;
            this.btnUpdateCOn.Text = "Update Book Condition";
            this.btnUpdateCOn.UseVisualStyleBackColor = true;
            // 
            // lblBook
            // 
            this.lblBook.AutoSize = true;
            this.lblBook.Location = new System.Drawing.Point(10, 77);
            this.lblBook.Name = "lblBook";
            this.lblBook.Size = new System.Drawing.Size(99, 19);
            this.lblBook.TabIndex = 4;
            this.lblBook.Text = "Textbook ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(322, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Please enter the following Details of the Client:";
            // 
            // lblCondition
            // 
            this.lblCondition.AutoSize = true;
            this.lblCondition.Location = new System.Drawing.Point(3, 150);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(93, 19);
            this.lblCondition.TabIndex = 7;
            this.lblCondition.Text = "New Quality";
            // 
            // dgMaintainCondition
            // 
            this.dgMaintainCondition.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMaintainCondition.Location = new System.Drawing.Point(433, 19);
            this.dgMaintainCondition.Name = "dgMaintainCondition";
            this.dgMaintainCondition.RowHeadersWidth = 51;
            this.dgMaintainCondition.RowTemplate.Height = 24;
            this.dgMaintainCondition.Size = new System.Drawing.Size(455, 310);
            this.dgMaintainCondition.TabIndex = 8;
            // 
            // cbTextbookID
            // 
            this.cbTextbookID.FormattingEnabled = true;
            this.cbTextbookID.Location = new System.Drawing.Point(171, 77);
            this.cbTextbookID.Name = "cbTextbookID";
            this.cbTextbookID.Size = new System.Drawing.Size(121, 27);
            this.cbTextbookID.TabIndex = 9;
            // 
            // cbQuality
            // 
            this.cbQuality.FormattingEnabled = true;
            this.cbQuality.Location = new System.Drawing.Point(171, 150);
            this.cbQuality.Name = "cbQuality";
            this.cbQuality.Size = new System.Drawing.Size(121, 27);
            this.cbQuality.TabIndex = 10;
            // 
            // tbCondition
            // 
            this.tbCondition.Controls.Add(this.tbpInsert);
            this.tbCondition.Controls.Add(this.tbNew);
            this.tbCondition.Location = new System.Drawing.Point(-2, 120);
            this.tbCondition.Name = "tbCondition";
            this.tbCondition.SelectedIndex = 0;
            this.tbCondition.Size = new System.Drawing.Size(922, 418);
            this.tbCondition.TabIndex = 6;
            // 
            // Conditions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 581);
            this.Controls.Add(this.tbCondition);
            this.Controls.Add(this.pnlTextbook);
            this.Name = "Conditions";
            this.Text = "Conditions";
            this.pnlTextbook.ResumeLayout(false);
            this.pnlTextbook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tbpInsert.ResumeLayout(false);
            this.tbpInsert.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMaintainCondition)).EndInit();
            this.tbCondition.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTextbook;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblconditions;
        private System.Windows.Forms.TabPage tbNew;
        private System.Windows.Forms.TabPage tbpInsert;
        private System.Windows.Forms.ComboBox cbQuality;
        private System.Windows.Forms.ComboBox cbTextbookID;
        private System.Windows.Forms.DataGridView dgMaintainCondition;
        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBook;
        private System.Windows.Forms.Button btnUpdateCOn;
        private System.Windows.Forms.TabControl tbCondition;
    }
}