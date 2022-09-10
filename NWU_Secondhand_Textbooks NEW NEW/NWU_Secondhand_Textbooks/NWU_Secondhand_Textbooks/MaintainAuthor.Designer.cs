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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTextbook = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbpDelete = new System.Windows.Forms.TabPage();
            this.cbID = new System.Windows.Forms.ComboBox();
            this.dgDeleteAuthor = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRemoveAuth = new System.Windows.Forms.Button();
            this.tbpUpdateAuthorInformation = new System.Windows.Forms.TabPage();
            this.pnlTextbook = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbltextbook = new System.Windows.Forms.Label();
            this.tbAuthor.SuspendLayout();
            this.tbpInsert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInsertAuthor)).BeginInit();
            this.tbpDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDeleteAuthor)).BeginInit();
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
            this.tbAuthor.Location = new System.Drawing.Point(2, 119);
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.SelectedIndex = 0;
            this.tbAuthor.Size = new System.Drawing.Size(922, 418);
            this.tbAuthor.TabIndex = 1;
            // 
            // tbpInsert
            // 
            this.tbpInsert.Controls.Add(this.dgInsertAuthor);
            this.tbpInsert.Controls.Add(this.label4);
            this.tbpInsert.Controls.Add(this.label3);
            this.tbpInsert.Controls.Add(this.label2);
            this.tbpInsert.Controls.Add(this.label1);
            this.tbpInsert.Controls.Add(this.txtTextbook);
            this.tbpInsert.Controls.Add(this.txtSurname);
            this.tbpInsert.Controls.Add(this.txtName);
            this.tbpInsert.Controls.Add(this.button1);
            this.tbpInsert.Font = new System.Drawing.Font("Baskerville Old Face", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpInsert.Location = new System.Drawing.Point(4, 25);
            this.tbpInsert.Name = "tbpInsert";
            this.tbpInsert.Padding = new System.Windows.Forms.Padding(3);
            this.tbpInsert.Size = new System.Drawing.Size(914, 389);
            this.tbpInsert.TabIndex = 0;
            this.tbpInsert.Tag = "";
            this.tbpInsert.Text = "Insert New Author";
            this.tbpInsert.UseVisualStyleBackColor = true;
            // 
            // dgInsertAuthor
            // 
            this.dgInsertAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInsertAuthor.Location = new System.Drawing.Point(433, 19);
            this.dgInsertAuthor.Name = "dgInsertAuthor";
            this.dgInsertAuthor.RowHeadersWidth = 51;
            this.dgInsertAuthor.RowTemplate.Height = 24;
            this.dgInsertAuthor.Size = new System.Drawing.Size(455, 310);
            this.dgInsertAuthor.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Textbook:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Author Surname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(331, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Please enter the following Details of the Author:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Author Name:";
            // 
            // txtTextbook
            // 
            this.txtTextbook.Location = new System.Drawing.Point(148, 211);
            this.txtTextbook.Name = "txtTextbook";
            this.txtTextbook.Size = new System.Drawing.Size(180, 27);
            this.txtTextbook.TabIndex = 3;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(148, 142);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(180, 27);
            this.txtSurname.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(148, 69);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(180, 27);
            this.txtName.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(171, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add user to the system";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbpDelete
            // 
            this.tbpDelete.Controls.Add(this.cbID);
            this.tbpDelete.Controls.Add(this.dgDeleteAuthor);
            this.tbpDelete.Controls.Add(this.label5);
            this.tbpDelete.Controls.Add(this.label6);
            this.tbpDelete.Controls.Add(this.btnRemoveAuth);
            this.tbpDelete.Font = new System.Drawing.Font("Baskerville Old Face", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpDelete.Location = new System.Drawing.Point(4, 25);
            this.tbpDelete.Name = "tbpDelete";
            this.tbpDelete.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDelete.Size = new System.Drawing.Size(914, 389);
            this.tbpDelete.TabIndex = 1;
            this.tbpDelete.Text = "Delete Author";
            this.tbpDelete.UseVisualStyleBackColor = true;
            // 
            // cbID
            // 
            this.cbID.FormattingEnabled = true;
            this.cbID.Location = new System.Drawing.Point(179, 128);
            this.cbID.Name = "cbID";
            this.cbID.Size = new System.Drawing.Size(187, 27);
            this.cbID.TabIndex = 13;
            // 
            // dgDeleteAuthor
            // 
            this.dgDeleteAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDeleteAuthor.Location = new System.Drawing.Point(443, 42);
            this.dgDeleteAuthor.Name = "dgDeleteAuthor";
            this.dgDeleteAuthor.RowHeadersWidth = 51;
            this.dgDeleteAuthor.RowTemplate.Height = 24;
            this.dgDeleteAuthor.Size = new System.Drawing.Size(455, 310);
            this.dgDeleteAuthor.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Author ID:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(331, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Please enter the following Details of the Author:";
            // 
            // btnRemoveAuth
            // 
            this.btnRemoveAuth.Location = new System.Drawing.Point(154, 226);
            this.btnRemoveAuth.Name = "btnRemoveAuth";
            this.btnRemoveAuth.Size = new System.Drawing.Size(134, 47);
            this.btnRemoveAuth.TabIndex = 9;
            this.btnRemoveAuth.Text = "Remove user from the system";
            this.btnRemoveAuth.UseVisualStyleBackColor = true;
            this.btnRemoveAuth.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbpUpdateAuthorInformation
            // 
            this.tbpUpdateAuthorInformation.Font = new System.Drawing.Font("Baskerville Old Face", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpUpdateAuthorInformation.Location = new System.Drawing.Point(4, 25);
            this.tbpUpdateAuthorInformation.Name = "tbpUpdateAuthorInformation";
            this.tbpUpdateAuthorInformation.Size = new System.Drawing.Size(914, 389);
            this.tbpUpdateAuthorInformation.TabIndex = 2;
            this.tbpUpdateAuthorInformation.Text = "Update Author Information";
            this.tbpUpdateAuthorInformation.UseVisualStyleBackColor = true;
            // 
            // pnlTextbook
            // 
            this.pnlTextbook.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pnlTextbook.Controls.Add(this.pictureBox2);
            this.pnlTextbook.Controls.Add(this.pictureBox1);
            this.pnlTextbook.Controls.Add(this.lbltextbook);
            this.pnlTextbook.Location = new System.Drawing.Point(2, 2);
            this.pnlTextbook.Name = "pnlTextbook";
            this.pnlTextbook.Size = new System.Drawing.Size(989, 111);
            this.pnlTextbook.TabIndex = 3;
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
            // lbltextbook
            // 
            this.lbltextbook.AutoSize = true;
            this.lbltextbook.Font = new System.Drawing.Font("Baskerville Old Face", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltextbook.Location = new System.Drawing.Point(327, 27);
            this.lbltextbook.Name = "lbltextbook";
            this.lbltextbook.Size = new System.Drawing.Size(274, 43);
            this.lbltextbook.TabIndex = 4;
            this.lbltextbook.Text = "Maintain Author:";
            // 
            // MaintainAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 543);
            this.Controls.Add(this.pnlTextbook);
            this.Controls.Add(this.tbAuthor);
            this.Name = "MaintainAuthor";
            this.Text = "MaintainAuthor";
            this.Load += new System.EventHandler(this.MaintainAuthor_Load);
            this.tbAuthor.ResumeLayout(false);
            this.tbpInsert.ResumeLayout(false);
            this.tbpInsert.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInsertAuthor)).EndInit();
            this.tbpDelete.ResumeLayout(false);
            this.tbpDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDeleteAuthor)).EndInit();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTextbook;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tbpDelete;
        private System.Windows.Forms.ComboBox cbID;
        private System.Windows.Forms.DataGridView dgDeleteAuthor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRemoveAuth;
        private System.Windows.Forms.TabPage tbpUpdateAuthorInformation;
        private System.Windows.Forms.Panel pnlTextbook;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbltextbook;
    }
}