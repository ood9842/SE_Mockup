namespace MockupV1
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.connectLAN = new System.Windows.Forms.Button();
            this.pointList = new System.Windows.Forms.ComboBox();
            this.checkPoint = new System.Windows.Forms.Label();
            this.ant1 = new System.Windows.Forms.Label();
            this.ant5 = new System.Windows.Forms.Label();
            this.ant6 = new System.Windows.Forms.Label();
            this.ant2 = new System.Windows.Forms.Label();
            this.ant8 = new System.Windows.Forms.Label();
            this.ant4 = new System.Windows.Forms.Label();
            this.ant7 = new System.Windows.Forms.Label();
            this.ant3 = new System.Windows.Forms.Label();
            this.switchRate = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.performance = new System.Windows.Forms.Label();
            this.readCount = new System.Windows.Forms.Label();
            this.addDB = new System.Windows.Forms.Label();
            this.addFile = new System.Windows.Forms.Label();
            this.addServer = new System.Windows.Forms.Label();
            this.serverStatus = new System.Windows.Forms.Label();
            this.fileStatus = new System.Windows.Forms.Label();
            this.dbStatus = new System.Windows.Forms.Label();
            this.deviceStatus = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pushToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.port4 = new System.Windows.Forms.RadioButton();
            this.port8 = new System.Windows.Forms.RadioButton();
            this.status1 = new System.Windows.Forms.Label();
            this.status2 = new System.Windows.Forms.Label();
            this.status4 = new System.Windows.Forms.Label();
            this.status3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(334, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(454, 298);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // connectLAN
            // 
            this.connectLAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectLAN.Location = new System.Drawing.Point(57, 109);
            this.connectLAN.Name = "connectLAN";
            this.connectLAN.Size = new System.Drawing.Size(206, 53);
            this.connectLAN.TabIndex = 1;
            this.connectLAN.Text = "connect LAN";
            this.connectLAN.UseVisualStyleBackColor = true;
            this.connectLAN.Click += new System.EventHandler(this.connectLAN_Click);
            // 
            // pointList
            // 
            this.pointList.FormattingEnabled = true;
            this.pointList.Items.AddRange(new object[] {
            "start",
            "point1",
            "point2",
            "point3",
            "point4",
            "point5",
            "point6",
            "point7",
            "point8",
            "point9",
            "finish"});
            this.pointList.Location = new System.Drawing.Point(133, 68);
            this.pointList.Name = "pointList";
            this.pointList.Size = new System.Drawing.Size(121, 21);
            this.pointList.TabIndex = 30;
            // 
            // checkPoint
            // 
            this.checkPoint.AutoSize = true;
            this.checkPoint.Location = new System.Drawing.Point(64, 71);
            this.checkPoint.Name = "checkPoint";
            this.checkPoint.Size = new System.Drawing.Size(63, 13);
            this.checkPoint.TabIndex = 5;
            this.checkPoint.Text = "check point";
            // 
            // ant1
            // 
            this.ant1.AutoSize = true;
            this.ant1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ant1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ant1.ForeColor = System.Drawing.Color.Silver;
            this.ant1.Location = new System.Drawing.Point(19, 183);
            this.ant1.Name = "ant1";
            this.ant1.Size = new System.Drawing.Size(133, 20);
            this.ant1.TabIndex = 6;
            this.ant1.Text = "ant1: 00.00.00.00";
            // 
            // ant5
            // 
            this.ant5.AutoSize = true;
            this.ant5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ant5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ant5.ForeColor = System.Drawing.Color.Silver;
            this.ant5.Location = new System.Drawing.Point(177, 183);
            this.ant5.Name = "ant5";
            this.ant5.Size = new System.Drawing.Size(133, 20);
            this.ant5.TabIndex = 7;
            this.ant5.Text = "ant5: 00.00.00.00";
            // 
            // ant6
            // 
            this.ant6.AutoSize = true;
            this.ant6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ant6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ant6.ForeColor = System.Drawing.Color.Silver;
            this.ant6.Location = new System.Drawing.Point(177, 213);
            this.ant6.Name = "ant6";
            this.ant6.Size = new System.Drawing.Size(133, 20);
            this.ant6.TabIndex = 9;
            this.ant6.Text = "ant6: 00.00.00.00";
            // 
            // ant2
            // 
            this.ant2.AutoSize = true;
            this.ant2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ant2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ant2.ForeColor = System.Drawing.Color.Silver;
            this.ant2.Location = new System.Drawing.Point(19, 213);
            this.ant2.Name = "ant2";
            this.ant2.Size = new System.Drawing.Size(133, 20);
            this.ant2.TabIndex = 8;
            this.ant2.Text = "ant2: 00.00.00.00";
            // 
            // ant8
            // 
            this.ant8.AutoSize = true;
            this.ant8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ant8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ant8.ForeColor = System.Drawing.Color.Silver;
            this.ant8.Location = new System.Drawing.Point(177, 273);
            this.ant8.Name = "ant8";
            this.ant8.Size = new System.Drawing.Size(133, 20);
            this.ant8.TabIndex = 13;
            this.ant8.Text = "ant8: 00.00.00.00";
            // 
            // ant4
            // 
            this.ant4.AutoSize = true;
            this.ant4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ant4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ant4.ForeColor = System.Drawing.Color.Silver;
            this.ant4.Location = new System.Drawing.Point(19, 273);
            this.ant4.Name = "ant4";
            this.ant4.Size = new System.Drawing.Size(133, 20);
            this.ant4.TabIndex = 12;
            this.ant4.Text = "ant4: 00.00.00.00";
            // 
            // ant7
            // 
            this.ant7.AutoSize = true;
            this.ant7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ant7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ant7.ForeColor = System.Drawing.Color.Silver;
            this.ant7.Location = new System.Drawing.Point(177, 243);
            this.ant7.Name = "ant7";
            this.ant7.Size = new System.Drawing.Size(133, 20);
            this.ant7.TabIndex = 11;
            this.ant7.Text = "ant7: 00.00.00.00";
            // 
            // ant3
            // 
            this.ant3.AutoSize = true;
            this.ant3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ant3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ant3.ForeColor = System.Drawing.Color.Silver;
            this.ant3.Location = new System.Drawing.Point(19, 243);
            this.ant3.Name = "ant3";
            this.ant3.Size = new System.Drawing.Size(133, 20);
            this.ant3.TabIndex = 10;
            this.ant3.Text = "ant3: 00.00.00.00";
            // 
            // switchRate
            // 
            this.switchRate.AutoSize = true;
            this.switchRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switchRate.Location = new System.Drawing.Point(101, 313);
            this.switchRate.Name = "switchRate";
            this.switchRate.Size = new System.Drawing.Size(112, 16);
            this.switchRate.TabIndex = 14;
            this.switchRate.Text = "switch rate (ms): 0";
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.White;
            this.start.Enabled = false;
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.Location = new System.Drawing.Point(96, 356);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(128, 51);
            this.start.TabIndex = 30;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // reset
            // 
            this.reset.Enabled = false;
            this.reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.Location = new System.Drawing.Point(715, 410);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(83, 39);
            this.reset.TabIndex = 16;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // performance
            // 
            this.performance.AutoSize = true;
            this.performance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.performance.Location = new System.Drawing.Point(334, 317);
            this.performance.Name = "performance";
            this.performance.Size = new System.Drawing.Size(92, 18);
            this.performance.TabIndex = 17;
            this.performance.Text = "performance";
            // 
            // readCount
            // 
            this.readCount.AutoSize = true;
            this.readCount.Location = new System.Drawing.Point(334, 345);
            this.readCount.Name = "readCount";
            this.readCount.Size = new System.Drawing.Size(98, 13);
            this.readCount.TabIndex = 18;
            this.readCount.Text = "Tag Read Count: 0";
            // 
            // addDB
            // 
            this.addDB.AutoSize = true;
            this.addDB.Location = new System.Drawing.Point(334, 366);
            this.addDB.Name = "addDB";
            this.addDB.Size = new System.Drawing.Size(102, 13);
            this.addDB.TabIndex = 19;
            this.addDB.Text = "Tag Added In DB: 0";
            // 
            // addFile
            // 
            this.addFile.AutoSize = true;
            this.addFile.Location = new System.Drawing.Point(334, 386);
            this.addFile.Name = "addFile";
            this.addFile.Size = new System.Drawing.Size(103, 13);
            this.addFile.TabIndex = 20;
            this.addFile.Text = "Tag Added In File: 0";
            // 
            // addServer
            // 
            this.addServer.AutoSize = true;
            this.addServer.Location = new System.Drawing.Point(334, 406);
            this.addServer.Name = "addServer";
            this.addServer.Size = new System.Drawing.Size(118, 13);
            this.addServer.TabIndex = 21;
            this.addServer.Text = "Tag Added In Server: 0";
            // 
            // serverStatus
            // 
            this.serverStatus.AutoSize = true;
            this.serverStatus.Location = new System.Drawing.Point(529, 406);
            this.serverStatus.Name = "serverStatus";
            this.serverStatus.Size = new System.Drawing.Size(74, 13);
            this.serverStatus.TabIndex = 25;
            this.serverStatus.Text = "Server Status:";
            // 
            // fileStatus
            // 
            this.fileStatus.AutoSize = true;
            this.fileStatus.Location = new System.Drawing.Point(529, 386);
            this.fileStatus.Name = "fileStatus";
            this.fileStatus.Size = new System.Drawing.Size(59, 13);
            this.fileStatus.TabIndex = 24;
            this.fileStatus.Text = "File Status:";
            // 
            // dbStatus
            // 
            this.dbStatus.AutoSize = true;
            this.dbStatus.Location = new System.Drawing.Point(529, 366);
            this.dbStatus.Name = "dbStatus";
            this.dbStatus.Size = new System.Drawing.Size(58, 13);
            this.dbStatus.TabIndex = 23;
            this.dbStatus.Text = "DB Status:";
            // 
            // deviceStatus
            // 
            this.deviceStatus.AutoSize = true;
            this.deviceStatus.Location = new System.Drawing.Point(529, 345);
            this.deviceStatus.Name = "deviceStatus";
            this.deviceStatus.Size = new System.Drawing.Size(77, 13);
            this.deviceStatus.TabIndex = 22;
            this.deviceStatus.Text = "Device Status:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.pushToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // pushToolStripMenuItem
            // 
            this.pushToolStripMenuItem.Name = "pushToolStripMenuItem";
            this.pushToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pushToolStripMenuItem.Text = "Push";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clearToolStripMenuItem.Text = "Clear Database";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enableToolStripMenuItem,
            this.testSystemToolStripMenuItem});
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.optionToolStripMenuItem.Text = "Option";
            this.optionToolStripMenuItem.Click += new System.EventHandler(this.optionToolStripMenuItem_Click);
            // 
            // enableToolStripMenuItem
            // 
            this.enableToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.soundToolStripMenuItem,
            this.lightToolStripMenuItem});
            this.enableToolStripMenuItem.Name = "enableToolStripMenuItem";
            this.enableToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.enableToolStripMenuItem.Text = "Enable";
            // 
            // soundToolStripMenuItem
            // 
            this.soundToolStripMenuItem.Name = "soundToolStripMenuItem";
            this.soundToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.soundToolStripMenuItem.Text = "Sound";
            // 
            // lightToolStripMenuItem
            // 
            this.lightToolStripMenuItem.Name = "lightToolStripMenuItem";
            this.lightToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.lightToolStripMenuItem.Text = "Light";
            // 
            // testSystemToolStripMenuItem
            // 
            this.testSystemToolStripMenuItem.Name = "testSystemToolStripMenuItem";
            this.testSystemToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.testSystemToolStripMenuItem.Text = "Test System";
            // 
            // port4
            // 
            this.port4.AutoSize = true;
            this.port4.Location = new System.Drawing.Point(62, 36);
            this.port4.Name = "port4";
            this.port4.Size = new System.Drawing.Size(52, 17);
            this.port4.TabIndex = 29;
            this.port4.TabStop = true;
            this.port4.Text = "4 port";
            this.port4.UseVisualStyleBackColor = true;
            // 
            // port8
            // 
            this.port8.AutoSize = true;
            this.port8.Location = new System.Drawing.Point(173, 36);
            this.port8.Name = "port8";
            this.port8.Size = new System.Drawing.Size(52, 17);
            this.port8.TabIndex = 28;
            this.port8.TabStop = true;
            this.port8.Text = "8 port";
            this.port8.UseVisualStyleBackColor = true;
            // 
            // status1
            // 
            this.status1.AutoSize = true;
            this.status1.ForeColor = System.Drawing.Color.Red;
            this.status1.Location = new System.Drawing.Point(613, 345);
            this.status1.Name = "status1";
            this.status1.Size = new System.Drawing.Size(73, 13);
            this.status1.TabIndex = 31;
            this.status1.Text = "Disconnected";
            // 
            // status2
            // 
            this.status2.AutoSize = true;
            this.status2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.status2.Location = new System.Drawing.Point(613, 366);
            this.status2.Name = "status2";
            this.status2.Size = new System.Drawing.Size(59, 13);
            this.status2.TabIndex = 32;
            this.status2.Text = "Connected";
            // 
            // status4
            // 
            this.status4.AutoSize = true;
            this.status4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.status4.Location = new System.Drawing.Point(613, 406);
            this.status4.Name = "status4";
            this.status4.Size = new System.Drawing.Size(59, 13);
            this.status4.TabIndex = 33;
            this.status4.Text = "Connected";
            // 
            // status3
            // 
            this.status3.AutoSize = true;
            this.status3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.status3.Location = new System.Drawing.Point(613, 386);
            this.status3.Name = "status3";
            this.status3.Size = new System.Drawing.Size(59, 13);
            this.status3.TabIndex = 34;
            this.status3.Text = "Connected";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.status3);
            this.Controls.Add(this.status4);
            this.Controls.Add(this.status2);
            this.Controls.Add(this.status1);
            this.Controls.Add(this.port8);
            this.Controls.Add(this.port4);
            this.Controls.Add(this.serverStatus);
            this.Controls.Add(this.fileStatus);
            this.Controls.Add(this.dbStatus);
            this.Controls.Add(this.deviceStatus);
            this.Controls.Add(this.addServer);
            this.Controls.Add(this.addFile);
            this.Controls.Add(this.addDB);
            this.Controls.Add(this.readCount);
            this.Controls.Add(this.performance);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.start);
            this.Controls.Add(this.switchRate);
            this.Controls.Add(this.ant8);
            this.Controls.Add(this.ant4);
            this.Controls.Add(this.ant7);
            this.Controls.Add(this.ant3);
            this.Controls.Add(this.ant6);
            this.Controls.Add(this.ant2);
            this.Controls.Add(this.ant5);
            this.Controls.Add(this.ant1);
            this.Controls.Add(this.checkPoint);
            this.Controls.Add(this.pointList);
            this.Controls.Add(this.connectLAN);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button connectLAN;
        private System.Windows.Forms.ComboBox pointList;
        private System.Windows.Forms.Label checkPoint;
        private System.Windows.Forms.Label ant1;
        private System.Windows.Forms.Label ant5;
        private System.Windows.Forms.Label ant6;
        private System.Windows.Forms.Label ant2;
        private System.Windows.Forms.Label ant8;
        private System.Windows.Forms.Label ant4;
        private System.Windows.Forms.Label ant7;
        private System.Windows.Forms.Label ant3;
        private System.Windows.Forms.Label switchRate;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label performance;
        private System.Windows.Forms.Label readCount;
        private System.Windows.Forms.Label addDB;
        private System.Windows.Forms.Label addFile;
        private System.Windows.Forms.Label addServer;
        private System.Windows.Forms.Label serverStatus;
        private System.Windows.Forms.Label fileStatus;
        private System.Windows.Forms.Label dbStatus;
        private System.Windows.Forms.Label deviceStatus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pushToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testSystemToolStripMenuItem;
        private System.Windows.Forms.RadioButton port4;
        private System.Windows.Forms.RadioButton port8;
        private System.Windows.Forms.Label status1;
        private System.Windows.Forms.Label status2;
        private System.Windows.Forms.Label status4;
        private System.Windows.Forms.Label status3;
    }
}