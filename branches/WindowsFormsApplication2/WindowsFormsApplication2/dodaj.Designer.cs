namespace WindowsFormsApplication2
{
    partial class dodaj
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
            this.IDserw_BX = new System.Windows.Forms.TextBox();
            this.IDklient_BX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.marka_BX = new System.Windows.Forms.TextBox();
            this.model_BX = new System.Windows.Forms.TextBox();
            this.rocznik_BX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.vin_BX = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.teroc_BX = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.opis_BX = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.monthCalendar5 = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // IDserw_BX
            // 
            this.IDserw_BX.Location = new System.Drawing.Point(152, 26);
            this.IDserw_BX.Name = "IDserw_BX";
            this.IDserw_BX.Size = new System.Drawing.Size(175, 20);
            this.IDserw_BX.TabIndex = 0;
            // 
            // IDklient_BX
            // 
            this.IDklient_BX.Location = new System.Drawing.Point(152, 52);
            this.IDklient_BX.Name = "IDklient_BX";
            this.IDklient_BX.Size = new System.Drawing.Size(175, 20);
            this.IDklient_BX.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID serwisanta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID klienta";
            // 
            // marka_BX
            // 
            this.marka_BX.Location = new System.Drawing.Point(15, 100);
            this.marka_BX.Name = "marka_BX";
            this.marka_BX.Size = new System.Drawing.Size(100, 20);
            this.marka_BX.TabIndex = 4;
            // 
            // model_BX
            // 
            this.model_BX.Location = new System.Drawing.Point(121, 100);
            this.model_BX.Name = "model_BX";
            this.model_BX.Size = new System.Drawing.Size(100, 20);
            this.model_BX.TabIndex = 5;
            // 
            // rocznik_BX
            // 
            this.rocznik_BX.Location = new System.Drawing.Point(227, 100);
            this.rocznik_BX.Name = "rocznik_BX";
            this.rocznik_BX.Size = new System.Drawing.Size(100, 20);
            this.rocznik_BX.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Marka";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Model";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Rocznik";
            // 
            // vin_BX
            // 
            this.vin_BX.Location = new System.Drawing.Point(152, 150);
            this.vin_BX.Name = "vin_BX";
            this.vin_BX.Size = new System.Drawing.Size(174, 20);
            this.vin_BX.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Numer VIN pojazdu";
            // 
            // teroc_BX
            // 
            this.teroc_BX.Location = new System.Drawing.Point(152, 187);
            this.teroc_BX.Name = "teroc_BX";
            this.teroc_BX.Size = new System.Drawing.Size(175, 20);
            this.teroc_BX.TabIndex = 13;
            this.teroc_BX.Click += new System.EventHandler(this.teroc_BX_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Termin OC";
            // 
            // opis_BX
            // 
            this.opis_BX.Location = new System.Drawing.Point(121, 228);
            this.opis_BX.Multiline = true;
            this.opis_BX.Name = "opis_BX";
            this.opis_BX.Size = new System.Drawing.Size(206, 93);
            this.opis_BX.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 270);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Opis zdarzenia";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(121, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.TabIndex = 20;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(163, 202);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 21;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.monthCalendar1_MouseUp);
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(163, 228);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 22;
            this.monthCalendar2.Visible = false;
            this.monthCalendar2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.monthCalendar2_MouseUp);
            // 
            // monthCalendar5
            // 
            this.monthCalendar5.Location = new System.Drawing.Point(163, 333);
            this.monthCalendar5.Name = "monthCalendar5";
            this.monthCalendar5.TabIndex = 33;
            this.monthCalendar5.Visible = false;
            this.monthCalendar5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.monthCalendar5_MouseUp);
            // 
            // dodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 408);
            this.Controls.Add(this.monthCalendar5);
            this.Controls.Add(this.monthCalendar2);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.opis_BX);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.teroc_BX);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.vin_BX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rocznik_BX);
            this.Controls.Add(this.model_BX);
            this.Controls.Add(this.marka_BX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDklient_BX);
            this.Controls.Add(this.IDserw_BX);
            this.Name = "dodaj";
            this.Text = "Dodawanie zdarzenia";
            this.Load += new System.EventHandler(this.dodaj_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IDserw_BX;
        private System.Windows.Forms.TextBox IDklient_BX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox marka_BX;
        private System.Windows.Forms.TextBox model_BX;
        private System.Windows.Forms.TextBox rocznik_BX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox vin_BX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox teroc_BX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox opis_BX;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.MonthCalendar monthCalendar5;
    }
}