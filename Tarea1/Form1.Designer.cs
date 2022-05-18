namespace Tarea1
{
    partial class Form1
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NameProcessor = new System.Windows.Forms.Label();
            this.Threads = new System.Windows.Forms.Label();
            this.NumberOfLogicalProcessors = new System.Windows.Forms.Label();
            this.NumberOfCores = new System.Windows.Forms.Label();
            this.NumberOfEnabledCore = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelProccessCount = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnKill = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lstCPU = new System.Windows.Forms.ListBox();
            this.lstThreads = new System.Windows.Forms.ListBox();
            this.lstTasks = new System.Windows.Forms.ListBox();
            this.lstIds = new System.Windows.Forms.ListBox();
            this.lstProccess = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Snow;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.labelProccessCount);
            this.tabPage1.Controls.Add(this.btnExit);
            this.tabPage1.Controls.Add(this.btnKill);
            this.tabPage1.Controls.Add(this.btnUpdate);
            this.tabPage1.Controls.Add(this.lstCPU);
            this.tabPage1.Controls.Add(this.lstThreads);
            this.tabPage1.Controls.Add(this.lstTasks);
            this.tabPage1.Controls.Add(this.lstIds);
            this.tabPage1.Controls.Add(this.lstProccess);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1454, 584);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Processes";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.NameProcessor);
            this.groupBox1.Controls.Add(this.Threads);
            this.groupBox1.Controls.Add(this.NumberOfLogicalProcessors);
            this.groupBox1.Controls.Add(this.NumberOfCores);
            this.groupBox1.Controls.Add(this.NumberOfEnabledCore);
            this.groupBox1.Location = new System.Drawing.Point(1035, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 541);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "About this system";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tarea1.Properties.Resources.download;
            this.pictureBox1.Location = new System.Drawing.Point(92, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // NameProcessor
            // 
            this.NameProcessor.AutoSize = true;
            this.NameProcessor.Location = new System.Drawing.Point(18, 322);
            this.NameProcessor.Name = "NameProcessor";
            this.NameProcessor.Size = new System.Drawing.Size(44, 16);
            this.NameProcessor.TabIndex = 16;
            this.NameProcessor.Text = "Name";
            // 
            // Threads
            // 
            this.Threads.AutoSize = true;
            this.Threads.Location = new System.Drawing.Point(18, 408);
            this.Threads.Name = "Threads";
            this.Threads.Size = new System.Drawing.Size(58, 16);
            this.Threads.TabIndex = 23;
            this.Threads.Text = "Threads";
            // 
            // NumberOfLogicalProcessors
            // 
            this.NumberOfLogicalProcessors.AutoSize = true;
            this.NumberOfLogicalProcessors.Location = new System.Drawing.Point(18, 492);
            this.NumberOfLogicalProcessors.Name = "NumberOfLogicalProcessors";
            this.NumberOfLogicalProcessors.Size = new System.Drawing.Size(72, 16);
            this.NumberOfLogicalProcessors.TabIndex = 22;
            this.NumberOfLogicalProcessors.Text = "Processes";
            // 
            // NumberOfCores
            // 
            this.NumberOfCores.AutoSize = true;
            this.NumberOfCores.Location = new System.Drawing.Point(18, 368);
            this.NumberOfCores.Name = "NumberOfCores";
            this.NumberOfCores.Size = new System.Drawing.Size(46, 16);
            this.NumberOfCores.TabIndex = 20;
            this.NumberOfCores.Text = "Cores:";
            // 
            // NumberOfEnabledCore
            // 
            this.NumberOfEnabledCore.AutoSize = true;
            this.NumberOfEnabledCore.Location = new System.Drawing.Point(18, 447);
            this.NumberOfEnabledCore.Name = "NumberOfEnabledCore";
            this.NumberOfEnabledCore.Size = new System.Drawing.Size(93, 16);
            this.NumberOfEnabledCore.TabIndex = 21;
            this.NumberOfEnabledCore.Text = "Enabled Core:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(769, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 16);
            this.label11.TabIndex = 14;
            this.label11.Text = "Threads";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(302, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Process";
            // 
            // labelProccessCount
            // 
            this.labelProccessCount.AutoSize = true;
            this.labelProccessCount.Location = new System.Drawing.Point(6, 564);
            this.labelProccessCount.Name = "labelProccessCount";
            this.labelProccessCount.Size = new System.Drawing.Size(44, 16);
            this.labelProccessCount.TabIndex = 9;
            this.labelProccessCount.Text = "label1";
            this.labelProccessCount.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(869, 535);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(140, 36);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnKill
            // 
            this.btnKill.Location = new System.Drawing.Point(677, 535);
            this.btnKill.Name = "btnKill";
            this.btnKill.Size = new System.Drawing.Size(140, 36);
            this.btnKill.TabIndex = 6;
            this.btnKill.Text = "End Task";
            this.btnKill.UseVisualStyleBackColor = true;
            this.btnKill.Click += new System.EventHandler(this.btnKill_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(501, 535);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(139, 36);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Refresh";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lstCPU
            // 
            this.lstCPU.FormattingEnabled = true;
            this.lstCPU.ItemHeight = 16;
            this.lstCPU.Location = new System.Drawing.Point(388, 40);
            this.lstCPU.Name = "lstCPU";
            this.lstCPU.Size = new System.Drawing.Size(10, 4);
            this.lstCPU.TabIndex = 4;
            this.lstCPU.Visible = false;
            // 
            // lstThreads
            // 
            this.lstThreads.FormattingEnabled = true;
            this.lstThreads.ItemHeight = 16;
            this.lstThreads.Location = new System.Drawing.Point(721, 73);
            this.lstThreads.Name = "lstThreads";
            this.lstThreads.Size = new System.Drawing.Size(155, 452);
            this.lstThreads.TabIndex = 3;
            // 
            // lstTasks
            // 
            this.lstTasks.FormattingEnabled = true;
            this.lstTasks.ItemHeight = 16;
            this.lstTasks.Location = new System.Drawing.Point(71, 30);
            this.lstTasks.Name = "lstTasks";
            this.lstTasks.Size = new System.Drawing.Size(15, 4);
            this.lstTasks.TabIndex = 2;
            this.lstTasks.Visible = false;
            // 
            // lstIds
            // 
            this.lstIds.FormattingEnabled = true;
            this.lstIds.ItemHeight = 16;
            this.lstIds.Location = new System.Drawing.Point(26, 30);
            this.lstIds.Name = "lstIds";
            this.lstIds.Size = new System.Drawing.Size(10, 4);
            this.lstIds.TabIndex = 1;
            this.lstIds.Visible = false;
            // 
            // lstProccess
            // 
            this.lstProccess.FormattingEnabled = true;
            this.lstProccess.ItemHeight = 16;
            this.lstProccess.Location = new System.Drawing.Point(26, 73);
            this.lstProccess.Name = "lstProccess";
            this.lstProccess.Size = new System.Drawing.Size(651, 452);
            this.lstProccess.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(630, -16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 16);
            this.label12.TabIndex = 15;
            this.label12.Text = "CPU";
            this.label12.Visible = false;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(607, -16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 16);
            this.label10.TabIndex = 13;
            this.label10.Text = "Tasks";
            this.label10.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(8, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1462, 613);
            this.tabControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1471, 632);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label NameProcessor;
        private System.Windows.Forms.Label Threads;
        private System.Windows.Forms.Label NumberOfLogicalProcessors;
        private System.Windows.Forms.Label NumberOfCores;
        private System.Windows.Forms.Label NumberOfEnabledCore;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelProccessCount;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnKill;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ListBox lstCPU;
        private System.Windows.Forms.ListBox lstThreads;
        private System.Windows.Forms.ListBox lstTasks;
        private System.Windows.Forms.ListBox lstIds;
        private System.Windows.Forms.ListBox lstProccess;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

