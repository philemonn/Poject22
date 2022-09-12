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
            this.components = new System.ComponentModel.Container();
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
            this.label10 = new System.Windows.Forms.Label();
            this.grpDelete = new System.Windows.Forms.GroupBox();
            this.txtDeleteStudent = new System.Windows.Forms.TextBox();
            this.txtDeletSName = new System.Windows.Forms.TextBox();
            this.txtDeleteFName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lstDelete = new System.Windows.Forms.ListBox();
            this.btnRemoveClient = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtChangeStudent = new System.Windows.Forms.TextBox();
            this.txtChangeSurname = new System.Windows.Forms.TextBox();
            this.txtChangeFName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtUpdateStudent = new System.Windows.Forms.TextBox();
            this.txtUpdateSName = new System.Windows.Forms.TextBox();
            this.txtUpdateFName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lstUpdate = new System.Windows.Forms.ListBox();
            this.pnlTextbook = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbltextbook = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tbClient.SuspendLayout();
            this.tbpInsert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInsertClients)).BeginInit();
            this.tbpDelete.SuspendLayout();
            this.grpDelete.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.tbClient.Location = new System.Drawing.Point(4, 112);
            this.tbClient.Margin = new System.Windows.Forms.Padding(2);
            this.tbClient.Name = "tbClient";
            this.tbClient.SelectedIndex = 0;
            this.tbClient.Size = new System.Drawing.Size(801, 414);
            this.tbClient.TabIndex = 0;
            this.toolTip1.SetToolTip(this.tbClient, "Choose How You Want To Maintain Clients");
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
            this.tbpInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpInsert.Location = new System.Drawing.Point(4, 22);
            this.tbpInsert.Margin = new System.Windows.Forms.Padding(2);
            this.tbpInsert.Name = "tbpInsert";
            this.tbpInsert.Padding = new System.Windows.Forms.Padding(2);
            this.tbpInsert.Size = new System.Drawing.Size(793, 388);
            this.tbpInsert.TabIndex = 0;
            this.tbpInsert.Tag = "";
            this.tbpInsert.Text = "Insert New Client";
            this.tbpInsert.UseVisualStyleBackColor = true;
            // 
            // dgInsertClients
            // 
            this.dgInsertClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInsertClients.Location = new System.Drawing.Point(325, 15);
            this.dgInsertClients.Margin = new System.Windows.Forms.Padding(2);
            this.dgInsertClients.Name = "dgInsertClients";
            this.dgInsertClients.RowHeadersWidth = 51;
            this.dgInsertClients.RowTemplate.Height = 24;
            this.dgInsertClients.Size = new System.Drawing.Size(455, 359);
            this.dgInsertClients.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 178);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Student Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Client Surname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Please enter the following Details of the Client:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Client Name:";
            // 
            // txtStudentNumber
            // 
            this.txtStudentNumber.Location = new System.Drawing.Point(123, 172);
            this.txtStudentNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtStudentNumber.Name = "txtStudentNumber";
            this.txtStudentNumber.Size = new System.Drawing.Size(136, 23);
            this.txtStudentNumber.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtStudentNumber, "Enter Client Student Number");
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(123, 116);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(2);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(136, 23);
            this.txtSurname.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtSurname, "Enter Client Surname");
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(123, 57);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(136, 23);
            this.txtName.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtName, "Enter Clients First Name");
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(123, 322);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 52);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Insert";
            this.toolTip1.SetToolTip(this.btnAdd, "Add The Client To The System");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbpDelete
            // 
            this.tbpDelete.Controls.Add(this.label10);
            this.tbpDelete.Controls.Add(this.grpDelete);
            this.tbpDelete.Controls.Add(this.lstDelete);
            this.tbpDelete.Controls.Add(this.btnRemoveClient);
            this.tbpDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpDelete.Location = new System.Drawing.Point(4, 22);
            this.tbpDelete.Margin = new System.Windows.Forms.Padding(2);
            this.tbpDelete.Name = "tbpDelete";
            this.tbpDelete.Padding = new System.Windows.Forms.Padding(2);
            this.tbpDelete.Size = new System.Drawing.Size(793, 388);
            this.tbpDelete.TabIndex = 1;
            this.tbpDelete.Text = "Delete a Client";
            this.tbpDelete.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(318, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(203, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Please Select Client To Delete:";
            // 
            // grpDelete
            // 
            this.grpDelete.Controls.Add(this.txtDeleteStudent);
            this.grpDelete.Controls.Add(this.txtDeletSName);
            this.grpDelete.Controls.Add(this.txtDeleteFName);
            this.grpDelete.Controls.Add(this.label8);
            this.grpDelete.Controls.Add(this.label6);
            this.grpDelete.Controls.Add(this.label5);
            this.grpDelete.Location = new System.Drawing.Point(4, 5);
            this.grpDelete.Name = "grpDelete";
            this.grpDelete.Size = new System.Drawing.Size(308, 170);
            this.grpDelete.TabIndex = 12;
            this.grpDelete.TabStop = false;
            this.grpDelete.Text = "Use These Fields To Search For A Client";
            // 
            // txtDeleteStudent
            // 
            this.txtDeleteStudent.Location = new System.Drawing.Point(139, 111);
            this.txtDeleteStudent.Name = "txtDeleteStudent";
            this.txtDeleteStudent.Size = new System.Drawing.Size(114, 23);
            this.txtDeleteStudent.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtDeleteStudent, "Enter Client Student Number");
            this.txtDeleteStudent.TextChanged += new System.EventHandler(this.txtDeleteStudent_TextChanged);
            // 
            // txtDeletSName
            // 
            this.txtDeletSName.Location = new System.Drawing.Point(139, 71);
            this.txtDeletSName.Name = "txtDeletSName";
            this.txtDeletSName.Size = new System.Drawing.Size(114, 23);
            this.txtDeletSName.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txtDeletSName, "Enter Client Surname");
            this.txtDeletSName.TextChanged += new System.EventHandler(this.txtDeletSName_TextChanged);
            // 
            // txtDeleteFName
            // 
            this.txtDeleteFName.Location = new System.Drawing.Point(139, 36);
            this.txtDeleteFName.Name = "txtDeleteFName";
            this.txtDeleteFName.Size = new System.Drawing.Size(114, 23);
            this.txtDeleteFName.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtDeleteFName, "Enter Clients First Name");
            this.txtDeleteFName.TextChanged += new System.EventHandler(this.txtDeleteFName_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Student Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Second Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "First Name";
            // 
            // lstDelete
            // 
            this.lstDelete.FormattingEnabled = true;
            this.lstDelete.ItemHeight = 17;
            this.lstDelete.Location = new System.Drawing.Point(321, 22);
            this.lstDelete.MultiColumn = true;
            this.lstDelete.Name = "lstDelete";
            this.lstDelete.Size = new System.Drawing.Size(467, 327);
            this.lstDelete.TabIndex = 11;
            // 
            // btnRemoveClient
            // 
            this.btnRemoveClient.Location = new System.Drawing.Point(143, 303);
            this.btnRemoveClient.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveClient.Name = "btnRemoveClient";
            this.btnRemoveClient.Size = new System.Drawing.Size(124, 46);
            this.btnRemoveClient.TabIndex = 9;
            this.btnRemoveClient.Text = "Delete";
            this.toolTip1.SetToolTip(this.btnRemoveClient, "Removes A Client From The System");
            this.btnRemoveClient.UseVisualStyleBackColor = true;
            this.btnRemoveClient.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnUpdate);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.lstUpdate);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(793, 388);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Update Client Information";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(12, 352);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.toolTip1.SetToolTip(this.btnUpdate, "Update The Client In The System");
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtChangeStudent);
            this.groupBox2.Controls.Add(this.txtChangeSurname);
            this.groupBox2.Controls.Add(this.txtChangeFName);
            this.groupBox2.Location = new System.Drawing.Point(12, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(299, 167);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fill In what you want to update:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 118);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 16);
            this.label13.TabIndex = 8;
            this.label13.Text = "Student Number";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 72);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 16);
            this.label14.TabIndex = 7;
            this.label14.Text = "Surname";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 16);
            this.label15.TabIndex = 6;
            this.label15.Text = "First Name";
            // 
            // txtChangeStudent
            // 
            this.txtChangeStudent.Location = new System.Drawing.Point(122, 115);
            this.txtChangeStudent.Name = "txtChangeStudent";
            this.txtChangeStudent.Size = new System.Drawing.Size(120, 22);
            this.txtChangeStudent.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtChangeStudent, "Enter Client Student Number To Change To");
            // 
            // txtChangeSurname
            // 
            this.txtChangeSurname.Location = new System.Drawing.Point(122, 69);
            this.txtChangeSurname.Name = "txtChangeSurname";
            this.txtChangeSurname.Size = new System.Drawing.Size(120, 22);
            this.txtChangeSurname.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txtChangeSurname, "Enter Client Surname To Change To");
            // 
            // txtChangeFName
            // 
            this.txtChangeFName.Location = new System.Drawing.Point(122, 21);
            this.txtChangeFName.Name = "txtChangeFName";
            this.txtChangeFName.Size = new System.Drawing.Size(120, 22);
            this.txtChangeFName.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtChangeFName, "Enter Clients First Name To Change To");
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(318, 2);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(198, 16);
            this.label12.TabIndex = 15;
            this.label12.Text = "Please Select Client To Update:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtUpdateStudent);
            this.groupBox1.Controls.Add(this.txtUpdateSName);
            this.groupBox1.Controls.Add(this.txtUpdateFName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 170);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Use These Fields To Search For A Client";
            // 
            // txtUpdateStudent
            // 
            this.txtUpdateStudent.Location = new System.Drawing.Point(131, 107);
            this.txtUpdateStudent.Name = "txtUpdateStudent";
            this.txtUpdateStudent.Size = new System.Drawing.Size(120, 22);
            this.txtUpdateStudent.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtUpdateStudent, "Enter Client Student Number");
            this.txtUpdateStudent.TextChanged += new System.EventHandler(this.txtUpdateStudent_TextChanged);
            // 
            // txtUpdateSName
            // 
            this.txtUpdateSName.Location = new System.Drawing.Point(131, 71);
            this.txtUpdateSName.Name = "txtUpdateSName";
            this.txtUpdateSName.Size = new System.Drawing.Size(120, 22);
            this.txtUpdateSName.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txtUpdateSName, "Enter Client Surname");
            this.txtUpdateSName.TextChanged += new System.EventHandler(this.txtUpdateSName_TextChanged);
            // 
            // txtUpdateFName
            // 
            this.txtUpdateFName.Location = new System.Drawing.Point(131, 31);
            this.txtUpdateFName.Name = "txtUpdateFName";
            this.txtUpdateFName.Size = new System.Drawing.Size(120, 22);
            this.txtUpdateFName.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtUpdateFName, "Enter Clients First Name");
            this.txtUpdateFName.TextChanged += new System.EventHandler(this.txtUpdateFName_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Student Number";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "Surname";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "First Name";
            // 
            // lstUpdate
            // 
            this.lstUpdate.FormattingEnabled = true;
            this.lstUpdate.ItemHeight = 16;
            this.lstUpdate.Location = new System.Drawing.Point(321, 22);
            this.lstUpdate.MultiColumn = true;
            this.lstUpdate.Name = "lstUpdate";
            this.lstUpdate.Size = new System.Drawing.Size(467, 324);
            this.lstUpdate.TabIndex = 13;
            // 
            // pnlTextbook
            // 
            this.pnlTextbook.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pnlTextbook.Controls.Add(this.pictureBox2);
            this.pnlTextbook.Controls.Add(this.pictureBox1);
            this.pnlTextbook.Controls.Add(this.lbltextbook);
            this.pnlTextbook.Location = new System.Drawing.Point(4, 1);
            this.pnlTextbook.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTextbook.Name = "pnlTextbook";
            this.pnlTextbook.Size = new System.Drawing.Size(742, 90);
            this.pnlTextbook.TabIndex = 4;
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
            this.lbltextbook.Location = new System.Drawing.Point(256, 26);
            this.lbltextbook.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltextbook.Name = "lbltextbook";
            this.lbltextbook.Size = new System.Drawing.Size(235, 36);
            this.lbltextbook.TabIndex = 4;
            this.lbltextbook.Text = "Maintain Clients:";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(730, 541);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.toolTip1.SetToolTip(this.btnBack, "Go Back To Staff Menu");
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(8, 541);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.toolTip1.SetToolTip(this.btnClose, "Close Program");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // MaintainClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 576);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnlTextbook);
            this.Controls.Add(this.tbClient);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MaintainClients";
            this.Text = "MaintainClients";
            this.Load += new System.EventHandler(this.MaintainClients_Load);
            this.tbClient.ResumeLayout(false);
            this.tbpInsert.ResumeLayout(false);
            this.tbpInsert.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInsertClients)).EndInit();
            this.tbpDelete.ResumeLayout(false);
            this.tbpDelete.PerformLayout();
            this.grpDelete.ResumeLayout(false);
            this.grpDelete.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Button btnRemoveClient;
        private System.Windows.Forms.TextBox txtStudentNumber;
        private System.Windows.Forms.Panel pnlTextbook;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbltextbook;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grpDelete;
        private System.Windows.Forms.ListBox lstDelete;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox lstUpdate;
        private System.Windows.Forms.TextBox txtDeleteStudent;
        private System.Windows.Forms.TextBox txtDeletSName;
        private System.Windows.Forms.TextBox txtDeleteFName;
        private System.Windows.Forms.TextBox txtUpdateStudent;
        private System.Windows.Forms.TextBox txtUpdateSName;
        private System.Windows.Forms.TextBox txtUpdateFName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtChangeStudent;
        private System.Windows.Forms.TextBox txtChangeSurname;
        private System.Windows.Forms.TextBox txtChangeFName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}