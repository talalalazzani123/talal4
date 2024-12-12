using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace المحاضرة_الرابعة
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (radioButtonup.Checked)
                for (int i = 0; i < Top; i++)
                {
                    // MessageBox.Show("Test"); 
                    if (checkBox1.Checked)
                        btnplayer.Top -= Convert.ToInt16(checkBox1.Text);
                    else if (checkBox2.Checked)
                        btnplayer.Top -= Convert.ToInt32(checkBox2.Text);
                    else if (checkBox3.Checked)
                        btnplayer.Top -= Convert.ToInt32(checkBox3.Text);
                    else if (checkBox4.Checked)
                        btnplayer.Top -= Convert.ToInt32(checkBox4.Text);
                    for (int j = 0; j < 100000000; j++) ;

                }
            else
          if (radioButtondown.Checked)
                for (int i = 0; i < Top; i++)
                {
                    if (checkBox1.Checked)
                        btnplayer.Top += Convert.ToInt32(checkBox1.Text);
                    else if (checkBox2.Checked)
                        btnplayer.Top += Convert.ToInt32(checkBox2.Text);
                    else if (checkBox3.Checked)
                        btnplayer.Top += Convert.ToInt32(checkBox3.Text);
                    else if (checkBox4.Checked)
                        btnplayer.Top += Convert.ToInt32(checkBox4.Text);
                    for (int j = 0; j < 100000000; j++) ;

                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnplayer.Width -= 5;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnplayer.Size = new Size(btnplayer.Width, btnplayer.Height + 5);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            btnplayer.Size = new Size(btnplayer.Width, btnplayer.Height - 5);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            btnplayer.Width += 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            btnplayer.Location = new Point(btnplayer.Left - 5, btnplayer.Top);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            btnplayer.Location = new Point(btnplayer.Left + 5, btnplayer.Top);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            btnplayer.Top -= 5;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            btnplayer.Location = new Point(btnplayer.Left, btnplayer.Top + 5);
        }
    }
    
}
