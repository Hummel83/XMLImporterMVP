
namespace XMLImporter.WinFormsMVP
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_end = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbBox_project = new System.Windows.Forms.ComboBox();
            this.cmbBox_domain = new System.Windows.Forms.ComboBox();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.lbl_project = new System.Windows.Forms.Label();
            this.lbl_domain = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.txtBox_password = new System.Windows.Forms.TextBox();
            this.txtBox_username = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.txtBox_ConnectionLink = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_startImport = new System.Windows.Forms.Button();
            this.btn_openFile = new System.Windows.Forms.Button();
            this.txtBox_file = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtBox_output = new System.Windows.Forms.RichTextBox();
            this.openFileDialog_SelectXmlFile = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_end);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 484);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(748, 64);
            this.panel1.TabIndex = 0;
            // 
            // btn_end
            // 
            this.btn_end.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_end.BackColor = System.Drawing.SystemColors.Control;
            this.btn_end.Location = new System.Drawing.Point(597, 15);
            this.btn_end.Name = "btn_end";
            this.btn_end.Size = new System.Drawing.Size(139, 37);
            this.btn_end.TabIndex = 1;
            this.btn_end.Text = "Beenden";
            this.btn_end.UseVisualStyleBackColor = false;
            this.btn_end.Click += new System.EventHandler(this.btn_end_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.splitContainer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(748, 283);
            this.panel2.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(748, 283);
            this.splitContainer1.SplitterDistance = 347;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbBox_project);
            this.groupBox1.Controls.Add(this.cmbBox_domain);
            this.groupBox1.Controls.Add(this.btn_Connect);
            this.groupBox1.Controls.Add(this.lbl_project);
            this.groupBox1.Controls.Add(this.lbl_domain);
            this.groupBox1.Controls.Add(this.btn_login);
            this.groupBox1.Controls.Add(this.txtBox_password);
            this.groupBox1.Controls.Add(this.txtBox_username);
            this.groupBox1.Controls.Add(this.lbl_password);
            this.groupBox1.Controls.Add(this.lbl_username);
            this.groupBox1.Controls.Add(this.txtBox_ConnectionLink);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 283);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Verbindung";
            // 
            // cmbBox_project
            // 
            this.cmbBox_project.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBox_project.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox_project.FormattingEnabled = true;
            this.cmbBox_project.Location = new System.Drawing.Point(123, 193);
            this.cmbBox_project.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cmbBox_project.Name = "cmbBox_project";
            this.cmbBox_project.Size = new System.Drawing.Size(207, 21);
            this.cmbBox_project.TabIndex = 23;
            this.cmbBox_project.SelectedIndexChanged += new System.EventHandler(this.cmbBox_project_SelectedIndexChanged);
            // 
            // cmbBox_domain
            // 
            this.cmbBox_domain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBox_domain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox_domain.FormattingEnabled = true;
            this.cmbBox_domain.Location = new System.Drawing.Point(123, 160);
            this.cmbBox_domain.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cmbBox_domain.Name = "cmbBox_domain";
            this.cmbBox_domain.Size = new System.Drawing.Size(207, 21);
            this.cmbBox_domain.TabIndex = 22;
            this.cmbBox_domain.SelectedIndexChanged += new System.EventHandler(this.cmbBox_domain_SelectedIndexChanged);
            // 
            // btn_Connect
            // 
            this.btn_Connect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Connect.Location = new System.Drawing.Point(226, 226);
            this.btn_Connect.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(104, 25);
            this.btn_Connect.TabIndex = 21;
            this.btn_Connect.Text = "Verbinden";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // lbl_project
            // 
            this.lbl_project.AutoSize = true;
            this.lbl_project.Location = new System.Drawing.Point(16, 196);
            this.lbl_project.Name = "lbl_project";
            this.lbl_project.Size = new System.Drawing.Size(40, 13);
            this.lbl_project.TabIndex = 20;
            this.lbl_project.Text = "Project";
            // 
            // lbl_domain
            // 
            this.lbl_domain.AutoSize = true;
            this.lbl_domain.Location = new System.Drawing.Point(16, 163);
            this.lbl_domain.Name = "lbl_domain";
            this.lbl_domain.Size = new System.Drawing.Size(43, 13);
            this.lbl_domain.TabIndex = 19;
            this.lbl_domain.Text = "Domain";
            // 
            // btn_login
            // 
            this.btn_login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_login.Location = new System.Drawing.Point(226, 125);
            this.btn_login.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(104, 25);
            this.btn_login.TabIndex = 18;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txtBox_password
            // 
            this.txtBox_password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBox_password.Location = new System.Drawing.Point(123, 94);
            this.txtBox_password.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtBox_password.Name = "txtBox_password";
            this.txtBox_password.Size = new System.Drawing.Size(207, 20);
            this.txtBox_password.TabIndex = 17;
            // 
            // txtBox_username
            // 
            this.txtBox_username.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBox_username.Location = new System.Drawing.Point(123, 63);
            this.txtBox_username.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtBox_username.Name = "txtBox_username";
            this.txtBox_username.Size = new System.Drawing.Size(207, 20);
            this.txtBox_username.TabIndex = 16;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(16, 97);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(50, 13);
            this.lbl_password.TabIndex = 15;
            this.lbl_password.Text = "Passwort";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(16, 66);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(75, 13);
            this.lbl_username.TabIndex = 14;
            this.lbl_username.Text = "Benutzername";
            // 
            // txtBox_ConnectionLink
            // 
            this.txtBox_ConnectionLink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBox_ConnectionLink.Location = new System.Drawing.Point(16, 32);
            this.txtBox_ConnectionLink.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtBox_ConnectionLink.Name = "txtBox_ConnectionLink";
            this.txtBox_ConnectionLink.Size = new System.Drawing.Size(314, 20);
            this.txtBox_ConnectionLink.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_startImport);
            this.groupBox2.Controls.Add(this.btn_openFile);
            this.groupBox2.Controls.Add(this.txtBox_file);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(397, 283);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datei Import";
            // 
            // btn_startImport
            // 
            this.btn_startImport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_startImport.Location = new System.Drawing.Point(17, 62);
            this.btn_startImport.Name = "btn_startImport";
            this.btn_startImport.Size = new System.Drawing.Size(368, 23);
            this.btn_startImport.TabIndex = 17;
            this.btn_startImport.Text = "Start Import";
            this.btn_startImport.UseVisualStyleBackColor = true;
            this.btn_startImport.Click += new System.EventHandler(this.btn_startImport_Click);
            // 
            // btn_openFile
            // 
            this.btn_openFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_openFile.Location = new System.Drawing.Point(282, 29);
            this.btn_openFile.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_openFile.Name = "btn_openFile";
            this.btn_openFile.Size = new System.Drawing.Size(103, 24);
            this.btn_openFile.TabIndex = 15;
            this.btn_openFile.Text = "Datei öffnen";
            this.btn_openFile.UseVisualStyleBackColor = true;
            this.btn_openFile.Click += new System.EventHandler(this.btn_openFile_Click);
            // 
            // txtBox_file
            // 
            this.txtBox_file.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBox_file.Location = new System.Drawing.Point(17, 32);
            this.txtBox_file.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtBox_file.Name = "txtBox_file";
            this.txtBox_file.Size = new System.Drawing.Size(259, 20);
            this.txtBox_file.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 283);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(748, 201);
            this.panel3.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtBox_output);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(748, 201);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ausgabe";
            // 
            // txtBox_output
            // 
            this.txtBox_output.BackColor = System.Drawing.Color.White;
            this.txtBox_output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBox_output.Location = new System.Drawing.Point(3, 16);
            this.txtBox_output.Name = "txtBox_output";
            this.txtBox_output.ReadOnly = true;
            this.txtBox_output.Size = new System.Drawing.Size(742, 182);
            this.txtBox_output.TabIndex = 1;
            this.txtBox_output.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 548);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(630, 550);
            this.Name = "MainForm";
            this.Text = "XML Importer";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbBox_project;
        private System.Windows.Forms.ComboBox cmbBox_domain;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Label lbl_project;
        private System.Windows.Forms.Label lbl_domain;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txtBox_password;
        private System.Windows.Forms.TextBox txtBox_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.TextBox txtBox_ConnectionLink;
        private System.Windows.Forms.Button btn_startImport;
        private System.Windows.Forms.Button btn_openFile;
        private System.Windows.Forms.TextBox txtBox_file;
        private System.Windows.Forms.Button btn_end;
        private System.Windows.Forms.RichTextBox txtBox_output;
        private System.Windows.Forms.OpenFileDialog openFileDialog_SelectXmlFile;
    }
}

