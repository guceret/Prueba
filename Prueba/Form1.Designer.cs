namespace Prueba
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
            this.sendMeals = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lunchMeal = new System.Windows.Forms.TextBox();
            this.breakfastMeal = new System.Windows.Forms.TextBox();
            this.dinnerMeal = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ToDo = new System.Windows.Forms.Button();
            this.nameDocComida = new System.Windows.Forms.TextBox();
            this.openDocComida = new System.Windows.Forms.Button();
            this.dataComidas = new System.Windows.Forms.TextBox();
            this.timeToilet = new System.Windows.Forms.TextBox();
            this.timeSpent1 = new System.Windows.Forms.Label();
            this.timeStamp1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGastos = new System.Windows.Forms.TextBox();
            this.value = new System.Windows.Forms.TextBox();
            this.openDocGastos = new System.Windows.Forms.Button();
            this.nameDocGastos = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.descriptionGasto = new System.Windows.Forms.TextBox();
            this.typeSpenditure = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.caus = new System.Windows.Forms.RadioButton();
            this.cred = new System.Windows.Forms.RadioButton();
            this.pana = new System.Windows.Forms.RadioButton();
            this.cash = new System.Windows.Forms.RadioButton();
            this.gift = new System.Windows.Forms.RadioButton();
            this.bwest = new System.Windows.Forms.RadioButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // sendMeals
            // 
            this.sendMeals.Location = new System.Drawing.Point(68, 242);
            this.sendMeals.Name = "sendMeals";
            this.sendMeals.Size = new System.Drawing.Size(100, 23);
            this.sendMeals.TabIndex = 7;
            this.sendMeals.Text = "Write File";
            this.sendMeals.UseVisualStyleBackColor = true;
            this.sendMeals.Click += new System.EventHandler(this.sendMeals_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Breakfast:";
            // 
            // lunchMeal
            // 
            this.lunchMeal.Location = new System.Drawing.Point(68, 140);
            this.lunchMeal.Name = "lunchMeal";
            this.lunchMeal.Size = new System.Drawing.Size(217, 20);
            this.lunchMeal.TabIndex = 3;
            this.lunchMeal.TextChanged += new System.EventHandler(this.lunch_TextChanged);
            // 
            // breakfastMeal
            // 
            this.breakfastMeal.Location = new System.Drawing.Point(68, 80);
            this.breakfastMeal.Name = "breakfastMeal";
            this.breakfastMeal.Size = new System.Drawing.Size(217, 20);
            this.breakfastMeal.TabIndex = 2;
            this.breakfastMeal.TextChanged += new System.EventHandler(this.breakfast_TextChanged);
            // 
            // dinnerMeal
            // 
            this.dinnerMeal.Location = new System.Drawing.Point(68, 189);
            this.dinnerMeal.Name = "dinnerMeal";
            this.dinnerMeal.Size = new System.Drawing.Size(217, 20);
            this.dinnerMeal.TabIndex = 4;
            this.dinnerMeal.TextChanged += new System.EventHandler(this.dinner_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(600, 400);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ToDo);
            this.tabPage1.Controls.Add(this.nameDocComida);
            this.tabPage1.Controls.Add(this.openDocComida);
            this.tabPage1.Controls.Add(this.dataComidas);
            this.tabPage1.Controls.Add(this.timeToilet);
            this.tabPage1.Controls.Add(this.timeSpent1);
            this.tabPage1.Controls.Add(this.timeStamp1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.sendMeals);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.lunchMeal);
            this.tabPage1.Controls.Add(this.dinnerMeal);
            this.tabPage1.Controls.Add(this.breakfastMeal);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(592, 374);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ToDo
            // 
            this.ToDo.Location = new System.Drawing.Point(406, 27);
            this.ToDo.Name = "ToDo";
            this.ToDo.Size = new System.Drawing.Size(75, 23);
            this.ToDo.TabIndex = 11;
            this.ToDo.Text = "ToDo";
            this.ToDo.UseVisualStyleBackColor = true;
            this.ToDo.Click += new System.EventHandler(this.ToDo_Click);
            // 
            // nameDocComida
            // 
            this.nameDocComida.Location = new System.Drawing.Point(68, 348);
            this.nameDocComida.Name = "nameDocComida";
            this.nameDocComida.Size = new System.Drawing.Size(414, 20);
            this.nameDocComida.TabIndex = 10;
            // 
            // openDocComida
            // 
            this.openDocComida.Location = new System.Drawing.Point(491, 345);
            this.openDocComida.Name = "openDocComida";
            this.openDocComida.Size = new System.Drawing.Size(75, 23);
            this.openDocComida.TabIndex = 6;
            this.openDocComida.Text = "Open File";
            this.openDocComida.UseVisualStyleBackColor = true;
            this.openDocComida.Click += new System.EventHandler(this.openDocComida_Click);
            // 
            // dataComidas
            // 
            this.dataComidas.Enabled = false;
            this.dataComidas.Location = new System.Drawing.Point(382, 189);
            this.dataComidas.Multiline = true;
            this.dataComidas.Name = "dataComidas";
            this.dataComidas.Size = new System.Drawing.Size(184, 130);
            this.dataComidas.TabIndex = 8;
            this.dataComidas.TabStop = false;
            // 
            // timeToilet
            // 
            this.timeToilet.Location = new System.Drawing.Point(382, 80);
            this.timeToilet.Multiline = true;
            this.timeToilet.Name = "timeToilet";
            this.timeToilet.Size = new System.Drawing.Size(100, 80);
            this.timeToilet.TabIndex = 5;
            this.timeToilet.TextChanged += new System.EventHandler(this.timeToilet_TextChanged);
            // 
            // timeSpent1
            // 
            this.timeSpent1.AutoSize = true;
            this.timeSpent1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeSpent1.Location = new System.Drawing.Point(65, 41);
            this.timeSpent1.Name = "timeSpent1";
            this.timeSpent1.Size = new System.Drawing.Size(45, 16);
            this.timeSpent1.TabIndex = 6;
            this.timeSpent1.Text = "label5";
            // 
            // timeStamp1
            // 
            this.timeStamp1.AutoSize = true;
            this.timeStamp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeStamp1.Location = new System.Drawing.Point(65, 18);
            this.timeStamp1.Name = "timeStamp1";
            this.timeStamp1.Size = new System.Drawing.Size(45, 16);
            this.timeStamp1.TabIndex = 5;
            this.timeStamp1.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dinner:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lunch:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGastos);
            this.tabPage2.Controls.Add(this.value);
            this.tabPage2.Controls.Add(this.openDocGastos);
            this.tabPage2.Controls.Add(this.nameDocGastos);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.descriptionGasto);
            this.tabPage2.Controls.Add(this.typeSpenditure);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(592, 374);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGastos
            // 
            this.dataGastos.Enabled = false;
            this.dataGastos.Location = new System.Drawing.Point(69, 217);
            this.dataGastos.Multiline = true;
            this.dataGastos.Name = "dataGastos";
            this.dataGastos.Size = new System.Drawing.Size(496, 122);
            this.dataGastos.TabIndex = 9;
            // 
            // value
            // 
            this.value.Location = new System.Drawing.Point(69, 55);
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(100, 20);
            this.value.TabIndex = 8;
            // 
            // openDocGastos
            // 
            this.openDocGastos.Location = new System.Drawing.Point(503, 345);
            this.openDocGastos.Name = "openDocGastos";
            this.openDocGastos.Size = new System.Drawing.Size(83, 23);
            this.openDocGastos.TabIndex = 7;
            this.openDocGastos.Text = "Open File";
            this.openDocGastos.UseVisualStyleBackColor = true;
            this.openDocGastos.Click += new System.EventHandler(this.openDocGastos_Click);
            // 
            // nameDocGastos
            // 
            this.nameDocGastos.Location = new System.Drawing.Point(69, 348);
            this.nameDocGastos.Name = "nameDocGastos";
            this.nameDocGastos.Size = new System.Drawing.Size(427, 20);
            this.nameDocGastos.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "label4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Value: ";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(69, 159);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 3;
            // 
            // descriptionGasto
            // 
            this.descriptionGasto.Location = new System.Drawing.Point(69, 107);
            this.descriptionGasto.Name = "descriptionGasto";
            this.descriptionGasto.Size = new System.Drawing.Size(279, 20);
            this.descriptionGasto.TabIndex = 3;
            // 
            // typeSpenditure
            // 
            this.typeSpenditure.FormattingEnabled = true;
            this.typeSpenditure.Location = new System.Drawing.Point(227, 55);
            this.typeSpenditure.Name = "typeSpenditure";
            this.typeSpenditure.Size = new System.Drawing.Size(121, 21);
            this.typeSpenditure.TabIndex = 2;
            this.typeSpenditure.SelectedIndexChanged += new System.EventHandler(this.typeSpenditure_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.caus);
            this.panel1.Controls.Add(this.cred);
            this.panel1.Controls.Add(this.pana);
            this.panel1.Controls.Add(this.cash);
            this.panel1.Controls.Add(this.gift);
            this.panel1.Controls.Add(this.bwest);
            this.panel1.Location = new System.Drawing.Point(401, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 106);
            this.panel1.TabIndex = 1;
            // 
            // caus
            // 
            this.caus.AutoSize = true;
            this.caus.Location = new System.Drawing.Point(3, 9);
            this.caus.Name = "caus";
            this.caus.Size = new System.Drawing.Size(54, 17);
            this.caus.TabIndex = 0;
            this.caus.TabStop = true;
            this.caus.Text = "CAUS";
            this.caus.UseVisualStyleBackColor = true;
            // 
            // cred
            // 
            this.cred.AutoSize = true;
            this.cred.Location = new System.Drawing.Point(100, 46);
            this.cred.Name = "cred";
            this.cred.Size = new System.Drawing.Size(55, 17);
            this.cred.TabIndex = 0;
            this.cred.TabStop = true;
            this.cred.Text = "CRED";
            this.cred.UseVisualStyleBackColor = true;
            // 
            // pana
            // 
            this.pana.AutoSize = true;
            this.pana.Location = new System.Drawing.Point(100, 81);
            this.pana.Name = "pana";
            this.pana.Size = new System.Drawing.Size(54, 17);
            this.pana.TabIndex = 0;
            this.pana.TabStop = true;
            this.pana.Text = "PANA";
            this.pana.UseVisualStyleBackColor = true;
            // 
            // cash
            // 
            this.cash.AutoSize = true;
            this.cash.Location = new System.Drawing.Point(100, 9);
            this.cash.Name = "cash";
            this.cash.Size = new System.Drawing.Size(54, 17);
            this.cash.TabIndex = 0;
            this.cash.TabStop = true;
            this.cash.Text = "CASH";
            this.cash.UseVisualStyleBackColor = true;
            // 
            // gift
            // 
            this.gift.AutoSize = true;
            this.gift.Location = new System.Drawing.Point(3, 81);
            this.gift.Name = "gift";
            this.gift.Size = new System.Drawing.Size(49, 17);
            this.gift.TabIndex = 0;
            this.gift.TabStop = true;
            this.gift.Text = "GIFT";
            this.gift.UseVisualStyleBackColor = true;
            // 
            // bwest
            // 
            this.bwest.AutoSize = true;
            this.bwest.Location = new System.Drawing.Point(3, 46);
            this.bwest.Name = "bwest";
            this.bwest.Size = new System.Drawing.Size(64, 17);
            this.bwest.TabIndex = 0;
            this.bwest.TabStop = true;
            this.bwest.Text = "BWEST";
            this.bwest.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.textBox6);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(592, 374);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(376, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(467, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(206, 317);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(148, 99);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sendMeals;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lunchMeal;
        private System.Windows.Forms.TextBox breakfastMeal;
        private System.Windows.Forms.TextBox dinnerMeal;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton caus;
        private System.Windows.Forms.RadioButton cred;
        private System.Windows.Forms.RadioButton pana;
        private System.Windows.Forms.RadioButton cash;
        private System.Windows.Forms.RadioButton gift;
        private System.Windows.Forms.RadioButton bwest;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox descriptionGasto;
        private System.Windows.Forms.ComboBox typeSpenditure;
        private System.Windows.Forms.Label timeSpent1;
        private System.Windows.Forms.Label timeStamp1;
        private System.Windows.Forms.TextBox timeToilet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dataComidas;
        private System.Windows.Forms.Button openDocComida;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button openDocGastos;
        private System.Windows.Forms.TextBox nameDocGastos;
        private System.Windows.Forms.TextBox nameDocComida;
        private System.Windows.Forms.TextBox value;
        private System.Windows.Forms.TextBox dataGastos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button ToDo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

