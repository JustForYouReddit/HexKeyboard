namespace HexCharacterInput
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
            this.btnMostSign = new System.Windows.Forms.Button();
            this.btnLeastSign = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.prgMostSign = new System.Windows.Forms.ProgressBar();
            this.prgLeastSign = new System.Windows.Forms.ProgressBar();
            this.lblHex = new System.Windows.Forms.Label();
            this.lblChar = new System.Windows.Forms.Label();
            this.chkMostSignLocked = new System.Windows.Forms.CheckBox();
            this.chkLeastSignLocked = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnMostSign
            // 
            this.btnMostSign.Location = new System.Drawing.Point(68, 12);
            this.btnMostSign.Name = "btnMostSign";
            this.btnMostSign.Size = new System.Drawing.Size(75, 23);
            this.btnMostSign.TabIndex = 0;
            this.btnMostSign.Text = "Inc most";
            this.btnMostSign.UseVisualStyleBackColor = true;
            this.btnMostSign.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnMostSign_MouseDown);
            this.btnMostSign.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMostSign_MouseUp);
            // 
            // btnLeastSign
            // 
            this.btnLeastSign.Location = new System.Drawing.Point(68, 41);
            this.btnLeastSign.Name = "btnLeastSign";
            this.btnLeastSign.Size = new System.Drawing.Size(75, 23);
            this.btnLeastSign.TabIndex = 1;
            this.btnLeastSign.Text = "Inc least";
            this.btnLeastSign.UseVisualStyleBackColor = true;
            this.btnLeastSign.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnLeastSign_MouseDown);
            this.btnLeastSign.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnLeastSign_MouseUp);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(297, 70);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(103, 23);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Add character";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // prgMostSign
            // 
            this.prgMostSign.Location = new System.Drawing.Point(149, 12);
            this.prgMostSign.Maximum = 300;
            this.prgMostSign.Name = "prgMostSign";
            this.prgMostSign.Size = new System.Drawing.Size(251, 23);
            this.prgMostSign.Step = 0;
            this.prgMostSign.TabIndex = 3;
            // 
            // prgLeastSign
            // 
            this.prgLeastSign.Location = new System.Drawing.Point(149, 41);
            this.prgLeastSign.Maximum = 300;
            this.prgLeastSign.Name = "prgLeastSign";
            this.prgLeastSign.Size = new System.Drawing.Size(251, 23);
            this.prgLeastSign.Step = 0;
            this.prgLeastSign.TabIndex = 4;
            // 
            // lblHex
            // 
            this.lblHex.AutoSize = true;
            this.lblHex.Location = new System.Drawing.Point(201, 75);
            this.lblHex.Name = "lblHex";
            this.lblHex.Size = new System.Drawing.Size(11, 13);
            this.lblHex.TabIndex = 5;
            this.lblHex.Text = "*";
            // 
            // lblChar
            // 
            this.lblChar.AutoSize = true;
            this.lblChar.Location = new System.Drawing.Point(234, 75);
            this.lblChar.Name = "lblChar";
            this.lblChar.Size = new System.Drawing.Size(35, 13);
            this.lblChar.TabIndex = 7;
            this.lblChar.Text = "label2";
            // 
            // chkMostSignLocked
            // 
            this.chkMostSignLocked.AutoSize = true;
            this.chkMostSignLocked.Location = new System.Drawing.Point(12, 16);
            this.chkMostSignLocked.Name = "chkMostSignLocked";
            this.chkMostSignLocked.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkMostSignLocked.Size = new System.Drawing.Size(50, 17);
            this.chkMostSignLocked.TabIndex = 8;
            this.chkMostSignLocked.Text = "Lock";
            this.chkMostSignLocked.UseVisualStyleBackColor = true;
            // 
            // chkLeastSignLocked
            // 
            this.chkLeastSignLocked.AutoSize = true;
            this.chkLeastSignLocked.Location = new System.Drawing.Point(12, 45);
            this.chkLeastSignLocked.Name = "chkLeastSignLocked";
            this.chkLeastSignLocked.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkLeastSignLocked.Size = new System.Drawing.Size(50, 17);
            this.chkLeastSignLocked.TabIndex = 9;
            this.chkLeastSignLocked.Text = "Lock";
            this.chkLeastSignLocked.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 103);
            this.Controls.Add(this.chkLeastSignLocked);
            this.Controls.Add(this.chkMostSignLocked);
            this.Controls.Add(this.lblChar);
            this.Controls.Add(this.lblHex);
            this.Controls.Add(this.prgLeastSign);
            this.Controls.Add(this.prgMostSign);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnLeastSign);
            this.Controls.Add(this.btnMostSign);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Hex keyboard";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMostSign;
        private System.Windows.Forms.Button btnLeastSign;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ProgressBar prgMostSign;
        private System.Windows.Forms.ProgressBar prgLeastSign;
        private System.Windows.Forms.Label lblHex;
        private System.Windows.Forms.Label lblChar;
        private System.Windows.Forms.CheckBox chkMostSignLocked;
        private System.Windows.Forms.CheckBox chkLeastSignLocked;
    }
}

