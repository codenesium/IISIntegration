namespace Tester
{
    public partial class Form1
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
            this.comboBoxSites = new System.Windows.Forms.ComboBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSiteStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDeleteWebsite = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxVirtualDirectoryPath = new System.Windows.Forms.TextBox();
            this.buttonCreateVirtualDirectory = new System.Windows.Forms.Button();
            this.textBoxVirtualDirectory = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxWebsitePhysicalPath = new System.Windows.Forms.TextBox();
            this.buttonCreateWebsite = new System.Windows.Forms.Button();
            this.textBoxSiteName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBoxApplications = new System.Windows.Forms.ComboBox();
            this.buttonDeleteApplication = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxApplicationPath = new System.Windows.Forms.TextBox();
            this.buttonCreateApplication = new System.Windows.Forms.Button();
            this.textBoxApplicationName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.comboBoxAppPools = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonDeleteAppPool = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonCreateAppPool = new System.Windows.Forms.Button();
            this.textBoxApplicationPoolName = new System.Windows.Forms.TextBox();
            this.checkBoxEnable32BitApplications = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxNETVersion = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxSites
            // 
            this.comboBoxSites.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSites.FormattingEnabled = true;
            this.comboBoxSites.Location = new System.Drawing.Point(39, 40);
            this.comboBoxSites.Name = "comboBoxSites";
            this.comboBoxSites.Size = new System.Drawing.Size(211, 21);
            this.comboBoxSites.TabIndex = 0;
            this.comboBoxSites.SelectedIndexChanged += new System.EventHandler(this.comboBoxSites_SelectedIndexChanged);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(286, 37);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(384, 37);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 2;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Status:";
            // 
            // labelSiteStatus
            // 
            this.labelSiteStatus.AutoSize = true;
            this.labelSiteStatus.Location = new System.Drawing.Point(81, 79);
            this.labelSiteStatus.Name = "labelSiteStatus";
            this.labelSiteStatus.Size = new System.Drawing.Size(0, 13);
            this.labelSiteStatus.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sites";
            // 
            // buttonDeleteWebsite
            // 
            this.buttonDeleteWebsite.Location = new System.Drawing.Point(480, 37);
            this.buttonDeleteWebsite.Name = "buttonDeleteWebsite";
            this.buttonDeleteWebsite.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteWebsite.TabIndex = 15;
            this.buttonDeleteWebsite.Text = "Delete";
            this.buttonDeleteWebsite.UseVisualStyleBackColor = true;
            this.buttonDeleteWebsite.Click += new System.EventHandler(this.buttonDeleteWebsite_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.textBoxVirtualDirectoryPath);
            this.panel2.Controls.Add(this.buttonCreateVirtualDirectory);
            this.panel2.Controls.Add(this.textBoxVirtualDirectory);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(355, 472);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(246, 190);
            this.panel2.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Virtual Directory";
            // 
            // textBoxVirtualDirectoryPath
            // 
            this.textBoxVirtualDirectoryPath.Location = new System.Drawing.Point(29, 101);
            this.textBoxVirtualDirectoryPath.Name = "textBoxVirtualDirectoryPath";
            this.textBoxVirtualDirectoryPath.Size = new System.Drawing.Size(178, 20);
            this.textBoxVirtualDirectoryPath.TabIndex = 16;
            // 
            // buttonCreateVirtualDirectory
            // 
            this.buttonCreateVirtualDirectory.Location = new System.Drawing.Point(132, 144);
            this.buttonCreateVirtualDirectory.Name = "buttonCreateVirtualDirectory";
            this.buttonCreateVirtualDirectory.Size = new System.Drawing.Size(75, 23);
            this.buttonCreateVirtualDirectory.TabIndex = 15;
            this.buttonCreateVirtualDirectory.Text = "Create";
            this.buttonCreateVirtualDirectory.UseVisualStyleBackColor = true;
            this.buttonCreateVirtualDirectory.Click += new System.EventHandler(this.buttonCreateVirtualDirectory_Click);
            // 
            // textBoxVirtualDirectory
            // 
            this.textBoxVirtualDirectory.Location = new System.Drawing.Point(29, 51);
            this.textBoxVirtualDirectory.Name = "textBoxVirtualDirectory";
            this.textBoxVirtualDirectory.Size = new System.Drawing.Size(178, 20);
            this.textBoxVirtualDirectory.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Virtual Directory Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Physical Path";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.textBoxPort);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.textBoxWebsitePhysicalPath);
            this.panel3.Controls.Add(this.buttonCreateWebsite);
            this.panel3.Controls.Add(this.textBoxSiteName);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Location = new System.Drawing.Point(55, 342);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(246, 253);
            this.panel3.TabIndex = 18;
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(30, 147);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(178, 20);
            this.textBoxPort.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(28, 131);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Port";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Create Website";
            // 
            // textBoxWebsitePhysicalPath
            // 
            this.textBoxWebsitePhysicalPath.Location = new System.Drawing.Point(29, 101);
            this.textBoxWebsitePhysicalPath.Name = "textBoxWebsitePhysicalPath";
            this.textBoxWebsitePhysicalPath.Size = new System.Drawing.Size(178, 20);
            this.textBoxWebsitePhysicalPath.TabIndex = 16;
            // 
            // buttonCreateWebsite
            // 
            this.buttonCreateWebsite.Location = new System.Drawing.Point(132, 186);
            this.buttonCreateWebsite.Name = "buttonCreateWebsite";
            this.buttonCreateWebsite.Size = new System.Drawing.Size(75, 23);
            this.buttonCreateWebsite.TabIndex = 15;
            this.buttonCreateWebsite.Text = "Create";
            this.buttonCreateWebsite.UseVisualStyleBackColor = true;
            this.buttonCreateWebsite.Click += new System.EventHandler(this.buttonCreateWebsite_Click);
            // 
            // textBoxSiteName
            // 
            this.textBoxSiteName.Location = new System.Drawing.Point(29, 51);
            this.textBoxSiteName.Name = "textBoxSiteName";
            this.textBoxSiteName.Size = new System.Drawing.Size(178, 20);
            this.textBoxSiteName.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Site Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 85);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Physical Path";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(39, 101);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "Applications";
            // 
            // comboBoxApplications
            // 
            this.comboBoxApplications.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxApplications.FormattingEnabled = true;
            this.comboBoxApplications.Location = new System.Drawing.Point(39, 115);
            this.comboBoxApplications.Name = "comboBoxApplications";
            this.comboBoxApplications.Size = new System.Drawing.Size(211, 21);
            this.comboBoxApplications.TabIndex = 19;
            // 
            // buttonDeleteApplication
            // 
            this.buttonDeleteApplication.Location = new System.Drawing.Point(286, 113);
            this.buttonDeleteApplication.Name = "buttonDeleteApplication";
            this.buttonDeleteApplication.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteApplication.TabIndex = 21;
            this.buttonDeleteApplication.Text = "Delete";
            this.buttonDeleteApplication.UseVisualStyleBackColor = true;
            this.buttonDeleteApplication.Click += new System.EventHandler(this.buttonDeleteApplication_Click);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.textBoxApplicationPath);
            this.panel5.Controls.Add(this.buttonCreateApplication);
            this.panel5.Controls.Add(this.textBoxApplicationName);
            this.panel5.Controls.Add(this.label16);
            this.panel5.Controls.Add(this.label17);
            this.panel5.Location = new System.Drawing.Point(355, 257);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(246, 195);
            this.panel5.TabIndex = 18;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 13);
            this.label15.TabIndex = 17;
            this.label15.Text = "Create Application";
            // 
            // textBoxApplicationPath
            // 
            this.textBoxApplicationPath.Location = new System.Drawing.Point(29, 101);
            this.textBoxApplicationPath.Name = "textBoxApplicationPath";
            this.textBoxApplicationPath.Size = new System.Drawing.Size(178, 20);
            this.textBoxApplicationPath.TabIndex = 16;
            // 
            // buttonCreateApplication
            // 
            this.buttonCreateApplication.Location = new System.Drawing.Point(132, 144);
            this.buttonCreateApplication.Name = "buttonCreateApplication";
            this.buttonCreateApplication.Size = new System.Drawing.Size(75, 23);
            this.buttonCreateApplication.TabIndex = 15;
            this.buttonCreateApplication.Text = "Create";
            this.buttonCreateApplication.UseVisualStyleBackColor = true;
            this.buttonCreateApplication.Click += new System.EventHandler(this.buttonCreateApplication_Click);
            // 
            // textBoxApplicationName
            // 
            this.textBoxApplicationName.Location = new System.Drawing.Point(29, 51);
            this.textBoxApplicationName.Name = "textBoxApplicationName";
            this.textBoxApplicationName.Size = new System.Drawing.Size(178, 20);
            this.textBoxApplicationName.TabIndex = 8;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(27, 35);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 13);
            this.label16.TabIndex = 9;
            this.label16.Text = "Application Name";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(27, 85);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(71, 13);
            this.label17.TabIndex = 11;
            this.label17.Text = "Physical Path";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.comboBoxAppPools);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.buttonDeleteAppPool);
            this.panel6.Controls.Add(this.comboBoxSites);
            this.panel6.Controls.Add(this.buttonStart);
            this.panel6.Controls.Add(this.buttonStop);
            this.panel6.Controls.Add(this.buttonDeleteApplication);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.label14);
            this.panel6.Controls.Add(this.labelSiteStatus);
            this.panel6.Controls.Add(this.comboBoxApplications);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.buttonDeleteWebsite);
            this.panel6.Location = new System.Drawing.Point(26, 16);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(575, 225);
            this.panel6.TabIndex = 23;
            // 
            // comboBoxAppPools
            // 
            this.comboBoxAppPools.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAppPools.FormattingEnabled = true;
            this.comboBoxAppPools.Location = new System.Drawing.Point(39, 175);
            this.comboBoxAppPools.Name = "comboBoxAppPools";
            this.comboBoxAppPools.Size = new System.Drawing.Size(211, 21);
            this.comboBoxAppPools.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Application Pools";
            // 
            // buttonDeleteAppPool
            // 
            this.buttonDeleteAppPool.Location = new System.Drawing.Point(286, 173);
            this.buttonDeleteAppPool.Name = "buttonDeleteAppPool";
            this.buttonDeleteAppPool.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteAppPool.TabIndex = 24;
            this.buttonDeleteAppPool.Text = "Delete";
            this.buttonDeleteAppPool.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.panel6);
            this.panel7.Controls.Add(this.panel5);
            this.panel7.Controls.Add(this.panel2);
            this.panel7.Controls.Add(this.panel3);
            this.panel7.Location = new System.Drawing.Point(12, 12);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(621, 692);
            this.panel7.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.buttonCreateAppPool);
            this.panel1.Controls.Add(this.textBoxApplicationPoolName);
            this.panel1.Controls.Add(this.checkBoxEnable32BitApplications);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.comboBoxNETVersion);
            this.panel1.Location = new System.Drawing.Point(653, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 243);
            this.panel1.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Application Pool";
            // 
            // buttonCreateAppPool
            // 
            this.buttonCreateAppPool.Location = new System.Drawing.Point(143, 199);
            this.buttonCreateAppPool.Name = "buttonCreateAppPool";
            this.buttonCreateAppPool.Size = new System.Drawing.Size(75, 23);
            this.buttonCreateAppPool.TabIndex = 15;
            this.buttonCreateAppPool.Text = "Create";
            this.buttonCreateAppPool.UseVisualStyleBackColor = true;
            // 
            // textBoxApplicationPoolName
            // 
            this.textBoxApplicationPoolName.Location = new System.Drawing.Point(28, 60);
            this.textBoxApplicationPoolName.Name = "textBoxApplicationPoolName";
            this.textBoxApplicationPoolName.Size = new System.Drawing.Size(178, 20);
            this.textBoxApplicationPoolName.TabIndex = 8;
            // 
            // checkBoxEnable32BitApplications
            // 
            this.checkBoxEnable32BitApplications.AutoSize = true;
            this.checkBoxEnable32BitApplications.Location = new System.Drawing.Point(28, 159);
            this.checkBoxEnable32BitApplications.Name = "checkBoxEnable32BitApplications";
            this.checkBoxEnable32BitApplications.Size = new System.Drawing.Size(147, 17);
            this.checkBoxEnable32BitApplications.TabIndex = 12;
            this.checkBoxEnable32BitApplications.Text = "Enable 32 bit applications";
            this.checkBoxEnable32BitApplications.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Application Pool Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = ".NET Version";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBoxNETVersion
            // 
            this.comboBoxNETVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNETVersion.FormattingEnabled = true;
            this.comboBoxNETVersion.Items.AddRange(new object[] {
            "v4.0",
            "v2.0"});
            this.comboBoxNETVersion.Location = new System.Drawing.Point(26, 110);
            this.comboBoxNETVersion.Name = "comboBoxNETVersion";
            this.comboBoxNETVersion.Size = new System.Drawing.Size(180, 21);
            this.comboBoxNETVersion.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 755);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSites;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSiteStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonDeleteWebsite;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonCreateVirtualDirectory;
        private System.Windows.Forms.TextBox textBoxVirtualDirectory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxVirtualDirectoryPath;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxWebsitePhysicalPath;
        private System.Windows.Forms.Button buttonCreateWebsite;
        private System.Windows.Forms.TextBox textBoxSiteName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBoxApplications;
        private System.Windows.Forms.Button buttonDeleteApplication;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxApplicationPath;
        private System.Windows.Forms.Button buttonCreateApplication;
        private System.Windows.Forms.TextBox textBoxApplicationName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox comboBoxAppPools;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonDeleteAppPool;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonCreateAppPool;
        private System.Windows.Forms.TextBox textBoxApplicationPoolName;
        private System.Windows.Forms.CheckBox checkBoxEnable32BitApplications;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxNETVersion;
    }
}

