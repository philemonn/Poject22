namespace NWU_Secondhand_Textbooks
{
    partial class MaintainClients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaintainClients));
            this.tbClient = new System.Windows.Forms.TabControl();
            this.tbpInsert = new System.Windows.Forms.TabPage();
            this.dgInsertClients = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStudentNumber = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbpDelete = new System.Windows.Forms.TabPage();
            this.cbNumber = new System.Windows.Forms.ComboBox();
            this.dgDeleteClients = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRemoveClient = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pnlTextbook = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbltextbook = new System.Windows.Forms.Label();
            this.tbClient.SuspendLayout();
            this.tbpInsert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInsertClients)).BeginInit();
            this.tbpDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDeleteClients)).BeginInit();
            this.pnlTextbook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbClient
            // 
            this.tbClient.Controls.Add(this.tbpInsert);
            this.tbClient.Controls.Add(this.tbpDelete);
            this.tbClient.Controls.Add(this.tabPage1);
            this.tbClient.Location = new System.Drawing.Point(6, 145);
            this.tbClient.Name = "tbClient";
            this.tbClient.SelectedIndex = 0;
            this.tbClient.Size = new System.Drawing.Size(922, 418);
            this.tbClient.TabIndex = 0;
            // 
            // tbpInsert
            // 
            this.tbpInsert.Controls.Add(this.dgInsertClients);
            this.tbpInsert.Controls.Add(this.label4);
            this.tbpInsert.Controls.Add(this.label3);
            this.tbpInsert.Controls.Add(this.label2);
            this.tbpInsert.Controls.Add(this.label1);
            this.tbpInsert.Controls.Add(this.txtStudentNumber);
            this.tbpInsert.Controls.Add(this.txtSurname);
            this.tbpInsert.Controls.Add(this.txtName);
            this.tbpInsert.Controls.Add(this.btnAdd);
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
            // dgInsertClients
            // 
            this.dgInsertClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInsertClients.Location = new System.Drawing.Point(433, 19);
            this.dgInsertClients.Name = "dgInsertClients";
            this.dgInsertClients.RowHeadersWidth = 51;
            this.dgInsertClients.RowTemplate.Height = 24;
            this.dgInsertClients.Size = new System.Drawing.Size(455, 310);
            this.dgInsertClients.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Student Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Client Surname:";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Client Name:";
            // 
            // txtStudentNumber
            // 
            this.txtStudentNumber.Location = new System.Drawing.Point(148, 211);
            this.txtStudentNumber.Name = "txtStudentNumber";
            this.txtStudentNumber.Size = new System.Drawing.Size(180, 27);
            this.txtStudentNumber.TabIndex = 3;
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
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(171, 282);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(134, 47);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add book to the system";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbpDelete
            // 
            this.tbpDelete.Controls.Add(this.cbNumber);
            this.tbpDelete.Controls.Add(this.dgDeleteClients);
            this.tbpDelete.Controls.Add(this.label5);
            this.tbpDelete.Controls.Add(this.label6);
            this.tbpDelete.Controls.Add(this.btnRemoveClient);
            this.tbpDelete.Font = new System.Drawing.Font("Baskerville Old Face", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpDelete.Location = new System.Drawing.Point(4, 25);
            this.tbpDelete.Name = "tbpDelete";
            this.tbpDelete.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDelete.Size = new System.Drawing.Size(914, 389);
            this.tbpDelete.TabIndex = 1;
            this.tbpDelete.Text = "Delete a Client";
            this.tbpDelete.UseVisualStyleBackColor = true;
            // 
            // cbNumber
            // 
            this.cbNumber.FormattingEnabled = true;
            this.cbNumber.Location = new System.Drawing.Point(179, 128);
            this.cbNumber.Name = "cbNumber";
            this.cbNumber.Size = new System.Drawing.Size(187, 27);
            this.cbNumber.TabIndex = 13;
            // 
            // dgDeleteClients
            // 
            this.dgDeleteClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDeleteClients.Location = new System.Drawing.Point(443, 42);
            this.dgDeleteClients.Name = "dgDeleteClients";
            this.dgDeleteClients.RowHeadersWidth = 51;
            this.dgDeleteClients.RowTemplate.Height = 24;
            this.dgDeleteClients.Size = new System.Drawing.Size(455, 310);
            this.dgDeleteClients.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Student Number:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(322, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Please enter the following Details of the Client:";
            // 
            // btnRemoveClient
            // 
            this.btnRemoveClient.Location = new System.Drawing.Point(154, 226);
            this.btnRemoveClient.Name = "btnRemoveClient";
            this.btnRemoveClient.Size = new System.Drawing.Size(134, 47);
            this.btnRemoveClient.TabIndex = 9;
            this.btnRemoveClient.Text = "Remove Client from the system";
            this.btnRemoveClient.UseVisualStyleBackColor = true;
            this.btnRemoveClient.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Font = new System.Drawing.Font("Baskerville Old Face", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(914, 389);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Update Client Information";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pnlTextbook
            // 
            this.pnlTextbook.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pnlTextbook.Controls.Add(this.pictureBox2);
            this.pnlTextbook.Controls.Add(this.pictureBox1);
            this.pnlTextbook.Controls.Add(this.lbltextbook);
            this.pnlTextbook.Location = new System.Drawing.Point(6, 1);
            this.pnlTextbook.Name = "pnlTextbook";
            this.pnlTextbook.Size = new System.Drawing.Size(989, 111);
            this.pnlTextbook.TabIndex = 4;
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
            this.lbltextbook.Location = new System.Drawing.Point(341, 32);
            this.lbltextbook.Name = "lbltextbook";
            this.lbltextbook.Size = new System.Drawing.Size(270, 43);
            this.lbltextbook.TabIndex = 4;
            this.lbltextbook.Text = "Maintain Clients:";
            // 
            // MaintainClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 632);
            this.Controls.Add(this.pnlTextbook);
            this.Controls.Add(this.tbClient);
            this.Name = "MaintainClients";
            this.Text = "MaintainClients";
            this.Load += new System.EventHandler(this.MaintainClients_Load);
            this.tbClient.ResumeLayout(false);
            this.tbpInsert.ResumeLayout(false);
            this.tbpInsert.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInsertClients)).EndInit();
            this.tbpDelete.ResumeLayout(false);
            this.tbpDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDeleteClients)).EndInit();
            this.pnlTextbook.ResumeLayout(false);
            this.pnlTextbook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbClient;
        private System.Windows.Forms.TabPage tbpInsert;
        private System.Windows.Forms.DataGridView dgInsertClients;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TabPage tbpDelete;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cbNumber;
        private System.Windows.Forms.DataGridView dgDeleteClients;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRemoveClient;
        private System.Windows.Forms.TextBox txtStudentNumber;
        private System.Windows.Forms.Panel pnlTextbook;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbltextbook;
    }
}