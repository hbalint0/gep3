namespace MysqlUsers
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
            this.tbxID = new System.Windows.Forms.TextBox();
            this.tbxNev = new System.Windows.Forms.TextBox();
            this.tbxJelszo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxAdmin = new System.Windows.Forms.CheckBox();
            this.btnConn = new System.Windows.Forms.Button();
            this.btnOp = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnIns = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxID
            // 
            this.tbxID.Location = new System.Drawing.Point(76, 45);
            this.tbxID.Name = "tbxID";
            this.tbxID.Size = new System.Drawing.Size(178, 20);
            this.tbxID.TabIndex = 0;
            // 
            // tbxNev
            // 
            this.tbxNev.Location = new System.Drawing.Point(76, 132);
            this.tbxNev.Name = "tbxNev";
            this.tbxNev.Size = new System.Drawing.Size(178, 20);
            this.tbxNev.TabIndex = 1;
            // 
            // tbxJelszo
            // 
            this.tbxJelszo.Location = new System.Drawing.Point(76, 218);
            this.tbxJelszo.Name = "tbxJelszo";
            this.tbxJelszo.Size = new System.Drawing.Size(178, 20);
            this.tbxJelszo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(73, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Azonosító";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(73, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Név";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(73, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Jelszó";
            // 
            // cbxAdmin
            // 
            this.cbxAdmin.AutoSize = true;
            this.cbxAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbxAdmin.Location = new System.Drawing.Point(76, 293);
            this.cbxAdmin.Name = "cbxAdmin";
            this.cbxAdmin.Size = new System.Drawing.Size(74, 21);
            this.cbxAdmin.TabIndex = 6;
            this.cbxAdmin.Text = "Admin?";
            this.cbxAdmin.UseVisualStyleBackColor = true;
            // 
            // btnConn
            // 
            this.btnConn.Location = new System.Drawing.Point(508, 42);
            this.btnConn.Name = "btnConn";
            this.btnConn.Size = new System.Drawing.Size(178, 23);
            this.btnConn.TabIndex = 7;
            this.btnConn.Text = "Kapcsolódás";
            this.btnConn.UseVisualStyleBackColor = true;
            this.btnConn.Click += new System.EventHandler(this.btnConn_Click);
            // 
            // btnOp
            // 
            this.btnOp.Location = new System.Drawing.Point(508, 110);
            this.btnOp.Name = "btnOp";
            this.btnOp.Size = new System.Drawing.Size(178, 23);
            this.btnOp.TabIndex = 8;
            this.btnOp.Text = "Megnyitás olvasásra";
            this.btnOp.UseVisualStyleBackColor = true;
            this.btnOp.Click += new System.EventHandler(this.btnOp_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(508, 174);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(178, 23);
            this.btnRead.TabIndex = 9;
            this.btnRead.Text = "Olvas";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnIns
            // 
            this.btnIns.Location = new System.Drawing.Point(508, 247);
            this.btnIns.Name = "btnIns";
            this.btnIns.Size = new System.Drawing.Size(178, 23);
            this.btnIns.TabIndex = 10;
            this.btnIns.Text = "Beszúrás";
            this.btnIns.UseVisualStyleBackColor = true;
            this.btnIns.Click += new System.EventHandler(this.btnIns_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(508, 315);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(178, 23);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Módosítás kezdés";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(508, 383);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(178, 23);
            this.btnDel.TabIndex = 12;
            this.btnDel.Text = "Törlés";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(76, 383);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(178, 23);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Kapcsolat bontása";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnIns);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnOp);
            this.Controls.Add(this.btnConn);
            this.Controls.Add(this.cbxAdmin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxJelszo);
            this.Controls.Add(this.tbxNev);
            this.Controls.Add(this.tbxID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxID;
        private System.Windows.Forms.TextBox tbxNev;
        private System.Windows.Forms.TextBox tbxJelszo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbxAdmin;
        private System.Windows.Forms.Button btnConn;
        private System.Windows.Forms.Button btnOp;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnIns;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnClose;
    }
}

