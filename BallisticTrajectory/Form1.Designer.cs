namespace BallisticTrajectory
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtBrzina = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUgao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSimulacija = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtVisina = new System.Windows.Forms.TextBox();
            this.txtMasa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTemperatura = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPritisak = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.Tabela = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtKalibar = new System.Windows.Forms.TextBox();
            this.cbxMetak = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnUslovi = new System.Windows.Forms.Button();
            this.cbxVakuum = new System.Windows.Forms.CheckBox();
            this.cbxVazduh = new System.Windows.Forms.CheckBox();
            this.cbxVazduhPC = new System.Windows.Forms.CheckBox();
            this.Tabela1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Grafik1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Grafik = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.txtLoc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.cbxEuler = new System.Windows.Forms.CheckBox();
            this.cbxAdams = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.Tabela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tabela1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grafik1)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grafik)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBrzina
            // 
            this.txtBrzina.Location = new System.Drawing.Point(158, 325);
            this.txtBrzina.Name = "txtBrzina";
            this.txtBrzina.Size = new System.Drawing.Size(100, 20);
            this.txtBrzina.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Početna brzina:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "m/s";
            // 
            // txtUgao
            // 
            this.txtUgao.Location = new System.Drawing.Point(158, 363);
            this.txtUgao.Name = "txtUgao";
            this.txtUgao.Size = new System.Drawing.Size(100, 20);
            this.txtUgao.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ugao:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label6.Location = new System.Drawing.Point(263, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "deg";
            // 
            // btnSimulacija
            // 
            this.btnSimulacija.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimulacija.Location = new System.Drawing.Point(14, 582);
            this.btnSimulacija.Name = "btnSimulacija";
            this.btnSimulacija.Size = new System.Drawing.Size(271, 61);
            this.btnSimulacija.TabIndex = 8;
            this.btnSimulacija.Text = "Pokreni simulaciju";
            this.btnSimulacija.UseVisualStyleBackColor = true;
            this.btnSimulacija.Click += new System.EventHandler(this.btnSimulacija_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(265, 402);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "m";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 402);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Početna visina:";
            // 
            // txtVisina
            // 
            this.txtVisina.Location = new System.Drawing.Point(158, 399);
            this.txtVisina.Name = "txtVisina";
            this.txtVisina.Size = new System.Drawing.Size(100, 20);
            this.txtVisina.TabIndex = 3;
            // 
            // txtMasa
            // 
            this.txtMasa.Location = new System.Drawing.Point(158, 294);
            this.txtMasa.Name = "txtMasa";
            this.txtMasa.Size = new System.Drawing.Size(100, 20);
            this.txtMasa.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Masa projektila:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "g";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(265, 436);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "C";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 436);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Temperatura vazduha:";
            // 
            // txtTemperatura
            // 
            this.txtTemperatura.Location = new System.Drawing.Point(159, 433);
            this.txtTemperatura.Name = "txtTemperatura";
            this.txtTemperatura.Size = new System.Drawing.Size(100, 20);
            this.txtTemperatura.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(264, 466);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "mbar";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 466);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Vazdusni pritisak:";
            // 
            // txtPritisak
            // 
            this.txtPritisak.Location = new System.Drawing.Point(159, 463);
            this.txtPritisak.Name = "txtPritisak";
            this.txtPritisak.Size = new System.Drawing.Size(100, 20);
            this.txtPritisak.TabIndex = 5;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(265, 496);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(20, 13);
            this.label16.TabIndex = 31;
            this.label16.Text = "ms";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(15, 496);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 13);
            this.label17.TabIndex = 30;
            this.label17.Text = "Interval (Δt):";
            // 
            // txtInterval
            // 
            this.txtInterval.Location = new System.Drawing.Point(159, 493);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(100, 20);
            this.txtInterval.TabIndex = 6;
            // 
            // Tabela
            // 
            this.Tabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabela.Location = new System.Drawing.Point(324, 12);
            this.Tabela.Name = "Tabela";
            this.Tabela.Size = new System.Drawing.Size(519, 336);
            this.Tabela.TabIndex = 32;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(264, 528);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(23, 13);
            this.label14.TabIndex = 35;
            this.label14.Text = "mm";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 528);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 13);
            this.label15.TabIndex = 34;
            this.label15.Text = "Kalibar:";
            // 
            // txtKalibar
            // 
            this.txtKalibar.Location = new System.Drawing.Point(159, 525);
            this.txtKalibar.Name = "txtKalibar";
            this.txtKalibar.Size = new System.Drawing.Size(100, 20);
            this.txtKalibar.TabIndex = 7;
            // 
            // cbxMetak
            // 
            this.cbxMetak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMetak.FormattingEnabled = true;
            this.cbxMetak.Location = new System.Drawing.Point(14, 25);
            this.cbxMetak.Name = "cbxMetak";
            this.cbxMetak.Size = new System.Drawing.Size(277, 28);
            this.cbxMetak.TabIndex = 36;
            this.cbxMetak.SelectedIndexChanged += new System.EventHandler(this.cbxMetak_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(15, 9);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(73, 13);
            this.label18.TabIndex = 37;
            this.label18.Text = "Izaberi metak:";
            // 
            // btnUslovi
            // 
            this.btnUslovi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUslovi.Location = new System.Drawing.Point(9, 217);
            this.btnUslovi.Name = "btnUslovi";
            this.btnUslovi.Size = new System.Drawing.Size(276, 63);
            this.btnUslovi.TabIndex = 41;
            this.btnUslovi.Text = "Izaberi standardne početne uslove";
            this.btnUslovi.UseVisualStyleBackColor = true;
            this.btnUslovi.Click += new System.EventHandler(this.btnUslovi_Click);
            // 
            // cbxVakuum
            // 
            this.cbxVakuum.AutoSize = true;
            this.cbxVakuum.Location = new System.Drawing.Point(14, 95);
            this.cbxVakuum.Name = "cbxVakuum";
            this.cbxVakuum.Size = new System.Drawing.Size(121, 17);
            this.cbxVakuum.TabIndex = 43;
            this.cbxVakuum.Text = "Putanja u  vakuumu";
            this.cbxVakuum.UseVisualStyleBackColor = true;
            this.cbxVakuum.CheckedChanged += new System.EventHandler(this.cbxVakuum_CheckedChanged);
            // 
            // cbxVazduh
            // 
            this.cbxVazduh.AutoSize = true;
            this.cbxVazduh.Location = new System.Drawing.Point(14, 118);
            this.cbxVazduh.Name = "cbxVazduh";
            this.cbxVazduh.Size = new System.Drawing.Size(115, 17);
            this.cbxVazduh.TabIndex = 44;
            this.cbxVazduh.Text = "Putanja u vazduhu";
            this.cbxVazduh.UseVisualStyleBackColor = true;
            this.cbxVazduh.CheckedChanged += new System.EventHandler(this.cbxVazduh_CheckedChanged);
            // 
            // cbxVazduhPC
            // 
            this.cbxVazduhPC.AutoSize = true;
            this.cbxVazduhPC.Location = new System.Drawing.Point(14, 141);
            this.cbxVazduhPC.Name = "cbxVazduhPC";
            this.cbxVazduhPC.Size = new System.Drawing.Size(207, 17);
            this.cbxVazduhPC.TabIndex = 45;
            this.cbxVazduhPC.Text = "Putanja u vazduhu:  prediktor-korektor";
            this.cbxVazduhPC.UseVisualStyleBackColor = true;
            this.cbxVazduhPC.CheckedChanged += new System.EventHandler(this.cbxVazduhPC_CheckedChanged);
            // 
            // Tabela1
            // 
            this.Tabela1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabela1.Location = new System.Drawing.Point(848, 12);
            this.Tabela1.Name = "Tabela1";
            this.Tabela1.Size = new System.Drawing.Size(336, 218);
            this.Tabela1.TabIndex = 49;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Grafik1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(922, 264);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Grafik brzine";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Grafik1
            // 
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.Name = "ChartArea1";
            this.Grafik1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Grafik1.Legends.Add(legend1);
            this.Grafik1.Location = new System.Drawing.Point(0, 0);
            this.Grafik1.Name = "Grafik1";
            this.Grafik1.Size = new System.Drawing.Size(920, 260);
            this.Grafik1.TabIndex = 46;
            this.Grafik1.Text = "chart1";
            this.Grafik1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Grafik1_MouseMove);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Grafik);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(922, 264);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Grafik pozicije";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Grafik
            // 
            chartArea2.CursorX.IsUserEnabled = true;
            chartArea2.CursorX.IsUserSelectionEnabled = true;
            chartArea2.Name = "ChartArea1";
            this.Grafik.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.Grafik.Legends.Add(legend2);
            this.Grafik.Location = new System.Drawing.Point(3, 3);
            this.Grafik.Name = "Grafik";
            this.Grafik.Size = new System.Drawing.Size(920, 260);
            this.Grafik.TabIndex = 13;
            this.Grafik.Text = "chart1";
            this.Grafik.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Grafik_MouseMove);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(324, 363);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(930, 290);
            this.tabControl1.TabIndex = 47;
            // 
            // txtLoc
            // 
            this.txtLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoc.Location = new System.Drawing.Point(848, 255);
            this.txtLoc.Multiline = true;
            this.txtLoc.Name = "txtLoc";
            this.txtLoc.Size = new System.Drawing.Size(336, 55);
            this.txtLoc.TabIndex = 53;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(872, 239);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(275, 13);
            this.label9.TabIndex = 52;
            this.label9.Text = "Pređite mišem preko linije grafika da biste dobili vrednost:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(11, 63);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(126, 16);
            this.label19.TabIndex = 54;
            this.label19.Text = "Odabir režima rada:";
            // 
            // cbxEuler
            // 
            this.cbxEuler.AutoSize = true;
            this.cbxEuler.Location = new System.Drawing.Point(14, 164);
            this.cbxEuler.Name = "cbxEuler";
            this.cbxEuler.Size = new System.Drawing.Size(192, 17);
            this.cbxEuler.TabIndex = 55;
            this.cbxEuler.Text = "Putanja u vazduhu:  Eulerov metod";
            this.cbxEuler.UseVisualStyleBackColor = true;
            this.cbxEuler.CheckedChanged += new System.EventHandler(this.cbxEuler_CheckedChanged);
            // 
            // cbxAdams
            // 
            this.cbxAdams.AutoSize = true;
            this.cbxAdams.Location = new System.Drawing.Point(14, 187);
            this.cbxAdams.Name = "cbxAdams";
            this.cbxAdams.Size = new System.Drawing.Size(200, 17);
            this.cbxAdams.TabIndex = 56;
            this.cbxAdams.Text = "Putanja u vazduhu:  Adamsov metod";
            this.cbxAdams.UseVisualStyleBackColor = true;
            this.cbxAdams.CheckedChanged += new System.EventHandler(this.cbxAdams_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1268, 659);
            this.Controls.Add(this.cbxAdams);
            this.Controls.Add(this.cbxEuler);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtLoc);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Tabela1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.cbxVazduhPC);
            this.Controls.Add(this.cbxVazduh);
            this.Controls.Add(this.cbxVakuum);
            this.Controls.Add(this.btnUslovi);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.cbxMetak);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtKalibar);
            this.Controls.Add(this.Tabela);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtInterval);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtPritisak);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtTemperatura);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMasa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtVisina);
            this.Controls.Add(this.btnSimulacija);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUgao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBrzina);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Ballistic Simulation";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tabela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tabela1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grafik1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grafik)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBrzina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUgao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSimulacija;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtVisina;
        private System.Windows.Forms.TextBox txtMasa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTemperatura;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPritisak;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtInterval;
        private System.Windows.Forms.DataGridView Tabela;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtKalibar;
        private System.Windows.Forms.ComboBox cbxMetak;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnUslovi;
        private System.Windows.Forms.CheckBox cbxVakuum;
        private System.Windows.Forms.CheckBox cbxVazduh;
        private System.Windows.Forms.CheckBox cbxVazduhPC;
        private System.Windows.Forms.DataGridView Tabela1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart Grafik1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataVisualization.Charting.Chart Grafik;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox txtLoc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.CheckBox cbxEuler;
        private System.Windows.Forms.CheckBox cbxAdams;
    }
}

