namespace NWU_Secondhand_Textbooks
{
    partial class MaintainAuthor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaintainAuthor));
            this.tbAuthor = new System.Windows.Forms.TabControl();
            this.tbpInsert = new System.Windows.Forms.TabPage();
            this.dgInsertAuthor = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbpDelete = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDeleteSName = new System.Windows.Forms.TextBox();
            this.txtDeleteFName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lstDelete = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tbpUpdateAuthorInformation = new System.Windows.Forms.TabPage();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtChangeSurname = new System.Windows.Forms.TextBox();
            this.txtChangeFName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtUpdateSName = new System.Windows.Forms.TextBox();
            this.txtUpdateFName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lstUpdate = new System.Windows.Forms.ListBox();
            this.pnlTextbook = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbltextbook = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tbAuthor.SuspendLayout();
            this.tbpInsert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInsertAuthor)).BeginInit();
            this.tbpDelete.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tbpUpdateAuthorInformation.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.pnlTextbook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbAuthor
            // 
            this.tbAuthor.Controls.Add(this.tbpInsert);
            this.tbAuthor.Controls.Add(this.tbpDelete);
            this.tbAuthor.Controls.Add(this.tbpUpdateAuthorInformation);
            this.tbAuthor.Location = new System.Drawing.Point(2, 97);
            this.tbAuthor.Margin = new System.Windows.Forms.Padding(2);
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.SelectedIndex = 0;
            this.tbAuthor.Size = new System.Drawing.Size(810, 416);
            this.tbAuthor.TabIndex = 1;
            // 
            // tbpInsert
            // 
            this.tbpInsert.Controls.Add(this.dgInsertAuthor);
            this.tbpInsert.Controls.Add(this.label3);
            this.tbpInsert.Controls.Add(this.label2);
            this.tbpInsert.Controls.Add(this.label1);
            this.tbpInsert.Controls.Add(this.txtSurname);
            this.tbpInsert.Controls.Add(this.txtName);
            this.tbpInsert.Controls.Add(this.button1);
            this.tbpInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpInsert.Location = new System.Drawing.Point(4, 22);
            this.tbpInsert.Margin = new System.Windows.Forms.Padding(2);
            this.tbpInsert.Name = "tbpInsert";
            this.tbpInsert.Padding = new System.Windows.Forms.Padding(2);
            this.tbpInsert.Size = new System.Drawing.Size(802, 390);
            this.tbpInsert.TabIndex = 0;
            this.tbpInsert.Tag = "";
            this.tbpInsert.Text = "Insert New Author";
            this.tbpInsert.UseVisualStyleBackColor = true;
            // 
            // dgInsertAuthor
            // 
            this.dgInsertAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInsertAuthor.Location = new System.Drawing.Point(342, 11);
            this.dgInsertAuthor.Margin = new System.Windows.Forms.Padding(2);
            this.dgInsertAuthor.Name = "dgInsertAuthor";
            this.dgInsertAuthor.RowHeadersWidth = 51;
            this.dgInsertAuthor.RowTemplate.Height = 24;
            this.dgInsertAuthor.Size = new System.Drawing.Size(442, 363);
            this.dgInsertAuthor.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Author Surname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Please enter the following Details of the Author:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Author Name:";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(144, 119);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(2);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(136, 23);
            this.txtSurname.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(144, 60);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(136, 23);
            this.txtName.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(144, 205);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 56);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Author to the system";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbpDelete
            // 
            this.tbpDelete.Controls.Add(this.label5);
            this.tbpDelete.Controls.Add(this.groupBox1);
            this.tbpDelete.Controls.Add(this.lstDelete);
            this.tbpDelete.Controls.Add(this.button2);
            this.tbpDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpDelete.Location = new System.Drawing.Point(4, 22);
            this.tbpDelete.Margin = new System.Windows.Forms.Padding(2);
            this.tbpDelete.Name = "tbpDelete";
            this.tbpDelete.Padding = new System.Windows.Forms.Padding(2);
            this.tbpDelete.Size = new System.Drawing.Size(802, 390);
            this.tbpDelete.TabIndex = 1;
            this.tbpDelete.Text = "Delete Author";
            this.tbpDelete.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(320, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Please Select Author To Delete:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDeleteSName);
            this.groupBox1.Controls.Add(this.txtDeleteFName);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Location = new System.Drawing.Point(6, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 116);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Use These Fields To Search For An Author";
            // 
            // txtDeleteSName
            // 
            this.txtDeleteSName.Location = new System.Drawing.Point(139, 71);
            this.txtDeleteSName.Name = "txtDeleteSName";
            this.txtDeleteSName.Size = new System.Drawing.Size(114, 23);
            this.txtDeleteSName.TabIndex = 4;
            this.txtDeleteSName.TextChanged += new System.EventHandler(this.txtDeleteSName_TextChanged);
            // 
            // txtDeleteFName
            // 
            this.txtDeleteFName.Location = new System.Drawing.Point(139, 36);
            this.txtDeleteFName.Name = "txtDeleteFName";
            this.txtDeleteFName.Size = new System.Drawing.Size(114, 23);
            this.txtDeleteFName.TabIndex = 3;
            this.txtDeleteFName.TextChanged += new System.EventHandler(this.txtDeleteFName_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "Second Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "First Name";
            // 
            // lstDelete
            // 
            this.lstDelete.FormattingEnabled = true;
            this.lstDelete.ItemHeight = 17;
            this.lstDelete.Location = new System.Drawing.Point(323, 31);
            this.lstDelete.MultiColumn = true;
            this.lstDelete.Name = "lstDelete";
            this.lstDelete.Size = new System.Drawing.Size(467, 327);
            this.lstDelete.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(145, 312);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 46);
            this.button2.TabIndex = 13;
            this.button2.Text = "Delete Author";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // tbpUpdateAuthorInformation
            // 
            this.tbpUpdateAuthorInformation.Controls.Add(this.btnUpdate);
            this.tbpUpdateAuthorInformation.Controls.Add(this.groupBox2);
            this.tbpUpdateAuthorInformation.Controls.Add(this.label7);
            this.tbpUpdateAuthorInformation.Controls.Add(this.groupBox3);
            this.tbpUpdateAuthorInformation.Controls.Add(this.lstUpdate);
            this.tbpUpdateAuthorInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpUpdateAuthorInformation.Location = new System.Drawing.Point(4, 22);
            this.tbpUpdateAuthorInformation.Margin = new System.Windows.Forms.Padding(2);
            this.tbpUpdateAuthorInformation.Name = "tbpUpdateAuthorInformation";
            this.tbpUpdateAuthorInformation.Size = new System.Drawing.Size(802, 390);
            this.tbpUpdateAuthorInformation.TabIndex = 2;
            this.tbpUpdateAuthorInformation.Text = "Update Author Information";
            this.tbpUpdateAuthorInformation.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(18, 359);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtChangeSurname);
            this.groupBox2.Controls.Add(this.txtChangeFName);
            this.groupBox2.Location = new System.Drawing.Point(9, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(299, 167);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select what you want to update:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Second Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "First Name";
            // 
            // txtChangeSurname
            // 
            this.txtChangeSurname.Location = new System.Drawing.Point(131, 69);
            this.txtChangeSurname.Name = "txtChangeSurname";
            this.txtChangeSurname.Size = new System.Drawing.Size(120, 22);
            this.txtChangeSurname.TabIndex = 4;
            // 
            // txtChangeFName
            // 
            this.txtChangeFName.Location = new System.Drawing.Point(131, 21);
            this.txtChangeFName.Name = "txtChangeFName";
            this.txtChangeFName.Size = new System.Drawing.Size(120, 22);
            this.txtChangeFName.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(324, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(203, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Please Select Author To Update:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtUpdateSName);
            this.groupBox3.Controls.Add(this.txtUpdateFName);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(9, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(308, 122);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Use These Fields To Search For An Author";
            // 
            // txtUpdateSName
            // 
            this.txtUpdateSName.Location = new System.Drawing.Point(131, 71);
            this.txtUpdateSName.Name = "txtUpdateSName";
            this.txtUpdateSName.Size = new System.Drawing.Size(120, 22);
            this.txtUpdateSName.TabIndex = 4;
            this.txtUpdateSName.TextChanged += new System.EventHandler(this.txtUpdateSName_TextChanged);
            // 
            // txtUpdateFName
            // 
            this.txtUpdateFName.Location = new System.Drawing.Point(131, 31);
            this.txtUpdateFName.Name = "txtUpdateFName";
            this.txtUpdateFName.Size = new System.Drawing.Size(120, 22);
            this.txtUpdateFName.TabIndex = 3;
            this.txtUpdateFName.TextChanged += new System.EventHandler(this.txtUpdateFName_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "Second Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "First Name";
            // 
            // lstUpdate
            // 
            this.lstUpdate.FormattingEnabled = true;
            this.lstUpdate.ItemHeight = 16;
            this.lstUpdate.Location = new System.Drawing.Point(327, 29);
            this.lstUpdate.MultiColumn = true;
            this.lstUpdate.Name = "lstUpdate";
            this.lstUpdate.Size = new System.Drawing.Size(467, 324);
            this.lstUpdate.TabIndex = 18;
            // 
            // pnlTextbook
            // 
            this.pnlTextbook.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pnlTextbook.Controls.Add(this.pictureBox2);
            this.pnlTextbook.Controls.Add(this.pictureBox1);
            this.pnlTextbook.Controls.Add(this.lbltextbook);
            this.pnlTextbook.Location = new System.Drawing.Point(2, 2);
            this.pnlTextbook.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTextbook.Name = "pnlTextbook";
            this.pnlTextbook.Size = new System.Drawing.Size(742, 90);
            this.pnlTextbook.TabIndex = 3;
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
            // lbltextbook
            // 
            this.lbltextbook.AutoSize = true;
            this.lbltextbook.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltextbook.Location = new System.Drawing.Point(245, 22);
            this.lbltextbook.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltextbook.Name = "lbltextbook";
            this.lbltextbook.Size = new System.Drawing.Size(234, 36);
            this.lbltextbook.TabIndex = 4;
            this.lbltextbook.Text = "Maintain Author:";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(737, 529);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 529);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // MaintainAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 564);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnlTextbook);
            this.Controls.Add(this.tbAuthor);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MaintainAuthor";
            this.Text = "MaintainAuthor";
            this.Load += new System.EventHandler(this.MaintainAuthor_Load);
            this.tbAuthor.ResumeLayout(false);
            this.tbpInsert.ResumeLayout(false);
            this.tbpInsert.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInsertAuthor)).EndInit();
            this.tbpDelete.ResumeLayout(false);
            this.tbpDelete.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbpUpdateAuthorInformation.ResumeLayout(false);
            this.tbpUpdateAuthorInformation.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.pnlTextbook.ResumeLayout(false);
            this.pnlTextbook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbAuthor;
        private System.Windows.Forms.TabPage tbpInsert;
        private System.Windows.Forms.DataGridView dgInsertAuthor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tbpDelete;
        private System.Windows.Forms.TabPage tbpUpdateAuthorInformation;
        private System.Windows.Forms.Panel pnlTextbook;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbltextbook;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDeleteSName;
        private System.Windows.Forms.TextBox txtDeleteFName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox lstDelete;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtChangeSurname;
        private System.Windows.Forms.TextBox txtChangeFName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtUpdateSName;
        private System.Windows.Forms.TextBox txtUpdateFName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox lstUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}