﻿namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Jelszó = new System.Windows.Forms.Label();
            this.cbxadmin = new System.Windows.Forms.CheckBox();
            this.button7 = new System.Windows.Forms.Button();
            this.tbxanozosito = new System.Windows.Forms.TextBox();
            this.tbxnev = new System.Windows.Forms.TextBox();
            this.tbxjelszo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Azonosító";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(360, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Kapcsolódás";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(337, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Megnyitás olvasásra";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(360, 176);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 21);
            this.button3.TabIndex = 3;
            this.button3.Text = "Olvas";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(360, 221);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Beszúrás";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(360, 276);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(92, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "Módosítás kezdés";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(360, 337);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(92, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "Törlés";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Név";
            // 
            // Jelszó
            // 
            this.Jelszó.AutoSize = true;
            this.Jelszó.Location = new System.Drawing.Point(117, 180);
            this.Jelszó.Name = "Jelszó";
            this.Jelszó.Size = new System.Drawing.Size(36, 13);
            this.Jelszó.TabIndex = 8;
            this.Jelszó.Text = "Jelszó";
            // 
            // cbxadmin
            // 
            this.cbxadmin.AutoSize = true;
            this.cbxadmin.Location = new System.Drawing.Point(112, 245);
            this.cbxadmin.Name = "cbxadmin";
            this.cbxadmin.Size = new System.Drawing.Size(60, 17);
            this.cbxadmin.TabIndex = 9;
            this.cbxadmin.Text = "admin?";
            this.cbxadmin.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(93, 301);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(119, 23);
            this.button7.TabIndex = 10;
            this.button7.Text = "Kapcsolat bontása";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // tbxanozosito
            // 
            this.tbxanozosito.Location = new System.Drawing.Point(102, 98);
            this.tbxanozosito.Name = "tbxanozosito";
            this.tbxanozosito.Size = new System.Drawing.Size(100, 20);
            this.tbxanozosito.TabIndex = 11;
            // 
            // tbxnev
            // 
            this.tbxnev.Location = new System.Drawing.Point(102, 146);
            this.tbxnev.Name = "tbxnev";
            this.tbxnev.Size = new System.Drawing.Size(100, 20);
            this.tbxnev.TabIndex = 12;
            // 
            // tbxjelszo
            // 
            this.tbxjelszo.Location = new System.Drawing.Point(102, 196);
            this.tbxjelszo.Name = "tbxjelszo";
            this.tbxjelszo.Size = new System.Drawing.Size(100, 20);
            this.tbxjelszo.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxjelszo);
            this.Controls.Add(this.tbxnev);
            this.Controls.Add(this.tbxanozosito);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.cbxadmin);
            this.Controls.Add(this.Jelszó);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Jelszó;
        private System.Windows.Forms.CheckBox cbxadmin;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox tbxanozosito;
        private System.Windows.Forms.TextBox tbxnev;
        private System.Windows.Forms.TextBox tbxjelszo;
    }
}

