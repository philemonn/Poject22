namespace NWU_Secondhand_Textbooks
{
    partial class MaintainTextbook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaintainTextbook));
            this.pnlTextbook = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbltextbook = new System.Windows.Forms.Label();
            this.tbClient = new System.Windows.Forms.TabControl();
            this.tbpInsert = new System.Windows.Forms.TabPage();
            this.cbModCode = new System.Windows.Forms.ComboBox();
            this.cbQuality = new System.Windows.Forms.ComboBox();
            this.cbAuthor = new System.Windows.Forms.ComboBox();
            this.lblSelectAuthor = new System.Windows.Forms.Label();
            this.lblModCode = new System.Windows.Forms.Label();
            this.lblBookQuality = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblBookPrice = new System.Windows.Forms.Label();
            this.lblBookedt = new System.Windows.Forms.Label();
            this.lblTextbookDetail = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.txtBookedt = new System.Windows.Forms.TextBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbpDelete = new System.Windows.Forms.TabPage();
            this.dgTestBooks = new System.Windows.Forms.DataGridView();
            this.txtInfo = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtAuthLName = new System.Windows.Forms.Label();
            this.txtAuth_Lname = new System.Windows.Forms.TextBox();
            this.txtAuthName = new System.Windows.Forms.Label();
            this.txtUpdateAuthorFName = new System.Windows.Forms.TextBox();
            this.txtModCode = new System.Windows.Forms.Label();
            this.txtQuality = new System.Windows.Forms.Label();
            this.txtUpdateModCod = new System.Windows.Forms.TextBox();
            this.txtUpdateQal = new System.Windows.Forms.TextBox();
            this.dbUpdate = new System.Windows.Forms.DataGridView();
            this.txtPrice = new System.Windows.Forms.Label();
            this.txtEdt = new System.Windows.Forms.Label();
            this.txtTextbookName = new System.Windows.Forms.Label();
            this.txtUpdatePrice = new System.Windows.Forms.TextBox();
            this.txtUpdateEd = new System.Windows.Forms.TextBox();
            this.txtUpdateName = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pnlTextbook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tbClient.SuspendLayout();
            this.tbpInsert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tbpDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTestBooks)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTextbook
            // 
            this.pnlTextbook.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pnlTextbook.Controls.Add(this.pictureBox2);
            this.pnlTextbook.Controls.Add(this.pictureBox1);
            this.pnlTextbook.Controls.Add(this.lbltextbook);
            this.pnlTextbook.Location = new System.Drawing.Point(0, 5);
            this.pnlTextbook.Name = "pnlTextbook";
            this.pnlTextbook.Size = new System.Drawing.Size(989, 111);
            this.pnlTextbook.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(765, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(177, 108);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
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
            this.lbltextbook.Size = new System.Drawing.Size(324, 43);
            this.lbltextbook.TabIndex = 4;
            this.lbltextbook.Text = "Maintain Textbooks:";
            // 
            // tbClient
            // 
            this.tbClient.Controls.Add(this.tbpInsert);
            this.tbClient.Controls.Add(this.tbpDelete);
            this.tbClient.Controls.Add(this.tabPage1);
            this.tbClient.Location = new System.Drawing.Point(-1, 138);
            this.tbClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbClient.Name = "tbClient";
            this.tbClient.SelectedIndex = 0;
            this.tbClient.Size = new System.Drawing.Size(941, 457);
            this.tbClient.TabIndex = 3;
            // 
            // tbpInsert
            // 
            this.tbpInsert.Controls.Add(this.cbModCode);
            this.tbpInsert.Controls.Add(this.cbQuality);
            this.tbpInsert.Controls.Add(this.cbAuthor);
            this.tbpInsert.Controls.Add(this.lblSelectAuthor);
            this.tbpInsert.Controls.Add(this.lblModCode);
            this.tbpInsert.Controls.Add(this.lblBookQuality);
            this.tbpInsert.Controls.Add(this.dataGridView1);
            this.tbpInsert.Controls.Add(this.lblBookPrice);
            this.tbpInsert.Controls.Add(this.lblBookedt);
            this.tbpInsert.Controls.Add(this.lblTextbookDetail);
            this.tbpInsert.Controls.Add(this.lblBookName);
            this.tbpInsert.Controls.Add(this.tbPrice);
            this.tbpInsert.Controls.Add(this.txtBookedt);
            this.tbpInsert.Controls.Add(this.txtBookName);
            this.tbpInsert.Controls.Add(this.button1);
            this.tbpInsert.Font = new System.Drawing.Font("Baskerville Old Face", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpInsert.Location = new System.Drawing.Point(4, 25);
            this.tbpInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpInsert.Name = "tbpInsert";
            this.tbpInsert.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpInsert.Size = new System.Drawing.Size(933, 428);
            this.tbpInsert.TabIndex = 0;
            this.tbpInsert.Tag = "";
            this.tbpInsert.Text = "Insert New Textbook";
            this.tbpInsert.UseVisualStyleBackColor = true;
            // 
            // cbModCode
            // 
            this.cbModCode.FormattingEnabled = true;
            this.cbModCode.Location = new System.Drawing.Point(200, 239);
            this.cbModCode.Margin = new System.Windows.Forms.Padding(4);
            this.cbModCode.Name = "cbModCode";
            this.cbModCode.Size = new System.Drawing.Size(180, 27);
            this.cbModCode.TabIndex = 28;
            // 
            // cbQuality
            // 
            this.cbQuality.FormattingEnabled = true;
            this.cbQuality.Location = new System.Drawing.Point(200, 191);
            this.cbQuality.Margin = new System.Windows.Forms.Padding(4);
            this.cbQuality.Name = "cbQuality";
            this.cbQuality.Size = new System.Drawing.Size(180, 27);
            this.cbQuality.TabIndex = 27;
            // 
            // cbAuthor
            // 
            this.cbAuthor.FormattingEnabled = true;
            this.cbAuthor.Location = new System.Drawing.Point(200, 288);
            this.cbAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.cbAuthor.Name = "cbAuthor";
            this.cbAuthor.Size = new System.Drawing.Size(180, 27);
            this.cbAuthor.TabIndex = 26;
            // 
            // lblSelectAuthor
            // 
            this.lblSelectAuthor.AutoSize = true;
            this.lblSelectAuthor.Location = new System.Drawing.Point(32, 288);
            this.lblSelectAuthor.Name = "lblSelectAuthor";
            this.lblSelectAuthor.Size = new System.Drawing.Size(106, 19);
            this.lblSelectAuthor.TabIndex = 25;
            this.lblSelectAuthor.Text = "Select Author:";
            // 
            // lblModCode
            // 
            this.lblModCode.AutoSize = true;
            this.lblModCode.Location = new System.Drawing.Point(33, 249);
            this.lblModCode.Name = "lblModCode";
            this.lblModCode.Size = new System.Drawing.Size(108, 19);
            this.lblModCode.TabIndex = 12;
            this.lblModCode.Text = "Module Code:";
            // 
            // lblBookQuality
            // 
            this.lblBookQuality.AutoSize = true;
            this.lblBookQuality.Location = new System.Drawing.Point(3, 201);
            this.lblBookQuality.Name = "lblBookQuality";
            this.lblBookQuality.Size = new System.Drawing.Size(133, 19);
            this.lblBookQuality.TabIndex = 11;
            this.lblBookQuality.Text = "Textbook Quality:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(439, 41);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(455, 310);
            this.dataGridView1.TabIndex = 8;
            // 
            // lblBookPrice
            // 
            this.lblBookPrice.AutoSize = true;
            this.lblBookPrice.Location = new System.Drawing.Point(19, 143);
            this.lblBookPrice.Name = "lblBookPrice";
            this.lblBookPrice.Size = new System.Drawing.Size(119, 19);
            this.lblBookPrice.TabIndex = 7;
            this.lblBookPrice.Text = "Textbook Price:";
            // 
            // lblBookedt
            // 
            this.lblBookedt.AutoSize = true;
            this.lblBookedt.Location = new System.Drawing.Point(5, 95);
            this.lblBookedt.Name = "lblBookedt";
            this.lblBookedt.Size = new System.Drawing.Size(134, 19);
            this.lblBookedt.TabIndex = 6;
            this.lblBookedt.Text = "Textbook Edition:";
            // 
            // lblTextbookDetail
            // 
            this.lblTextbookDetail.AutoSize = true;
            this.lblTextbookDetail.Location = new System.Drawing.Point(5, 18);
            this.lblTextbookDetail.Name = "lblTextbookDetail";
            this.lblTextbookDetail.Size = new System.Drawing.Size(349, 19);
            this.lblTextbookDetail.TabIndex = 5;
            this.lblTextbookDetail.Text = "Please enter the following Details of the Textbook:";
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Location = new System.Drawing.Point(11, 49);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(126, 19);
            this.lblBookName.TabIndex = 4;
            this.lblBookName.Text = "Textbook Name:";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(200, 139);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(180, 27);
            this.tbPrice.TabIndex = 3;
            // 
            // txtBookedt
            // 
            this.txtBookedt.Location = new System.Drawing.Point(200, 86);
            this.txtBookedt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBookedt.Name = "txtBookedt";
            this.txtBookedt.Size = new System.Drawing.Size(180, 27);
            this.txtBookedt.TabIndex = 2;
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(200, 41);
            this.txtBookName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(180, 27);
            this.txtBookName.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(161, 373);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add book to the system";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tbpDelete
            // 
            this.tbpDelete.Controls.Add(this.dgTestBooks);
            this.tbpDelete.Controls.Add(this.txtInfo);
            this.tbpDelete.Controls.Add(this.btnDelete);
            this.tbpDelete.Font = new System.Drawing.Font("Baskerville Old Face", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpDelete.Location = new System.Drawing.Point(4, 25);
            this.tbpDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpDelete.Name = "tbpDelete";
            this.tbpDelete.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpDelete.Size = new System.Drawing.Size(933, 428);
            this.tbpDelete.TabIndex = 1;
            this.tbpDelete.Text = "Delete a Textbook";
            this.tbpDelete.UseVisualStyleBackColor = true;
            // 
            // dgTestBooks
            // 
            this.dgTestBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTestBooks.Location = new System.Drawing.Point(20, 67);
            this.dgTestBooks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgTestBooks.Name = "dgTestBooks";
            this.dgTestBooks.RowHeadersWidth = 51;
            this.dgTestBooks.RowTemplate.Height = 24;
            this.dgTestBooks.Size = new System.Drawing.Size(491, 310);
            this.dgTestBooks.TabIndex = 12;
            // 
            // txtInfo
            // 
            this.txtInfo.AutoSize = true;
            this.txtInfo.Location = new System.Drawing.Point(16, 37);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(345, 19);
            this.txtInfo.TabIndex = 10;
            this.txtInfo.Text = "Please Select the textbook  that should be deleted:";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(585, 203);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(257, 47);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Remove book from the system";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtAuthLName);
            this.tabPage1.Controls.Add(this.txtAuth_Lname);
            this.tabPage1.Controls.Add(this.txtAuthName);
            this.tabPage1.Controls.Add(this.txtUpdateAuthorFName);
            this.tabPage1.Controls.Add(this.txtModCode);
            this.tabPage1.Controls.Add(this.txtQuality);
            this.tabPage1.Controls.Add(this.txtUpdateModCod);
            this.tabPage1.Controls.Add(this.txtUpdateQal);
            this.tabPage1.Controls.Add(this.dbUpdate);
            this.tabPage1.Controls.Add(this.txtPrice);
            this.tabPage1.Controls.Add(this.txtEdt);
            this.tabPage1.Controls.Add(this.txtTextbookName);
            this.tabPage1.Controls.Add(this.txtUpdatePrice);
            this.tabPage1.Controls.Add(this.txtUpdateEd);
            this.tabPage1.Controls.Add(this.txtUpdateName);
            this.tabPage1.Controls.Add(this.btnUpdate);
            this.tabPage1.Font = new System.Drawing.Font("Baskerville Old Face", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(933, 428);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Update Textbook Information";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtAuthLName
            // 
            this.txtAuthLName.AutoSize = true;
            this.txtAuthLName.Location = new System.Drawing.Point(1, 308);
            this.txtAuthLName.Name = "txtAuthLName";
            this.txtAuthLName.Size = new System.Drawing.Size(156, 19);
            this.txtAuthLName.TabIndex = 23;
            this.txtAuthLName.Text = "Author Last Name:";
            // 
            // txtAuth_Lname
            // 
            this.txtAuth_Lname.Location = new System.Drawing.Point(213, 308);
            this.txtAuth_Lname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAuth_Lname.Name = "txtAuth_Lname";
            this.txtAuth_Lname.Size = new System.Drawing.Size(180, 27);
            this.txtAuth_Lname.TabIndex = 22;
            // 
            // txtAuthName
            // 
            this.txtAuthName.AutoSize = true;
            this.txtAuthName.Location = new System.Drawing.Point(-1, 265);
            this.txtAuthName.Name = "txtAuthName";
            this.txtAuthName.Size = new System.Drawing.Size(159, 19);
            this.txtAuthName.TabIndex = 21;
            this.txtAuthName.Text = "Author First Name:";
            // 
            // txtUpdateAuthorFName
            // 
            this.txtUpdateAuthorFName.Location = new System.Drawing.Point(213, 261);
            this.txtUpdateAuthorFName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUpdateAuthorFName.Name = "txtUpdateAuthorFName";
            this.txtUpdateAuthorFName.Size = new System.Drawing.Size(180, 27);
            this.txtUpdateAuthorFName.TabIndex = 20;
            // 
            // txtModCode
            // 
            this.txtModCode.AutoSize = true;
            this.txtModCode.Location = new System.Drawing.Point(43, 220);
            this.txtModCode.Name = "txtModCode";
            this.txtModCode.Size = new System.Drawing.Size(120, 19);
            this.txtModCode.TabIndex = 19;
            this.txtModCode.Text = "Module Code:";
            // 
            // txtQuality
            // 
            this.txtQuality.AutoSize = true;
            this.txtQuality.Location = new System.Drawing.Point(12, 171);
            this.txtQuality.Name = "txtQuality";
            this.txtQuality.Size = new System.Drawing.Size(150, 19);
            this.txtQuality.TabIndex = 18;
            this.txtQuality.Text = "Textbook Quality:";
            // 
            // txtUpdateModCod
            // 
            this.txtUpdateModCod.Location = new System.Drawing.Point(213, 212);
            this.txtUpdateModCod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUpdateModCod.Name = "txtUpdateModCod";
            this.txtUpdateModCod.Size = new System.Drawing.Size(180, 27);
            this.txtUpdateModCod.TabIndex = 17;
            // 
            // txtUpdateQal
            // 
            this.txtUpdateQal.Location = new System.Drawing.Point(213, 162);
            this.txtUpdateQal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUpdateQal.Name = "txtUpdateQal";
            this.txtUpdateQal.Size = new System.Drawing.Size(180, 27);
            this.txtUpdateQal.TabIndex = 16;
            // 
            // dbUpdate
            // 
            this.dbUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbUpdate.Location = new System.Drawing.Point(441, 39);
            this.dbUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dbUpdate.Name = "dbUpdate";
            this.dbUpdate.RowHeadersWidth = 51;
            this.dbUpdate.RowTemplate.Height = 24;
            this.dbUpdate.Size = new System.Drawing.Size(455, 310);
            this.dbUpdate.TabIndex = 15;
            // 
            // txtPrice
            // 
            this.txtPrice.AutoSize = true;
            this.txtPrice.Location = new System.Drawing.Point(24, 114);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(134, 19);
            this.txtPrice.TabIndex = 14;
            this.txtPrice.Text = "Textbook Price:";
            // 
            // txtEdt
            // 
            this.txtEdt.AutoSize = true;
            this.txtEdt.Location = new System.Drawing.Point(12, 71);
            this.txtEdt.Name = "txtEdt";
            this.txtEdt.Size = new System.Drawing.Size(151, 19);
            this.txtEdt.TabIndex = 13;
            this.txtEdt.Text = "Textbook Edition:";
            // 
            // txtTextbookName
            // 
            this.txtTextbookName.AutoSize = true;
            this.txtTextbookName.Location = new System.Drawing.Point(24, 20);
            this.txtTextbookName.Name = "txtTextbookName";
            this.txtTextbookName.Size = new System.Drawing.Size(140, 19);
            this.txtTextbookName.TabIndex = 12;
            this.txtTextbookName.Text = "Textbook Name:";
            // 
            // txtUpdatePrice
            // 
            this.txtUpdatePrice.Location = new System.Drawing.Point(213, 111);
            this.txtUpdatePrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUpdatePrice.Name = "txtUpdatePrice";
            this.txtUpdatePrice.Size = new System.Drawing.Size(180, 27);
            this.txtUpdatePrice.TabIndex = 11;
            // 
            // txtUpdateEd
            // 
            this.txtUpdateEd.Location = new System.Drawing.Point(213, 68);
            this.txtUpdateEd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUpdateEd.Name = "txtUpdateEd";
            this.txtUpdateEd.Size = new System.Drawing.Size(180, 27);
            this.txtUpdateEd.TabIndex = 10;
            // 
            // txtUpdateName
            // 
            this.txtUpdateName.Location = new System.Drawing.Point(213, 20);
            this.txtUpdateName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUpdateName.Name = "txtUpdateName";
            this.txtUpdateName.Size = new System.Drawing.Size(180, 27);
            this.txtUpdateName.TabIndex = 9;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(60, 359);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(317, 47);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update book to the system";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // MaintainTextbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 601);
            this.Controls.Add(this.tbClient);
            this.Controls.Add(this.pnlTextbook);
            this.Name = "MaintainTextbook";
            this.Text = "MaintainTextbook";
            this.Load += new System.EventHandler(this.MaintainTextbook_Load);
            this.pnlTextbook.ResumeLayout(false);
            this.pnlTextbook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tbClient.ResumeLayout(false);
            this.tbpInsert.ResumeLayout(false);
            this.tbpInsert.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tbpDelete.ResumeLayout(false);
            this.tbpDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTestBooks)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbUpdate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlTextbook;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbltextbook;
        private System.Windows.Forms.TabControl tbClient;
        private System.Windows.Forms.TabPage tbpInsert;
        private System.Windows.Forms.ComboBox cbModCode;
        private System.Windows.Forms.ComboBox cbQuality;
        private System.Windows.Forms.ComboBox cbAuthor;
        private System.Windows.Forms.Label lblSelectAuthor;
        private System.Windows.Forms.Label lblModCode;
        private System.Windows.Forms.Label lblBookQuality;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblBookPrice;
        private System.Windows.Forms.Label lblBookedt;
        private System.Windows.Forms.Label lblTextbookDetail;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox txtBookedt;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tbpDelete;
        private System.Windows.Forms.DataGridView dgTestBooks;
        private System.Windows.Forms.Label txtInfo;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label txtAuthLName;
        private System.Windows.Forms.TextBox txtAuth_Lname;
        private System.Windows.Forms.Label txtAuthName;
        private System.Windows.Forms.TextBox txtUpdateAuthorFName;
        private System.Windows.Forms.Label txtModCode;
        private System.Windows.Forms.Label txtQuality;
        private System.Windows.Forms.TextBox txtUpdateModCod;
        private System.Windows.Forms.TextBox txtUpdateQal;
        private System.Windows.Forms.DataGridView dbUpdate;
        private System.Windows.Forms.Label txtPrice;
        private System.Windows.Forms.Label txtEdt;
        private System.Windows.Forms.Label txtTextbookName;
        private System.Windows.Forms.TextBox txtUpdatePrice;
        private System.Windows.Forms.TextBox txtUpdateEd;
        private System.Windows.Forms.TextBox txtUpdateName;
        private System.Windows.Forms.Button btnUpdate;
    }
}