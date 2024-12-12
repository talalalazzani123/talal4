namespace المحاضرة_الرابعة
{
    partial class Form3
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textres = new System.Windows.Forms.TextBox();
            this.Txtarrnum = new System.Windows.Forms.TextBox();
            this.textadd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(41, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(370, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "اضافة للمصفوفة";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(56, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 36);
            this.button2.TabIndex = 1;
            this.button2.Text = "عرض العناصر";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(239, 217);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(166, 37);
            this.button3.TabIndex = 2;
            this.button3.Text = "حذف العناصر";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(265, 539);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(146, 45);
            this.button4.TabIndex = 3;
            this.button4.Text = "المجموع";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textres
            // 
            this.textres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textres.Location = new System.Drawing.Point(41, 542);
            this.textres.Multiline = true;
            this.textres.Name = "textres";
            this.textres.Size = new System.Drawing.Size(173, 35);
            this.textres.TabIndex = 5;
            // 
            // Txtarrnum
            // 
            this.Txtarrnum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txtarrnum.Location = new System.Drawing.Point(236, 54);
            this.Txtarrnum.Multiline = true;
            this.Txtarrnum.Name = "Txtarrnum";
            this.Txtarrnum.Size = new System.Drawing.Size(173, 35);
            this.Txtarrnum.TabIndex = 6;
            this.Txtarrnum.TextChanged += new System.EventHandler(this.Txtarrnum_TextChanged);
            this.Txtarrnum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtarrnum_KeyPress);
            this.Txtarrnum.Leave += new System.EventHandler(this.Txtarrnum_Leave);
            // 
            // textadd
            // 
            this.textadd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textadd.Location = new System.Drawing.Point(44, 54);
            this.textadd.Multiline = true;
            this.textadd.Name = "textadd";
            this.textadd.Size = new System.Drawing.Size(173, 35);
            this.textadd.TabIndex = 7;
            this.textadd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textadd_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "ادخل الرقم";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(258, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "ادخل عدد العناصر";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(56, 260);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(349, 270);
            this.listBox1.TabIndex = 10;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(488, 596);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textadd);
            this.Controls.Add(this.Txtarrnum);
            this.Controls.Add(this.textres);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textres;
        private System.Windows.Forms.TextBox Txtarrnum;
        private System.Windows.Forms.TextBox textadd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
    }
}