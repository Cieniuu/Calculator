
namespace Kalkulator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bUstawTlo = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bClear = new System.Windows.Forms.Button();
            this.BoxWynik = new System.Windows.Forms.TextBox();
            this.button0 = new System.Windows.Forms.Button();
            this.bWynik = new System.Windows.Forms.Button();
            this.bDziel = new System.Windows.Forms.Button();
            this.bMnoz = new System.Windows.Forms.Button();
            this.bOdej = new System.Windows.Forms.Button();
            this.bDod = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bDot = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bUstawTlo
            // 
            this.bUstawTlo.Location = new System.Drawing.Point(142, 12);
            this.bUstawTlo.Name = "bUstawTlo";
            this.bUstawTlo.Size = new System.Drawing.Size(75, 23);
            this.bUstawTlo.TabIndex = 42;
            this.bUstawTlo.Text = "ustaw tlo";
            this.bUstawTlo.UseVisualStyleBackColor = true;
            this.bUstawTlo.Click += new System.EventHandler(this.bUstawTlo_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Tlo 1",
            "Tlo 2",
            "Tlo 3"});
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 41;
            this.comboBox1.Text = "Wybierz tlo";
            // 
            // bClear
            // 
            this.bClear.Location = new System.Drawing.Point(225, 56);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(67, 23);
            this.bClear.TabIndex = 39;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // BoxWynik
            // 
            this.BoxWynik.Location = new System.Drawing.Point(84, 85);
            this.BoxWynik.Name = "BoxWynik";
            this.BoxWynik.Size = new System.Drawing.Size(208, 23);
            this.BoxWynik.TabIndex = 38;
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(84, 201);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(49, 23);
            this.button0.TabIndex = 37;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // bWynik
            // 
            this.bWynik.Location = new System.Drawing.Point(189, 201);
            this.bWynik.Name = "bWynik";
            this.bWynik.Size = new System.Drawing.Size(46, 23);
            this.bWynik.TabIndex = 36;
            this.bWynik.Text = "=";
            this.bWynik.UseVisualStyleBackColor = true;
            this.bWynik.Click += new System.EventHandler(this.bWynik_Click);
            // 
            // bDziel
            // 
            this.bDziel.Location = new System.Drawing.Point(244, 201);
            this.bDziel.Name = "bDziel";
            this.bDziel.Size = new System.Drawing.Size(48, 23);
            this.bDziel.TabIndex = 35;
            this.bDziel.Text = "/";
            this.bDziel.UseVisualStyleBackColor = true;
            this.bDziel.Click += new System.EventHandler(this.bDziel_Click);
            // 
            // bMnoz
            // 
            this.bMnoz.Location = new System.Drawing.Point(244, 172);
            this.bMnoz.Name = "bMnoz";
            this.bMnoz.Size = new System.Drawing.Size(48, 23);
            this.bMnoz.TabIndex = 34;
            this.bMnoz.Text = "*";
            this.bMnoz.UseVisualStyleBackColor = true;
            this.bMnoz.Click += new System.EventHandler(this.bMnoz_Click);
            // 
            // bOdej
            // 
            this.bOdej.Location = new System.Drawing.Point(244, 143);
            this.bOdej.Name = "bOdej";
            this.bOdej.Size = new System.Drawing.Size(48, 23);
            this.bOdej.TabIndex = 33;
            this.bOdej.Text = "-";
            this.bOdej.UseVisualStyleBackColor = true;
            this.bOdej.Click += new System.EventHandler(this.bOdej_Click);
            // 
            // bDod
            // 
            this.bDod.Location = new System.Drawing.Point(244, 114);
            this.bDod.Name = "bDod";
            this.bDod.Size = new System.Drawing.Size(48, 23);
            this.bDod.TabIndex = 32;
            this.bDod.Text = "+";
            this.bDod.UseVisualStyleBackColor = true;
            this.bDod.Click += new System.EventHandler(this.bDod_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(189, 172);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(46, 23);
            this.button9.TabIndex = 31;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(137, 172);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(47, 23);
            this.button8.TabIndex = 30;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(84, 172);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(49, 23);
            this.button7.TabIndex = 29;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(189, 143);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(46, 23);
            this.button6.TabIndex = 28;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(137, 143);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(47, 23);
            this.button5.TabIndex = 27;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(84, 143);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(49, 23);
            this.button4.TabIndex = 26;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(189, 114);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(46, 23);
            this.button3.TabIndex = 25;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(137, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(84, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(225, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 43;
            // 
            // textBoxTime
            // 
            this.textBoxTime.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTime.Location = new System.Drawing.Point(236, 278);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(123, 16);
            this.textBoxTime.TabIndex = 44;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-6, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(381, 325);
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bDot
            // 
            this.bDot.Location = new System.Drawing.Point(137, 201);
            this.bDot.Name = "bDot";
            this.bDot.Size = new System.Drawing.Size(47, 23);
            this.bDot.TabIndex = 46;
            this.bDot.Text = ".";
            this.bDot.UseVisualStyleBackColor = true;
            this.bDot.Click += new System.EventHandler(this.bDot_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 313);
            this.Controls.Add(this.bDot);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bUstawTlo);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.BoxWynik);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.bWynik);
            this.Controls.Add(this.bDziel);
            this.Controls.Add(this.bMnoz);
            this.Controls.Add(this.bOdej);
            this.Controls.Add(this.bDod);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bUstawTlo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.TextBox BoxWynik;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button bWynik;
        private System.Windows.Forms.Button bDziel;
        private System.Windows.Forms.Button bMnoz;
        private System.Windows.Forms.Button bOdej;
        private System.Windows.Forms.Button bDod;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bDot;
    }
}

