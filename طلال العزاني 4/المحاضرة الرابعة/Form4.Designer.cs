namespace المحاضرة_الرابعة
{
    partial class Form4
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
            this.txtavg = new System.Windows.Forms.TextBox();
            this.textname = new System.Windows.Forms.TextBox();
            this.txtnumstd = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtavg
            // 
            this.txtavg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtavg.Location = new System.Drawing.Point(97, 112);
            this.txtavg.Multiline = true;
            this.txtavg.Name = "txtavg";
            this.txtavg.Size = new System.Drawing.Size(112, 50);
            this.txtavg.TabIndex = 0;
            this.txtavg.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textname
            // 
            this.textname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textname.Location = new System.Drawing.Point(280, 112);
            this.textname.Multiline = true;
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(153, 50);
            this.textname.TabIndex = 1;
            this.textname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textname_KeyPress);
            // 
            // txtnumstd
            // 
            this.txtnumstd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnumstd.Location = new System.Drawing.Point(521, 112);
            this.txtnumstd.Multiline = true;
            this.txtnumstd.Name = "txtnumstd";
            this.txtnumstd.Size = new System.Drawing.Size(112, 50);
            this.txtnumstd.TabIndex = 2;
            this.txtnumstd.TextChanged += new System.EventHandler(this.txtnumstd_TextChanged);
            this.txtnumstd.Leave += new System.EventHandler(this.txtnumstd_Leave);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(216, 243);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(323, 213);
            this.listBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(216, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(323, 55);
            this.button1.TabIndex = 4;
            this.button1.Text = "اضافة للقائمة";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(216, 462);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(323, 55);
            this.button2.TabIndex = 5;
            this.button2.Text = "ترتيب العناصر";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "المعدل";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Wide Latin", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(303, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "اسم الطالب";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(517, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "عدد الطلاب";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 544);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtnumstd);
            this.Controls.Add(this.textname);
            this.Controls.Add(this.txtavg);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtavg;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.TextBox txtnumstd;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}