namespace DLogExport
{
    partial class mainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainform));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progress = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lb_progress_text = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gb_org = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.NumericUpDown();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gb_dates = new System.Windows.Forms.GroupBox();
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_begin = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gb_sources = new System.Windows.Forms.GroupBox();
            this.ch_treasure_taler = new System.Windows.Forms.CheckBox();
            this.ch_treasure_money = new System.Windows.Forms.CheckBox();
            this.ch_all_treasure = new System.Windows.Forms.CheckBox();
            this.ch_all_storage = new System.Windows.Forms.CheckBox();
            this.ch_storage_lib = new System.Windows.Forms.CheckBox();
            this.ch_storage_prof = new System.Windows.Forms.CheckBox();
            this.ch_storage_mods = new System.Windows.Forms.CheckBox();
            this.ch_storage_second = new System.Windows.Forms.CheckBox();
            this.ch_storage_main = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gb_control = new System.Windows.Forms.GroupBox();
            this.btn_import = new System.Windows.Forms.Button();
            this.bgw_download = new System.ComponentModel.BackgroundWorker();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lb_createreport = new System.Windows.Forms.ToolStripStatusLabel();
            this.bgw_report = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gb_org.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_id)).BeginInit();
            this.panel2.SuspendLayout();
            this.gb_dates.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gb_sources.SuspendLayout();
            this.panel4.SuspendLayout();
            this.gb_control.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progress,
            this.toolStripStatusLabel1,
            this.lb_progress_text,
            this.toolStripStatusLabel2,
            this.lb_createreport});
            this.statusStrip1.Location = new System.Drawing.Point(0, 439);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(352, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // progress
            // 
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // lb_progress_text
            // 
            this.lb_progress_text.Name = "lb_progress_text";
            this.lb_progress_text.Size = new System.Drawing.Size(0, 17);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gb_org);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 98);
            this.panel1.TabIndex = 1;
            // 
            // gb_org
            // 
            this.gb_org.Controls.Add(this.label2);
            this.gb_org.Controls.Add(this.tb_id);
            this.gb_org.Controls.Add(this.tb_pass);
            this.gb_org.Controls.Add(this.label1);
            this.gb_org.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_org.Location = new System.Drawing.Point(0, 0);
            this.gb_org.Margin = new System.Windows.Forms.Padding(4);
            this.gb_org.Name = "gb_org";
            this.gb_org.Padding = new System.Windows.Forms.Padding(4);
            this.gb_org.Size = new System.Drawing.Size(352, 98);
            this.gb_org.TabIndex = 0;
            this.gb_org.TabStop = false;
            this.gb_org.Text = "Организация";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Пароль";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(128, 26);
            this.tb_id.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(212, 22);
            this.tb_id.TabIndex = 10;
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(128, 57);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(212, 22);
            this.tb_pass.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID организации";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gb_dates);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(352, 90);
            this.panel2.TabIndex = 2;
            // 
            // gb_dates
            // 
            this.gb_dates.Controls.Add(this.dtp_end);
            this.gb_dates.Controls.Add(this.label4);
            this.gb_dates.Controls.Add(this.label3);
            this.gb_dates.Controls.Add(this.dtp_begin);
            this.gb_dates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_dates.Location = new System.Drawing.Point(0, 0);
            this.gb_dates.Name = "gb_dates";
            this.gb_dates.Size = new System.Drawing.Size(352, 90);
            this.gb_dates.TabIndex = 0;
            this.gb_dates.TabStop = false;
            this.gb_dates.Text = "Даты";
            // 
            // dtp_end
            // 
            this.dtp_end.Location = new System.Drawing.Point(128, 54);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(212, 22);
            this.dtp_end.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Окончание";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Начало";
            // 
            // dtp_begin
            // 
            this.dtp_begin.Location = new System.Drawing.Point(128, 22);
            this.dtp_begin.Name = "dtp_begin";
            this.dtp_begin.Size = new System.Drawing.Size(212, 22);
            this.dtp_begin.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gb_sources);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 188);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(352, 193);
            this.panel3.TabIndex = 3;
            // 
            // gb_sources
            // 
            this.gb_sources.Controls.Add(this.ch_treasure_taler);
            this.gb_sources.Controls.Add(this.ch_treasure_money);
            this.gb_sources.Controls.Add(this.ch_all_treasure);
            this.gb_sources.Controls.Add(this.ch_all_storage);
            this.gb_sources.Controls.Add(this.ch_storage_lib);
            this.gb_sources.Controls.Add(this.ch_storage_prof);
            this.gb_sources.Controls.Add(this.ch_storage_mods);
            this.gb_sources.Controls.Add(this.ch_storage_second);
            this.gb_sources.Controls.Add(this.ch_storage_main);
            this.gb_sources.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_sources.Location = new System.Drawing.Point(0, 0);
            this.gb_sources.Name = "gb_sources";
            this.gb_sources.Size = new System.Drawing.Size(352, 193);
            this.gb_sources.TabIndex = 0;
            this.gb_sources.TabStop = false;
            this.gb_sources.Text = "Источники";
            // 
            // ch_treasure_taler
            // 
            this.ch_treasure_taler.AutoSize = true;
            this.ch_treasure_taler.Location = new System.Drawing.Point(247, 84);
            this.ch_treasure_taler.Name = "ch_treasure_taler";
            this.ch_treasure_taler.Size = new System.Drawing.Size(65, 17);
            this.ch_treasure_taler.TabIndex = 9;
            this.ch_treasure_taler.Text = "Талеры";
            this.ch_treasure_taler.UseVisualStyleBackColor = true;
            this.ch_treasure_taler.CheckedChanged += new System.EventHandler(this.ChTreasureTalerCheckedChanged);
            // 
            // ch_treasure_money
            // 
            this.ch_treasure_money.AutoSize = true;
            this.ch_treasure_money.Location = new System.Drawing.Point(247, 58);
            this.ch_treasure_money.Name = "ch_treasure_money";
            this.ch_treasure_money.Size = new System.Drawing.Size(56, 17);
            this.ch_treasure_money.TabIndex = 8;
            this.ch_treasure_money.Text = "Рубли";
            this.ch_treasure_money.UseVisualStyleBackColor = true;
            this.ch_treasure_money.CheckedChanged += new System.EventHandler(this.ChTreasureTalerCheckedChanged);
            // 
            // ch_all_treasure
            // 
            this.ch_all_treasure.AutoSize = true;
            this.ch_all_treasure.Location = new System.Drawing.Point(226, 28);
            this.ch_all_treasure.Name = "ch_all_treasure";
            this.ch_all_treasure.Size = new System.Drawing.Size(57, 17);
            this.ch_all_treasure.TabIndex = 7;
            this.ch_all_treasure.Text = "Казна";
            this.ch_all_treasure.UseVisualStyleBackColor = true;
            this.ch_all_treasure.CheckedChanged += new System.EventHandler(this.ChAllTreasureCheckedChanged);
            // 
            // ch_all_storage
            // 
            this.ch_all_storage.Location = new System.Drawing.Point(20, 28);
            this.ch_all_storage.Name = "ch_all_storage";
            this.ch_all_storage.Size = new System.Drawing.Size(67, 20);
            this.ch_all_storage.TabIndex = 6;
            this.ch_all_storage.Text = "Склад";
            this.ch_all_storage.UseVisualStyleBackColor = true;
            this.ch_all_storage.CheckedChanged += new System.EventHandler(this.ChAllStorageCheckedChanged);
            // 
            // ch_storage_lib
            // 
            this.ch_storage_lib.AutoSize = true;
            this.ch_storage_lib.Location = new System.Drawing.Point(39, 162);
            this.ch_storage_lib.Name = "ch_storage_lib";
            this.ch_storage_lib.Size = new System.Drawing.Size(86, 17);
            this.ch_storage_lib.TabIndex = 5;
            this.ch_storage_lib.Text = "Библиотека";
            this.ch_storage_lib.UseVisualStyleBackColor = true;
            this.ch_storage_lib.CheckedChanged += new System.EventHandler(this.ChStorageMainCheckedChanged);
            // 
            // ch_storage_prof
            // 
            this.ch_storage_prof.AutoSize = true;
            this.ch_storage_prof.Location = new System.Drawing.Point(39, 136);
            this.ch_storage_prof.Name = "ch_storage_prof";
            this.ch_storage_prof.Size = new System.Drawing.Size(128, 17);
            this.ch_storage_prof.TabIndex = 4;
            this.ch_storage_prof.Text = "Профессиональный";
            this.ch_storage_prof.UseVisualStyleBackColor = true;
            this.ch_storage_prof.CheckedChanged += new System.EventHandler(this.ChStorageMainCheckedChanged);
            // 
            // ch_storage_mods
            // 
            this.ch_storage_mods.AutoSize = true;
            this.ch_storage_mods.Location = new System.Drawing.Point(39, 110);
            this.ch_storage_mods.Name = "ch_storage_mods";
            this.ch_storage_mods.Size = new System.Drawing.Size(104, 17);
            this.ch_storage_mods.TabIndex = 3;
            this.ch_storage_mods.Text = "Модификаторы";
            this.ch_storage_mods.UseVisualStyleBackColor = true;
            this.ch_storage_mods.CheckedChanged += new System.EventHandler(this.ChStorageMainCheckedChanged);
            // 
            // ch_storage_second
            // 
            this.ch_storage_second.AutoSize = true;
            this.ch_storage_second.Location = new System.Drawing.Point(39, 84);
            this.ch_storage_second.Name = "ch_storage_second";
            this.ch_storage_second.Size = new System.Drawing.Size(114, 17);
            this.ch_storage_second.TabIndex = 2;
            this.ch_storage_second.Text = "Дополнительный";
            this.ch_storage_second.UseVisualStyleBackColor = true;
            this.ch_storage_second.CheckedChanged += new System.EventHandler(this.ChStorageMainCheckedChanged);
            // 
            // ch_storage_main
            // 
            this.ch_storage_main.AutoSize = true;
            this.ch_storage_main.Location = new System.Drawing.Point(39, 58);
            this.ch_storage_main.Name = "ch_storage_main";
            this.ch_storage_main.Size = new System.Drawing.Size(70, 17);
            this.ch_storage_main.TabIndex = 1;
            this.ch_storage_main.Text = "Главный";
            this.ch_storage_main.UseVisualStyleBackColor = true;
            this.ch_storage_main.CheckedChanged += new System.EventHandler(this.ChStorageMainCheckedChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.gb_control);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 381);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(352, 58);
            this.panel4.TabIndex = 4;
            // 
            // gb_control
            // 
            this.gb_control.Controls.Add(this.btn_import);
            this.gb_control.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_control.Location = new System.Drawing.Point(0, 0);
            this.gb_control.Name = "gb_control";
            this.gb_control.Size = new System.Drawing.Size(352, 58);
            this.gb_control.TabIndex = 0;
            this.gb_control.TabStop = false;
            // 
            // btn_import
            // 
            this.btn_import.Location = new System.Drawing.Point(39, 21);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(276, 23);
            this.btn_import.TabIndex = 0;
            this.btn_import.Text = "Начать импорт";
            this.btn_import.UseVisualStyleBackColor = true;
            this.btn_import.Click += new System.EventHandler(this.BtnImportClick);
            // 
            // bgw_download
            // 
            this.bgw_download.WorkerReportsProgress = true;
            this.bgw_download.WorkerSupportsCancellation = true;
            this.bgw_download.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgwDoWork);
            this.bgw_download.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BgwProgressChanged);
            this.bgw_download.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BgwRunWorkerCompleted);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(25, 17);
            this.toolStripStatusLabel2.Text = "      ";
            // 
            // lb_createreport
            // 
            this.lb_createreport.Name = "lb_createreport";
            this.lb_createreport.Size = new System.Drawing.Size(142, 17);
            this.lb_createreport.Text = "Формируется файл отчета";
            this.lb_createreport.Visible = false;
            // 
            // bgw_report
            // 
            this.bgw_report.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_report_DoWork);
            this.bgw_report.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_report_RunWorkerCompleted);
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 461);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainform";
            this.Text = "Экспортер логов проекта Dozory.Ru";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.gb_org.ResumeLayout(false);
            this.gb_org.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_id)).EndInit();
            this.panel2.ResumeLayout(false);
            this.gb_dates.ResumeLayout(false);
            this.gb_dates.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.gb_sources.ResumeLayout(false);
            this.gb_sources.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.gb_control.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gb_org;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown tb_id;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox gb_dates;
        private System.Windows.Forms.DateTimePicker dtp_end;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_begin;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox gb_sources;
        private System.Windows.Forms.CheckBox ch_storage_lib;
        private System.Windows.Forms.CheckBox ch_storage_prof;
        private System.Windows.Forms.CheckBox ch_storage_mods;
        private System.Windows.Forms.CheckBox ch_storage_second;
        private System.Windows.Forms.CheckBox ch_storage_main;
        private System.Windows.Forms.CheckBox ch_all_storage;
        private System.Windows.Forms.CheckBox ch_all_treasure;
        private System.Windows.Forms.CheckBox ch_treasure_taler;
        private System.Windows.Forms.CheckBox ch_treasure_money;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox gb_control;
        private System.Windows.Forms.Button btn_import;
        private System.Windows.Forms.ToolStripProgressBar progress;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lb_progress_text;
        private System.ComponentModel.BackgroundWorker bgw_download;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel lb_createreport;
        private System.ComponentModel.BackgroundWorker bgw_report;
    }
}

