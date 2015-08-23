using System.Security.AccessControl;

namespace lizingas_v2
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
            this.label3 = new System.Windows.Forms.Label();
            this.ToCredit_Label = new System.Windows.Forms.Label();
            this.ToAlive_Label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Liabilities_TextBox = new System.Windows.Forms.TextBox();
            this.Income_TextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.leasPayment = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.admMokestis = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Automobiliokaina = new System.Windows.Forms.Label();
            this.Pradineimoka = new System.Windows.Forms.Label();
            this.Palukanunorma = new System.Windows.Forms.Label();
            this.Lizingoterminas = new System.Windows.Forms.Label();
            this.priceCar = new System.Windows.Forms.NumericUpDown();
            this.firstIncome = new System.Windows.Forms.NumericUpDown();
            this.interestRate = new System.Windows.Forms.NumericUpDown();
            this.leasTerm = new System.Windows.Forms.NumericUpDown();
            this.Price_Lt = new System.Windows.Forms.Label();
            this.PayText_Label = new System.Windows.Forms.Label();
            this.PercentText_Label = new System.Windows.Forms.Label();
            this.monthText_label = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ResidualValue_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.LT_radioButton = new System.Windows.Forms.RadioButton();
            this.EUR_radioButton = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Finansinislizingassulikutineverte = new System.Windows.Forms.RadioButton();
            this.Finansinislizingas = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstIncome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interestRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leasTerm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResidualValue_numericUpDown)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Grynosios šeimos mėnesio pajamos, Lt";
            // 
            // ToCredit_Label
            // 
            this.ToCredit_Label.AutoSize = true;
            this.ToCredit_Label.Location = new System.Drawing.Point(355, 23);
            this.ToCredit_Label.Name = "ToCredit_Label";
            this.ToCredit_Label.Size = new System.Drawing.Size(10, 13);
            this.ToCredit_Label.TabIndex = 14;
            this.ToCredit_Label.Text = "-";
            // 
            // ToAlive_Label
            // 
            this.ToAlive_Label.AutoSize = true;
            this.ToAlive_Label.Location = new System.Drawing.Point(355, 46);
            this.ToAlive_Label.Name = "ToAlive_Label";
            this.ToAlive_Label.Size = new System.Drawing.Size(10, 13);
            this.ToAlive_Label.TabIndex = 13;
            this.ToAlive_Label.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Per mėnesį Jūsų šeimai pragyvenimui liekanti pajamų dalis";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Šeimos mėnesinių pajamų dalis, kurią galėtumėte skirti lizingo įmokai";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Finansiniai įsipareigojimai, Lt";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Vilnius",
            "Kaunas",
            "Klaipėda",
            "Šiauliai",
            "Panevėžys",
            "Kiti",
            "Užsienis"});
            this.comboBox1.Location = new System.Drawing.Point(233, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(133, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gyvenamoji vieta";
            // 
            // Liabilities_TextBox
            // 
            this.Liabilities_TextBox.Location = new System.Drawing.Point(233, 32);
            this.Liabilities_TextBox.Name = "Liabilities_TextBox";
            this.Liabilities_TextBox.Size = new System.Drawing.Size(133, 20);
            this.Liabilities_TextBox.TabIndex = 8;
            this.Liabilities_TextBox.TextChanged += new System.EventHandler(this.Liabilities_TextChanged);
            // 
            // Income_TextBox
            // 
            this.Income_TextBox.Location = new System.Drawing.Point(233, 9);
            this.Income_TextBox.Name = "Income_TextBox";
            this.Income_TextBox.Size = new System.Drawing.Size(133, 20);
            this.Income_TextBox.TabIndex = 2;
            this.Income_TextBox.TextChanged += new System.EventHandler(this.Income_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.Liabilities_TextBox);
            this.panel2.Controls.Add(this.Income_TextBox);
            this.panel2.Location = new System.Drawing.Point(12, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(907, 84);
            this.panel2.TabIndex = 13;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ToCredit_Label);
            this.groupBox3.Controls.Add(this.ToAlive_Label);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(385, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(497, 72);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Apskaičiuotos likutinės pajamos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Sutarties administravimo mokestis:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(111, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Lizingo įmoka:";
            // 
            // leasPayment
            // 
            this.leasPayment.AutoSize = true;
            this.leasPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.leasPayment.Location = new System.Drawing.Point(187, 93);
            this.leasPayment.Name = "leasPayment";
            this.leasPayment.Size = new System.Drawing.Size(16, 24);
            this.leasPayment.TabIndex = 17;
            this.leasPayment.Text = "-";
            this.leasPayment.Click += new System.EventHandler(this.leasPayment_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(113, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Bendra suma:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(188, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(10, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "-";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // admMokestis
            // 
            this.admMokestis.AutoSize = true;
            this.admMokestis.Location = new System.Drawing.Point(188, 28);
            this.admMokestis.Name = "admMokestis";
            this.admMokestis.Size = new System.Drawing.Size(10, 13);
            this.admMokestis.TabIndex = 21;
            this.admMokestis.Text = "-";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.admMokestis);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.leasPayment);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(440, 304);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 138);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rezultatai";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.ResidualValue_numericUpDown);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.monthText_label);
            this.groupBox2.Controls.Add(this.PercentText_Label);
            this.groupBox2.Controls.Add(this.PayText_Label);
            this.groupBox2.Controls.Add(this.Price_Lt);
            this.groupBox2.Controls.Add(this.leasTerm);
            this.groupBox2.Controls.Add(this.interestRate);
            this.groupBox2.Controls.Add(this.firstIncome);
            this.groupBox2.Controls.Add(this.priceCar);
            this.groupBox2.Controls.Add(this.Lizingoterminas);
            this.groupBox2.Controls.Add(this.Palukanunorma);
            this.groupBox2.Controls.Add(this.Pradineimoka);
            this.groupBox2.Controls.Add(this.Automobiliokaina);
            this.groupBox2.Location = new System.Drawing.Point(397, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(295, 185);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Įvestys";
            // 
            // Automobiliokaina
            // 
            this.Automobiliokaina.AutoSize = true;
            this.Automobiliokaina.Location = new System.Drawing.Point(10, 18);
            this.Automobiliokaina.Name = "Automobiliokaina";
            this.Automobiliokaina.Size = new System.Drawing.Size(90, 13);
            this.Automobiliokaina.TabIndex = 17;
            this.Automobiliokaina.Text = "Automobilio kaina";
            // 
            // Pradineimoka
            // 
            this.Pradineimoka.AutoSize = true;
            this.Pradineimoka.Location = new System.Drawing.Point(10, 49);
            this.Pradineimoka.Name = "Pradineimoka";
            this.Pradineimoka.Size = new System.Drawing.Size(74, 13);
            this.Pradineimoka.TabIndex = 19;
            this.Pradineimoka.Text = "Pradinė įmoka";
            // 
            // Palukanunorma
            // 
            this.Palukanunorma.AutoSize = true;
            this.Palukanunorma.Location = new System.Drawing.Point(10, 85);
            this.Palukanunorma.Name = "Palukanunorma";
            this.Palukanunorma.Size = new System.Drawing.Size(84, 13);
            this.Palukanunorma.TabIndex = 20;
            this.Palukanunorma.Text = "Palūkanų norma";
            // 
            // Lizingoterminas
            // 
            this.Lizingoterminas.AutoSize = true;
            this.Lizingoterminas.Location = new System.Drawing.Point(10, 121);
            this.Lizingoterminas.Name = "Lizingoterminas";
            this.Lizingoterminas.Size = new System.Drawing.Size(82, 13);
            this.Lizingoterminas.TabIndex = 21;
            this.Lizingoterminas.Text = "Lizingo terminas";
            // 
            // priceCar
            // 
            this.priceCar.Location = new System.Drawing.Point(123, 10);
            this.priceCar.Maximum = new decimal(new int[] {
            200000,
            0,
            0,
            0});
            this.priceCar.Minimum = new decimal(new int[] {
            12500,
            0,
            0,
            0});
            this.priceCar.Name = "priceCar";
            this.priceCar.Size = new System.Drawing.Size(83, 20);
            this.priceCar.TabIndex = 30;
            this.priceCar.Value = new decimal(new int[] {
            12500,
            0,
            0,
            0});
            this.priceCar.ValueChanged += new System.EventHandler(this.priceCar_ValueChanged);
            // 
            // firstIncome
            // 
            this.firstIncome.Location = new System.Drawing.Point(123, 42);
            this.firstIncome.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.firstIncome.Minimum = new decimal(new int[] {
            1250,
            0,
            0,
            0});
            this.firstIncome.Name = "firstIncome";
            this.firstIncome.Size = new System.Drawing.Size(83, 20);
            this.firstIncome.TabIndex = 31;
            this.firstIncome.Value = new decimal(new int[] {
            1250,
            0,
            0,
            0});
            this.firstIncome.ValueChanged += new System.EventHandler(this.firstIncome_ValueChanged);
            // 
            // interestRate
            // 
            this.interestRate.DecimalPlaces = 1;
            this.interestRate.Location = new System.Drawing.Point(123, 78);
            this.interestRate.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.interestRate.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.interestRate.Name = "interestRate";
            this.interestRate.Size = new System.Drawing.Size(83, 20);
            this.interestRate.TabIndex = 32;
            this.interestRate.Value = new decimal(new int[] {
            33,
            0,
            0,
            65536});
            this.interestRate.ValueChanged += new System.EventHandler(this.interestRate_ValueChanged);
            // 
            // leasTerm
            // 
            this.leasTerm.Location = new System.Drawing.Point(123, 114);
            this.leasTerm.Maximum = new decimal(new int[] {
            84,
            0,
            0,
            0});
            this.leasTerm.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.leasTerm.Name = "leasTerm";
            this.leasTerm.Size = new System.Drawing.Size(83, 20);
            this.leasTerm.TabIndex = 33;
            this.leasTerm.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.leasTerm.ValueChanged += new System.EventHandler(this.leasTerm_ValueChanged);
            // 
            // Price_Lt
            // 
            this.Price_Lt.AutoSize = true;
            this.Price_Lt.Location = new System.Drawing.Point(213, 17);
            this.Price_Lt.Name = "Price_Lt";
            this.Price_Lt.Size = new System.Drawing.Size(20, 13);
            this.Price_Lt.TabIndex = 34;
            this.Price_Lt.Text = "LT";
            // 
            // PayText_Label
            // 
            this.PayText_Label.AutoSize = true;
            this.PayText_Label.Location = new System.Drawing.Point(213, 49);
            this.PayText_Label.Name = "PayText_Label";
            this.PayText_Label.Size = new System.Drawing.Size(20, 13);
            this.PayText_Label.TabIndex = 35;
            this.PayText_Label.Text = "LT";
            // 
            // PercentText_Label
            // 
            this.PercentText_Label.AutoSize = true;
            this.PercentText_Label.Location = new System.Drawing.Point(213, 85);
            this.PercentText_Label.Name = "PercentText_Label";
            this.PercentText_Label.Size = new System.Drawing.Size(15, 13);
            this.PercentText_Label.TabIndex = 36;
            this.PercentText_Label.Text = "%";
            // 
            // monthText_label
            // 
            this.monthText_label.AutoSize = true;
            this.monthText_label.Location = new System.Drawing.Point(213, 121);
            this.monthText_label.Name = "monthText_label";
            this.monthText_label.Size = new System.Drawing.Size(27, 13);
            this.monthText_label.TabIndex = 37;
            this.monthText_label.Text = "mėn";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "Likutinė Vertė";
            // 
            // ResidualValue_numericUpDown
            // 
            this.ResidualValue_numericUpDown.Enabled = false;
            this.ResidualValue_numericUpDown.Location = new System.Drawing.Point(124, 148);
            this.ResidualValue_numericUpDown.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.ResidualValue_numericUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ResidualValue_numericUpDown.Name = "ResidualValue_numericUpDown";
            this.ResidualValue_numericUpDown.Size = new System.Drawing.Size(83, 20);
            this.ResidualValue_numericUpDown.TabIndex = 34;
            this.ResidualValue_numericUpDown.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.ResidualValue_numericUpDown.ValueChanged += new System.EventHandler(this.ResidualValue_numericUpDown_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(213, 155);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 13);
            this.label12.TabIndex = 37;
            this.label12.Text = "%";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.EUR_radioButton);
            this.groupBox4.Controls.Add(this.LT_radioButton);
            this.groupBox4.Location = new System.Drawing.Point(12, 171);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(306, 55);
            this.groupBox4.TabIndex = 40;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Valiuta";
            // 
            // LT_radioButton
            // 
            this.LT_radioButton.AutoSize = true;
            this.LT_radioButton.Location = new System.Drawing.Point(121, 9);
            this.LT_radioButton.Name = "LT_radioButton";
            this.LT_radioButton.Size = new System.Drawing.Size(38, 17);
            this.LT_radioButton.TabIndex = 22;
            this.LT_radioButton.TabStop = true;
            this.LT_radioButton.Text = "LT";
            this.LT_radioButton.UseVisualStyleBackColor = true;
            this.LT_radioButton.CheckedChanged += new System.EventHandler(this.LT_radioButton_CheckedChanged);
            // 
            // EUR_radioButton
            // 
            this.EUR_radioButton.AutoSize = true;
            this.EUR_radioButton.Location = new System.Drawing.Point(121, 32);
            this.EUR_radioButton.Name = "EUR_radioButton";
            this.EUR_radioButton.Size = new System.Drawing.Size(48, 17);
            this.EUR_radioButton.TabIndex = 39;
            this.EUR_radioButton.TabStop = true;
            this.EUR_radioButton.Text = "EUR";
            this.EUR_radioButton.UseVisualStyleBackColor = true;
            this.EUR_radioButton.CheckedChanged += new System.EventHandler(this.EUR_radioButton_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Finansinislizingas);
            this.groupBox5.Controls.Add(this.Finansinislizingassulikutineverte);
            this.groupBox5.Location = new System.Drawing.Point(12, 113);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(306, 52);
            this.groupBox5.TabIndex = 23;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Mokėjimo tipas";
            // 
            // Finansinislizingassulikutineverte
            // 
            this.Finansinislizingassulikutineverte.AutoSize = true;
            this.Finansinislizingassulikutineverte.Location = new System.Drawing.Point(121, 29);
            this.Finansinislizingassulikutineverte.Name = "Finansinislizingassulikutineverte";
            this.Finansinislizingassulikutineverte.Size = new System.Drawing.Size(185, 17);
            this.Finansinislizingassulikutineverte.TabIndex = 7;
            this.Finansinislizingassulikutineverte.TabStop = true;
            this.Finansinislizingassulikutineverte.Text = "Finansinis lizingas su likutine verte";
            this.Finansinislizingassulikutineverte.UseVisualStyleBackColor = true;
            this.Finansinislizingassulikutineverte.CheckedChanged += new System.EventHandler(this.Finansinislizingassulikutineverte_CheckedChanged);
            // 
            // Finansinislizingas
            // 
            this.Finansinislizingas.AutoSize = true;
            this.Finansinislizingas.Location = new System.Drawing.Point(121, 11);
            this.Finansinislizingas.Name = "Finansinislizingas";
            this.Finansinislizingas.Size = new System.Drawing.Size(108, 17);
            this.Finansinislizingas.TabIndex = 6;
            this.Finansinislizingas.TabStop = true;
            this.Finansinislizingas.Text = "Finansinis lizingas";
            this.Finansinislizingas.UseVisualStyleBackColor = true;
            this.Finansinislizingas.CheckedChanged += new System.EventHandler(this.Finansinislizingas_CheckedChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.radioButton2);
            this.groupBox6.Controls.Add(this.radioButton1);
            this.groupBox6.Location = new System.Drawing.Point(12, 232);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(306, 55);
            this.groupBox6.TabIndex = 23;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Skaičiuoti su draudimu";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(121, 10);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(46, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Taip";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(121, 31);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(39, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Ne";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 660);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.priceCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstIncome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interestRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leasTerm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResidualValue_numericUpDown)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ToCredit_Label;
        private System.Windows.Forms.Label ToAlive_Label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Liabilities_TextBox;
        private System.Windows.Forms.TextBox Income_TextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label leasPayment;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label admMokestis;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown ResidualValue_numericUpDown;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label monthText_label;
        private System.Windows.Forms.Label PercentText_Label;
        private System.Windows.Forms.Label PayText_Label;
        private System.Windows.Forms.Label Price_Lt;
        private System.Windows.Forms.NumericUpDown leasTerm;
        private System.Windows.Forms.NumericUpDown interestRate;
        private System.Windows.Forms.NumericUpDown firstIncome;
        private System.Windows.Forms.NumericUpDown priceCar;
        private System.Windows.Forms.Label Lizingoterminas;
        private System.Windows.Forms.Label Palukanunorma;
        private System.Windows.Forms.Label Pradineimoka;
        private System.Windows.Forms.Label Automobiliokaina;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton EUR_radioButton;
        private System.Windows.Forms.RadioButton LT_radioButton;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton Finansinislizingas;
        private System.Windows.Forms.RadioButton Finansinislizingassulikutineverte;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;

    }
}

