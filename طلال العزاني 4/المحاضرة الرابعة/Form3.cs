using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace المحاضرة_الرابعة
{
    public partial class Form3 : Form
    {
        string[] a;
        int m = 0, i = 0;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textadd.Enabled=button1.Enabled=button2.Enabled=button3.Enabled=
                textres.Enabled=listBox1.Enabled= false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int s = 0;
            if (listBox1.Items.Count > 0)
            {
                for (int h = 0; h < i; h++)
                {
                    s += int.Parse(a[h]);
                }
                textres.Text = s.ToString();
            }
            else
                MessageBox.Show("المصفوفه فارغة");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int b=listBox1.Items.Count;
            if (b > 0)
            {
                for (int h = 1; h < b; h++)
                {
                    listBox1.Items.Remove(listBox1.Items[0]);
                }
                i = m = 0;
                a = new string[0];
                textadd.Text = textres.Text = Txtarrnum.Text = "";
                Form3_Load(null, null);
            }
            else
                MessageBox.Show("المصفوفة فارغة");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (i > 0)
            {
                for (int h = 0; h < i; h++)
                {
                    listBox1.Items.Add(a[h]);
                }
            }
            else
                MessageBox.Show("المصفوفه فارغة");
        }

        private void Txtarrnum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar<48&&e.KeyChar>57)
                e.Handled = true;
            if(e.KeyChar==8)
            { e.Handled = false; }

        }

        private void textadd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar < 48 || e.KeyChar > 57)
                e.Handled = true;
            if (e.KeyChar == 8)
                e.Handled = false;
        }

        private void Txtarrnum_TextChanged(object sender, EventArgs e)
        {
            bool f = (Txtarrnum.Text != "");
            textadd.Enabled = button1.Enabled = button2.Enabled = button3.Enabled =
                textres.Enabled = listBox1.Enabled = f;
            listBox1.Items.Clear();
            textres.Text = "";
        }

        private void Txtarrnum_Leave(object sender, EventArgs e)
        {
            if (Txtarrnum.Text.Trim() != "")
            {
                m = int.Parse(Txtarrnum.Text);
                a = new string[m]; i = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textadd.Text.Trim() != "")
            {
                if (i < m)
                {
                    a[i++] = textadd.Text.ToString();
                    textadd.Focus();
                    textadd.Clear();
                }
                else
                {
                    MessageBox.Show("   تجاوزت حد المصفوفة "); textadd.Clear();

                }
            }
            else
            {
                MessageBox.Show("ادخل الرقم");
            }
        }
    }
}
